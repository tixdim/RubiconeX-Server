using Microsoft.EntityFrameworkCore;
using RubiconeX_Server.DataAccess.Core.Interfaces.Context;
using RubiconeX_Server.DataAccess.Core.Models;
using System.Threading;
using System.Threading.Tasks;

namespace RubiconeX_Server.DataAccess.DbContext
{
    public class RubicContext : Microsoft.EntityFrameworkCore.DbContext, IRubicContext
    {
        public RubicContext(DbContextOptions<RubicContext> option) : base(option) { }
        public DbSet<UserRto> Users { get; set; }
        public DbSet<UserRoleRto> UserRoles { get; set; }
    }
}
