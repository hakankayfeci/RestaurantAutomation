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
    public class AccountPaymentBusiness : IAccountPayment
    {
        public void Delete(AccountPayment t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public AccountPayment Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<AccountPayment> GetAll()
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {
                return db.AccountPayments.ToList();
            }
        }

        public void Insert(AccountPayment t)
        {
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				db.AccountPayments.Add(t);
				db.SaveChanges();
			}
		}

        public void Update(AccountPayment t)
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {

                db.AccountPayments.Attach(t);
                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public List<AccountPaymentViewModel> AccountPayments()
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {
                var accountpayments = new List<AccountPaymentViewModel>();


                var result = from a in db.AccountPayments
                             join tt in db.Additions on a.AdditionID equals tt.AdditionID
                             join t in db.Tables on a.TableID equals t.TableID
                             join c in db.Customers on a.CustomerID equals c.CustomerID
                             select new
                             {
                                 a.PaymentID,
                                 a.AdditionID,
                                 a.TableID,
                                 a.CustomerID,
                                 a.PaymentType,
                                 a.PaymentDate,
                                 a.TotalAmount,
                                 a.AccountStatus,
                                 tt.TotalPrice,							 
                                 t.TableName,
                                 c.NameSurname

                             };
                foreach (var hesapodeme in result)
                {
                    accountpayments.Add(new AccountPaymentViewModel
                    {
                        PaymentID = hesapodeme.PaymentID,
                        AdditionID = hesapodeme.AdditionID,
                        TableID = hesapodeme.TableID,
                        CustomerID = hesapodeme.CustomerID,
                        PaymentType = hesapodeme.PaymentType,
                        PaymentDate = hesapodeme.PaymentDate,
                        TotalAmount = hesapodeme.TotalAmount,
                        AccountStatus = hesapodeme.AccountStatus,
                        Addition = hesapodeme.TotalPrice.ToString(),
                        Table = hesapodeme.TableName,
                        Customer = hesapodeme.NameSurname,


                    });
                }

                return accountpayments;
            }
        }
    }
}
