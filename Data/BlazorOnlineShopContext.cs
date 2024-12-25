using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorOnlineShop.Models;

namespace BlazorOnlineShop.Data
{
    public class BlazorOnlineShopContext : DbContext
    {
        public BlazorOnlineShopContext (DbContextOptions<BlazorOnlineShopContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorOnlineShop.Models.Product> Product { get; set; } = default!;
        public DbSet<BlazorOnlineShop.Models.Order> Order { get; set; } = default!;
        public DbSet<BlazorOnlineShop.Models.OrderItem> OrderItem { get; set; } = default!;
    }
}
