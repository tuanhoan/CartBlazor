using CartBlazor.Data;
using Microsoft.EntityFrameworkCore; 
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Threading.Tasks;

namespace CartBlazor
{
    public class Context : DbContext
    {
        public Context() : base() {  
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartImg> CartImgs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>()
                .HasMany<CartImg>(g => g.CartImgs)
                .WithOne(s => s.Cart)
                .HasForeignKey(s => s.CardId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=CartDB;Username=postgres;Password=tuanhoan");


    }
}
