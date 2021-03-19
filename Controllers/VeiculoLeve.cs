using System;
using System.Collections.Generic;

namespace Controller
{
    public class VeiculoLeve
    {

        /// <summary>
        ///Criando Veiculo Leve chamando as informações do Model
        public static Model.VeiculoLeve CriarVeiculoLeve(
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
            /// Aqui o retorno das excessões está trabalhando com as informações de Veiculo Leve no Model
            return new Model.VeiculoLeve(
                Marca,
                Modelo,
                ConverterAno,
                ConverterPreco,
                Restricoes
            );
        }

        /// <summary>
        ///Listando os Veiculos Leves puxando as informações do Model

        public static IEnumerable<Model.VeiculoLeve> GetVeiculosLeves()
        {
            return Model.VeiculoLeve.GetVeiculosLeves();
        }

        /// <summary>
        ///Testando se o Id informado é menor que 0

        public static Model.VeiculoLeve GetVeiculosLeves(int Id)
        {
            int ListLenght = Model.VeiculoLeve.GetCount();

            if (Id < 0 || ListLenght <= Id)
            {
                throw new Exception("Id informado é inválido.");
            }

            return Model.VeiculoLeve.GetVeiculoLeve(Id);
        }
    }
}
