using Model;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<VeiculoPesado> VeiculosPesados  {get; set;}
        public DbSet<VeiculoLeve> VeiculosLeves  {get; set;}
        public DbSet<Locacao> Locacoes {get; set;}
        public DbSet<LocacaoVeiculoPesado> LocacaoVeiculoPesados {get; set;}
        public DbSet<LocacaoVeiculoLeve> LocacaoVeiculoLeves {get; set;}

         protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql("Server=localhost;User Id=root;Database=LocacoesVeiculos");
    }
}
