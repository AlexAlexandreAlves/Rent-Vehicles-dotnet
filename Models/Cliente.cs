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

        public Cliente()
        {

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
            unchecked
            {
                int hash = (int)2166136261;

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

            Context db = new Context();
            IEnumerable<Cliente> query = from cliente in db.Clientes where cliente.Id == Id select cliente;

            return query.First();

        }


        //Atualização de clientes no banco de dados
            
        public static Cliente AtualizarClientes(
          Cliente cliente,
          string stringValor,
          string stringCampo
      )
        {
            int Campo = Convert.ToInt32(stringCampo);
            switch (Campo)
            {
                case 1:
                   cliente.Nome = stringValor;
                    break;
                case 2:
                   cliente.Cpf = stringValor;
                    break;


            }
            Context db = new Context();
            db.Clientes.Update(cliente);
            db.SaveChanges();
            return cliente;


        }

        //Remoção de clientes no banco de dados


        public static void RemoverClientes(int Id) {
            Cliente cliente = GetCliente(Id);
            Context db = new Context();
            db.Clientes.Remove(cliente);
            db.SaveChanges();
        }
    }
}
