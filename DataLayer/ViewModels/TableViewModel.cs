using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModels
{
	public class TableViewModel
	{
		public int TableID { get; set; }
		public string Capacity { get; set; }
		public Nullable<bool> Status { get; set; }
		public string TableName { get; set; }
	}
}
