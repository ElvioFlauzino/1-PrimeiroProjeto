using System;

namespace P10_CalculaPouponca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Executando Projeto 10 - Calcula Poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12) 
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " +contadorMes+" meses, voce terá R$ " + valorInvestido);
                //contadorMes =  contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;
            }
                        
            Console.ReadLine();
        }
    }
}
