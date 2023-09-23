using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using scrapapp.entity;

namespace scrapapp.data.Configurations
{
    public class SiteConfiguration : IEntityTypeConfiguration<Site>
    {
        public void Configure(EntityTypeBuilder<Site> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.Product)
                .WithMany(p => p.Sites)
                .HasForeignKey(s => s.ProductId);
        }
    }
}