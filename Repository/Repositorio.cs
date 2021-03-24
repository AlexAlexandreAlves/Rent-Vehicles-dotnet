using Model;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class Context : DbContext
    {
        public Dbset<Cliente> Clientes {get; set;}
        public Dbset<VeiculoPesado> VeiculosPesados  {get; set;}
        public Dbset<VeiculoLeve> VeiculosLeves  {get; set;}
        public Dbset<Locacao> Locacoes {get; set;}
        public Dbset<LocacaoVeiculoPesado> LocacaoVeiculoPesados {get; set;}
        public Dbset<LocacaoVeiculoLeve> LocacaoVeiculoLeves {get; set;}

         protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql("Server=localhost;User Id=root;Database=LocacoesVeiculos");
    }
}