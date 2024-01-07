using BasedClub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BasedClub.Data
{
    public class ProductConfiguration :
   IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p =>
           p.ImageName).HasColumnName("ImageFileName");
        }
    }
}