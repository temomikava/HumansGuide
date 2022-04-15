using HumansGuideApi.Enums;
using HumansGuideApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HumansGuideApi.DataContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
        public DbSet<Human> Humans { get; set; }

        public IQueryable<Human> GetHumans() => Humans.Include(x => x.ConnectedHumans);
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PhoneNumber>()
                .HasOne(x => x.Human)
                .WithMany(x=>x.Phones)
                .HasForeignKey(x=>x.HumanId)
                .OnDelete(DeleteBehavior.ClientCascade);
            builder.Entity<City>()
                .HasMany(x => x.Humans)
                .WithOne(x => x.City)
                .HasForeignKey(x => x.CityId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<ConnectedHuman>()
                .HasOne(x=>x.Human)
                .WithMany(x=>x.ConnectedHumans)
                .HasForeignKey(x=>x.HumanId)
                .HasForeignKey(x => x.ConnectedHumanId)
                .OnDelete(DeleteBehavior.ClientCascade);
                

        }
    }
}
