using CoreWebApp.Data.EF.Extensions;
using CoreWebApp.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreWebApp.Data.EF.Configurations
{
    public class SystemConfigConfiguration : DbEntityConfiguration<SystemConfig>
    {
        public override void Configure(EntityTypeBuilder<SystemConfig> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
        }
    }
}