using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseManagment.Data.Models
{
	public class StockMovement
	{
		[Key]
		public int StockMovementID { get; set; }

		public int ArticleID { get; set; }
		public Article Article { get; set; }

        public int ProcessTypeID { get; set; }
        public ProcessType ProcessType { get; set; }

		public int BusinessCaseID { get; set; }
		public BusinessCase BusinessCase { get; set; }

		[Required]
		[Range(0, 50000)]
		public int Amount { get; set; } = 1;


    }
}
