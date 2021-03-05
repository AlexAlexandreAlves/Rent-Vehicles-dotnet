using System;
using System.Collections.Generic;


namespace Controller
{

    public class Rent
    {

        public static Model.Rent CreateRent(string Costumer, string RentDate)
        {
            Model.Customer Customer = Controller.Customer.GetCustomers(Convert.ToInt32(IdCustomer));
            DateTime RentDate = new DateTime();

            return new Model.Rent(Customer, RentDate

        }
        public static List<Model.Rent> GetRents()
        {
            return Model.Rent.GetRents();
        }


    }

}
