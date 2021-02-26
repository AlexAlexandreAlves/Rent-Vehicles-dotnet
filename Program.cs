using System;
using View;
using Models;
using Controllers;

namespace MvcExample
{
    public class Program
    {
        public static void Main()
        {
            int menu = 0;
            do
            {
                Console.WriteLine("Digite a opção do programa:");
                Console.WriteLine("1 - Inserir Cliente:");
                Console.WriteLine("2 - Listar Cliente:");

                Console.WriteLine("0 - Sair");

                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 0:
                        break;
                    case 1:
                        InserirCliente();
                        break;
                    case 2:
                        ListarClientes();
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (menu != 0);
     
     
     
        }
    }
}
