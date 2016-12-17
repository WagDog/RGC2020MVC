using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGC2020MVC.Model
{
    public class Account
    {
        [Required]
        public int Id { get; set; }

        public User User { get; set; }

        [Required]
        public int UserId { get; set; }

        public Competition Competition { get; set; }

        [Required]
        public int CompetitionId { get; set; }

        [Required]
        [Display(Name = "Date")]
        public DateTime EntryDateTime { get; set; }

        [Display(Name = "Credited")]
        public decimal? AmountCredited { get; set; }

        [Display(Name = "Debited")]
        public decimal? AmountDebited { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Display(Name = "Date Updated")]
        public DateTime UpdatedAt { get; set; }



    }
}
