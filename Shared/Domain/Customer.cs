using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Itinerary.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? ContactNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? CusFirstName { get; set; }
        public string? CusLastName { get; set; }
    }
}
