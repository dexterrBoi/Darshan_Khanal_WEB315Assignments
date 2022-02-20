using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesDcUniverse.Models;

    public class RazorPagesDcUniverseContext : DbContext
    {
        public RazorPagesDcUniverseContext (DbContextOptions<RazorPagesDcUniverseContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesDcUniverse.Models.Movie> Movie { get; set; }
    }
