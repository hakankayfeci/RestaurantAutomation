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
	public class ProductBusiness : IProducts
	{
		public void Delete(Product t)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{

				db.Products.Attach(t);
				db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();

			}
		}

		public void Delete(int id)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				Product a = Get(id);
				db.Products.Attach(a);
				db.Entry(a).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}

		public Product Get(int id)
		{

			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				return db.Products.Find(id);

			}
		}

		public List<Product> GetAll()
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				return db.Products.ToList();
			}
		}

		public void Insert(Product t)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				db.Products.Add(t);
				db.SaveChanges();
			}
		}

		public void Update(Product t)
		{

			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				db.Products.Attach(t);
				db.Entry(t).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}
		public List<Product> GetCategoryProducts(int categoryid)
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				return db.Products.Where(x => x.CategoryID == categoryid).ToList();
			}
		}
		public List<ProductViewModel> Products()
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				var products = new List<ProductViewModel>();
				var result = from a in db.Products
							 join tt in db.Categories on a.CategoryID equals tt.CategoryID
							 select new
							 {
								 a.ProductID,
								 a.CategoryID,
								 a.ProductName,
								 a.Price,
								 a.Status,
								 a.ProductImage,
								 tt.CategoryName
							 };

				foreach (var urun in result)
				{
					products.Add(new ProductViewModel
					{
						ProductID = urun.ProductID,
						CategoryID = urun.CategoryID,
						ProductName = urun.ProductName,
						Price = urun.Price,
						Status = urun.Status,
						CategoryName = urun.CategoryName,
						ProductImage = urun.ProductImage
					});
				}
				return products;
			}
		}
	}
}