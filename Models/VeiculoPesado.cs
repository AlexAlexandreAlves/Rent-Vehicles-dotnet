using System;
using System.Collections.Generic;
using Repository;

namespace Model
{
    public class VeiculoPesado : Veiculo
    {
        public int Id { set; get; }
        public string Restricoes { set; get; }
        public List<LocacaoVeiculoPesado> Locacao { set; get; }

        public static readonly List<VeiculoPesado> VeiculoPesados = new List<VeiculoPesado>();
        public VeiculoPesado(
            string Marca,
            string Modelo,
            int Ano,
            double Preco,
            string Restricoes
        ) : base(Marca, Modelo, Ano, Preco)
        {

            this.Id = Context.veiculosPesados.Count;
            this.Restricoes = Restricoes;
            this.Locacao = new List<LocacaoVeiculoPesado>();

            VeiculoPesados.Add(this);
        }
        public override string ToString()
        {
            return "Id: " + this.Id + " - " + base.ToString() + " - Restrições: " + this.Restricoes;
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
            VeiculoPesado veiculoPesado = (VeiculoPesado)obj;
            return this.GetHashCode() == veiculoPesado.GetHashCode();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id);
        }

        public static List<VeiculoPesado> GetVeiculosPesados()
        {
            return VeiculoPesados;
        }

        public static VeiculoPesado GetVeiculoPesado(int Id)
        {
            return VeiculoPesados[Id];
        }


    }
}
