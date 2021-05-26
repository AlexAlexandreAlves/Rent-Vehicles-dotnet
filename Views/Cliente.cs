using System;

namespace Views
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
                Controller.Cliente.CriarCliente(Nome, DtNascimento, Cpf, Convert.ToDecimal(DiasParaRetorno));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Informações digitadas são incorretas: {e.Message}");
            }
        }

        public static void AtualizarClientes()
        {
            Model.Cliente cliente;
            try
            {
                Console.WriteLine("Informe o ID do cliente: ");
                string Id = Console.ReadLine();
                cliente = Controller.Cliente.GetCliente(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception(e.Message);
            }

            Console.WriteLine("Digite o campo que deseja alterar: 1- Nome 2- CPF: ");
            string stringCampo = Console.ReadLine();
            Console.WriteLine("Digite a informação: ");
            string stringValor = Console.ReadLine();

            try
            {
                Controller.Cliente.AtualizarClientes(cliente);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }   

            public static void RemoverClientes(){

                  try
            {
                Console.WriteLine("Informe o ID do cliente: ");
                string Id = Console.ReadLine();
                Controller.Cliente.RemoverClientes(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            }


        public static void ListarClientes()
        {
            foreach (Model.Cliente cliente in Controller.Cliente.ListarClientes())
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine(cliente);
            }
            Console.WriteLine("---------------------------\n");
        }
    }
}
