using System;
using System.Collections.Generic;
using System.Linq;
using Repository;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Locacao
    {
        public int Id { set; get; } // Identificador Único (ID)
        public int ClienteId { set; get; } // Identificador Único do Cliente
        [NotMapped]
        public virtual Cliente Cliente { set; get; } // Cliente
        public DateTime DataLocacao { set; get; }

        public Locacao(){

        }

        public Locacao(
           Cliente Cliente,
           DateTime DataLocacao,
           List<VeiculoLeve> VeiculosLeves,
           List<VeiculoPesado> VeiculosPesados
       )
        {
            Context db= new Context();
            this.Cliente = Cliente;
            this.ClienteId = Cliente.Id;
            this.DataLocacao = DataLocacao;

            foreach (VeiculoLeve veiculo in VeiculosLeves)
            {
                LocacaoVeiculoLeve locacaoVeiculosLeves = new LocacaoVeiculoLeve(this, veiculo);

            }
            foreach (VeiculoPesado veiculo in VeiculosPesados)
            {
                LocacaoVeiculoPesado locacaoVeiculosPesados = new LocacaoVeiculoPesado(this, veiculo);

            }

            db.Locacoes.Add(this);
            db.SaveChanges();
        }

        public double GetValorLocacao()
        {
            double total = 0;

            foreach (LocacaoVeiculoLeve veiculo in LocacaoVeiculoLeve.GetVeiculosLeves(this.Id))
            {
                total += veiculo.VeiculoLeve.Preco;
            }

            total += LocacaoVeiculoPesado.GetTotal(this.Id);

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
            if (LocacaoVeiculoLeve.GetCount(this.Id) > 0)
            {
                foreach (LocacaoVeiculoLeve veiculo in LocacaoVeiculoLeve.GetVeiculosLeves(this.Id))
                {
                    Print += "\n   " + veiculo.VeiculoLeve;
                }
            }
            else
            {
                Print += "\n      Nada Consta";
            }

            Print += "\nVeiculos Pesados Locados: ";
            if (LocacaoVeiculoPesado.GetCount(this.Id) > 0)
            {
                foreach (LocacaoVeiculoPesado veiculo in LocacaoVeiculoPesado.GetVeiculosPesados(this.Id))
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

        public static IEnumerable<Locacao> GetLocacoes()
        {
            Context db = new Context();
            return from Locacao in db.Locacoes select Locacao;
        }

        public static int GetCount(int ClienteId)   
        {
            Context db = new Context();
            return (from Locacao in db.Locacoes where Locacao.ClienteId == ClienteId select Locacao).Count();
        }

        public static Locacao GetLocacao(int Id)
        {

            Context db = new Context();
            IEnumerable<Locacao> query = from locacao in db.Locacoes where locacao.Id == Id select locacao;

            return query.First();

        }

        public static Locacao AtualizarLocacao(
          Locacao locacao,
          string stringValor,
          string stringCampo
      )
        {
            int Campo = Convert.ToInt32(stringCampo);
            switch (Campo)
            {
                case 1:
                   locacao.DataLocacao = Convert.ToDateTime(stringValor);
                break;
        

            }
            Context db = new Context();
            db.Locacoes.Update(locacao);
            db.SaveChanges();
            return locacao;


        }

        //Remoção de clientes no banco de dados


        public static void RemoverLocacao(int Id) {
            Locacao locacao = GetLocacao(Id);
            Context db = new Context();
            db.Locacoes.Remove(locacao);
            db.SaveChanges();
        }
    }

}
