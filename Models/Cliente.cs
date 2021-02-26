using System;
using System.Collections.Generic;


namespace Models
{
    public class Cliente
    {

        private int Id;                   // Identificador Único (ID)
        private string Name;              // Nome
        private string Birth;             // Data de Nascimento
        private string Identification;    // C.P.F.
        private int ReturnDays;           // Dias para Devolução

        private static readonly List<Cliente> clientes = new List<Cliente>();

        public Cliente(int Id, string Name, string Birth, string Identification, int ReturnDays)
        {

            this.Id = clientes.Count;
            this.Name = Name;   
            this.Birth = Birth;
            this.Identification = Identification;
            this.ReturnDays = ReturnDays;

            clientes.AddCliente(this);
    
        }


        public void setId(int Id)
        {
            this.Id = Id;
        }

        public void setName(string Name)
        {
            this.Name = Name;
        }

        public void setBirth(string Birth)
        {
            this.Birth = Birth;
        }
        public void setIdentification(string Identification)
        {
            this.Identification = Identification;
        }
        public void setReturnDays(int ReturnDays)
        {
            this.ReturnDays = ReturnDays;
        }

        public int getId()
        {
            return Id;
        }
        public string getName()
        {
            return Name;
        }
        public string getBirth()
        {
            return Birth;
        }
        public string getIdentification()
        {
            return Identification;
        }
        public int getRetunrDays()
        {
            return ReturnDays;
        }

        public static List<Cliente> GetClientes()
        {
            return clientes;
        }

        public override bool Equals(object Id)
        {
            if (Id == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
        }


        public override string ToString()
        {
            return $"ID:{this.getId()} - \nNome:{this.getName()} - \nAniversário:{this.getBirth()} - \nCpf:{this.getIdentification()} - \nDias para retorno:{this.getRetunrDays()}";
        }

    }
}
