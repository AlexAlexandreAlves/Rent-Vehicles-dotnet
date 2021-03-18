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
        /// <summary>
        ///Listando os Veiculos Pesados puxando as informações do Model
        public static List<Model.VeiculoPesado> GetVeiculosPesados()
        {
            return Model.VeiculoPesado.GetVeiculosPesados();
        }
        /// <summary>
        ///Testando se o Id informado é menor que 0
        public static Model.VeiculoPesado GetVeiculoPesado(int Id)
        {
            int ListLenght = Model.VeiculoPesado.GetVeiculosPesados().Count;

            if (Id < 0 || ListLenght <= Id)
            {
                throw new Exception("Id informado é inválido.");
            }

            return Model.VeiculoPesado.GetVeiculoPesado(Id);
        }
    }
}
