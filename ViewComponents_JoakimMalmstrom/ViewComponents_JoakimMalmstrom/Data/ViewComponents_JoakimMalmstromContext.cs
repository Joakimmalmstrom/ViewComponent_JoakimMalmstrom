using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ViewComponents_JoakimMalmstrom.Models;

namespace ViewComponents_JoakimMalmstrom.Data
{
    public class ViewComponents_JoakimMalmstromContext : DbContext
    {
        public ViewComponents_JoakimMalmstromContext (DbContextOptions<ViewComponents_JoakimMalmstromContext> options)
            : base(options)
        {
        }

        public DbSet<ViewComponents_JoakimMalmstrom.Models.User> User { get; set; }
    }
}
