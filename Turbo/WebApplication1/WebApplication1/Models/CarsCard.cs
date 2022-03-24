using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CarsCard
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        public double Price { get; set; }
        [StringLength(1000)]
        public string Name { get; set; }
        public int Year { get; set; }
        public double Motor { get; set; }
        public double Distance { get; set; }
        public IEnumerable<Detail> Details { get; set; }
    }
}
