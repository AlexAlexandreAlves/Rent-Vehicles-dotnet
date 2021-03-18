using System;
using System.Collections.Generic;

namespace View
{
    public class VeiculoPesado
    {
        public static void CriarVeiculoPesado()
        {
            Console.WriteLine("Informe a Marca do Veículo: ");
            string Marca = Console.ReadLine();
            Console.WriteLine("Informe o Modelo do Veículo: ");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Informe o Ano do Veículo: ");
            string Ano = Console.ReadLine();
            Console.WriteLine("Informe o Preço de Locação do Veículo: ");
            string Preco = Console.ReadLine();
            Console.WriteLine("Informe o Restrições do Veículo: ");
            string Restricoes = Console.ReadLine();

            Controller.VeiculoPesado.CriarVeiculoPesado(Marca, Modelo, Ano, Preco, Restricoes);
        }

        public static void ListarVeiculosPesados()
        {
            List<Model.VeiculoPesado> VeiculosPesados = Controller.VeiculoPesado.GetVeiculosPesados();

            foreach (Model.VeiculoPesado veiculo in VeiculosPesados)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine(veiculo);
            }
            Console.WriteLine("---------------------------\n");
        }
    }
}
