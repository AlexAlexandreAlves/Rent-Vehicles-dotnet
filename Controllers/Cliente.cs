
using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class ClienteController
    {


        public static List<Cliente> GetClientes()
        {
            return Cliente.GetClientes();
        }
    }

}
