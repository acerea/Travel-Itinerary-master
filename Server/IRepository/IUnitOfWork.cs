using Travel_Itinerary.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel_Itinerary.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<TravelDocs> TravelDocs { get; }
        //IGenericRepository<Model> Models { get; }
        //IGenericRepository<Vehicle> Vehicles { get; }
        IGenericRepository<Destination> Destination { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Customer> Customers { get; }
    }
}