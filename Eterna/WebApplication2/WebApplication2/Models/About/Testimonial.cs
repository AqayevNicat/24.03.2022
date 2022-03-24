using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models.About
{
    public class Testimonial
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string Content { get; set; }
    }
}
