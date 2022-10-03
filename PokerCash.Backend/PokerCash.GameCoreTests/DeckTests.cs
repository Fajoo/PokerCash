using PokerCash.Backend.SignalR.GameCore;

namespace PokerCash.GameCoreTests
{
    public class DeckTests
    {
        [Fact]
        public void Get52Cards_Success()
        {
            var deck = new Deck();
            var expect = 52;

            var actual = deck.GetCards(52).ToList();

            Assert.Equal(expect, actual.Count);
        }

        [Fact]
        public void Get53Cards_Exception()
        {
            var deck = new Deck();
            
            Assert.Throws<ArgumentException>(() => deck.GetCards(53).ToList());
        }
    }
}