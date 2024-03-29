﻿using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Travel_Itinerary.Server.Configurations.Entities;
using Travel_Itinerary.Server.Models;
using Travel_Itinerary.Shared.Domain;

namespace Travel_Itinerary.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Destination> Destination { get; set; }
        public DbSet<TravelDocs> TravelDocs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new DestinationSeedConfiguration());

			builder.ApplyConfiguration(new TravelDocsSeedConfiguration());

			builder.ApplyConfiguration(new CustomerSeedConfiguration());

			builder.ApplyConfiguration(new RoleSeedConfiguration());

			builder.ApplyConfiguration(new UserRoleSeedConfiguration());

			builder.ApplyConfiguration(new UserSeedConfiguration());
		}
    }
}