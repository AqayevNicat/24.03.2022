using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class TurboDbContext : DbContext
    {
        public TurboDbContext(DbContextOptions<TurboDbContext> options) : base(options) { }
        public DbSet<CarsCard> CarsCards { get; set; }
        public DbSet<Detail> Details { get; set; }
    }
}
