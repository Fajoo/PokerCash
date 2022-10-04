using PokerCash.Backend.Utils;

namespace PokerCash.Backend.SignalR.GameCore.PlayerLib;

public class Player
{
    public int Cash { get; set; }
    public PlayerChoice Choice { get; set; } = PlayerChoice.None;
    public List<Card> HandCards { get; set; }
}