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
            string StringDataLocacao,
            List<Model.VeiculoLeve> VeiculosLeves,
            List<Model.VeiculoPesado> VeiculosPesados
        )
        {
            Model.Cliente Cliente = Controller.Cliente
                .GetCliente(Convert.ToInt32(ClienteId));

            ///No RentDate estamos trabalhando com a converção da entrada da data de locação para calcular os dias
            ///a partir da data de entrada que for inserida no terminal, utilizando o método DateTime.Now

            DateTime DataLocacao;

            try
            {
                DataLocacao = Convert.ToDateTime(StringDataLocacao);
            }
            catch
            {
                DataLocacao = DateTime.Now;
            }

            if (DataLocacao > DateTime.Now)
            {
                throw new Exception("Data de Locação não pode ser maior que a data atual");
            }

            return new Model.Locacao(Cliente, DataLocacao, VeiculosLeves, VeiculosPesados);
        }
     
       ///Passando a listagem de locações através do List
        public static List<Model.Locacao> GetLocacoes()
        {
            return Model.Locacao.GetLocacoes();
        }
    }
}
