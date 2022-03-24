using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class AboutVM
    {
        public About Abouts { get; set; }
        public List<AbProvide> AbProvides { get; set; }
        public AbPerformance AbPerformances { get; set; }
        public List<AbHistory> AbHistories { get; set; }
    }
}
