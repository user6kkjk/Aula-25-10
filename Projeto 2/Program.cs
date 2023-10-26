using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1;
            decimal num2;
            decimal num3;
            decimal num4;

            decimal media;
            decimal numeros = 4;
            decimal som_num;

            Console.WriteLine("informe o primeiro número:");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("informe o primeiro número:");
            num2 = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("informe o primeiro número:");
            num3 = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("informe o primeiro número:");
            num4 = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

            som_num = num1 + num2 + num3 + num4;
            media = som_num / numeros;

            Console.WriteLine("A média dos 4 números é:"+ media);





        }
    }
}
