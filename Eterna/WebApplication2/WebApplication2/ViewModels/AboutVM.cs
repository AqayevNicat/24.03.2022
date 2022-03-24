using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models.Home;
using WebApplication2.Models.About;

namespace WebApplication2.ViewModels
{
    public class AboutVM
    {
        public About Abouts { get; set; }
        public List<AboutLi> AboutLis { get; set; }
        public ClientText ClientText { get; set; }
        public List<ClientImg> ClientImgs { get; set; }
        public List<CountUser> CountUsers { get; set; }
        public Testimonial Testimonial { get; set; }
        public List<TestimonialEmp> TestimonialEmps { get; set; }
    }
}
