using BusinessLayer.Repository.Abstract;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository.Concrete
{
   public class TitleBusiness : ITitle
    {
        public void Delete(Title t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Title Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Title> GetAll()
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {
                return db.Titles.ToList();
                                
            }      
        }

        public void Insert(Title t)
        {
            throw new NotImplementedException();
        }

        public void Update(Title t)
        {
            throw new NotImplementedException();
        }
        public List<string> GetTitle()
        {
            using (RestoranDBEntities db = new RestoranDBEntities())
            {
                var title = db.Titles.Select(p => p.TitleName).ToList();
                title.Insert(0, "Seçiniz...");
                return title;
            }

        }
    }
}
