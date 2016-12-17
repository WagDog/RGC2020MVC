using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGC2020MVC.Model
{
    public class Competition
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public CompetitionType CompetitionType { get; set; }

        [Required]
        public int CompetitionTypeId { get; set; }

        [Display(Name = "Number of Players")]
        int NumberofPlayers { get; set; }

        [Display(Name = "Total Money")]
        public decimal TotalMoney { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Display(Name = "Date Updated")]
        public DateTime UpdatedAt { get; set; }

    }
}
