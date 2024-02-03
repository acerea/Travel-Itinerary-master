using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;


namespace Travel_Itinerary.Shared.Domain
{
    public class Booking : BaseDomainModel, IValidatableObject
	{
		public string? BookingName { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime? DateIn { get; set; }
        public DateTime? DateOut { get; set; }
		[Required]
		[StringLength(100, MinimumLength = 1, ErrorMessage = "First Name does not meet length requirements")]
		public string? BookingLocation { get; set; }
		[Required]
		[DataType(DataType.EmailAddress, ErrorMessage = "Email is not a valid email")]
		[EmailAddress]
		public string? BookingEmail { get; set; }
		public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
		[Required]
		[DataType(DataType.Currency, ErrorMessage = "Number of Guests must be a valid number")]
		[RegularExpression(@"^[+]?\d+([.]\d+)?$", ErrorMessage = "Number of Guests cannot be a negative number")]
		//[RegularExpression(@"^[+]?\d+([.]\d+)?$", ErrorMessage = "Number of Guests cannot be zero")]

		public double GuestNumber { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{

			if (DateOut != null)
			{
				if (DateOut <= DateIn)
				{
					yield return new ValidationResult("DateOut must be greater than DateIn", new[] { "DateOut" });
				}
			}
		}
	}
}