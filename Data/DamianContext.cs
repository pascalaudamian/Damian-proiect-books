using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Damian.Models;

namespace Damian.Data
{
    public class DamianContext : DbContext
    {
        public DamianContext (DbContextOptions<DamianContext> options)
            : base(options)
        {
        }

        public DbSet<Damian.Models.Book> Book { get; set; }

        public DbSet<Damian.Models.Publisher> Publisher { get; set; }

        public DbSet<Damian.Models.BookCategory> BookCategory { get; set; }
    }
}
