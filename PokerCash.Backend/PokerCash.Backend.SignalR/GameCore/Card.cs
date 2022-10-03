using PokerCash.Backend.Utils;

namespace PokerCash.Backend.SignalR.GameCore;

public class Card
{
    public Rank Rank { get; }
    public Suit Suit { get; }

    public Card(Rank rank, Suit suit)
    {
        Rank = rank;
        Suit = suit;
    }

    public override string ToString() => $"{Rank.ToRankString()}{Suit.ToSuitString()}";
}