using PersonasEmpresaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasEmpresaApp.Interfaces
{
    internal interface IMenu
    {
        void AddEmployee(List<Employee> list);
        void List(List<Employee> List);
        void List2();
        void DeleteEmployee();
        void UpdateEmployee();
        void DeleteAll();
    }
}
