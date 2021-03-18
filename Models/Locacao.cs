using System;
using System.Collections.Generic;

namespace Model
{
    public class Locacao
    {
        public int Id { set; get; } // Identificador Único (ID)
        public int ClienteId { set; get; } // Identificador Único do Cliente
        public Cliente Cliente { set; get; } // Cliente
        public DateTime DataLocacao { set; get; }

        public List<LocacaoVeiculoLeve> VeiculosLeves { set; get; }
        public List<LocacaoVeiculoPesado> VeiculosPesados { set; get; }


        public static readonly List<Locacao> Locacoes = new List<Locacao>();

        public Locacao(
           Cliente Cliente,
           DateTime DataLocacao,
           List<VeiculoLeve> VeiculosLeves,
           List<VeiculoPesado> VeiculosPesados
       )
        {
            this.Cliente = Cliente;
            this.ClienteId = Cliente.Id;
            this.DataLocacao = DataLocacao;
            this.VeiculosLeves = new List<LocacaoVeiculoLeve>();
            this.VeiculosPesados = new List<LocacaoVeiculoPesado>();

            Cliente.Locacoes.Add(this);

            foreach (VeiculoLeve veiculo in VeiculosLeves)
            {
                LocacaoVeiculoLeve locacaoVeiculosLeves = new LocacaoVeiculoLeve(this, veiculo);
                this.VeiculosLeves.Add(locacaoVeiculosLeves);
            }
            foreach (VeiculoPesado veiculo in VeiculosPesados)
            {
                LocacaoVeiculoPesado locacaoVeiculosPesados = new LocacaoVeiculoPesado(this, veiculo);
                this.VeiculosPesados.Add(locacaoVeiculosPesados);
            }

            Locacoes.Add(this);
        }

        public double GetValorLocacao()
        {
            double total = 0;

            foreach (LocacaoVeiculoLeve veiculo in VeiculosLeves)
            {
                total += veiculo.VeiculoLeve.Preco;
            }

            foreach (LocacaoVeiculoPesado veiculo in VeiculosPesados)
            {
                total += veiculo.VeiculoPesado.Preco;
            }
            return total;
        }

        public DateTime GetDiasParaRetorno()
        {
            int DiasParaRetorno = this.Cliente.DiasParaRetorno;

            return this.DataLocacao.AddDays(DiasParaRetorno);
        }

        public override string ToString()
        {
            string Print = String.Format(
                 "Data da Locação: {0:d} - Data da Devolução: {1:d} - Valor: {2:C}\nCliente: {3}",
                 this.DataLocacao,
                 this.GetDiasParaRetorno(),
                 this.GetValorLocacao(),
                 this.Cliente
            );

            Print += "\nVeiculos Leves Locados: ";
            if (VeiculosLeves.Count > 0)
            {
                foreach (LocacaoVeiculoLeve veiculo in VeiculosLeves)
                {
                    Print += "\n   " + veiculo.VeiculoLeve;
                }
            }
            else
            {
                Print += "\n      Nada Consta";
            }

            Print += "\nVeiculos Pesados Locados: ";
            if (VeiculosPesados.Count > 0)
            {
                foreach (LocacaoVeiculoPesado veiculo in VeiculosPesados)
                {
                    Print += "\n   " + veiculo.VeiculoPesado;
                }
            }
            else
            {
                Print += "\n      Nada Consta";
            }

            return Print;

        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Locacao locacao = (Locacao)obj;
            return this.GetHashCode() == locacao.GetHashCode();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id);
        }

        public static List<Locacao> GetLocacoes()
        {
            return Locacoes;
        }

    }

}
