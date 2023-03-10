using System.ComponentModel.DataAnnotations;

namespace WarehouseManagment.Data.Models
{
	public class ProcessType
	{
		[Key]
		public int ProcessTypeID { get; set; }

		[Required]
		[StringLength(100)]
		public string TypeName { get; set; }

		public virtual ICollection<StockMovement> StockMovement { get; set; }

	}
}
