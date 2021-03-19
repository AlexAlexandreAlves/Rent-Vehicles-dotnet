using System;
using System.Collections.Generic;
using Repository;
using System.Linq;


namespace Model
{
    public class VeiculoLeve : Veiculo
    {
        public int Id { set; get; }
        public string Cor { set; get; }

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


            Context.veiculosLeves.Add(this);
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

        public static IEnumerable<VeiculoLeve> GetVeiculosLeves()
        {
            return from VeiculoLeve in Context.veiculosLeves select VeiculoLeve;
        }

        public static int GetCount()
        {
            return GetVeiculosLeves().Count();
        }
        public static VeiculoLeve GetVeiculoLeve(int Id)
        {
            return (from VeiculoLeve in Context.veiculosLeves where VeiculoLeve.Id == Id select VeiculoLeve).First();
        }
    }
}