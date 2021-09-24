using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatjoshibj.Models
{
    public class Industry
    {

        public int Id { get; set; }

        [DisplayName("Industry Name")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Please Enter a Valid Name")]
        [Required(ErrorMessage = "Please enter Industry Name")]
        public string IndustryName { get; set; }


        public List<Candidate> CandidateIds { get; set; }
        public List<Company> CompanyIds { get; set; }

        [Range(1, 1000000)]
        public long? Sensex { get; set; }
    }
}
