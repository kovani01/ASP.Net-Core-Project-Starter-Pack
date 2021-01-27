using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExAsp.Models
{
    public class User
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Do not attack the helicopter!")]
        public string password { get; set; }

        [EmailAddress(ErrorMessage = "Do not attack the helicopter!")]
        public string email { get; set; }
        [Required(ErrorMessage = "Do not attack the helicopter!")]
        public double balance { get; set; }
    }
}
