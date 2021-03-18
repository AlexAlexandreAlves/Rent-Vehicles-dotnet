using System;
using System.Collections.Generic;

namespace View {
    public class VeiculoLeve {
        public static void CriarVeiculoLeve () {
            Console.WriteLine ("Informe a Marca do Veículo: ");
            string Marca = Console.ReadLine ();
            Console.WriteLine ("Informe o Modelo do Veículo: ");
            string Modelo = Console.ReadLine ();
            Console.WriteLine ("Informe o Ano do Veículo: ");
            string Ano = Console.ReadLine ();
            Console.WriteLine ("Informe o Preço de Locação do Veículo: ");
            string Preco = Console.ReadLine ();
            Console.WriteLine ("Informe a Cor do Veículo: ");
            string Cor = Console.ReadLine ();

            Controller.VeiculoLeve.CriarVeiculoLeve (Marca, Modelo, Ano, Preco, Cor);
        }

        public static void ListarVeiculosLeves () {
            List<Model.VeiculoLeve> veiculoLeve = Controller.VeiculoLeve.GetVeiculosLeves();

            foreach (Model.VeiculoLeve veiculo in veiculoLeve) {
                Console.WriteLine ("---------------------------");
                Console.WriteLine (veiculo);
            }
            Console.WriteLine ("---------------------------\n");
        }
    }
}
