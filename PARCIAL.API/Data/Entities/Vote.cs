using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace PARCIAL.Api.Data.Entities
{
    public class Vote

    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string QuestionId { get; set; }

        [Required]
        [MaxLength(500)]
        public string OptionId { get; set; }
        [Required]
        public User User { get; set; }
    }
}
