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
    public class DeleteModel : PageModel
    {
        private readonly SocialHX.Data.SocialHXContext _context;

        public DeleteModel(SocialHX.Data.SocialHXContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Follow_Up Follow_Up { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var follow_up = await _context.Follow_Up.FirstOrDefaultAsync(m => m.Follow_Up_ID == id);

            if (follow_up is not null)
            {
                Follow_Up = follow_up;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var follow_up = await _context.Follow_Up.FindAsync(id);
            if (follow_up != null)
            {
                Follow_Up = follow_up;
                _context.Follow_Up.Remove(Follow_Up);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
