using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using scrapapp.entity;

namespace scrapapp.data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(m=>m.Id);
            builder.HasOne(e => e.Detail)
                    .WithOne(e => e.Product)
                    .HasForeignKey<Detail>(e => e.DetailId)
                    .IsRequired();
        }
    }
}