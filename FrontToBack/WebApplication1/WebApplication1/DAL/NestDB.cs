using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class NestDB : DbContext
    {
        public NestDB(DbContextOptions<NestDB> options) : base(options) { }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutSlides> AboutSlides { get; set; }
        public DbSet<AbProvide> AbProvides { get; set; }
        public DbSet<AbPerformance> AbPerformances { get; set; }
        public DbSet<AbHistory> AbHistories { get; set; }
    }
}
