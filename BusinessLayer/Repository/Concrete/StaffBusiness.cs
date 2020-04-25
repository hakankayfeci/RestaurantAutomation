using BusinessLayer.Repository.Abstract;
using DataLayer;
using DataLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository.Concrete
{
   public class StaffBusiness : IStaff
    {
        public void Delete(Staff t)
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {
                
                db.Staffs.Attach(t);
                db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {
                Staff s = Get(id);
                db.Staffs.Attach(s);
                db.Entry(s).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();


            }
        }

        public Staff Get(int id)
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {
               return db.Staffs.Find(id);

            }
        }

        public List<Staff> GetAll()
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {
                return db.Staffs.ToList();
            }
        }

        public void Insert(Staff t)
        {
            using (RestoranDBEntities db= new RestoranDBEntities())
            {
                db.Staffs.Add(t);
                db.SaveChanges();
            }
        }

        public void Update(Staff t)
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {

                db.Staffs.Attach(t);
                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<StaffViewModel> Staffs()
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {
				var stafflar = new List<StaffViewModel>();


				var result = from a in db.Staffs
							 join tt in db.Titles on a.TitleID equals tt.TitleID
							 select new
							 {
								 a.StaffID,
								 a.TitleID,
								 a.FirstName,
								 a.LastName,
								 a.UserName,
								 a.Password,
								 a.Phone,
								 a.TcNumber,
								 a.SecurityQuestion,
								 a.SecurityAnswer,
								 a.MonthlySalary,
								 a.WorkDateOfStarting,
								 a.WorkLeavingDate,
								 tt.TitleName
							 };
				foreach (var personel in result)
				{
					stafflar.Add(new StaffViewModel
					{
						StaffID = personel.StaffID,
						TitleID = personel.TitleID,
						FirstName = personel.FirstName,
						LastName = personel.LastName,
						UserName = personel.UserName,
						Password = personel.Password,
						Phone = personel.Phone,
						TcNumber = personel.TcNumber,
						SecurityQuestion = personel.SecurityQuestion,
						SecurityAnswer = personel.SecurityAnswer,
						MonthlySalary = personel.MonthlySalary,
						WorkDateOfStarting = personel.WorkDateOfStarting,
						WorkLeavingDate = personel.WorkLeavingDate,
						TitleName = personel.TitleName
					});
				}
				return stafflar;
            }
        }
        public Staff GetByUsername(string text)
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {
                return db.Staffs.FirstOrDefault(x=>x.UserName ==text);
            }
        }
    }
}
