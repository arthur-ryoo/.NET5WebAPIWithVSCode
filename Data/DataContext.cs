using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _NETWebAPIWithEF.Models;
using Microsoft.EntityFrameworkCore;

namespace _NETWebAPIWithEF.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Character> Characters { get; set; }
    }
}