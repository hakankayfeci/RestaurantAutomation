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
    public class ProductTableBusiness
    {
        private IRepository<Addition> _AdditionRepository;
        private IUnitOfWork _AdditionUnitOfWork;
        private DbContext _dbContext;
        public ProductTableBusiness()
        {
            _dbContext = new RestoranDBEntities();
            _AdditionUnitOfWork = new EFUnitOfWork(_dbContext);
            _AdditionRepository = _AdditionUnitOfWork.GetRepository<Addition>();
        }

        public List<Addition> GetAdditions()
        {
            return _AdditionRepository.GetAll().ToList();
        }

        public void Add(Addition Addition)
        {
            _AdditionRepository.Insert(Addition);
            _AdditionUnitOfWork.SaveChanges();
        }

        public void Delete(int id)
        {
            _AdditionRepository.Delete(id);
            _AdditionUnitOfWork.SaveChanges();
        }

        public Addition GetByTableId(int? tableid)
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {

                var firstaddition = db.Additions.FirstOrDefault(a => a.TableID == tableid && a.Status == true);

                if (firstaddition != null)
                {
                    return firstaddition;
                }
                else
                {
                    return null;
                }
            }
        }
        public void Edit(Addition Addition)
        {
            var s = GetByTableId(Addition.TableID);
            s.TotalPrice = Addition.TotalPrice;
            s.PaymentCode = Addition.PaymentCode;
            s.ServiceType = Addition.ServiceType;
            s.Status = Addition.Status;
            
            _AdditionRepository.Update(s);
            _AdditionUnitOfWork.SaveChanges();
        }
    }
}
