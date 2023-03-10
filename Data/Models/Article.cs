using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseManagment.Data.Models
{
	public class Article
	{
		[Key]
		public int ArticleID { get; set; }

		[Required]
		[StringLength(100)]
		public string ArticleName { get; set; }

		[Required]
		[StringLength(100)]
		public string Unit { get; set; }

		[Required]
		[Column(TypeName = "decimal(7, 2)")]
		public decimal Price { get; set; }

		[Required]
		[Range(0,50000)]
		public int Stock { get; set; }

		public virtual ICollection<StockMovement> StockMovement { get; set;}
	}
}
