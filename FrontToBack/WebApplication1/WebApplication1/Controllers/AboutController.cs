using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class AboutController : Controller
    {
        private readonly NestDB _context;
        public AboutController(NestDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            About about = _context.Abouts
                .Include(a=>a.AboutSlides)
                .FirstOrDefault();
            List<AbProvide> abProvides = _context.AbProvides.ToList();
            AbPerformance abPerformance = _context.AbPerformances.FirstOrDefault();
            List<AbHistory> abHistories = _context.AbHistories.ToList();
            AboutVM aboutVM = new AboutVM
            {
                Abouts = about,
                AbProvides = abProvides,
                AbPerformances = abPerformance,
                AbHistories = abHistories
            };
            if (aboutVM == null) return BadRequest();
            return View(aboutVM);
        }
    }
}
