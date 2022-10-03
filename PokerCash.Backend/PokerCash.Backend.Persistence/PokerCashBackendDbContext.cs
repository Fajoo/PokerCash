using Microsoft.EntityFrameworkCore;
using PokerCash.Backend.Application.Interfaces;
using PokerCash.Backend.Domain;

namespace PokerCash.Backend.Persistence;

/// <summary>
/// Database context
/// </summary>
public class PokerCashBackendDbContext : DbContext, IPokerCashBackendDbContext
{
    /// <summary>
    /// User data table with data
    /// </summary>
    public DbSet<UserData> UserDatas { get; set; }
    /// <summary>
    /// User statistics table with data
    /// </summary>
    public DbSet<UserStatistics> UserStatistics { get; set; }

    public PokerCashBackendDbContext(DbContextOptions<PokerCashBackendDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}