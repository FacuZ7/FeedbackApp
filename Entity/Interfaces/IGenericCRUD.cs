using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Interfaces
{
    public interface IGenericCRUD<T>
    {
        T GetById();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
