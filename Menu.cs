using System;
using System.Windows.Forms;
using System.Drawing;

namespace Programa
{
    public class Menu : Form
    {
        public static void Main(){
            Application.EnableVisualStyles();
            Application.Run(new View.Menu());
            Application.Run(new CadastroClienteVisual());

        }
        public static void Terminal()
        {
            int opt;
            Console.WriteLine("======= Bem vindo a nossa revenda =======");

            do
            {
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("| Digite a operação de Menu       |");
                Console.WriteLine("| 1 - Cadastrar Cliente           |");
                Console.WriteLine("| 2 - Lista de Clientes           |");
                Console.WriteLine("| 3 - Atualizar Cliente           |");
                Console.WriteLine("| 4 - Remover Clientes            |");
                Console.WriteLine("| 5 - Cadastrar Veículo Pesado    |");
                Console.WriteLine("| 6 - Lista de Veículos Pesados   |");
                Console.WriteLine("| 7 - Atualizar Veículos Pesados  |");
                Console.WriteLine("| 8 - Remover Veículos Pesados    |");
                Console.WriteLine("| 9 - Cadastrar Veículo Leve      |");
                Console.WriteLine("| 10 - Lista de Veículos Leves    |");
                Console.WriteLine("| 11 - Atualizar Veículos Leves   |");
                Console.WriteLine("| 12 - Remover Veículos Leves     |");
                Console.WriteLine("| 13 - Cadastrar Locação          |");
                Console.WriteLine("| 14 - Lista de Locações          |");
                Console.WriteLine("| 15 -  Atualizar Locação         |");
                Console.WriteLine("| 16 - Remover Locações           |");
                Console.WriteLine("|  0 - Sair                       |");
                Console.WriteLine("+---------------------------------+");

                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 0:
                        Console.WriteLine("======= Até a próxima! =======");

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
                        View.VeiculoPesado.AtualizarVeiculoPesado();
                        break;
                    case 8:
                        View.VeiculoPesado.RemoverVeiculosPesados();
                        break;
                    case 9:
                        View.VeiculoLeve.CriarVeiculoLeve();
                        break;
                    case 10:
                        View.VeiculoLeve.ListarVeiculosLeves();
                        break;
                    case 11:
                        View.VeiculoLeve.AtualizarVeiculoLeve();
                        break;
                    case 12:
                       View.VeiculoLeve.RemoverVeiculosLeves();
                       break;
                    case 13:
                        View.Locacao.CriarLocacao();
                        break;
                    case 14:
                        View.Locacao.ListarLocacao();
                        break;
                    case 15:
                        View.Locacao.AtualizarLocacao();
                        break;
                    case 16:
                        View.Locacao.RemoverLocacao();
                        break;
                    default:
                        Console.WriteLine("Operação Inválida.");
                        break;
                }
            } while (opt != 0);
        }

    }
}
