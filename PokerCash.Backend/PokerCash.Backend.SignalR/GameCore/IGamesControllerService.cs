
using PokerCash.Backend.SignalR.GameCore.GameLib;

namespace PokerCash.Backend.SignalR.GameCore;

public interface IGamesControllerService
{
    void CreateGame(Game game);
    IEnumerable<Game> GetGames();
    Game GetGameById(Guid id);
}