using System;
using System.Globalization;

namespace ExercicioClasse2 {
    internal class Program {
        static void Main (string[] args) {

            Funcionario x, y;

            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (x.salario + y.salario) / 2;
            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
