using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.DAL;
using WebApplication2.Models.Home;
using WebApplication2.Models.Portfolio;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly EternaDBContext _context;
        public PortfolioController(EternaDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<ClientImg> clientImgs = _context.ClientImgs.ToList();
            ClientText clientText = _context.ClientTexts.FirstOrDefault();
            List<Portfolio> portfolios = _context.Portfolios.ToList();

            PortfolioVM portfolioVM = new PortfolioVM
            {
                ClientImgs = clientImgs,
                ClientText= clientText,
                Portfolios = portfolios
            };
            return View(portfolioVM);
        }
    }
}
