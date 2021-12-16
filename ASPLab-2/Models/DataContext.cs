using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPLab_2.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Services> Services { get; set; }
        public DbSet<TestTimonal> TestTimonals { get; set; }
        public DbSet<Client> Clients { get; set; }

        public DbSet<AboutUs> aboutUs { get; set; }
    }
}
