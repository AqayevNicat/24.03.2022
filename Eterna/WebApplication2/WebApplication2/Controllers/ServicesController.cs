using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.DAL;
using WebApplication2.Models.Home;
using WebApplication2.Models.Services;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class ServicesController : Controller
    {
        private readonly EternaDBContext _context;
        public ServicesController(EternaDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Service> services = _context.Services.ToList();
            Skill skill = _context.Skills.FirstOrDefault();
            ServiceVM serviceVM = new ServiceVM
            {
                Services = services,
                Skill = skill
            };
            return View(serviceVM);
        }
    }
}
