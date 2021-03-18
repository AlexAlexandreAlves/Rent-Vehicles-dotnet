using System.Collections.Generic;
using Model;

namespace Repository
{
    public class Context 
    {
        public static readonly List<Cliente> clientes = new List<Cliente> ();
        public static readonly List<VeiculoPesado> veiculosPesados = new List<VeiculoPesado> ();
        public static readonly List<VeiculoLeve> veiculosLeves = new List<VeiculoLeve> ();
        public static readonly List<Locacao> locacoes = new List<Locacao> ();
        public static readonly List<LocacaoVeiculoPesado> locacaoVeiculoPesados = new List<LocacaoVeiculoPesado> ();
        public static readonly List<LocacaoVeiculoLeve> locacaoVeiculoLeves = new List<LocacaoVeiculoLeve> ();

    }
}