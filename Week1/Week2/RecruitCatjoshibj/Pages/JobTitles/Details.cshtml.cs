using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatjoshibj.Data;
using RecruitCatjoshibj.Models;

namespace RecruitCatjoshibj.Pages.JobTitles
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatjoshibj.Data.RecruitCatjoshibjContext _context;

        public DetailsModel(RecruitCatjoshibj.Data.RecruitCatjoshibjContext context)
        {
            _context = context;
        }

        public JobTitle JobTitle { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JobTitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.Id == id);

            if (JobTitle == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
