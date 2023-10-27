using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            decimal idade;
            char sexo;
            decimal peso;
            decimal altura;
            decimal imc;

            //

            Console.Write("Qual seu nome? ");
            nome = Console.ReadLine();

            Console.Write("Quantos anos vc tem? ");
            idade = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite M para Masculino e F para Feminino: ");
            sexo = Convert.ToChar(Console.ReadLine());

            Console.Write("Qual seu peso? ");
            peso = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Qual sua altura? ");
            altura = Convert.ToDecimal(Console.ReadLine());

            imc = peso / altura * altura;
            Console.Write("\nO valor do seu imc é de: " + imc.ToString("N2"));

            //

            if (imc < 18.5m)
            {
                Console.Write("Seu imc esta abaixo do nivel recomendado !");
            }
            else if (imc >= 25.00m && imc < 29.9m)
            {
                Console.Write("Seu imc esta no nivel de Excesso de Peso !");
            }
            else if (imc >= 30.00m && imc < 34.9m)
            {
                Console.Write("Seu imc esta no nivel de Obesidade 1 !");
            }
            else if (imc >= 35.00m && imc < 39.9m)
            {
                Console.Write("Seu imc esta no nivel de Obesidade 2 !");
            }
            else if (imc >= 40.00m)
            {
                Console.Write("Seu imc esta no nivel de Obesidade 3 !");
            }
            else
            {
                Console.WriteLine("Seu imc esta no nivel recomendado !");
            }

            //

            Console.ReadKey();
        }
    }
}
