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
	public class ProductOrderBusiness : IProductOrders
	{
		public void Delete(ProductOrder t)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public ProductOrder Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<ProductOrder> GetAll()
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				return db.ProductOrders.ToList();
			}
		}

		public void Insert(ProductOrder t)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				db.ProductOrders.Add(t);
				db.SaveChanges();
			}
		}

		public void Update(ProductOrder t)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{

				db.ProductOrders.Attach(t);
				db.Entry(t).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}

		public List<ProductOrderViewModel> ProductOrders()
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				var orders = new List<ProductOrderViewModel>();


				var result = from a in db.ProductOrders
							 join tt in db.Products on a.ProductID equals tt.ProductID
							 join at in db.Tables on a.TableID equals at.TableID
							 select new
							 {
								 a.OrderID,
								 a.ProductID,
								 a.TableID,								
								 a.ProductPiece,
								 a.OrderNote,
								 a.OrderStatus,
								 tt.ProductName,
								


							 };
				foreach (var productorders in result)
				{
					orders.Add(new ProductOrderViewModel
					{
						
						
						 OrderID=productorders.OrderID,
						 ProductID=productorders.ProductID,
						 TableID=productorders.TableID,
						 ProductPiece=productorders.ProductPiece,
						 OrderNote=productorders.OrderNote,
						 OrderStatus=productorders.OrderStatus,
						 ProductName=productorders.ProductName,
						 
						//ReservationID = reservation.ReservationID,
						//CustomerID = reservation.CustomerID,
						//TableID = reservation.TableID,
						//ReservationDate = reservation.ReservationDate,
						//ReservationNote = reservation.ReservationNote,
						//PersonCount = reservation.PersonCount,
						//Status = reservation.Status,
						//Customer = reservation.NameSurname,
						//Table = reservation.TableName


					});
				}

				return orders;
			}
		}



	}
}
