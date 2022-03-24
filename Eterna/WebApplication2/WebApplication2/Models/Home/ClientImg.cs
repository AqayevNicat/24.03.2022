using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models.Home
{
    public class ClientImg
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
    }
}
