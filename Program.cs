using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSoma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int n2 = int.Parse(Console.ReadLine()); 

            int resultado = n1 + n2;

            Console.WriteLine("O resultado da some é " + resultado);

            Console.ReadKey();
        }
    }
}
