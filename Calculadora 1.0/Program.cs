using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal numero_um;
            decimal numero_dois;

            decimal resultado_sm;
            decimal resultado_sb;
            decimal resultado_mt;
            decimal resultado_dv;

            // 

            Console.WriteLine("CALCULADORA CONSOLE");
            
            Console.Write("\ninforme o primeiro numero: ");
            numero_um = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

            Console.Write("\ninforme o segundo numero: ");
            numero_dois = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

            // 
            
            resultado_sm = numero_um + numero_dois;
            Console.Write("\nA soma dos dois números é: " + resultado_sm);

            //

            resultado_sb = numero_um - numero_dois;
            Console.Write("\nA subtração dos dois números é: " + resultado_sb);

            //

            resultado_dv = numero_um / numero_dois;
            Console.Write("\nA divisão dos dois numeros é: " + resultado_dv);

            //

            resultado_mt = numero_um * numero_dois;
            Console.Write("\nA multiplicação dos dois números é: " + resultado_mt);

            Console.ReadKey(); 
        }
    }
}
