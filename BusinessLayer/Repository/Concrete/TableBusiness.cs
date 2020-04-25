using BusinessLayer.Repository.Abstract;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.ViewModels;

namespace BusinessLayer.Repository.Concrete
{
	public class TableBusiness : ITable
	{
		public void Delete(Table t)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{

				db.Tables.Attach(t);
				db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}

		public void Delete(int id)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				Table s = Get(id);
				db.Tables.Attach(s);
				db.Entry(s).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();


			}
		}

		public Table Get(int id)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				return db.Tables.Find(id);

			}
		}

		public List<Table> GetAll()
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				return db.Tables.ToList();
			}
		}

		public void Insert(Table t)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				db.Tables.Add(t);
				db.SaveChanges();
			}
		}

		public void Update(Table t)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{

				db.Tables.Attach(t);
				db.Entry(t).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}

		public List<Table> GetTables()
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				return db.Tables.ToList();
			}
		}
		public Table GetTable(int TableId)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				return db.Tables.Find(TableId);
			}
		}
		public Table GetByTableId(int tableid)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{

				var firsttable = db.Tables.FirstOrDefault(a => a.TableID == tableid && a.Status == true);

				if (firsttable != null)
				{
					return firsttable;
				}
				else
				{
					return null;
				}
			}
		}

	}

}