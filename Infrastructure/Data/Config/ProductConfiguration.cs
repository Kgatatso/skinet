
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config

{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder <Product> Builder)
        { 
            Builder.Property(p => p.Id).IsRequired();
            Builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            Builder.Property(p => p.Description).IsRequired();
            Builder.Property(p => p.Price).HasColumnType("decimal(18.2)");
            Builder.Property(p => p.PictureUrl).IsRequired();
            Builder.HasOne(b => b.ProductBrand).WithMany().HasForeignKey(p => p.ProductBrandId);
            Builder.HasOne(t => t.ProductType).WithMany().HasForeignKey(p => p.ProductTypeId);

            


          
        }
        
    }
}