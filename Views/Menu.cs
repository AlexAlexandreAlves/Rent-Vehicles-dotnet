using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{

    public class Menu : Form
    {

        private Button btnCadastrarCliente = new Button();

        private Button btnListarCliente = new Button();

        private Button btnAtualizarCliente = new Button();

        private Button btnRemoverCliente = new Button();

        private Button btnCadastroVeicPesado = new Button();


        public Menu()
        {

            this.Text = "Menu Principal";
            this.BackColor = Color.LightYellow;

            //Cliente


            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.Size = new Size(200, 30);
            btnCadastrarCliente.Location = new Point(200, 100);
            btnCadastrarCliente.Click += new EventHandler(this.btnCadastrarClienteClick);



            btnListarCliente.Text = "Listar Clientes";
            btnListarCliente.Size = new Size(200, 30);
            btnListarCliente.Location = new Point(200, 150);



            btnAtualizarCliente.Text = "Atualizar Clientes";
            btnAtualizarCliente.Size = new Size(200, 30);
            btnAtualizarCliente.Location = new Point(200, 200);



            btnRemoverCliente.Text = "Remover Clientes";
            btnRemoverCliente.Size = new Size(200, 30);
            btnRemoverCliente.Location = new Point(200, 250);

            //Veiculo Pesado


            btnCadastroVeicPesado.Text = "Cadastrar Veiculo Pesado";
            btnCadastroVeicPesado.Size = new Size(200, 30);
            btnCadastroVeicPesado.Location = new Point(200, 300);


            this.Size = new Size(600, 450);

            //Buttons Clientes

            this.Controls.Add(btnCadastrarCliente);
            this.Controls.Add(btnListarCliente);
            this.Controls.Add(btnAtualizarCliente);
            this.Controls.Add(btnRemoverCliente);



            //Buttons Veiculos Pesados

            this.Controls.Add(btnCadastroVeicPesado);
        }

        private void btnCadastrarClienteClick(object sender, EventArgs e)
        {
            CadastroClienteVisual cadastroCliente = new CadastroClienteVisual();
            cadastroCliente.Show();
        }

    }
}
