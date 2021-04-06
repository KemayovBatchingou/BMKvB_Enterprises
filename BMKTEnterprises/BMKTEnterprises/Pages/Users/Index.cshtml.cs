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
    public class IndexModel : PageModel
    {
        private readonly BMKTEnterprises.Models.AppDbContext _context;

        public IndexModel(BMKTEnterprises.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<UserModel> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
