using PokerCash.Backend.SignalR.GameCore.PlayerLib;

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

    public Game(string name, int blind = 100)
    {
        Blind = blind;
        Name = name;
    }

    public async Task StartGame(CancellationToken token)
    {
        IsGameStarted = true;

        while (!token.IsCancellationRequested)
        {
            if (ActivePlayers.Count > 1)
            {
                var newDeck = new Deck();

                foreach (var player in ActivePlayers)
                {
                    var cards = newDeck.GetCards(2);
                    player.HandCards = new List<Card>(cards);
                }
            }

            await Task.Delay(100, token);
        }
    }
}