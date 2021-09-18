using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatjoshibj.Models
{
    public class Industry
    {

        public int Id { get; set; }
        public string IndustryName { get; set; }
        public List<Candidate> CandidateIds { get; set; }
        public List<Company> CompanyIds { get; set; }
        public long? Sensex { get; set; }
    }
}
