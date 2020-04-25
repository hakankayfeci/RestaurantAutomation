using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository.Abstract
{
    interface IDatabaseRepository<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        void Delete(int id);
        T Get(int id);
        List<T> GetAll();
    }
}
