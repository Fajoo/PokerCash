using PokerCash.Backend.SignalR.GameCore;
using PokerCash.Backend.SignalR.GameCore.GameLib;
using PokerCash.Backend.SignalR.GameCore.PlayerLib;
using PokerCash.Backend.Utils;

namespace PokerCash.GameCoreTests;

public class HandPowerTests
{
    [Fact]
    public void HighCardCheck_Success()
    {
        var expect = Power.High;
        var cards = new List<Card>
        {
            new(Rank.Ten, Suit.Club),
            new(Rank.Ace, Suit.Diamond),
            new(Rank.Two, Suit.Club),
            new(Rank.Seven, Suit.Club),
            new(Rank.Eight, Suit.Heart),
            new(Rank.King, Suit.Heart),
            new(Rank.Three, Suit.Diamond)
        };

        var actual = HandPower.GetPower(cards);

        Assert.Equal(expect, actual);
    }

    [Fact]
    public void OnePairCheck_Success()
    {
        var expect = Power.OnePair;
        var cards = new List<Card>
        {
            new(Rank.Ace, Suit.Club),
            new(Rank.Ace, Suit.Diamond),
            new(Rank.Two, Suit.Club),
            new(Rank.Seven, Suit.Club),
            new(Rank.Eight, Suit.Heart),
            new(Rank.King, Suit.Heart),
            new(Rank.Three, Suit.Diamond)
        };

        var actual = HandPower.GetPower(cards);

        Assert.Equal(expect, actual);
    }

    [Fact]
    public void TwoPairCheck_Success()
    {
        var expect = Power.TwoPair;
        var cards = new List<Card>
        {
            new(Rank.Ace, Suit.Club),
            new(Rank.Ace, Suit.Diamond),
            new(Rank.Two, Suit.Club),
            new(Rank.Seven, Suit.Club),
            new(Rank.Eight, Suit.Heart),
            new(Rank.King, Suit.Heart),
            new(Rank.Two, Suit.Diamond)
        };

        var actual = HandPower.GetPower(cards);

        Assert.Equal(expect, actual);
    }

    [Fact]
    public void ThreeOfAKindCheck_Success()
    {
        var expect = Power.ThreeOfAKind;
        var cards = new List<Card>
        {
            new(Rank.Ace, Suit.Club),
            new(Rank.Ace, Suit.Diamond),
            new(Rank.Two, Suit.Club),
            new(Rank.Seven, Suit.Club),
            new(Rank.Eight, Suit.Heart),
            new(Rank.King, Suit.Heart),
            new(Rank.Ace, Suit.Spade)
        };

        var actual = HandPower.GetPower(cards);

        Assert.Equal(expect, actual);
    }

    [Fact]
    public void StraightWheelCheck_Success()
    {
        var expect = Power.Straight;
        var cards = new List<Card>
        {
            new(Rank.Ace, Suit.Club),
            new(Rank.Queen, Suit.Diamond),
            new(Rank.Two, Suit.Club),
            new(Rank.Eight, Suit.Club),
            new(Rank.Five, Suit.Heart),
            new(Rank.Four, Suit.Heart),
            new(Rank.Three, Suit.Spade)
        };

        var actual = HandPower.GetPower(cards);

        Assert.Equal(expect, actual);
    }

    [Fact]
    public void StraightCheck_Success()
    {
        var expect = Power.Straight;
        var cards = new List<Card>
        {
            new(Rank.King, Suit.Club),
            new(Rank.Queen, Suit.Diamond),
            new(Rank.Jack, Suit.Club),
            new(Rank.Ten, Suit.Club),
            new(Rank.Ace, Suit.Heart),
            new(Rank.Four, Suit.Heart),
            new(Rank.Ace, Suit.Spade)
        };

        var actual = HandPower.GetPower(cards);

        Assert.Equal(expect, actual);
    }

    [Fact]
    public void FlushCheck_Success()
    {
        var expect = Power.Flush;
        var cards = new List<Card>
        {
            new(Rank.Ace, Suit.Diamond),
            new(Rank.Two, Suit.Diamond),
            new(Rank.Five, Suit.Club),
            new(Rank.Ten, Suit.Club),
            new(Rank.Four, Suit.Diamond),
            new(Rank.Six, Suit.Diamond),
            new(Rank.Seven, Suit.Diamond)
        };

        var actual = HandPower.GetPower(cards);

        Assert.Equal(expect, actual);
    }

    [Fact]
    public void FullHouseCheck_Success()
    {
        var expect = Power.FullHouse;
        var cards = new List<Card>
        {
            new(Rank.Two, Suit.Spade),
            new(Rank.Jack, Suit.Club),
            new(Rank.Eight, Suit.Heart),
            new(Rank.Six, Suit.Club),
            new(Rank.Jack, Suit.Club),
            new(Rank.Six, Suit.Diamond),
            new(Rank.Six, Suit.Diamond)
        };

        var actual = HandPower.GetPower(cards);

        Assert.Equal(expect, actual);
    }

    [Fact]
    public void FourOfAKindCheck_Success()
    {
        var expect = Power.FourOfAKind;
        var cards = new List<Card>
        {
            new(Rank.Six, Suit.Spade),
            new(Rank.Jack, Suit.Club),
            new(Rank.Eight, Suit.Heart),
            new(Rank.Six, Suit.Club),
            new(Rank.Jack, Suit.Club),
            new(Rank.Six, Suit.Heart),
            new(Rank.Six, Suit.Diamond)
        };

        var actual = HandPower.GetPower(cards);

        Assert.Equal(expect, actual);
    }

    [Fact]
    public void StraightFlushCheck_Success()
    {
        var expect = Power.StraightFlush;
        var cards = new List<Card>
        {
            new(Rank.Ace, Suit.Club),
            new(Rank.Eight, Suit.Club),
            new(Rank.Five, Suit.Club),
            new(Rank.Ten, Suit.Club),
            new(Rank.Four, Suit.Heart),
            new(Rank.Six, Suit.Diamond),
            new(Rank.Seven, Suit.Club)
        };

        var actual = HandPower.GetPower(cards);

        Assert.Equal(expect, actual);
    }

    [Fact]
    public void RoyalFlushCheck_Success()
    {
        var expect = Power.RoyalFlush;
        var cards = new List<Card>
        {
            new(Rank.Ace, Suit.Club),
            new(Rank.King, Suit.Club),
            new(Rank.Five, Suit.Heart),
            new(Rank.Queen, Suit.Club),
            new(Rank.Jack, Suit.Club),
            new(Rank.Six, Suit.Diamond),
            new(Rank.Ten, Suit.Club)
        };

        var actual = HandPower.GetPower(cards);

        Assert.Equal(expect, actual);
    }
}