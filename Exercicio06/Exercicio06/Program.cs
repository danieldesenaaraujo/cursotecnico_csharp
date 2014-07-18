using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio06
{
    class Program
    {
        static public string RetornaDiaSemanaIf(int dia)
        {
            if (dia == 1)
                return "Domingo";
            else if (dia == 2)
                return "Segunda";
            else if (dia == 3)
                return "Terça";
            else if (dia == 4)
                return "Quarta";
            else if (dia == 5)
                return "Quinta";
            else if (dia == 6)
                return "Sexta";
            else if (dia == 7)
                return "Sábado";
            else
                return "Dia não existe";
        }

        static public string RetornaDiaSemanaSwitch(int dia)
        {
            string diaExtenso = "";
            switch (dia)
            {
                case 1:
                    diaExtenso = "Domingo";
                    break;
                case 2:
                    diaExtenso = "Segunda";
                    break;
                case 3:
                    diaExtenso = "Terça";
                    break;
                case 4:
                    diaExtenso = "Quarta";
                    break;
                case 5:
                    diaExtenso = "Quinta";
                    break;
                case 6:
                    diaExtenso = "Sexta";
                    break;
                case 7:
                    diaExtenso = "Sábado";
                    break;
                default:
                    diaExtenso = "Dia não existe";
                    break;
            }

            return diaExtenso;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Dia: " + RetornaDiaSemanaSwitch(1));
            Console.WriteLine("Dia: " + RetornaDiaSemanaSwitch(3));
        }
    }
}
