using System;

namespace Programa {
    public class Menu {
       
        public static void Main () {
            int opt;
            Console.WriteLine ("======= Bem vindo a nossa revenda =======");
            // Always repeat until the user leaves
            do {
                Console.WriteLine ("+-------------------------------+");
                Console.WriteLine ("| Digite a operação de Menu     |");
                Console.WriteLine ("| 1 - Cadastrar Cliente         |");
                Console.WriteLine ("| 2 - Lista de Clientes         |");
                Console.WriteLine ("| 3 - Cadastrar Veículo Pesado  |");
                Console.WriteLine ("| 4 - Lista de Veículos Pesados |");
                Console.WriteLine ("| 5 - Cadastrar Veículo Leve    |");
                Console.WriteLine ("| 6 - Lista de Veículos Leves   |");
                Console.WriteLine ("| 7 - Cadastrar Locação         |");
                Console.WriteLine ("| 8 - Lista de Locações         |");
                Console.WriteLine ("| 0 - Sair                      |");
                Console.WriteLine ("+-------------------------------+");
                // Get the user option
                opt = Convert.ToInt32 (Console.ReadLine ());
                switch (opt) {
                    case 0:
                        Console.WriteLine ("======= Até a próxima! =======");
                        // Close system
                        break;
                    case 1:
                        View.Cliente.CriarCliente();
                        break;
                    case 2:
                        View.Cliente.ListarClientes ();
                        break;
                    case 3:
                        View.VeiculoPesado.CriarVeiculoPesado ();
                        break;
                    case 4:
                        View.VeiculoPesado.ListarVeiculosPesados();
                        break;
                    case 5:
                        View.VeiculoLeve.CriarVeiculoLeve ();
                        break;
                    case 6:
                        View.VeiculoLeve.ListarVeiculosLeves ();
                        break;
                    case 7:
                        View.Locacao.CriarLocacao ();
                        break;
                    case 8:
                        View.Locacao.ListarLocacao ();
                        break;
                    default:
                        Console.WriteLine ("Operação Inválida.");
                        break;
                }
            } while (opt != 0);
        }

    }
}
