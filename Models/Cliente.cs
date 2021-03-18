using System;
using System.Collections.Generic;
using Repository;

namespace Model
{
    public class Cliente
    {
        public int Id { set; get; }
        public string Nome { set; get; }
        public DateTime DtNascimento { set; get; }
        public string Cpf { set; get; }
        public int DiasParaRetorno { set; get; }
        public List<Locacao> Locacoes { set; get; }

        private static readonly List<Cliente> Clientes = new List<Cliente>();

        public Cliente(string Nome, DateTime DtNascimento, string Cpf, int DiasParaRetorno)
        {


            this.Id = Context.clientes.Count;
            this.DtNascimento = DtNascimento;
            this.Cpf = Cpf;
            this.DiasParaRetorno = DiasParaRetorno;
            this.Locacoes = new List<Locacao>();

            Clientes.Add(this);
        }

        public override string ToString()
        {
            return String.Format(
                "Id: {0} - Nome: {1} - Data de Nascimento: {2:d} - Dias p/ Devolução: {3} - Qtd. Locações {4}",
                this.Id,
                this.Nome,
                this.DtNascimento,
                this.DiasParaRetorno,
                this.Locacoes.Count
            );
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
            Cliente cliente = (Cliente)obj;
            return this.GetHashCode() == cliente.GetHashCode();
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = (int)2166136261;
                // Suitable nullity checks etc, of course :)
                hash = (hash * 16777619) ^ this.Id.GetHashCode();
                return hash;
            }
        }

        public static List<Cliente> GetClientes(){
            return Clientes;
        }

        public static void AddCliente (Cliente cliente){
            Cliente.AddCliente(cliente);
        }

        public static Cliente GetCliente(int Id) {
            return Clientes[Id];
        }



















    }
}