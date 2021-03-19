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


        public LocacaoVeiculoLeve (
            Locacao Locacao,
            VeiculoLeve VeiculoLeve
        ) {
            this.Locacao = Locacao;
            this.IdLocacao = Locacao.Id;
            this.VeiculoLeve = VeiculoLeve;
            this.IdVeiculoLeve = VeiculoLeve.Id;

            Context.locacaoVeiculoLeves.Add(this);
        }

            public static IEnumerable<LocacaoVeiculoLeve> GetVeiculosLeves(int IdLocacao){
                return from Veiculo in Context.locacaoVeiculoLeves where Veiculo.IdLocacao == IdLocacao select Veiculo;

            }

            public static int GetCount(int IdLocacao) {
                return GetVeiculosLeves(IdLocacao).Count();
            }




    }
}
