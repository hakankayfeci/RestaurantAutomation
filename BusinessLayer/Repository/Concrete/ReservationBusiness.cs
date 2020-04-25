using BusinessLayer.Repository.Abstract;
using DataLayer;
using DataLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository.Concrete
{
	public class ReservationBusiness : IReservation
	{
		public void Delete(int id)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				Reservation a = Get(id);
				db.Reservations.Attach(a);
				db.Entry(a).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}

		public void Delete(Reservation t)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				db.Reservations.Attach(t);
				db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}
		public Reservation Get(int id)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				return db.Reservations.FirstOrDefault(x => x.ReservationID == id);
			}
		}
		public List<Reservation> GetAll()
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				return db.Reservations.ToList();
			}
		}
		public void Insert(Reservation t)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				db.Reservations.Add(t);
				db.SaveChanges();
			}
		}
		public void Update(Reservation t)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				var reserve = Get(t.ReservationID);
				reserve.PersonCount = t.PersonCount;
				reserve.ReservationDate = t.ReservationDate;
				reserve.ReservationNote = t.ReservationNote;
				reserve.Status = t.Status;
				reserve.ReservationID = t.ReservationID;
				reserve.CustomerID = t.CustomerID;
				db.Reservations.Attach(reserve);
				db.Entry(reserve).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}
		public List<string> GetTable()
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				var table = db.Tables.Select(p => p.TableID.ToString()).ToList();
				table.Insert(0, "Seçiniz...");
				return table;
			}
		}
		public List<ReservationViewModel> Reservations()
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				var reservations = new List<ReservationViewModel>();
				var result = from a in db.Reservations
							 join tt in db.Customers on a.CustomerID equals tt.CustomerID
							 join at in db.Tables on a.TableID equals at.TableID
							 select new
							 {
								 a.ReservationID,
								 a.CustomerID,
								 a.TableID,
								 a.ReservationDate,
								 a.ReservationNote,
								 a.PersonCount,
								 a.Status,
								 tt.NameSurname,
								 tt.Phone
							 };

				foreach (var reservation in result)
				{
					reservations.Add(new ReservationViewModel
					{
						ReservationID = reservation.ReservationID,
						CustomerID = reservation.CustomerID,
						TableID = reservation.TableID,
						ReservationDate = reservation.ReservationDate,
						ReservationNote = reservation.ReservationNote,
						PersonCount = reservation.PersonCount,
						Status = reservation.Status,
						Customer = reservation.NameSurname,
						Phone = reservation.Phone
					});
				}
				return reservations;
			}
		}
	}
}
