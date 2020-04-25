using BusinessLayer.Repository.Abstract;
using DataLayer;
using DataLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository.Concrete
{
	public class ProductOrderBusiness
	{

		private IRepository<ProductOrder> _ProductOrderRepository;
		private IUnitOfWork _ProductOrderUnitofwork;
		private DbContext _dbContext;
		public ProductOrderBusiness()
		{
			_dbContext = new RestoranDBEntities();
			_ProductOrderUnitofwork = new EFUnitOfWork(_dbContext);
			_ProductOrderRepository = _ProductOrderUnitofwork.GetRepository<ProductOrder>();
		}

		public List<ProductOrder> GetProductOrder()
		{
			return _ProductOrderRepository.GetAll().ToList();
		}

		public void Add(ProductOrder t)
		{
			_ProductOrderRepository.Insert(t);
			_ProductOrderUnitofwork.SaveChanges();
		}

		public void Delete(int id)
		{
			_ProductOrderRepository.Delete(id);
			_ProductOrderUnitofwork.SaveChanges();
		}

		public void Edit(ProductOrder t)
		{
			_ProductOrderRepository.Update(t);
			_ProductOrderUnitofwork.SaveChanges();
		}

		public void Delete(ProductOrder t)
		{
			_ProductOrderRepository.Delete(t);
			_ProductOrderUnitofwork.SaveChanges();
		}

		public ProductOrder Get(int id)
		{
			return _ProductOrderRepository.Get(x => x.OrderID == id);
		}
		public List<ProductOrderViewModel> ProductOrders()
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				var orders = new List<ProductOrderViewModel>();
				var result = from a in db.ProductOrders
							 join tt in db.Products on a.ProductID equals tt.ProductID
							 select new
							 {
								 a.OrderID,
								 a.ProductID,
								 a.TableID,
								 a.ProductPiece,
								 a.OrderNote,
								 a.OrderStatus,
								 tt.ProductName
							 };

				foreach (var productorder in result)
				{
					orders.Add(new ProductOrderViewModel
					{
						OrderID = productorder.OrderID,
						ProductID = productorder.ProductID,
						ProductPiece = productorder.ProductPiece,
						OrderStatus = productorder.OrderStatus,
						ProductName=productorder.ProductName,
						TableID=productorder.TableID

					});
				}
				return orders;
			}
		}

	}
}
