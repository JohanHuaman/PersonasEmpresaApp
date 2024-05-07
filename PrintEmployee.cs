using PersonasEmpresaApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasEmpresaApp
{
    internal class PrintEmployee
    {
        public void PrintInfoEmployee(IEmployee employee)
        {
            Console.WriteLine(employee.EmployeeInformation());
        }
    }
}
