using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data.FluentAPI;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
           
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CommentFluentAPI());
            modelBuilder.ApplyConfiguration(new StockFluentAPI());
            base.OnModelCreating(modelBuilder);
        }
    }
}