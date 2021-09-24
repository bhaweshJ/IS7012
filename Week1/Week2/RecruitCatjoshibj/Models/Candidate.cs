using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatjoshibj.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Please Enter a Valid First Name")]
        [Required(ErrorMessage ="Please enter Your first Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Please Enter a Valid Last Name")]
        [Required(ErrorMessage = "Please enter Your Last Name")]
        public string LastName { get; set; }

        [DisplayName("Target Salary")]
        public decimal TargetSalary { get; set; }

        [DisplayName("Company name")]
        public int? CompanyId { get; set; }

        [DisplayName("Job Title")]
        public int JobTitleId { get; set; }
        public Company Company { get; set; }

        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }
        public string Address { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        public Industry Industry { get; set; }

        [DisplayName("Industry")]
        public int IndustryId { get; set; }
        [DisplayName("phone")]
        [Phone]
        public int? phone { get; set; }

        [DisplayName("email")]
        [EmailAddress]
        public int? email { get; set; }
    }
}
