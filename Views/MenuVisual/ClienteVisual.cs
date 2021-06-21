using System;
using System.Windows.Forms;
using System.Drawing;

namespace Views
{

    public class ClienteVisual : Form
    {

        private Button btnCadastrarCliente = new Button();

        private Button btnListarCliente = new Button();

        private Button btnAtualizarCliente = new Button();

        private Button btnRemoverCliente = new Button();

        private Button btnEncMenu = new Button();

        private PictureBox pictureBox = new PictureBox();




        public ClienteVisual()
        {

            this.Text = "Menu Cliente";
            this.BackColor = Color.White;

            //Cliente


            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.Size = new Size(200, 30);
            btnCadastrarCliente.Location = new Point(200, 50);
            btnCadastrarCliente.Click += new EventHandler(this.btnCadastrarClienteClick);



            btnListarCliente.Text = "Lista de Clientes Cadastrados";
            btnListarCliente.Size = new Size(200, 30);
            btnListarCliente.Location = new Point(200, 100);
            btnListarCliente.Click += new EventHandler(this.btnListarClienteClick);



            btnAtualizarCliente.Text = "Atualizar Clientes";
            btnAtualizarCliente.Size = new Size(200, 30);
            btnAtualizarCliente.Location = new Point(200, 150);
            btnAtualizarCliente.Click += new EventHandler(this.btnAtualizarClienteClick);


            btnRemoverCliente.Text = "Remover Clientes";
            btnRemoverCliente.Size = new Size(200, 30);
            btnRemoverCliente.Location = new Point(200, 200);
            btnRemoverCliente.Click += new EventHandler(this.btnRemoverClienteClick);


            btnEncMenu.Text = "Voltar Menu Principal";
            btnEncMenu.Size = new Size(200, 30);
            btnEncMenu.Location = new Point(200, 300);
            btnEncMenu.Click += new EventHandler(this.btnEncMenuClick);
            btnEncMenu.BackColor = Color.White;

            pictureBox = new PictureBox();
            pictureBox.Size = new Size(600, 600);
            pictureBox.Location = new Point(0, 0);
            pictureBox.Load("Logo_rent_vehicles.png");
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;



            this.Size = new Size(600, 600);

            //Buttons Clientes

            this.Controls.Add(btnCadastrarCliente);
            this.Controls.Add(btnListarCliente);
            this.Controls.Add(btnAtualizarCliente);
            this.Controls.Add(btnRemoverCliente);
            this.Controls.Add(btnEncMenu);

            this.Controls.Add(pictureBox);


        }


        private void btnCadastrarClienteClick(object sender, EventArgs e)
        {
            CadClienteVisual cadastroCliente = new CadClienteVisual();
            cadastroCliente.Show();
        }

        private void btnListarClienteClick(object sender, EventArgs e)
        {
            ListarClienteVisual listarCliente = new ListarClienteVisual();
            listarCliente.Show();
        }
        private void btnAtualizarClienteClick(object sender, EventArgs e)
        {
            AtlzClienteVisual atualizarCliente = new AtlzClienteVisual();
            atualizarCliente.Show();
        }
        
         private void btnRemoverClienteClick(object sender, EventArgs e)
        {
            DltClienteVisual deletarCliente = new DltClienteVisual();
            deletarCliente.Show();
        }




        private void btnEncMenuClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Deseja Sair do Menu?", "Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Retornando!");
            }
            else
            {
                MessageBox.Show("Opção desconhecida!");
            }
            this.Close();

        }
    }
}

