using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StaffManagement
    {
        public StaffState GetUser(string uname, string pass)//Kullanıcının Olup Olmadığını Kontrol Etmek İçin Oluşturduk.
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {
                return db.Staffs.Where(s => s.UserName == uname && s.Password == pass).FirstOrDefault()
                    != null ? StaffState.UserExists : StaffState.UserNotExists;
            }
        }
        public Staff GetUser(string username)//Kullancı Adına Göre Bilgileri Çağırmak için Oluşturduk.
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {
                return db.Staffs.Where(s => s.UserName == username).FirstOrDefault();
            }
        }
		public Staff GetUserr(string username, string pass)//Kullancı Adına Göre Bilgileri Çağırmak için Oluşturduk.
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				return db.Staffs.Where(s => s.UserName == username && s.Password == pass).FirstOrDefault();
			}
		}
	}
    
}
