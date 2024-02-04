using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Travel_Itinerary.Shared.Domain;

namespace Travel_Itinerary.Server.Configurations.Entities
{
    public class TravelDocsSeedConfiguration : IEntityTypeConfiguration<TravelDocs>
    {
        public void Configure(EntityTypeBuilder<TravelDocs> builder)
        {
            builder.HasData(
                new TravelDocs
                {
                    Id = 1,
                    TravelName = "Singapore to Paris",
                    TravelEmail = "parni@yahoo.com",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new TravelDocs
                {
                    Id = 2,
                    TravelName = "Amsterdam Adventure",
					TravelEmail = "ameel@yahoo.com",
					DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
