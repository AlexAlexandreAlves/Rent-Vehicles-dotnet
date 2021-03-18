using System;
using System.Collections.Generic;

namespace Model {
    public class LocacaoVeiculoLeve {
        public string Id { set; get; }
        public int IdLocacao { set; get; }
        public Locacao Locacao { set; get; }
        public int IdVeiculoLeve { set; get; }
        public VeiculoLeve VeiculoLeve { set; get; }

        public static readonly List<LocacaoVeiculoLeve> bancoDeDados = new List<LocacaoVeiculoLeve> ();

        public LocacaoVeiculoLeve (
            Locacao Locacao,
            VeiculoLeve VeiculoLeve
        ) {
            this.Locacao = Locacao;
            this.IdLocacao = Locacao.Id;
            this.VeiculoLeve = VeiculoLeve;
            this.IdVeiculoLeve = VeiculoLeve.Id;

            VeiculoLeve.Locacao.Add (this);
        }
    }
}
