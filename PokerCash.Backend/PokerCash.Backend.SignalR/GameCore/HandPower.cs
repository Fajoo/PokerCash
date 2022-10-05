using PokerCash.Backend.Utils;
using System.Linq;

namespace PokerCash.Backend.SignalR.GameCore;

public static class HandPower
{
    public static Power GetPower(List<Card> cards)
    {
        var hand = cards.OrderBy(c => c.Rank).ToList();

        if (RoyalFlush(hand)) return Power.RoyalFlush;
        if (StraightFlush(hand)) return Power.StraightFlush;
        if (FourOfAKindCheck(hand)) return Power.FourOfAKind;
        if (FullHouseCheck(hand)) return Power.FullHouse;
        if (FlushCheck(hand)) return Power.Flush;
        if (StraightCheck(hand)) return Power.Straight;
        if (ThreeOfAKindCheck(hand)) return Power.ThreeOfAKind;
        if (TwoPairCheck(hand)) return Power.TwoPair;
        if (OnePairCheck(hand)) return Power.OnePair;

        return Power.High;
    }
    private static bool OnePairCheck(List<Card> hand) => hand.GroupBy(h => h.Rank).Count(h => h.Count() == 2) == 1;
    private static bool TwoPairCheck(List<Card> hand) => hand.GroupBy(h => h.Rank).Count(h => h.Count() == 2) > 1;
    private static bool ThreeOfAKindCheck(List<Card> hand) => hand.GroupBy(h => h.Rank).Count(h => h.Count() == 3) > 0;
    private static bool StraightCheck(List<Card> hand)
    {
        if (hand[^1].Rank == Rank.Ace && hand[0].Rank == Rank.Two && hand[1].Rank == Rank.Three &&
            hand[2].Rank == Rank.Four && hand[3].Rank == Rank.Five) return true;

        var h = string.Concat(hand.OrderBy(c => c.Rank).Select(c => (int)c.Rank).Distinct());
        var straights = new[] { "23456", "34567", "45678", "56789", "678910", "7891011", "89101112", "910111213", "1011121314" };
        return straights.Select(s => h.Contains(s)).Contains(true);
    }
    private static bool FlushCheck(List<Card> hand) => hand.GroupBy(h => h.Suit).Count(h => h.Count() == 5) == 1;
    private static bool FullHouseCheck(List<Card> hand)
    {
        var group = hand.GroupBy(h => h.Rank);
        var three = group.Count(t => t.Count() == 3) > 0;
        var threeX2 = group.Count(t => t.Count() == 3) == 2;
        var two = group.Count(t => t.Count() == 2) > 0;
        return (three && two) || threeX2;
    }
    private static bool FourOfAKindCheck(List<Card> hand) => hand.GroupBy(h => h.Rank).Count(h => h.Count() == 4) == 1;
    private static bool StraightFlush(List<Card> hand) => StraightCheck(hand) && FlushCheck(hand);
    private static bool RoyalFlush(List<Card> hand) =>    hand[^1].Rank == Rank.Ace 
                                                       && hand[^2].Rank == Rank.King
                                                       && hand[^3].Rank == Rank.Queen
                                                       && hand[^4].Rank == Rank.Jack
                                                       && hand[^5].Rank == Rank.Ten && FlushCheck(hand);
}