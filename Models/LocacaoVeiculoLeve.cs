using System;
using System.Collections.Generic;
using Repository;
using System.Linq;


namespace Model {
    public class LocacaoVeiculoLeve {
        public string Id { set; get; }
        public int IdLocacao { set; get; }
        public Locacao Locacao { set; get; }
        public int IdVeiculoLeve { set; get; }
        public VeiculoLeve VeiculoLeve { set; get; }

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
