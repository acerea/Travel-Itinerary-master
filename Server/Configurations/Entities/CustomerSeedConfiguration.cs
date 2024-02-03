using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Travel_Itinerary.Shared.Domain;


namespace Travel_Itinerary.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
				{
                    Id = 1,
                    ContactNumber = "8170 2202",
					EmailAddress = "sv@yahoo.com",
					CusFirstName = "Juliana",
					CusLastName = "Florian",
					DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Customer
				{
                    Id = 2,
                    ContactNumber = "8210 2202",
                    EmailAddress = "legends_a@gmail.com",
                    CusFirstName = "Akari",
                    CusLastName = "Rei",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
