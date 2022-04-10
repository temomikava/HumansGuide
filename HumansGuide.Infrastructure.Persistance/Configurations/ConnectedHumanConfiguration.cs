using HumansGuide.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansGuide.Infrastructure.Persistance.Configurations
{
    class ConnectedHumanConfiguration : IEntityTypeConfiguration<ConnectedHuman>
    {
        public void Configure(EntityTypeBuilder<ConnectedHuman> builder)
        {
            builder.HasQueryFilter(x => !x.DateDeleted.HasValue);


            builder.HasOne(x => x.Human)
                .WithMany(x => x.BaseConnectedHumans)
                .HasForeignKey(x => x.HumanId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.BaseConnectedHuman)
                .WithMany()
                .HasForeignKey(x => x.BaseConnectedHumanId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
