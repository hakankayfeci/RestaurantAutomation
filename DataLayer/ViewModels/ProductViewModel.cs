using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModels
{
	public class ProductViewModel
	{

		public int ProductID { get; set; }
		public Nullable<int> CategoryID { get; set; }
		public string ProductName { get; set; }
		public string Price { get; set; }
		public Nullable<bool> Status { get; set; }
		public byte[] ProductImage { get; set; }
		public string CategoryName { get; set; }
	}
}
