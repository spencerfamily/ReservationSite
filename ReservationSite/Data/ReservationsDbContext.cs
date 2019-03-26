using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSite.Data
{
    public class ReservationsDbContext : DbContext
    {
        private readonly DbContextOptions options;

        public ReservationsDbContext(DbContextOptions options) : base(options)
        {
            this.options = options ?? throw new ArgumentNullException(nameof(options));
        }

        public DbSet<Reservation> Reservations { get; set; }
    }
}
