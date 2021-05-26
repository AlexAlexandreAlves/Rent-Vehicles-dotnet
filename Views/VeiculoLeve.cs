using System;
using System.Collections.Generic;

namespace Views
{
    public class VeiculoLeve
    {
        public static void CriarVeiculoLeve()
        {
            Console.WriteLine("Informe a Marca do Veículo: ");
            string Marca = Console.ReadLine();
            Console.WriteLine("Informe o Modelo do Veículo: ");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Informe o Ano do Veículo: ");
            string Ano = Console.ReadLine();
            Console.WriteLine("Informe o Preço de Locação do Veículo: ");
            string Preco = Console.ReadLine();
            Console.WriteLine("Informe a Cor do Veículo: ");
            string Cor = Console.ReadLine();

            Controller.VeiculoLeve.CriarVeiculoLeve(Marca, Modelo, Ano, Preco, Cor);
        }

        public static void ListarVeiculosLeves()
        {

            foreach (Model.VeiculoLeve veiculo in Controller.VeiculoLeve.GetVeiculosLeves())
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine(veiculo);
            }
            Console.WriteLine("---------------------------\n");
        }

        public static void AtualizarVeiculoLeve()
        {
            Model.VeiculoLeve veiculoLeve;
            try
            {
                Console.WriteLine("Informe o ID do Veiculo Leve: ");
                string Id = Console.ReadLine();
                veiculoLeve = Controller.VeiculoLeve.GetVeiculosLeves(Id);
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
                Controller.VeiculoLeve.AtualizarVeiculoLeve(veiculoLeve);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }   

            public static void RemoverVeiculosLeves(){

                  try
            {
                Console.WriteLine("Informe o ID do Veiculo Leve: ");
                string Id = Console.ReadLine();
                Controller.VeiculoLeve.RemoverVeiculosLeves(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            }
    }
}
