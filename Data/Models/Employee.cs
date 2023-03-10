using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WarehouseManagment.Data.Models
{
	public class Employee : IdentityUser
	{
		[Required]
		[StringLength(100)]
		public string FirstName { get; set; }

		[Required]
		[StringLength(100)]
		public string LastName { get; set; }

		public virtual ICollection<BusinessCase> BusinessCase { get; set; }
	}
}
