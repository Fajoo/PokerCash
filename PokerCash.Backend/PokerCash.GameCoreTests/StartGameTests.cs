using PokerCash.Backend.SignalR.GameCore;
using PokerCash.Backend.SignalR.GameCore.GameLib;

namespace PokerCash.GameCoreTests;

public class StartGameTests
{
    private readonly IGamesControllerService _controller = new GamesControllerService();

    [Fact]
    public void StartGetGames_Success()
    {
        var expect = GamesInitializer.GetGames().Count();

        var actual = _controller.GetGames().Count();

        Assert.Equal(expect, actual);
    }

    [Fact]
    public void GetGameById_Success()
    {
        var expect = _controller.GetGames().First().Id;

        var actual = _controller.GetGameById(expect).Id;

        Assert.Equal(expect, actual);
    }

    [Fact]
    public void GetGameById_Null()
    {
        var id = Guid.Empty;

        var actual = _controller.GetGameById(id);

        Assert.Null(actual);
    }
}