using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesApp.Models
{
    public class RazorPagesAppContext : DbContext
    {
        public RazorPagesAppContext (DbContextOptions<RazorPagesAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesApp.Models.Products> Products { get; set; }
    }
}
