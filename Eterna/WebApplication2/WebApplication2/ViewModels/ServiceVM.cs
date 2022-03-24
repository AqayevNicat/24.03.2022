using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models.Home;
using WebApplication2.Models.Services;

namespace WebApplication2.ViewModels
{
    public class ServiceVM
    {
        public List<Service> Services { get; set; }
        public Skill Skill { get; set; }
    }
}
