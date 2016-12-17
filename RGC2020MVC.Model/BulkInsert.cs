using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGC2020MVC.Model
{
    public class BulkInsert
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public Competition Competition { get; set; }

        [Required]
        public int CompetitionId { get; set; }

        public string CsvInput { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Display(Name = "Date Updated")]
        public DateTime UpdatedAt { get; set; }

    }
}
