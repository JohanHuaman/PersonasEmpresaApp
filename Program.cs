
using PersonasEmpresaApp.Models;
using PersonasEmpresaApp.Interfaces;
using PersonasEmpresaApp;

int option;
List<Employee> employees = new List<Employee>();
MenuImpl menu = new MenuImpl();

do
{
    Console.WriteLine("GESTOR DE NOMBRES" +
        "\nIngrese una opción:" +
        "\n1. Agregar Dato" +
        "\n2. Listar Datos" +
        "\n0. Salir");
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            menu.AddEmployee(employees); break;
        case 2:
            menu.List(employees); break;
        case 0:
            Console.WriteLine("GRACIAS!"); break;
        default: 
            Console.WriteLine("Ingrese una opción Correcta"); break;
    }
} while (option != 0);

//foreach (var employee in employees)
//{
//    Console.WriteLine(employee.PersonalInformation());
//    Console.WriteLine("***************************************");
//    var printInfo = new PrintEmployee();
//    printInfo.PrintInfoEmployee(employee);
//    Console.WriteLine(employee.IdCode());
//}

//Employee employee = employees.First();
//string info = employee.PersonalInformation();
//Console.WriteLine(info);
//Console.WriteLine("***************************************");
//var printInfo = new PrintEmployee();
//printInfo.PrintInfoEmployee(employee);

//Console.WriteLine(employee.IdCode());