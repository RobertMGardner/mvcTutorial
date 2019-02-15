using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mvcTutorial.Models
{
    public class mvcTutorialContext : DbContext
    {
        public mvcTutorialContext (DbContextOptions<mvcTutorialContext> options)
            : base(options)
        {
        }

        public DbSet<mvcTutorial.Models.Movie> Movie { get; set; }
    }
}
