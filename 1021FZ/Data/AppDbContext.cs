using Microsoft.EntityFrameworkCore;
using _1021FZ.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;


namespace _1021FZ.Data
{
    public class AppDbContext: DbContext
    { 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Blogger> bloggers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
