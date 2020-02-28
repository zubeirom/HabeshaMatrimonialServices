using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabeshaMatrimonialStorage
{
    public interface IGenericRepository<T>
    {
        List<T> GetAll();

        T GetOne(int id);

        void Delete(int id);

        T Update(int id);

    }
}
