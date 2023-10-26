using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args, out float result)
        {
            /*
             
             criar um script que solicite 2 numeros ao usuario
             e no final mostre a soma dos valores 
             
             */

            // Variáveis do projeto

            decimal numero_um;
            decimal numero_dois;
            decimal resultado_sm;
            decimal resultado_sb;
            decimal resultado_mt;
            decimal resultado_dv;

            // Configurações

            Console.WriteLine("CALCULADORA CONSOLE");
            
            Console.WriteLine("\nInforme o primeiro numero");
            numero_um = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("\nInforme o segundo numero");
            numero_dois = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

            // SOMA 
            
            if (numero_um > 0 && numero_dois > 0) {

                resultado_sm = numero_um + numero_dois;
                Console.WriteLine("\nA soma dos dois números é: " + resultado_sm);


            }


            else {

                Console.WriteLine("Não foi possível fazer a soma, Porfavor informe um número maior que 0!");
            }

            // SUBTRAÇÃO

            if (numero_um > 0 && numero_dois > 0)
            {

                resultado_sb = numero_um - numero_dois;
                Console.WriteLine("\nA subtração dos dois números é: " + resultado_sb);

            }

            else
            {
                Console.WriteLine("Você subtraiu o primeiro número por ele mesmo!");
            }

            // DIVISÃO

            if (numero_um / numero_dois > 0)
            {

                resultado_dv = numero_um / numero_dois;
                Console.WriteLine("\nA divisão dos dois numeros é: " + resultado_dv);

            }


            else
            {

                Console.WriteLine("Você dividiu o primeiro número por ele mesmo!");

            }

            // MULTIPLICAÇÃO

            if (numero_um > 0 && numero_dois > 0)
            {

                resultado_mt = numero_um * numero_dois;
                Console.WriteLine("\nA multiplicação dos dois números é: " + resultado_mt);

            }

            else
            {

                Console.WriteLine("Não foi possível fazer a multiplicação, Porfavor informe um número maior que 0!");

            }
        }
    }
}
