using System;
using System.Collections.Generic;

namespace Views
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

            foreach (Model.VeiculoPesado veiculo in Controller.VeiculoPesado.GetVeiculosPesados())
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine(veiculo);
            }
            Console.WriteLine("---------------------------\n");
        }

        public static void AtualizarVeiculoPesado()
        {
            Model.VeiculoPesado veiculoPesado;
            try
            {
                Console.WriteLine("Informe o ID do Veiculo Pesado: ");
                string Id = Console.ReadLine();
                veiculoPesado = Controller.VeiculoPesado.GetVeiculoPesado(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception(e.Message);
            }

            Console.WriteLine("Digite o campo que deseja alterar: 1- Marca 2- Modelo: ");
            string stringCampo = Console.ReadLine();
            Console.WriteLine("Digite a informação: ");
            string stringValor = Console.ReadLine();

            try
            {
                Controller.VeiculoPesado.AtualizarVeiculoPesado(veiculoPesado);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }   

            public static void RemoverVeiculosPesados(){

                  try
            {
                Console.WriteLine("Informe o ID do Veiculo Pesado: ");
                string Id = Console.ReadLine();
                Controller.VeiculoPesado.RemoverVeiculosPesados(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            }
    }
}
