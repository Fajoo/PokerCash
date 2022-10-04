using Microsoft.AspNetCore.Mvc;
using PokerCash.Backend.SignalR.GameCore.GameLib;
using PokerCash.Backend.SignalR.GameCore.PlayerLib;

namespace PokerCash.GameCoreTests;

public class AddPlayersTests
{
    [Fact]
    public void CreatePlayer_Success()
    {
        var game = new Game("testGame1");
        var player = new Player("testlogin1");
        var expect = player.Login;

        game.AddPlayer(player);

        Assert.NotNull(game.Players.FirstOrDefault(p => p.Login == expect));
    }

    [Fact]
    public void CreatePlayer_DoubleError()
    {
        var game = new Game("testGame1");
        var player = new Player("testlogin1");
        var player2 = new Player("testlogin1");

        game.AddPlayer(player);
        game.AddPlayer(player2);

        Assert.Equal(1, game.Players.Count(p => p.Login == "testlogin1"));
    }

    [Fact]
    public void CreateActivePlayer_Success()
    {
        var game = new Game("testGame1");
        var player = new Player("testlogin1");

        game.AddPlayer(player);
        var actual = game.AddToActivePlayers(player.Login);

        Assert.True(actual);
    }
}