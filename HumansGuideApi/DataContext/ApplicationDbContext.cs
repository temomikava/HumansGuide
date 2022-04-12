using HumansGuideApi.Enums;
using HumansGuideApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HumansGuideApi.DataContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
        DbSet<Human> Humans { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PhoneNumber>()
                .HasOne(x => x.Human)
                .WithMany(x=>x.Phones)
                .HasForeignKey(x=>x.HumanId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<City>()
                .HasMany(x => x.Humans)
                .WithOne(x => x.City)
                .HasForeignKey(x => x.CityId);
                
                

        }
    }
}
