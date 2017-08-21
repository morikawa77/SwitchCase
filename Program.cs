using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;
            Console.Write("Digite o número do mês de nascimento: ");
            mes = Convert.ToInt32(Console.ReadLine());
            switch(mes)
            {
                case 1:
                    Console.Write("Você nasceu em Janeiro");
                    break;
                case 2:
                    Console.Write("Você nasceu em Fevereiro");
                    break;
                case 3:
                    Console.Write("Você nasceu em Março");
                    break;
                case 4:
                    Console.Write("Você nasceu em Abril");
                    break;
                case 5:
                    Console.Write("Você nasceu em Maio");
                    break;
                case 6:
                    Console.Write("Você nasceu em Junho");
                    break;
                case 7:
                    Console.Write("Você nasceu em Julho");
                    break;
                case 8:
                    Console.Write("Você nasceu em Agosto");
                    break;
                case 9:
                    Console.Write("Você nasceu em Setembro");
                    break;
                case 10:
                    Console.Write("Você nasceu em Outubro");
                    break;
                case 11:
                    Console.Write("Você nasceu em Novembro");
                    break;
                case 12:
                    Console.Write("Você nasceu em Dezembro");
                    break;
                default:
                    Console.Write("Mês inválido");
                    break;
            }
            Console.ReadLine();
        }
    }
}
