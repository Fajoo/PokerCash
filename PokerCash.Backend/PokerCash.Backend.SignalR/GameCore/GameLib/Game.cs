using PokerCash.Backend.SignalR.GameCore.PlayerLib;
using PokerCash.Backend.Utils;

namespace PokerCash.Backend.SignalR.GameCore.GameLib;

public class Game : IGame
{
    /// <summary>
    /// Poker game name
    /// </summary>
    public string Name { get; init; }
    /// <summary>
    /// Unique id
    /// </summary>
    public Guid Id { get; } = Guid.NewGuid();
    /// <summary>
    /// All players logged into the game
    /// </summary>
    public List<Player> Players { get; set; } = new();
    /// <summary>
    /// Active players who sat down at the table
    /// </summary>
    public List<Player> ActivePlayers { get; set; } = new();
    /// <summary>
    /// Current game bank
    /// </summary>
    public int Pot { get; set; }
    /// <summary>
    /// Has the game been launched
    /// </summary>
    public bool IsGameStarted { get; private set; }
    /// <summary>
    /// Table blind set
    /// </summary>
    public int Blind { get; }

    /// <summary>
    /// Current game round
    /// </summary>
    public Round GameRound { get; private set; } = Round.None;

    public Game(string name, int blind = 100)
    {
        Blind = blind;
        Name = name;
    }

    //!TODo logics/checks
    public async Task StartGame(CancellationToken token)
    {
        IsGameStarted = true;

        while (!token.IsCancellationRequested)
        {
            if (ActivePlayers.Count > 1)
            {
                GameRound = Round.Preflop;

                var newDeck = new Deck();

                foreach (var player in ActivePlayers) player.HandCards = new List<Card>(newDeck.GetCards(2));

                await Task.Delay(100, token);
            }

            await Task.Delay(10, token);
        }
    }

    //!TODo logics/result/checks
    public void AddPlayer(Player player)
    {
        if(player is null || Players.Any(p => p.Login == player.Login)) return;
        Players.Add(player);
    }

    //!TODo logics/result/checks
    public bool AddToActivePlayers(string login)
    {
        if (string.IsNullOrEmpty(login)) return false;
        var player = Players.FirstOrDefault(p => p.Login == login);
        if (player == null) return false;
        ActivePlayers.Add(player);
        Players.Remove(player);
        return true;
    }
}