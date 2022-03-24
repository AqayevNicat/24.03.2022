using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models.Home;
using WebApplication2.Models.About;
using WebApplication2.Models.Services;
using WebApplication2.Models.Portfolio;

namespace WebApplication2.DAL
{
    public class EternaDBContext : DbContext
    {
        public EternaDBContext(DbContextOptions<EternaDBContext> options) : base(options) { }
        // Home
        public DbSet<IntroSlide> IntroSlides { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutLi> AboutLis { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ClientText> ClientTexts { get; set; }
        public DbSet<ClientImg> ClientImgs { get; set; }
        // About
        public DbSet<CountUser> CountUsers { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<TestimonialEmp> TestimonialEmps { get; set; }
        // Service
        public DbSet<Skill> Skills { get; set; }
        // Portfolio
        public DbSet<Portfolio> Portfolios { get; set; }
    }
}
