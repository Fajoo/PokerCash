namespace PokerCash.Backend.Utils;

public static class RankExtensions
{
    public static string ToRankString(this Rank rank) =>
        rank switch
        {
            Rank.Two => "2",
            Rank.Three => "3",
            Rank.Four => "4",
            Rank.Five => "5",
            Rank.Six => "6",
            Rank.Seven => "7",
            Rank.Eight => "8",
            Rank.Nine => "9",
            Rank.Ten => "10",
            Rank.Jack => "J",
            Rank.Queen => "Q",
            Rank.King => "K",
            Rank.Ace => "A",
            _ => throw new ArgumentOutOfRangeException(nameof(rank), rank, null)
        };
}