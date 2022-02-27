using Microsoft.EntityFrameworkCore;
using Olo.Domain.Entities;

namespace Olo.Informator.Interfaces
{
    public interface IOloDbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<MatchHistory> MatchHistories { get; set; }
    }
}
