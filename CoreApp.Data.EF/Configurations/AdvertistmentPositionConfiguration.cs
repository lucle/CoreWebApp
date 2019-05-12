using CoreWebApp.Data.EF.Extensions;
using CoreWebApp.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreWebApp.Data.EF.Configurations
{
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
        }
    }
}