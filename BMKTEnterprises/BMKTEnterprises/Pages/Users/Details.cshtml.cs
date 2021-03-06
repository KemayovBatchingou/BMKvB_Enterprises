using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BMKTEnterprises.Models;

namespace BMKTEnterprises.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly BMKTEnterprises.Models.AppDbContext _context;

        public DetailsModel(BMKTEnterprises.Models.AppDbContext context)
        {
            _context = context;
        }

        public UserModel User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.ID == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
