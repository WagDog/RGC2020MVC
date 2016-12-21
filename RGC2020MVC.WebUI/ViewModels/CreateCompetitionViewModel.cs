using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RGC2020MVC.DAL.Repositories;
using RGC2020MVC.Model;

namespace RGC2020MVC.WebUI.ViewModels
{
    public class CreateCompetitionViewModel
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}")]
        public DateTime Date { get; set; }

        public List<CompetitionType> CompetitionTypes { get; set; }

        [Required]
        public int CompetitionTypeId { get; set; }

        public string PageTitle { get; set; }

        public CreateCompetitionViewModel()
        {
            Id = 0;
            Name = "";
            Date = DateTime.Now;
            CompetitionTypeId = 0;
            PageTitle = "";
            CompetitionTypes = new List<CompetitionType>();
        }

        public CreateCompetitionViewModel(Competition competition)
        {
            Id = competition.Id;
            Name = competition.Name;
            Date = competition.Date;
            CompetitionTypeId = competition.CompetitionTypeId;
            PageTitle = "";
            CompetitionTypes = new List<CompetitionType>();
        }

    }
}