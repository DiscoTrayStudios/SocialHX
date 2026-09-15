using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SocialHX.Data;
using SocialHX.Models;

namespace SocialHX.Pages.Prescribed_Events
{
    public class DetailsModel : PageModel
    {
        private readonly SocialHX.Data.SocialHXContext _context;

        public DetailsModel(SocialHX.Data.SocialHXContext context)
        {
            _context = context;
        }

        public Prescribed_Event Prescribed_Event { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prescribed_event = await _context.Prescribed_Event.FirstOrDefaultAsync(m => m.Prescribed_Event_ID == id);

            if (prescribed_event is not null)
            {
                Prescribed_Event = prescribed_event;

                return Page();
            }

            return NotFound();
        }
    }
}
