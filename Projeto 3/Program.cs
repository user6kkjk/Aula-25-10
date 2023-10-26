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

            Console.WriteLine("Qual seu nome?");
            Console.ReadLine();

            Console.WriteLine("Quantos anos vc tem?");
            idade = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(

                "infome M para o sexo Masxulino e F para o sexo Feminino"

                );
            sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Qual seu peso?");
            peso = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Qual sua altura?");
            altura = Convert.ToDecimal(Console.ReadLine());

            imc = altura * altura / peso;
            Console.WriteLine("Seu IMC é de:" + imc );
        }
    }
}
