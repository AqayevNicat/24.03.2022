using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.Home
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Content { get; set; }
    }
}
