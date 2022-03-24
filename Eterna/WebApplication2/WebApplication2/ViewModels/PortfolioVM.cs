using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models.Home;
using WebApplication2.Models.Portfolio;

namespace WebApplication2.ViewModels
{
    public class PortfolioVM
    {
        public List<ClientImg> ClientImgs { get; set; }
        public ClientText ClientText { get; set; }
        public List<Portfolio> Portfolios { get; set; }
    }
}
