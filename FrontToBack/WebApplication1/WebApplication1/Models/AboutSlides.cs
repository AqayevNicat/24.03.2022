using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AboutSlides
    {
        public int Id { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        public int AboutId { get; set; }
        public About About { get; set; }
    }
}
