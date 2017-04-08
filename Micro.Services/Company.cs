using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro.Services
{
    public class Company
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        
        [MaxLength(13)]
        public ulong Bulstrat { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string MOL { get; set; }
        public int Number { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
