using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data.Dao.InterfacesDAO
{
    public interface IEmployeeDAO
    {
        void RegisterEmployee(Employee employee);
        List<Employee> ListEmployees();
        void DeleteEmployee(int id);
        void UpdateEmployee(Employee employee);
    }
}
