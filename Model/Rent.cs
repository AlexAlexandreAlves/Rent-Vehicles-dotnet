using System.Collections.Generic;
using System;

namespace Model{

    public class Rent{

        
        public int Id { set; get; }

        public Costumer Costumer { set; get; }
        public DateTime RentDate { set; get; }


        public static readonly  List <Rent> Rents = new();
        

        public Rent( Costumer Costumer,DateTime RentDate){
        this.Costumer = Costumer;
        this.RentDate = RentDate;

        Rents.Add(this); 

    }

     public override ToString(){

         //Formata a string diretamente com o {} por ordem, 0,1...
         
         retunr String.Format("Data da locação{0} . Cliente {1}", this.RentDate, this.Costumer);
     }

         //Valida as informações da locação (Rent)

       public override bool Equals (object obj) {
            if (obj == null) {
                return false;
            }
            if (obj.GetType () != this.GetType ()) {
                return false;
            }
            Rent rent = (Rent) obj;
            return this.GetHashCode () == rent.GetHashCode ();
        }

        public override int GetHashCode() {
            return HashCode.Combine(this.Id);
        }

    }


    }

