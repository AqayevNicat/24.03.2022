using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.DAL;
using WebApplication2.Models.Home;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly EternaDBContext _context;
        public HomeController(EternaDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<IntroSlide> introSlides = _context.IntroSlides.ToList();
            List<Feature> features = _context.Features.ToList();
            About about = _context.Abouts.FirstOrDefault();
            List<AboutLi> aboutLis = _context.AboutLis.ToList();
            List<Service> services = _context.Services.ToList();
            ClientText clientText = _context.ClientTexts.FirstOrDefault();
            List<ClientImg> clientImgs = _context.ClientImgs.ToList();

            HomeVM homeVM = new HomeVM
            {
                IntroSlides = introSlides,
                Features = features,
                Abouts = about,
                AboutLis = aboutLis,
                Services = services,
                ClientText = clientText,
                ClientImgs = clientImgs
            };
            return View(homeVM);
        }
    }
}
