using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class WebApplicationDBContext : DbContext
    {
        public WebApplicationDBContext(DbContextOptions<WebApplicationDBContext> options)
            : base(options) 
        {
            Database.EnsureCreated();
        }

        public DbSet<Dog> Dogs { get; set; }
    }
}
