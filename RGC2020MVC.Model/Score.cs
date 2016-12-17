using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGC2020MVC.Model
{
    public class Score
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public Competition Competition { get; set; }

        public int CompetitionId { get; set; }

        public int Position { get; set; }

        public decimal AmountWon { get; set; }

        public int Result { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Display(Name = "Date Updated")]
        public DateTime UpdatedAt { get; set; }
    }
}
