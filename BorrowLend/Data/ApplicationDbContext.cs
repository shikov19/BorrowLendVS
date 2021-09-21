using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BorrowLend.Models;
using Microsoft.EntityFrameworkCore;

namespace BorrowLend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Item> items { get; set; }
    }
}
