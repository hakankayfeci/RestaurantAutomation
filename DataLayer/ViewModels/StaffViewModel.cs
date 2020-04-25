using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModels
{
    public class StaffViewModel
    {
        public int StaffID { get; set; }
        public Nullable<int> TitleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string TcNumber { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public Nullable<decimal> MonthlySalary { get; set; }
        public Nullable<System.DateTime> WorkDateOfStarting { get; set; }
        public Nullable<System.DateTime> WorkLeavingDate { get; set; }
        public byte[] StaffImage { get; set; }
        public string TitleName { get; set; }
    }
}
