using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PARCIAL.Api.Data.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [MaxLength(20)]
        [MinLength(6)]
        public string Password { get; set; }

        public ICollection<Vote> Votes { get; set; }


    }
}
