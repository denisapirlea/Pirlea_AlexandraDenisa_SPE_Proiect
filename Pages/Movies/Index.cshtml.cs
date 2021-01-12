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
    public class IndexModel : PageModel
    {
        private readonly Pirlea_AlexandraDenisa_Proiect.Data.Pirlea_AlexandraDenisa_ProiectContext _context;

        public IndexModel(Pirlea_AlexandraDenisa_Proiect.Data.Pirlea_AlexandraDenisa_ProiectContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
