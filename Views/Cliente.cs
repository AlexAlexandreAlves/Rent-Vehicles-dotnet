using System;
using System.Collections.Generic;

namespace View
{
    /// <summary>
    /// Represents the Customer View
    /// </summary>
    public static class Cliente
    {
        /// <summary>
        /// Generates the Cliente creation
        /// </summary>
        public static void CriarCliente()
        {
            Console.WriteLine("Informe o Nome do Cliente: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Informe a Data de Nascimento do Cliente: ");
            string DtNascimento = Console.ReadLine();
            Console.WriteLine("Informe o CPF do Cliente: ");
            string Cpf = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de dias para a devolução do Cliente: ");
            string DiasParaRetorno = Console.ReadLine();
            try
            {
                Controller.Cliente.CriarCliente(Nome, DtNascimento, Cpf, DiasParaRetorno);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Informações digitadas são incorretas: {e.Message}");
            }
        }
        /// <summary>
        /// Shows the customer's list
        /// </summary>
        public static void ListarClientes()
        {
            List<Model.Cliente> Clientes = Controller.Cliente.ListarClientes();

            foreach (Model.Cliente cliente in Clientes)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine(cliente);
            }
            Console.WriteLine("---------------------------\n");
        }
    }
}