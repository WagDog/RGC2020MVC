using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGC2020MVC.Model
{
    public class CompetitionType
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string Description { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Display(Name = "Date Updated")]
        public DateTime UpdatedAt { get; set; }

    }
}
