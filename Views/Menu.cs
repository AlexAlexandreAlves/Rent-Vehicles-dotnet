using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{

    public class Menu : Form
    {


        private Button btnCadastroVeicPesado = new Button();

        private Button btnListarVeicPesado = new Button();

        private Button btnAtlzVeicPesado = new Button();

        private Button btnRmvVeicPesado = new Button();

        private Button btnCadastrarVeicLeve = new Button();

        private Button btnListarVeicLeve = new Button();

        private Button btnAtlzVeicLeve = new Button();

        private Button btnRmvVeicLeve = new Button();

        private Button  btnEncMenu = new Button();


        public Menu()
        {

            this.Text = "Menu Principal";
            this.BackColor = Color.LightYellow;

    
  
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


            btnEncMenu.Text = "Encerrar Menu";
            btnEncMenu.Size = new Size(200, 30);
            btnEncMenu.Location = new Point(200, 900);  
            btnEncMenu.Click += new EventHandler(this.btnEncMenuClick);
            btnEncMenu.BackColor = Color.White;
          





            this.Size = new Size(600, 900);

        

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


            this.Controls.Add(btnEncMenu);


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
