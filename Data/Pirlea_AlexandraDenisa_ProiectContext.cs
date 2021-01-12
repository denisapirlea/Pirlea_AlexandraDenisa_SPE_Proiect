using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pirlea_AlexandraDenisa_Proiect.Models;

namespace Pirlea_AlexandraDenisa_Proiect.Data
{
    public class Pirlea_AlexandraDenisa_ProiectContext : DbContext
    {
        public Pirlea_AlexandraDenisa_ProiectContext (DbContextOptions<Pirlea_AlexandraDenisa_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Pirlea_AlexandraDenisa_Proiect.Models.Movie> Movie { get; set; }
    }
}
