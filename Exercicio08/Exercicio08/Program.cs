using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Capturando exceções

            /*
            try
            {
                string a = "teste";
                Console.WriteLine(int.Parse(a));
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro! ", e.Message);
            }
            */

            //Múltiplas exceções

            /*
            try
            {
                string b = "true";
                Console.WriteLine(int.Parse(b));
            }
            catch (FormatException f)
            {
                Console.WriteLine("Ocorreu um erro no formato do argumento! ", f.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro! ", e.Message);
            }
            */

            //Instruções verificadas;

            /*
            int c = Int32.MaxValue;

            checked
            {
                c++;
                Console.WriteLine(c);
            }
            */

            //Lançando exceções

            /*
            double nota = 12.0;

            if ((nota <= 0.0) || (nota >= 10.0))
            {
                throw new ArgumentException("Nota inválida");
            }
            */


            //Finally

            SqlConnection conexao = new SqlConnection();

            try
            {
                conexao.Open();
                //Executa comandos
            }
            catch (SqlException e)
            {
                //Trata erro
            }
            finally
            {
                conexao.Close();
            }
            
        }
    }
}
