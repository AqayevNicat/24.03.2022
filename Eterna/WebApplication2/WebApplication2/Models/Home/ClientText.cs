using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.Home
{
    public class ClientText
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string Content { get; set; }
    }
}
