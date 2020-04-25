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
	public class CustomerBusiness : ICustomer
	{
		public void Delete(Customer t)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				db.Customers.Attach(t);
				db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}

		public void Delete(int id)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				Customer c = Get(id);
				db.Customers.Attach(c);
				db.Entry(c).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();


			}
		}

		public Customer Get(int id)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				return db.Customers.FirstOrDefault(x=>x.CustomerID==id);
			}
		}

		public List<Customer> GetAll()
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				return db.Customers.ToList();
			}
		}

		public void Insert(Customer t)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				db.Customers.Add(t);
				db.SaveChanges();
			}
		}

		public void Update(Customer t)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{

				db.Customers.Attach(t);
				db.Entry(t).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}
		
	}
}
