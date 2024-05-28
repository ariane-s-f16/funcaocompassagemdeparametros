using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcaocompassagemdeparametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação(+,-,*,/)");
            string op = Console.ReadLine();
            Console.WriteLine("Digite o primeiro valor");
            double n1= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            double n2 = double.Parse(Console.ReadLine());


            operacao(op,n1, n2);
            Console.ReadKey();
        }
        static void operacao(string ope,double v11, double v2)
        {
            

            if (ope == "+") 
            {
                double resultado = v11 + v2;
                Console.WriteLine("o valor da soma é: " + resultado);

            }
            else if(ope == "-")
            {
                double resultado = v11 - v2;
                Console.WriteLine("o valor da subtração é: " + resultado);
            }
            else if(ope == "*")
            {
                double resultado = v11 * v2;
                Console.WriteLine("o valor da multiplicação é: " + resultado);

            }
            else if (ope == "/") 
            {
                double resultado = v11 / v2;
                Console.WriteLine("o valor da divisão é: " + resultado);
            }
            else 
            {
                Console.WriteLine("informação errada");
            }
           
        }
    }
}
