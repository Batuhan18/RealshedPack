using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class RealshedPackContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-TMJ1T9T;initial Catalog=RealshedPack;integrated Security=true");
        }

        public DbSet<Agents> Agents { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<Contact_Messages> Contact_Messages { get; set; }
        public DbSet<Properties> Properties { get; set; }
        public DbSet<Settings> Settings { get; set; }
    }
}
