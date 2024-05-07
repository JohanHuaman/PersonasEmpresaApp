using PersonasEmpresaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasEmpresaApp.Interfaces
{
    internal interface IEmployee
    {
        string IdEmployee { get; set; }
        string FullNameEmployee { get; set; }
        string Area { get; set; }
        string  OccupationEmployee { get; set; }

        string EmployeeInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id Empleado: {IdEmployee}");
            sb.AppendLine($"Nombre Completo: {FullNameEmployee}");
            sb.AppendLine($"Area de trabajo: {Area}");
            sb.AppendLine($"Ocupación: {OccupationEmployee}");
            return sb.ToString();
        }
    }
}
