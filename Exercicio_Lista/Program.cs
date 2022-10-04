using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int num = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();
            

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine("Emplyoee #" + i + ":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));
                Console.WriteLine("");
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int IdPesquisa = int.Parse(Console.ReadLine());


            Employee emp = list.Find(x => x.Id == IdPesquisa);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.SalaryIncrement(percentage);

            }
            else { Console.WriteLine("This id does not exist!"); }


            /*
             *Ordenamento de uma lista de Employe, em ordem crescente.
             */
            Console.WriteLine("");
            list = list.OrderBy(x => x.Id).ToList();


            Console.WriteLine("Updated list of employees: ");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
