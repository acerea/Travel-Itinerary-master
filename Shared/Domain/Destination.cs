using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Itinerary.Shared.Domain
{
    public class Destination : BaseDomainModel
    {
        public string? DesName { get; set; }
		public int? CustomerId { get; set; }
		public virtual Customer? Customer { get; set; }
		public int? BookingId { get; set; }
		public virtual List<Booking>? Bookings { get; set; }

	}
}
