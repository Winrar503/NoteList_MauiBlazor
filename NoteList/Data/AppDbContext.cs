using Microsoft.EntityFrameworkCore;
using NoteList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteList.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Notes> Notes { get; set; }
        //public DbSet<Photos> Photos { get; set; }
    }
}
