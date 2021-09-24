using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatjoshibj.Models
{
    public class Company
    {
        [DisplayName("Company Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please Enter  valid Company Name")]
        [Required(ErrorMessage = "Please enter Your Company Name")]
        public string CompanyName { get; set; }
        [DisplayName("Position Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please Enter  valid Position Name")]
        [Required(ErrorMessage = "Please enter Your Company Name")]
        public string Position { get; set; }
     
        [DisplayName("Min Salary")]
        [Range(1, 1000000)]
        public decimal MinSalary { get; set; }

        [DisplayName("Max Salary")]
        [Range(1, 1000000)]
        public decimal MaxSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }

        [DisplayName("Location")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Please Enter  valid Location")]
        [Required(ErrorMessage = "Please enter Location")]
        public string Location { get; set; }

        [DisplayName("Company Id")]
        public int CompanyId { get; set; }
        public List<Candidate> CandidateIds { get; set; }
        public Industry Industry { get; set; }

        [DisplayName("Indsutry")]
        public int IndustryId { get; set; }

        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }

        [DisplayName("Job Ttile")]
        public int JobTitleId { get; set; }

        [DisplayName("Recruitment Date")]
        public DateTime RecruitmentDate { get; set; }

        [DisplayName("Open Position")]
        public bool OpenPosition { get; set; }

        [DisplayName("URL")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Please Enter  valid URL")]
        [Required(ErrorMessage = "Please enter Comapny Website URL")]
        [Url]
        public string Url { get; set; }
    }
}
