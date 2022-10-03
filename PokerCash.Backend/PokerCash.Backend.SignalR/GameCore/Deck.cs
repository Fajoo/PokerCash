using System.Collections;
using PokerCash.Backend.Utils;

namespace PokerCash.Backend.SignalR.GameCore;

public class Deck
{
    private readonly List<Card> _cards = new();

    private static readonly Random _r = new();

    private readonly Suit[] _suits = {
        Suit.Club,
        Suit.Diamond,
        Suit.Heart,
        Suit.Spade
    };

    private readonly Rank[] _ranks = {
        Rank.Two,
        Rank.Three,
        Rank.Four,
        Rank.Five,
        Rank.Six,
        Rank.Seven,
        Rank.Eight,
        Rank.Nine,
        Rank.Ten,
        Rank.Jack,
        Rank.Queen,
        Rank.King,
        Rank.Ace
    };

    public Deck()
    {
        foreach (var suit in _suits)
            _cards.AddRange(_ranks.Select(rank => new Card(rank, suit)));

        for (var i = 0; i < _cards.Count; i++)
        {
            var randomIndex = _r.Next(_cards.Count);
            (_cards[i], _cards[randomIndex]) = (_cards[randomIndex], _cards[i]);
        }
    }

    public IEnumerable<Card> GetCards(int num)
    {
        var cards = new List<Card>(_cards.Take(num));
        _cards.RemoveRange(0, num);
        return cards;
    }
}