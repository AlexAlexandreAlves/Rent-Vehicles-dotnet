using System;
using System.Collections.Generic;

namespace Controller
{

    /// <summary>
    /// Criando Veiculo Pesado chamando as informações do Model
    public class VeiculoPesado
    {
        public static Model.VeiculoPesado CriarVeiculoPesado(
            string Marca,
            string Modelo,
            string Ano,
            string Preco,
            string Restricoes
        )
        {

            /// <summary>
            /// Trabalhando com exceções, para preço e ano

            int ConverterAno = Convert.ToInt32(Ano);
            double ConverterPreco = Convert.ToDouble(Preco);

            if (ConverterAno < 1990)
            {
                throw new Exception("Carro muito antigo");
            }

            if (ConverterPreco < 0)
            {
                throw new Exception("Valor não pode ser negativo");
            }

            /// <summary>
            /// Aqui o retorno das excessões está trabalhando com as informações de Veiculo Pesado no Model

            return new Model.VeiculoPesado(
                Marca,
                Modelo,
                ConverterAno,
                ConverterPreco,
                Restricoes
            );
        }

        public static IEnumerable<Model.VeiculoPesado> GetVeiculosPesados()
        {
            {
                return Model.VeiculoPesado.GetVeiculosPesados();
            }
        }

        public static Model.VeiculoPesado GetVeiculoPesado(string StringId)
        {   
            int Id = Convert.ToInt32(StringId);
            int ListLenght = Model.VeiculoPesado.GetCount();

            if (Id < 0 || ListLenght < Id)
            {
                throw new Exception("Id informado é inválido.");
            }

            return Model.VeiculoPesado.GetVeiculoPesado(Id);
        }

         public static Model.VeiculoPesado AtualizarVeiculoPesado(
            Model.VeiculoPesado veiculoPesado
            
        )
        {

                return Model.VeiculoPesado.AtualizarVeiculoPesado(veiculoPesado);
                   
        }

            public static IEnumerable<Model.VeiculoPesado> ListarVeicPesado()
        {
            return Model.VeiculoPesado.GetVeiculosPesados();
        }


               //Remoção de clientes no banco de dados

        public static void RemoverVeiculosPesados(string StringId)
        {
            int Id = Convert.ToInt32(StringId);
            try
            {
                Model.VeiculoPesado.RemoverVeiculosPesados(Id);
            }
            catch
            {
                throw new Exception("Não foi permitido concluir a exclusão ou ID inválido ");
            }
        }
    }
}
