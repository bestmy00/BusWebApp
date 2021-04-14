using Microsoft.EntityFrameworkCore;
using SchoolBussWebApp.Models;

namespace SchoolBussWebApp.Data
{
    public class BussDbContext : DbContext
    {
        public BussDbContext(DbContextOptions<BussDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BussAtnd>().HasKey(table => new {
                table.Schl_Year,
                table.Schl_Shtm,
                table.Stnt_Numb
            });

            builder.Entity<BussCardIssu>().HasKey(table => new
            {
                table.Issu_Year,
                table.Issu_Shtm,
                table.Stnt_Numb
            });
        }

        public DbSet<BussLine> BussLine { get; set; }
        public DbSet<BussCard> BussCard { get; set; }
        public DbSet<BussAtnd> BussAtnd { get; set; }
        public DbSet<BussCardIssu> BussCardIssu { get; set; }
    }
}
