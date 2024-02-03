using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Itinerary.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
		[Required]
		[DataType(DataType.PhoneNumber)]
		[RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not a valid phone number")]
		public string? ContactNumber { get; set; }
		[Required]
		[DataType(DataType.EmailAddress, ErrorMessage = "Email is not a valid email")]
		[EmailAddress]
		public string? EmailAddress { get; set; }

		[Required]
		[StringLength(100, MinimumLength = 1, ErrorMessage = "First Name does not meet length requirements")]
		public string? CusFirstName { get; set; }
		[Required]
		[StringLength(100, MinimumLength = 1, ErrorMessage = "Last Name does not meet length requirements")]
		public string? CusLastName { get; set; }
    }
}
