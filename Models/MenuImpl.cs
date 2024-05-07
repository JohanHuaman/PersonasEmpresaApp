using PersonasEmpresaApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasEmpresaApp.Models
{
    internal class MenuImpl : IMenu
    {
        public void AddEmployee(List<Employee> employees)
        {
            Console.WriteLine("Ingrese Los siguientes datos: ");
            Console.WriteLine("Ingrese su ID de 4 dígitos");
            var Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su nombre");
            string Name = Console.ReadLine();

            Console.WriteLine("Igrese un Apellido");
            string LastName = Console.ReadLine();

            Console.WriteLine("Genero?:" +
                "\n M, F u Otro?");
            string Gender = Console.ReadLine();

            Console.WriteLine("Que ocupación tiene? Escoga una opción:" +
                "\n1.Engineer" +
                "\n2.Lawyer" +
                "\n3.Accountant" +
                "\n4.Archichet" +
                "\n5.Doctor" +
                "\n6.Other");
            int optionOccupation = int.Parse(Console.ReadLine());
            string OccupationStr = OccupationOption(optionOccupation);

            Console.WriteLine("En que Area se encuenta? Escoga una opción:" +
                "\n1.Software" +
                "\n2.Medicime" +
                "\n3.Admistration" +
                "\n4.Other");
            int optionArea = int.Parse(Console.ReadLine());
            string AreaStr = AreaOption(optionArea);

            Employee employee = new Employee(Id, Name, LastName, Gender, OccupationStr, AreaStr);
            employees.Add(employee);
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee()
        {
            throw new NotImplementedException();
        }

        public void List(List<Employee> List)
        {
            foreach (var employee in List)
            {
                Console.WriteLine("***************************************");
                Console.WriteLine(employee.PersonalInformation());
                var printInfo = new PrintEmployee();
                printInfo.PrintInfoEmployee(employee);
                Console.WriteLine(employee.IdCode());
                Console.WriteLine("***************************************");
            }
        }

        public void List2()
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee()
        {
            throw new NotImplementedException();
        }

        private string OccupationOption(int option)
        {
            string result;
            if (option == 1)
            {
                result = Occupation.Engineer.ToString();
            } 
            else if (option == 2)
            {
                result = Occupation.Lawyer.ToString();
            }
            else if (option == 3)
            {
                result = Occupation.Accountant.ToString();
            }
            else if (option == 4)
            {
                result = Occupation.Architect.ToString();
            }
            else if (option == 5)
            {
                result = Occupation.Doctor.ToString();
            }
            else
            {
                result = Occupation.Other.ToString();
            }
            return result;
        }

        private string AreaOption(int option)
        {
            string result;
            switch (option)
            {
                case 1:
                    result = Area.Software.ToString();
                    break;
                case 2:
                    result = Area.Medicine.ToString();
                    break;
                case 3:
                    result = Area.Administration.ToString();
                    break;
                default:
                    result = Area.Other.ToString(); 
                    break;
            }
            return result;
        }
    }
}
