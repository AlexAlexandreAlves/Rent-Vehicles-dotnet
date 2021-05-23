using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller
{

    /// <summary>
    ///Na classe Locação chamamos as informações de Model, acrescentando o IdCustomer,
    ///StringRentDate e as listas de Veiculo Leve e Veiculo Pesado
    public class Locacao
    {
        public static Model.Locacao CriarLocacao(
            string ClienteId,
            DateTime DataLocacao,
            List<Model.VeiculoLeve> VeiculosLeves,
            List<Model.VeiculoPesado> VeiculosPesados
        )
        {
            Model.Cliente Cliente = Controller.Cliente
                .GetCliente(ClienteId);

            ///No RentDate estamos trabalhando com a converção da entrada da data de locação para calcular os dias
            ///a partir da data de entrada que for inserida no terminal, utilizando o método DateTime.Now

            if (DataLocacao > DateTime.Now)
            {
                throw new Exception("Data de Locação não pode ser maior que a data atual");
            }

            return new Model.Locacao(Cliente, DataLocacao, VeiculosLeves, VeiculosPesados);
        }

        ///Passando a listagem de locações através do List
        /// 
        /// 
        public static IEnumerable<Model.Locacao> GetLocacoes()
        {
            return Model.Locacao.GetLocacoes();
        }

        public static Model.Locacao AtualizarLocacao(
            Model.Locacao locacao,
            string stringValor,
            string stringCampo
        )
        {
            int Campo = Convert.ToInt32(stringCampo);
           
            switch (Campo)
            {
                case 1: //Data de locação;

                return Model.Locacao.AtualizarLocacao(locacao, stringValor, stringCampo);
                   
                
                default:
                throw new Exception("Operação inválida");
            }
        }

               //Remoção de clientes no banco de dados

        public static void RemoverLocacao(string StringId)
        {
            int Id = Convert.ToInt32(StringId);
            try
            {
                Model.Locacao.RemoverLocacao(Id);
            }
            catch
            {
                throw new Exception("Não foi permitido concluir a exclusão ou ID inválido ");
            }
        }

             public static IEnumerable<Model.Locacao> ListarLocacoes()
        {
            return Model.Locacao.GetLocacoes();
        }


         public static Model.Locacao GetLocacao(string Id)
        {

            return Model.Locacao.GetLocacao(Convert.ToInt32(Id));

        }
    }
}
