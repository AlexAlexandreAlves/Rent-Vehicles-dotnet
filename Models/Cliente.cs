using System;
using System.Collections.Generic;
using Repository;
using System.Linq;

namespace Model
{
    public class Cliente
    {
        public int Id { set; get; }
        public string Nome { set; get; }
        public DateTime DtNascimento { set; get; }
        public string Cpf { set; get; }
        public int DiasParaRetorno { set; get; }

        public Cliente(){

        }

        public Cliente(string Nome, DateTime DtNascimento, string Cpf, int DiasParaRetorno)
        {


            Context db = new Context();
            this.Nome = Nome;
            this.DtNascimento = DtNascimento;
            this.Cpf = Cpf;
            this.DiasParaRetorno = DiasParaRetorno;


            db.Clientes.Add(this);
            db.SaveChanges();
        }

        public override string ToString()
        {
            return String.Format(
                "Id: {0} - Nome do Cliente: {1} - Data de Nascimento: {2:d} - Dias p/ Devolução: {3} - Qtd. Locações {4}",
                
                this.Id,
                this.Nome,
                this.DtNascimento,
                this.DiasParaRetorno,
                Locacao.GetCount(this.Id)
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

        public static IEnumerable<Cliente> GetClientes()
        {
            Context db = new Context();
            return from Cliente in db.Clientes select Cliente;
        }

        public static int GetCount()
        {
            return GetClientes().Count();
        }

        public static void AddCliente(Cliente cliente)
        {
            Context db = new Context();
            db.Clientes.Add(cliente);
        }

        public static Cliente GetCliente(int Id)
        {

            // Context db = new Context();

            // SELECT * FROM clientes;
            // from cliente in Context.clientes select cliente;

            // "SELECT * FROM cliente WHERE id = '" + Id + "'";
            Context db = new Context();
            IEnumerable<Cliente> query = from cliente in db.Clientes where cliente.Id == Id select cliente;

            return query.First();

        }
    }
}