namespace PokerCash.Backend.Utils;

public static class SuitExtensions
{
    public static string ToSuitString(this Suit suit) =>
        suit switch
        {
            Suit.Club => "\u2663",
            Suit.Diamond => "\u2666",
            Suit.Heart => "\u2665",
            Suit.Spade => "\u2660",
            _ => throw new ArgumentOutOfRangeException(nameof(suit), suit, null)
        };
}