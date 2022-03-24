using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Detail
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        public int CarsCardId { get; set; }
        public CarsCard CarsCard { get; set; }
    }
}
