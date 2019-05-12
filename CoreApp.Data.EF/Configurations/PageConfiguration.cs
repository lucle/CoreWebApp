using CoreWebApp.Data.EF.Extensions;
using CoreWebApp.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreWebApp.Data.EF.Configurations
{
    public class PageConfiguration : DbEntityConfiguration<Page>
    {
        public override void Configure(EntityTypeBuilder<Page> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
        }
    }
}