using BusinessLayer.Repository.Abstract;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository.Concrete
{
	
	public class ExpenseBusiness
	{

		private IRepository<Expense> _Expenserepository;
		private IUnitOfWork _ExpenseUnitofwork;
		private DbContext _dbContext;
		public ExpenseBusiness()
		{
			_dbContext = new RestoranDBEntities();
			_ExpenseUnitofwork = new EFUnitOfWork(_dbContext);
			_Expenserepository = _ExpenseUnitofwork.GetRepository<Expense>();
		}

		public List<Expense> GetExpenses()
		{
			return _Expenserepository.GetAll().ToList();
		}

		public void Add(Expense t)
		{
			_Expenserepository.Insert(t);
			_ExpenseUnitofwork.SaveChanges();
		}

		public void Delete(int id)
		{
			_Expenserepository.Delete(id);
			_ExpenseUnitofwork.SaveChanges();
		}

		public void Edit(Expense t)
		{
			_Expenserepository.Update(t);
			_ExpenseUnitofwork.SaveChanges();
		}

		public void Delete(Expense t)
		{
			_Expenserepository.Delete(t);
			_ExpenseUnitofwork.SaveChanges();
		}

		public Expense Get(int id)
		{
			return _Expenserepository.Get(x => x.ExpenseID == id);
		}
		
	}

}
