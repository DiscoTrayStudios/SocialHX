using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SocialHX.Data;
using SocialHX.Models;

namespace SocialHX.Pages.Prescribed_Events
{
    public class CreateModel : PageModel
    {
        private readonly SocialHX.Data.SocialHXContext _context;

        public CreateModel(SocialHX.Data.SocialHXContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Prescribed_Event Prescribed_Event { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Prescribed_Event.Add(Prescribed_Event);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
