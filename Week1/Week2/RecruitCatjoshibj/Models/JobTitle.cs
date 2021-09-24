using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatjoshibj.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        [DisplayName("Industry Name")]
        [StringLength(15,MinimumLength =4,ErrorMessage ="Please Enter a Valid Job Title")]
        [Required(ErrorMessage = "Please enter Industry Name")]
        public string Title { get; set; }

        [DisplayName("Min Salary")]
        [Range(1,1000000)]
        public decimal MinSalary { get; set; }

        [DisplayName("Max Salary")]
        [Range(1, 1000000)]
        public decimal MaxSalary { get; set; }
        public List<Candidate> CandidateIds { get; set; }
        public List<Company> CompanyIds { get; set; }
    }
}
