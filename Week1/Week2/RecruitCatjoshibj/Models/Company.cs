using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatjoshibj.Models
{
    public class Company
    {
        public string? CompanyName { get; set; }
        public string Position { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public string Location { get; set; }
        public int CompanyId { get; set; }
        public List<Candidate> CandidateIds { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        public DateTime RecruitmentDate { get; set; }
        public bool OpenPosition { get; set; }
    }
}
