using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de while

            int contador = 1;

            while (contador < 10)
            {
                Console.WriteLine("5 x {0} = {1}", contador, contador * 5);
                contador++;
            }

            //Exemplo de for

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("5 x {0} = {1}", i, i * 5);
            }

            //Exemplo de do while
            
            contador = 1;

            do
            {
                Console.WriteLine("5 x {0} = {1}", contador, contador * 5);
                contador++;
            }
            while (contador < 10);
        }
    }
}
