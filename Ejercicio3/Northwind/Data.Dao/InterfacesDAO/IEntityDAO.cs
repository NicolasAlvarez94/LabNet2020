using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dao.InterfacesDAO
{
    public interface IEntityDAO<T>
    {
        void RegisterEntity(T entity);
        List<T> GetListEntities();
        void DeleteEntity(int id);
        void UpdateEntity(T entity);
        T GetEntityByID(int id);
    }
}
