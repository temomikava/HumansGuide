using HumansGuide.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanGuide.Infrastructure.Persistence.Configurations
{
    class PhoneNumberConfiguration : IEntityTypeConfiguration<PhoneNumber>
    {
        public void Configure(EntityTypeBuilder<PhoneNumber> builder)
        {
            builder.ToTable("Phones");

            builder.HasQueryFilter(x => !x.DateDeleted.HasValue);
        }
    }
}
