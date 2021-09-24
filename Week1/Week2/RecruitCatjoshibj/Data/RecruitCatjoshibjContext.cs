using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatjoshibj.Models;

namespace RecruitCatjoshibj.Data
{
    public class RecruitCatjoshibjContext : DbContext
    {
        public RecruitCatjoshibjContext (DbContextOptions<RecruitCatjoshibjContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatjoshibj.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatjoshibj.Models.Company> Company { get; set; }

        public DbSet<RecruitCatjoshibj.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatjoshibj.Models.JobTitle> JobTitle { get; set; }
    }
}
