using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasEmpresaApp.Models
{
    internal abstract class Person
    {
        public abstract int IdNumber { get; set; }
        public abstract string Name { get; set; }
        public abstract string LastName { get; set; }
        public abstract string Gender { get; set; }

        public virtual string FullName()
        {
            return $"{Name} {LastName}";
        }

        public abstract string IdCode();

        public virtual string PersonalInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id: {IdNumber}");
            sb.AppendLine($"Nombre: {Name}");
            sb.AppendLine($"Apellido: {LastName}");
            sb.AppendLine($"Genero: {Gender}");
            return sb.ToString();
        }
    }
}
