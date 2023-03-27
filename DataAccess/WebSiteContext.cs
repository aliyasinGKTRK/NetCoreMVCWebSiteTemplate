using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class WebSiteContext:DbContext
    {
        public DbSet<About>? Abouts { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<Gallery>? Galleries { get; set; }
        public DbSet<Slider>? Sliders { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<Referance>? Referances { get; set; }
        public DbSet<Product>? Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=Database; Trusted_Connection=true");
        }

    }
}
