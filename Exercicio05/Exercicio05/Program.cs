using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            double diaria = LerDouble("Digite o valor da diária:");
            int numeroDias = LerInt("Digite o número de dias:");
            Escreva(CalcularPagamento(diaria, numeroDias));
        }

        private static void Escreva(double p)
        {
            Console.WriteLine("Valor do pagamento: {0:#,##0.00}", p);
        }

        private static double CalcularPagamento(double diaria, int numeroDias)
        {
            return diaria * numeroDias;
        }

        private static int LerInt(string p)
        {
            Console.WriteLine(p);
            string linha = Console.ReadLine();
            return int.Parse(linha);
        }

        private static double LerDouble(string p)
        {
            Console.WriteLine(p);
            string linha = Console.ReadLine();
            return double.Parse(linha);
        }
    }
}
