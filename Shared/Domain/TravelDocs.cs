using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Travel_Itinerary.Shared.Domain
{
    public class TravelDocs : BaseDomainModel, IValidatableObject
	{
		[Required]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements")]
		public string? TravelName { get; set; }
		[Required]
		[DataType(DataType.EmailAddress, ErrorMessage = "Email is not a valid email")]
		[EmailAddress]
		public string? TravelEmail { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; }
	
		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (EndDate != null)
			{
				if (EndDate <= StartDate)
				{
					yield return new ValidationResult("EndDate must be greater than StartDate", new[] { "EndDate" });
				}
			}
		}

	}
}
