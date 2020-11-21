using System;

namespace Calculadora___Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir operação 
            //Pedir o 1 número 
            //Pedir o 2 número 
            //Exibir Resultados 

            Console.WriteLine("Digite a operação que deseja fazer /n, Soma, subtração, multiplicação, divisão");
            String operação = Console.ReadLine();

            Console.WriteLine("Digite o 1º número");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;

            //Switch Case

            switch(operação){
                case "soma":
                resultado = num1+num2;
                break;

                case "subtração":
                resultado = num1-num2;
                break;

                case "multiplicação":
                resultado = num1*num2;
                break;

                case "divisão":
                resultado = num1/num2;
                break;

                default:
                Console.WriteLine("Operação inválida");
                break;
            }

            Console.WriteLine($"resultado:{resultado}");
        }
    }
}
