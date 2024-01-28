namespace Travel_Itinerary.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
		public string? BookingName { get; set; }
		public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
		public string? BookingLocation { get; set; }
		public string? BookingEmail { get; set; }
		public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}