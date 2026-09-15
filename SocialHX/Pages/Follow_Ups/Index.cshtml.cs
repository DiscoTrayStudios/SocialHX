using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SocialHX.Data;
using SocialHX.Models;

namespace SocialHX.Pages.Follow_Ups
{
    public class IndexModel : PageModel
    {
        private readonly SocialHX.Data.SocialHXContext _context;

        public IndexModel(SocialHX.Data.SocialHXContext context)
        {
            _context = context;
        }

        public IList<Follow_Up> Follow_Up { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Follow_Up = await _context.Follow_Up.ToListAsync();
        }
    }
}
