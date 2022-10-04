using Microsoft.AspNetCore.Mvc;
using PokerCash.Backend.SignalR.GameCore.GameLib;
using PokerCash.Backend.SignalR.GameCore.PlayerLib;
using PokerCash.Backend.Utils;

namespace PokerCash.GameCoreTests;

public class PreflopRoundTests
{
    [Fact]
    public async Task PreflopRoundStart_Success()
    {
        var game = new Game("testGame1");
        var expect = Round.Preflop;
        var player1 = new Player("user1");
        var player2 = new Player("user2");

        game.StartGame(CancellationToken.None);
        game.AddPlayer(player1);
        game.AddPlayer(player2);
        game.AddToActivePlayers(player1.Login);
        game.AddToActivePlayers(player2.Login);

        await Task.Delay(100);

        Assert.Equal(game.GameRound, expect);
    }
}