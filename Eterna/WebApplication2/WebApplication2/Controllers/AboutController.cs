using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.DAL;
using WebApplication2.Models.Home;
using WebApplication2.Models.About;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class AboutController : Controller
    {
        private readonly EternaDBContext _context;
        public AboutController(EternaDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            About about = _context.Abouts.FirstOrDefault();
            List<AboutLi> aboutLis = _context.AboutLis.ToList();
            ClientText clientText = _context.ClientTexts.FirstOrDefault();
            List<ClientImg> clientImgs = _context.ClientImgs.ToList();
            List<CountUser> countUsers = _context.CountUsers.ToList();
            Testimonial testimonial = _context.Testimonials.FirstOrDefault();
            List<TestimonialEmp> testimonialEmps = _context.TestimonialEmps.ToList();

            AboutVM aboutVM = new AboutVM
            {
                Abouts = about,   
                AboutLis = aboutLis,
                ClientText = clientText,
                ClientImgs = clientImgs,
                CountUsers = countUsers,
                Testimonial = testimonial,
                TestimonialEmps = testimonialEmps
            };
            return View(aboutVM);
        }
    }
}
