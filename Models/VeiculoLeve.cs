using System;
using System.Collections.Generic;
using Repository;


namespace Model
{
    public class VeiculoLeve : Veiculo
    {
        public int Id { set; get; }
        public string Cor { set; get; }
        public List<LocacaoVeiculoLeve> Locacao { set; get; }


        public static readonly List<VeiculoLeve> VeiculosLeves = new List<VeiculoLeve>();
        public VeiculoLeve(
            string Marca,
            string Modelo,
            int Ano,
            double Preco,
            string Cor
        ) : base(Marca, Modelo, Ano, Preco)
        {
            this.Id = Context.veiculosLeves.Count;
            this.Cor = Cor;
            this.Locacao = new List<LocacaoVeiculoLeve>();


            VeiculosLeves.Add(this);
        }


        public override string ToString()
        {
            return "Id: " + this.Id + " - " + base.ToString() + " - Cor: " + this.Cor;
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
            VeiculoLeve veiculoLeve = (VeiculoLeve)obj;
            return this.GetHashCode() == veiculoLeve.GetHashCode();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id);
        }

        public static List<VeiculoLeve> GetVeiculosLeves()
        {
            return VeiculosLeves;
        }

        public static VeiculoLeve GetVeiculoLeve(int Id)
        {
            return VeiculosLeves[Id];
        }
    }
}