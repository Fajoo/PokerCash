using PokerCash.Backend.Utils;

namespace PokerCash.Utils.Tests
{
    public class RankTests
    {
        [Fact]
        public void RankExtensions_Success()
        {
            //Arrange
            var expected = "\u2663";
            var str = Suit.Club;

            //Act
            var actual = str.ToSuitString();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}