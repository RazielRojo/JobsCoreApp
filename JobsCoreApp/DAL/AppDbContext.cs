using JobsCoreApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsCoreApp.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<DayStatistics> DaysStatistics { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DayStatistics>().ToTable("DaysStatistics");
        }
    }
}
