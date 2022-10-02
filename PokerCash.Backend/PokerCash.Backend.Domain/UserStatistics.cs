namespace PokerCash.Backend.Domain;

/// <summary>
/// Basic user statistics
/// </summary>
public class UserStatistics
{
    /// <summary>
    /// Unique id user statistics
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Basic data user
    /// </summary>
    public UserData UserData { get; set; }
    /// <summary>
    /// Number of games played
    /// </summary>
    public int GameCount { get; set; }
    /// <summary>
    /// Number of hands won
    /// </summary>
    public int HandsWon { get; set; }
}