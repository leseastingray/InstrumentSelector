using System;
using Microsoft.EntityFrameworkCore;
using InstrumentSelector.Models;

namespace InstrumentSelector.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Selection> Selections { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
