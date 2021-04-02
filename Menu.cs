using System;

namespace Programa {
    public class Menu {
       
        public static void Main () {
            int opt;
            Console.WriteLine ("======= Bem vindo a nossa revenda =======");
           
            do {
                Console.WriteLine ("+-------------------------------+");
                Console.WriteLine ("| Digite a operação de Menu     |");
                Console.WriteLine ("| 1 - Cadastrar Cliente         |");
                Console.WriteLine ("| 2 - Lista de Clientes         |");
                Console.WriteLine ("| 3 - Atualizar Cliente         |");
                Console.WriteLine ("| 4 - Remover Clientes          |");
                Console.WriteLine ("| 5 - Cadastrar Veículo Pesado  |");
                Console.WriteLine ("| 6 - Lista de Veículos Pesados |");
                Console.WriteLine ("| 7 - Cadastrar Veículo Leve    |");
                Console.WriteLine ("| 8 - Lista de Veículos Leves   |");
                Console.WriteLine ("| 9 - Cadastrar Locação         |");
                Console.WriteLine ("| 10 - Lista de Locações        |");
                Console.WriteLine ("| 0 - Sair                      |");
                Console.WriteLine ("+-------------------------------+");
                
                opt = Convert.ToInt32 (Console.ReadLine ());
                switch (opt) {
                    case 0:
                        Console.WriteLine ("======= Até a próxima! =======");
                        
                        break;
                    case 1:
                        View.Cliente.CriarCliente();
                        break;
                    case 2:
                        View.Cliente.ListarClientes();
                        break;
                    case 3:
                        View.Cliente.AtualizarClientes();
                        break;
                    case 4:
                        View.Cliente.RemoverClientes();
                        break;
                    case 5:
                        View.VeiculoPesado.CriarVeiculoPesado();
                        break;
                    case 6:
                        View.VeiculoPesado.ListarVeiculosPesados();
                        break;
                    case 7:
                        View.VeiculoLeve.CriarVeiculoLeve();
                        break;
                    case 8:
                        View.VeiculoLeve.ListarVeiculosLeves();
                        break;
                    case 9:
                        View.Locacao.CriarLocacao();
                        break;
                    case 10:
                        View.Locacao.ListarLocacao();
                        break;
                    default:
                        Console.WriteLine ("Operação Inválida.");
                        break;
                }
            } while (opt != 0);
        }

    }
}
