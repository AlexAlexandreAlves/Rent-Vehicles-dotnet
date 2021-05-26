using System;
using System.Collections.Generic;
using Repository;
using System.Linq;

namespace Model
{
    public class VeiculoPesado : Veiculo
    {
        public int Id { set; get; }
        public string Restricoes { set; get; }

        public VeiculoPesado(){

        }

        public VeiculoPesado(
        string Marca,
        string Modelo,
        int Ano,
        double Preco,
        string Restricoes
    ) : base(Marca, Modelo, Ano, Preco)
        {

            Context db = new Context();
            this.Restricoes = Restricoes;

            db.VeiculosPesados.Add(this);
            db.SaveChanges();
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


        public static IEnumerable<VeiculoPesado> GetVeiculosPesados()
        {
            Context db = new Context();
            return from VeiculoPesado in db.VeiculosPesados select VeiculoPesado;
        }

        public static int GetCount()
        {
            return GetVeiculosPesados().Count();
        }
        public static VeiculoPesado GetVeiculoPesado(int Id)
        {
            Context db = new Context();
            return (from VeiculoPesado in db.VeiculosPesados
                    where VeiculoPesado.Id == Id
                    select VeiculoPesado
            ).First();
        }

        
        public static VeiculoPesado AtualizarVeiculoPesado(
          VeiculoPesado veiculoPesado
        
      )
        {
          
            Context db = new Context();
            db.VeiculosPesados.Update(veiculoPesado);
            db.SaveChanges();
            return veiculoPesado;


        }

        //Remoção de clientes no banco de dados


        public static void RemoverVeiculosPesados(int Id) {
            VeiculoPesado veiculoPesado = GetVeiculoPesado(Id);
            Context db = new Context();
            db.VeiculosPesados.Remove(veiculoPesado);
            db.SaveChanges();
        }

    }
}
