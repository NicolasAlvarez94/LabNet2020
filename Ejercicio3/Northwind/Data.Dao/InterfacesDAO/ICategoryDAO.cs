using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace Data.Dao.InterfacesDAO
{
    public interface ICategoryDAO
    {
        void RegisterCategory(Category category);
        List<Category> ListCategories();
        void DeleteCategory(int id);
        void UpdateCategory(Category category);

    }
}
