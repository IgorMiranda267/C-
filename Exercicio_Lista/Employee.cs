using System.Globalization;

namespace Exercicio_Lista
{
    class Employee
    {
        // Atributos Privados.
        public int Id { get; set;}
        public string Name { get; set;}
        public double Salary { get; private set;}

        //Construtores
        public Employee (int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        //Propriedades Autoimplementadas
        public void SalaryIncrement( double percentage)
        {
            Salary += Salary * percentage / 100;
        }

        //Outros Métodos da Classe
        public override string ToString()
        {
            return Id + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InstalledUICulture);
        }

    }
}
