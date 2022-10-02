namespace PokerCash.Backend.Domain;

/// <summary>
/// Basic data user
/// </summary>
public class UserData
{
    /// <summary>
    /// Unique id user data
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Basic user statistics
    /// </summary>
    public UserStatistics UserStatistics { get; set; }
    /// <summary>
    /// User login from the authorization server
    /// </summary>
    public string Login { get; set; }
    /// <summary>
    /// Free user chips 
    /// </summary>
    public decimal Cash { get; set; }
    /// <summary>
    /// User blocking
    /// </summary>
    public bool IsBanned { get; set; }
    /// <summary>
    /// Date of last receipt of free chips
    /// </summary>
    public DateTime LastTakeCash { get; set; }
}