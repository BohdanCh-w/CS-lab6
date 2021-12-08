using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_final.Models
{
    public class ClubDbContext : DbContext {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<EquipmentUsage> EquipmentUsages { get; set; }
        
        public ClubDbContext(DbContextOptions<ClubDbContext> options) : base(options) {
            
        }
    }
}
