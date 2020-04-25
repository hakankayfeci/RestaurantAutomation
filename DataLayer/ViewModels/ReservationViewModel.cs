using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModels
{
	public class ReservationViewModel
	{
		public int ReservationID { get; set; }
		public Nullable<int> CustomerID { get; set; }
		public Nullable<int> TableID { get; set; }
		public string Phone { get; set; }
		public Nullable<System.DateTime> ReservationDate { get; set; }
		public string ReservationNote { get; set; }
		public Nullable<int> PersonCount { get; set; }
		public Nullable<bool> Status { get; set; }
		public string  Customer { get; set; }

		public string Table { get; set; }
	}
}
