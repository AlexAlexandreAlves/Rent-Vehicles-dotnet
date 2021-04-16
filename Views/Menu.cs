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

        private Button btnListarVeicPesado = new Button();

        private Button btnAtlzVeicPesado = new Button();

        private Button btnRmvVeicPesado = new Button();

        private Button btnCadastrarVeicLeve = new Button();

        private Button btnListarVeicLeve = new Button();

        private Button btnAtlzVeicLeve = new Button();

        private Button btnRmvVeicLeve = new Button();

        private Button btnCadastrarLoc = new Button();

        private Button btnListarLoc = new Button();

        private Button btnAtlzLoc = new Button();

        private Button btnRmvLoc = new Button();

        private Button  btnEncMenu = new Button();


        public Menu()
        {

            this.Text = "Menu Principal";
            this.BackColor = Color.LightYellow;

            //Cliente


            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.Size = new Size(200, 30);
            btnCadastrarCliente.Location = new Point(200, 50);
            btnCadastrarCliente.Click += new EventHandler(this.btnCadastrarClienteClick);



            btnListarCliente.Text = "Lista de Clientes Cadastrados";
            btnListarCliente.Size = new Size(200, 30);
            btnListarCliente.Location = new Point(200, 100);



            btnAtualizarCliente.Text = "Atualizar Clientes";
            btnAtualizarCliente.Size = new Size(200, 30);
            btnAtualizarCliente.Location = new Point(200, 150);



            btnRemoverCliente.Text = "Remover Clientes";
            btnRemoverCliente.Size = new Size(200, 30);
            btnRemoverCliente.Location = new Point(200, 200);

            //Veiculo Pesado


            btnCadastroVeicPesado.Text = "Cadastrar Veiculo Pesado";
            btnCadastroVeicPesado.Size = new Size(200, 30);
            btnCadastroVeicPesado.Location = new Point(200, 250);
            btnCadastroVeicPesado.Click += new EventHandler(this.btnCadastroVeicPesadoClick);

            btnListarVeicPesado.Text = "Lista De Veiculos Pesados Cadastrados";
            btnListarVeicPesado.Size = new Size(200, 40);
            btnListarVeicPesado.Location = new Point(200, 300);


            btnAtlzVeicPesado.Text = "Atualizar Veiculos Pesados Cadastrados";
            btnAtlzVeicPesado.Size = new Size(200, 40);
            btnAtlzVeicPesado.Location = new Point(200, 350);

            btnRmvVeicPesado.Text = "Remover Veiculos Pesados Cadastrados";
            btnRmvVeicPesado.Size = new Size(200, 40);
            btnRmvVeicPesado.Location = new Point(200, 400);


            //Veiculo Leve


            btnCadastrarVeicLeve.Text = "Cadastrar Veiculo Leve";
            btnCadastrarVeicLeve.Size = new Size(200, 30);
            btnCadastrarVeicLeve.Location = new Point(200, 450);
            btnCadastrarVeicLeve.Click += new EventHandler(this.btnCadastrarVeicLeveClick);

            btnListarVeicLeve.Text = "Lista De Veiculos Leves Cadastrados";
            btnListarVeicLeve.Size = new Size(200, 40);
            btnListarVeicLeve.Location = new Point(200, 500);


            btnAtlzVeicLeve.Text = "Atualizar Veiculos Leves Cadastrados";
            btnAtlzVeicLeve.Size = new Size(200, 40);
            btnAtlzVeicLeve.Location = new Point(200, 550);

            btnRmvVeicLeve.Text = "Remover Veiculos Leves Cadastrados";
            btnRmvVeicLeve.Size = new Size(200, 40);
            btnRmvVeicLeve.Location = new Point(200, 600);

            //Locação


            btnCadastrarLoc.Text = "Cadastrar Locação";
            btnCadastrarLoc.Size = new Size(200, 30);
            btnCadastrarLoc.Location = new Point(200, 650);
            btnCadastrarLoc.Click += new EventHandler(this.btnCadastrarLocClick);

            btnListarLoc.Text = "Lista De Locações Cadastradas";
            btnListarLoc.Size = new Size(200, 40);
            btnListarLoc.Location = new Point(200, 700);


            btnAtlzLoc.Text = "Atualizar Locações Cadastrados";
            btnAtlzLoc.Size = new Size(200, 40);
            btnAtlzLoc.Location = new Point(200, 750);

            btnRmvLoc.Text = "Remover Locação Cadastrada";
            btnRmvLoc.Size = new Size(200, 40);
            btnRmvLoc.Location = new Point(200, 800);

            btnEncMenu.Text = "Encerrar Menu";
            btnEncMenu.Size = new Size(200, 30);
            btnEncMenu.Location = new Point(200, 900);  
            btnEncMenu.Click += new EventHandler(this.btnEncMenuClick);
            btnEncMenu.BackColor = Color.White;
          





            this.Size = new Size(600, 900);

            //Buttons Clientes

            this.Controls.Add(btnCadastrarCliente);
            this.Controls.Add(btnListarCliente);
            this.Controls.Add(btnAtualizarCliente);
            this.Controls.Add(btnRemoverCliente);


            //Buttons Veiculos Pesados

            this.Controls.Add(btnCadastroVeicPesado);
            this.Controls.Add(btnListarVeicPesado);
            this.Controls.Add(btnAtlzVeicPesado);
            this.Controls.Add(btnRmvVeicPesado);

            //Buttons Veiculos Leves

            this.Controls.Add(btnCadastrarVeicLeve);
            this.Controls.Add(btnListarVeicLeve);
            this.Controls.Add(btnAtlzVeicLeve);
            this.Controls.Add(btnRmvVeicLeve);

            //Buttons Locações

            this.Controls.Add(btnCadastrarLoc);
            this.Controls.Add(btnListarLoc);
            this.Controls.Add(btnAtlzLoc);
            this.Controls.Add(btnRmvLoc);

            this.Controls.Add(btnEncMenu);


        }

        private void btnCadastrarClienteClick(object sender, EventArgs e)
        {
            CadastroClienteVisual cadastroCliente = new CadastroClienteVisual();
            cadastroCliente.Show();
        }

        private void btnCadastroVeicPesadoClick(object sender, EventArgs e)
        {
            CadastroVeicPesaVisual cadastroVeicPesado = new CadastroVeicPesaVisual();
            cadastroVeicPesado.Show();
        }

         private void btnCadastrarVeicLeveClick(object sender, EventArgs e)
        {
            CadastroVeicLeveVisual cadastroVeicLeve = new CadastroVeicLeveVisual();
            cadastroVeicLeve.Show();
        }

           private void btnCadastrarLocClick(object sender, EventArgs e)
        {
            CadastroLocacaoVisual cadastroLocacao = new CadastroLocacaoVisual();
            cadastroLocacao.Show();
        }

         private void btnEncMenuClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Deseja Sair do Menu?", "Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Até a próxima!");
            }
            else
            {
                MessageBox.Show("Opção desconhecida!");
            }
            this.Close();

        }
    }
}
