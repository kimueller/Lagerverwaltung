using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseManagment.Data.Models
{
	public class BusinessCase
	{
		[Key] 
		public int BusinessCaseID { get; set; }

		public DateTime CreationTime { get; set; }

		public string EmployeeID { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ICollection<StockMovement> StockMovement { get; set; }
	}
}
