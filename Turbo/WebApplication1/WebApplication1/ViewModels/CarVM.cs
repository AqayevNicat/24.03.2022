using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class CarVM
    {
        public List<CarsCard> CarsCards { get; set; }
        public List<Detail> Details { get; set; }
    }
}
