using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModels
{
	public class ProductOrderViewModel
	{
		public int OrderID { get; set; }
		public Nullable<int> ProductID { get; set; }
		public Nullable<int> TableID { get; set; }
		public string ProductName { get; set; }
		public Nullable<int> ProductPiece { get; set; }
		public string OrderNote { get; set; }
		public string OrderStatus { get; set; }

		public virtual ProductOrder ProductOrders { get; set; }
		public string Table{ get; set; }
	}
}
