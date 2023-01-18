using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios7
{
    internal class Identidades
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Identidades(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void incrementar (double porcentagem)
        {
            Salary += Salary * porcentagem / 100;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
