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

namespace SocialHX.Pages.Prescribed_Events
{
    public class EditModel : PageModel
    {
        private readonly SocialHX.Data.SocialHXContext _context;

        public EditModel(SocialHX.Data.SocialHXContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Prescribed_Event Prescribed_Event { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prescribed_event =  await _context.Prescribed_Event.FirstOrDefaultAsync(m => m.Prescribed_Event_ID == id);
            if (prescribed_event == null)
            {
                return NotFound();
            }
            Prescribed_Event = prescribed_event;
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

            _context.Attach(Prescribed_Event).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Prescribed_EventExists(Prescribed_Event.Prescribed_Event_ID))
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

        private bool Prescribed_EventExists(int id)
        {
            return _context.Prescribed_Event.Any(e => e.Prescribed_Event_ID == id);
        }
    }
}
