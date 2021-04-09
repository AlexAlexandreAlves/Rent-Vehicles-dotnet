using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{

    public class Menu : Form
    {

        public Menu()
        {

            this.Text = "Menu Principal";
            this.BackColor = Color.LightBlue;
            
            
            
            Button btnCadastrarCliente = new Button();     //Criando botões
            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.Size = new Size(200, 30);
            btnCadastrarCliente.Location = new Point(900, 100);

            this.Size = new Size(900, 450); 


            this.Controls.Add(btnCadastrarCliente);
        }


    }
}
