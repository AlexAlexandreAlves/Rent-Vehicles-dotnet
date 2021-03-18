using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller
{
    public static class Cliente
    {
        public static Model.Cliente CriarCliente(
            string Nome,
            string DtNascimento,
            string Cpf,
            string DiasParaRetorno)
        {


            Regex rgx = new Regex("^\\d{3}\\.\\d{3}\\.\\d{3}-\\d{2}$");
            if (!rgx.IsMatch(Cpf))
            {
                throw new Exception("C.P.F. Inválido");
            }

            DateTime Data;


            try
            {
                Data = Convert.ToDateTime(DtNascimento);
            }
            catch
            {
                throw new Exception("Data de nascimento inválida");
            }

            return new Model.Cliente(
                 Nome,
                 Data,
                 Cpf,
                 Convert.ToInt32(DiasParaRetorno)
             );
        }

        public static List<Model.Cliente> ListarClientes()
        {
            return Model.Cliente.GetClientes();
        }

        public static Model.Cliente GetCliente(int Id)
        {
            int ListLenght = Model.Cliente.GetClientes().Count;

            if (Id < 0 || ListLenght <= Id)
            {
                throw new Exception("Id informado é inválido.");
            }

            return Model.Cliente.GetCliente(Id);
        }


    }
}
