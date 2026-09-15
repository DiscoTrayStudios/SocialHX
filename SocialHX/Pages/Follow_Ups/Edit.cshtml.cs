using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SocialHX.Data;
using SocialHX.Models;

namespace SocialHX.Pages.Follow_Ups
{
    public class EditModel : PageModel
    {
        private readonly SocialHX.Data.SocialHXContext _context;

        public EditModel(SocialHX.Data.SocialHXContext context)
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

            var follow_up =  await _context.Follow_Up.FirstOrDefaultAsync(m => m.Follow_Up_ID == id);
            if (follow_up == null)
            {
                return NotFound();
            }
            Follow_Up = follow_up;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Follow_Up).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Follow_UpExists(Follow_Up.Follow_Up_ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Follow_UpExists(int id)
        {
            return _context.Follow_Up.Any(e => e.Follow_Up_ID == id);
        }
    }
}
