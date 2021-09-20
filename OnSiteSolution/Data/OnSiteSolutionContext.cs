using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnSiteSolution.Model;

namespace OnSiteSolution.Data
{
    public class OnSiteSolutionContext : DbContext
    {
        public OnSiteSolutionContext (DbContextOptions<OnSiteSolutionContext> options)
            : base(options)
        {
        }

        public DbSet<OnSiteSolution.Model.Clients> Clients { get; set; }

        public DbSet<OnSiteSolution.Model.Message> Message { get; set; }
    }
}
