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

        public VeiculoLeve() : base()
        {

        }

        public VeiculoLeve(
            string Marca,
            string Modelo,
            int Ano,
            double Preco,
            string Cor
        ) : base(Marca, Modelo, Ano, Preco)
        {
            Context db = new Context();
            this.Cor = Cor;


            db.VeiculosLeves.Add(this);
            db.SaveChanges();
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
            Context db = new Context();
            return from VeiculoLeve in db.VeiculosLeves select VeiculoLeve;
        }

        public static int GetCount()
        {
            return GetVeiculosLeves().Count();
        }
        public static VeiculoLeve GetVeiculoLeve(int Id)
        {
            Context db = new Context();
            return (from VeiculoLeve in db.VeiculosLeves where VeiculoLeve.Id == Id select VeiculoLeve).First();
        }

        public static VeiculoLeve AtualizarVeiculoLeve(
          VeiculoLeve veiculoLeve

      )
        {

            Context db = new Context();
            db.VeiculosLeves.Update(veiculoLeve);
            db.SaveChanges();
            return veiculoLeve;


        }

        //Remoção de clientes no banco de dados


        public static void RemoverVeiculosLeves(int Id)
        {
            VeiculoLeve veiculoLeve = GetVeiculoLeve(Id);
            Context db = new Context();
            db.VeiculosLeves.Remove(veiculoLeve);
            db.SaveChanges();
        }
    }
}