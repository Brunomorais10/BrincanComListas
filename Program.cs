using System.Globalization;


namespace Exercicios7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantas pessoas voce quer resgistrar: ");
            int pessoas = int.Parse(Console.ReadLine());

            List<Identidades> list = new List<Identidades>();

            for (int i = 1; i <= pessoas; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Empregado #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Identidades(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Digite em qual funcionario quer incrementar o salário: ");
            double procurarId = double.Parse(Console.ReadLine());

            Identidades emp = list.Find(x => x.Id == procurarId);
            if (emp != null)
            {
                Console.Write("Digite a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.incrementar(percentage);
            }
            else
            {
                Console.WriteLine("Esse id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada: ");
            foreach (Identidades obj in list)
            {
                Console.WriteLine(obj);

            }
        }
    }
}
