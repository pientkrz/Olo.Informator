using Microsoft.EntityFrameworkCore;
using Olo.Common;
using Olo.Domain.Entities;
using Olo.Informator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olo.Persistance
{
    public class OloDbContext : DbContext, IOloDbContext
    {
        private readonly IDateTime _dateTime;

        public OloDbContext(DbContextOptions<OloDbContext> options)
            : base(options)
        {
        }

        public OloDbContext(
            DbContextOptions<OloDbContext> options,
            IDateTime dateTime)
            : base(options)
        {
            _dateTime = dateTime;
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<MatchHistory> MatchHistories { get; set; }
    }
}
