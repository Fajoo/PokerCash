
using PokerCash.Backend.SignalR.GameCore.GameLib;

namespace PokerCash.Backend.SignalR.GameCore;


public class GamesControllerService : IGamesControllerService
{
    private readonly List<Game> _games;

    public GamesControllerService()
    {
        _games = new List<Game>(GamesInitializer.GetGames());
        foreach (var game in _games)
        {
            game.StartGame(CancellationToken.None);
        }
    }

    public void CreateGame(Game game)
    {
        _games.Add(game);
    }

    public IEnumerable<Game> GetGames() => _games.Where(g => g.IsGameStarted);
    public Game GetGameById(Guid id)
    {
        return _games.FirstOrDefault(g => g.Id == id);
    }
}