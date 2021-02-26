using System;
using Models;
using Controllers;

namespace View
{
    public class ClienteView
    {
        public static void InserirCliente()
        {
            Console.WriteLine("Informações sobre o cliente: ");
            Console.WriteLine("Informe o nome: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Informe a data de nascimento (dd/mm/yyyy): ");
            string Birth = Console.ReadLine();
            Console.WriteLine("Informe o C.P.F.: ");
            string Identification = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de dias para devolução: ");
            int ReturnDays = Convert.ToInt32(Console.ReadLine());

            ClienteController.InserirCliente(Name, Birth, Identification, ReturnDays);
        }

        public static void ListarClientes()
        {
            Console.WriteLine("Lista de Clientes: ");
            ClienteController.GetClientes().ForEach(
            cliente => Console.WriteLine(cliente.ToString(true)));
        }

    }
}
