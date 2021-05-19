using System;
using System.Collections.Generic;

namespace Views
{
    public class Locacao
    {
        public static void CriarLocacao()
        {
            int opt;
            int optLeve;
            int optPesado;
            List<Model.VeiculoLeve> VeiculosLeves = new List<Model.VeiculoLeve>();
            List<Model.VeiculoPesado> VeiculosPesados = new List<Model.VeiculoPesado>();
            Console.WriteLine("Informe o Id do Cliente: ");
            string ClienteId = Console.ReadLine();
            Console.WriteLine("Informe a Data da Locação: ");
            DateTime DataLocacao = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Foram locados veículos leves? [1] Sim");
            opt = Convert.ToInt32(Console.ReadLine());
            if (opt == 1)
            {
                do
                {
                    
                    Console.WriteLine("Informe o Id do Veículo Leve: ");
                    try
                    {
                       string VeiculoId = Console.ReadLine();

                        Model.VeiculoLeve veiculo = Controller.VeiculoLeve.GetVeiculosLeves(VeiculoId);
                        VeiculosLeves.Add(veiculo);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }

                    Console.WriteLine("Deseja informar outro veículo? [1] Sim");
                    optLeve = Convert.ToInt32(Console.ReadLine());

                } while (optLeve == 1);
            }
            Console.WriteLine("Foram locados veículos pesados? [1] Sim");
            opt = Convert.ToInt32(Console.ReadLine());
            if (opt == 1)
            {
                do
                {
                    Console.WriteLine("Informe o Id do Veículo Pesado: ");
                    try
                    {
                        string VeiculoId = Console.ReadLine();
                        Model.VeiculoPesado veiculo = Controller.VeiculoPesado.GetVeiculoPesado(VeiculoId);
                        VeiculosPesados.Add(veiculo);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine("Deseja informar outro veículo? [1] Sim");
                    optPesado = Convert.ToInt32(Console.ReadLine());
                } while (optPesado == 1);
            }

            try
            {
                Controller.Locacao.CriarLocacao(ClienteId, DataLocacao, VeiculosLeves, VeiculosPesados);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Informações digitadas são incorretas: {e.Message}");
            }
        }

        public static void ListarLocacao()
        {

            foreach (Model.Locacao locacao in Controller.Locacao.GetLocacoes())
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine(locacao);
            }
            Console.WriteLine("---------------------------\n");
        }

        public static void AtualizarLocacao()
        {
            Model.Locacao locacao;
            try
            {
                Console.WriteLine("Informe o ID da Locação: ");
                string Id = Console.ReadLine();
                locacao = Controller.Locacao.GetLocacao(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception(e.Message);
            }

            Console.WriteLine("Digite 1 para alterar data de locação: ");
            string stringCampo = Console.ReadLine();
            Console.WriteLine("Digite a informação: ");
            string stringValor = Console.ReadLine();

            try
            {
                Controller.Locacao.AtualizarLocacao(locacao, stringCampo, stringValor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }   

            public static void RemoverLocacao(){

                  try
            {
                Console.WriteLine("Informe o ID da locação: ");
                string Id = Console.ReadLine();
                Controller.Locacao.RemoverLocacao(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            }
    }
}
