using Microsoft.AspNetCore.Identity;

namespace Travel_Itinerary.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
    }
}