using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pirlea_AlexandraDenisa_Proiect.Data;
using Pirlea_AlexandraDenisa_Proiect.Models;

namespace Pirlea_AlexandraDenisa_Proiect.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly Pirlea_AlexandraDenisa_Proiect.Data.Pirlea_AlexandraDenisa_ProiectContext _context;

        public DetailsModel(Pirlea_AlexandraDenisa_Proiect.Data.Pirlea_AlexandraDenisa_ProiectContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
