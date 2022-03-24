using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models.Home;

namespace WebApplication2.ViewModels
{
    public class HomeVM
    {
        public List<IntroSlide> IntroSlides { get; set; }
        public List<Feature> Features { get; set; }
        public About Abouts { get; set; }
        public List<AboutLi> AboutLis { get; set; }
        public List<Service> Services { get; set; }
        public ClientText ClientText { get; set; }
        public List<ClientImg> ClientImgs { get; set; }

    }
}
