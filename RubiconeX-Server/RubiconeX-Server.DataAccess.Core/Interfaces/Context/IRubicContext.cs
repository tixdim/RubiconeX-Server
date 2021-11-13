using Microsoft.EntityFrameworkCore;
using RubiconeX_Server.DataAccess.Core.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RubiconeX_Server.DataAccess.Core.Interfaces.Context
{
    public interface IRubicContext : IDisposable, IAsyncDisposable
    {
        DbSet<UserRto> Users { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
