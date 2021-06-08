using System;
using System.Collections.Generic;
using Repository;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model {
    public class LocacaoVeiculoLeve {
        public int Id { set; get; }
        public int IdLocacao { set; get; }
        [NotMapped]
        public virtual Locacao Locacao { set; get; }
        public int IdVeiculoLeve { set; get; }
        [NotMapped]
        public virtual VeiculoLeve VeiculoLeve { set; get; }

        public LocacaoVeiculoLeve(){

        }


        public LocacaoVeiculoLeve (
            Locacao Locacao,
            VeiculoLeve VeiculoLeve
        ) {
            Context db = new Context();
            this.Locacao = Locacao;
            this.IdLocacao = Locacao.Id;
            this.VeiculoLeve = VeiculoLeve;
            this.IdVeiculoLeve = VeiculoLeve.Id;

            db.LocacaoVeiculoLeves.Add(this);
            db.SaveChanges();

        }

            public static IEnumerable<LocacaoVeiculoLeve> GetVeiculosLeves(int IdLocacao){
                Context db = new Context();
                return from Veiculo in db.LocacaoVeiculoLeves where Veiculo.IdLocacao == IdLocacao select Veiculo;

            }

            public static int GetCount(int IdLocacao) {
                return GetVeiculosLeves(IdLocacao).Count();
            }




    }
}
