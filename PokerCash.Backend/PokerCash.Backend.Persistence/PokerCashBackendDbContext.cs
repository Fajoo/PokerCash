using Microsoft.EntityFrameworkCore;
using PokerCash.Backend.Application.Interfaces;

namespace PokerCash.Backend.Persistence;

/// <summary>
/// Database context
/// </summary>
public class PokerCashBackendDbContext : DbContext, IPokerCashBackendDbContext
{
    /// <summary>
    /// People table with data
    /// </summary>

    public PokerCashBackendDbContext(DbContextOptions<PokerCashBackendDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}