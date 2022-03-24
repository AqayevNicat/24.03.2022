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
    public class HomeController : Controller
    {
        private readonly TurboDbContext _context;
        public HomeController(TurboDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<CarsCard> carsCards = _context.CarsCards.Include(p=>p.Details).ToList();
            return View(carsCards);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return BadRequest();
            List<CarsCard> carsCards = _context.CarsCards.Where(p=>p.Id == id).ToList();
            List<Detail> details = _context.Details.Where(p => p.CarsCardId == id).ToList();
            CarVM carVm = new CarVM
            {
                Details = details,
                CarsCards = carsCards
            };
            return View(carVm);
        }
    }
}
