namespace PokerCash.Backend.SignalR.GameCore.GameLib;

public interface IGame
{
    Task StartGame(CancellationToken token);
}