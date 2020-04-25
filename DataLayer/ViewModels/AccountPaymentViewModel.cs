using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModels
{
	public class AccountPaymentViewModel
	{
		public int PaymentID { get; set; }
		public Nullable<int> AdditionID { get; set; }
		public Nullable<int> CustomerID { get; set; }
		public string PaymentType { get; set; }
		public Nullable<System.DateTime> PaymentDate { get; set; }
		public Nullable<decimal> TotalAmount { get; set; }
		public Nullable<bool> AccountStatus { get; set; }
		public Nullable<int> TableID { get; set; }

		public string Addition { get; set; }
		public string Customer { get; set; }
		public string Table { get; set; }
	}
}
