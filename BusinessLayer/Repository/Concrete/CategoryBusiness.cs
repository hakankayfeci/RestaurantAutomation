using BusinessLayer.Repository.Abstract;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository.Concrete
{
	public class CategoryBusiness : ICategory
	{
		public void Delete(Category t)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public Category Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<Category> GetAll()
		{

			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				return db.Categories.ToList();
			}
		}

		public void Insert(Category t)
		{
			throw new NotImplementedException();
		}

		public void Update(Category t)
		{
			throw new NotImplementedException();
		}
		public List<string> GetCategory()
		{
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				var categories = db.Categories.Select(p => p.CategoryName).ToList();
				categories.Insert(0, "Seçiniz...");
				return categories;
			}

		}
	}
}
