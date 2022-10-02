using Microsoft.EntityFrameworkCore;

namespace PokerCash.Backend.Application.Interfaces;

/// <summary>
/// Interface describing the database context
/// </summary>
public interface IPokerCashBackendDbContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}