using BusinessLayer.Repository.Abstract;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository.Concrete
{
	public class AdditionBusiness : IPayment
	{
		public void Delete(Addition t)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public Addition Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<Addition> GetAll()
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				return db.Additions.ToList();
			}
		}

		public void Insert(Addition t)
		{
            using (RestoranDBEntities db = new RestoranDBEntities())
            {
                db.Additions.Add(t);
                db.SaveChanges();
            }
        }

		public void Update(Addition t)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{

				db.Additions.Attach(t);
				db.Entry(t).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}
        public Addition GetByPrice(int price)
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {
                return db.Additions.FirstOrDefault(a => a.TotalPrice == price);
            }
        }
        public Addition GetByTableId(int tableid)
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {

                var firstaddition = db.Additions.FirstOrDefault(a => a.TableID == tableid && a.Status == true);

                if(firstaddition!=null)
                {
                    return firstaddition;
                }
                else
                {
                    return null;
                }
            }
        }
		public Addition GetByTable(int tableid)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{

				var tableId = db.Additions.FirstOrDefault(a => a.TableID == tableid && a.Status == true);

				if (tableId != null)
				{
					return tableId;
				}
				else
				{
					return null;
				}
			}
		}
	}
}
