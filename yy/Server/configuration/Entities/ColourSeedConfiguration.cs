using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using yy.Shared.Domain;

namespace yy.Server.configuration.Entities
{
    public class ColourSeedConfiguration : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                new Colour
                {
                    Id = 1,
                    name = "Black",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
new Colour
{
    Id = 2,
    name = "Blue",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
}
);
        }
    }
}
