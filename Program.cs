using System;

namespace Calculadora_Simlpes
{
    class Program
    {
        static void Main(string[] args)
        {
                int ops;
                float resu;
                float num1;
                float num2;
                int calcu;

            calcu = 1;

            while (calcu == 1)
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("-------------------");
                Console.WriteLine("Qual operação você deseja fazer? \n [1] para soma \n [2] para multiplicação \n [3] para subtração \n [4] para divisão");
                ops = int.Parse(Console.ReadLine());
    
                while (ops != 1 && ops!=2 && ops!=3 && ops!=4)
                {
                    Console.WriteLine("Opição inválida. Apenas: \n [1] para soma \n [2] para multiplicação \n [3] para subtração \n [4] para divisão");
                    ops = int.Parse(Console.ReadLine());
                }
    
                Console.Write("Digite o primeiro valor: ");
                num1 = float.Parse(Console.ReadLine());
                Console.Write("Digite o primeiro valor: ");
                num2 = float.Parse(Console.ReadLine());
    
                switch (ops){
                    case 1:
                        resu = num1 + num2;
                        Console.WriteLine($"A soma de {num1} + {num2} é igual a: {resu}");
                        break;
                    case 2:
                        resu = num1 * num2;
                        Console.WriteLine($"A multiplicação de {num1} x {num2} é igual a:   {resu}");
                        break;
                    case 3:
                        resu = num1 - num2;
                        Console.WriteLine($"A subtração de {num1} - {num2} é igual a: {resu}    ");
                        break;
                    case 4:
                        resu = num1 / num2;
                        Console.WriteLine($"A divisão de {num1} / {num2} é igual a: {resu}");
                        break;
                }
                Console.WriteLine("Deseja fazer outra conta? \n [1] Fazer outra conta \n [2] Não fazer outra conta");
                calcu = int.Parse(Console.ReadLine());
            }

            
        }
    }
}
