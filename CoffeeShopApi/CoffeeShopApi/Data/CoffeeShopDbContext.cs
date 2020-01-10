using CoffeeShopApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApi.Data
{
    public class CoffeeShopDbContext : DbContext
    {
        public CoffeeShopDbContext(DbContextOptions<CoffeeShopDbContext>options):base(options)
        {

        }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<Reservation> Reservations { get; set; }
    }
}
