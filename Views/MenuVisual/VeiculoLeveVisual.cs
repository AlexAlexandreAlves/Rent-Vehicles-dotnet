using System;
using System.Windows.Forms;
using System.Drawing;

namespace Views
{

    public class VeiculoLeveVisual : Form
    {
        private Button btnCadastrarVeicLeve = new Button();

        private Button btnListarVeicLeve = new Button();

        private Button btnAtlzVeicLeve = new Button();

        private Button btnRmvVeicLeve = new Button();

        private Button btnEncMenu = new Button();

        private PictureBox pictureBox = new PictureBox();

        public VeiculoLeveVisual()
        {
            
            this.Text = "Menu Veiculos Leves";
            this.BackColor = Color.White;


            btnCadastrarVeicLeve.Text = "Cadastrar Veiculo Leve";
            btnCadastrarVeicLeve.Size = new Size(200, 30);
            btnCadastrarVeicLeve.Location = new Point(200, 50);
            btnCadastrarVeicLeve.Click += new EventHandler(this.btnCadastrarVeicLeveClick);

            btnListarVeicLeve.Text = "Lista De Veiculos Leves Cadastrados";
            btnListarVeicLeve.Size = new Size(200, 40);
            btnListarVeicLeve.Location = new Point(200, 100);
            btnListarVeicLeve.Click += new EventHandler(this.btnListarVeicLeveClick);


            btnAtlzVeicLeve.Text = "Atualizar Veiculos Leves Cadastrados";
            btnAtlzVeicLeve.Size = new Size(200, 40);
            btnAtlzVeicLeve.Location = new Point(200, 150);
            btnAtlzVeicLeve.Click += new EventHandler(this.btnAtlzVeicLeveClick);

            btnRmvVeicLeve.Text = "Remover Veiculos Leves Cadastrados";
            btnRmvVeicLeve.Size = new Size(200, 40);
            btnRmvVeicLeve.Location = new Point(200, 200);
            btnRmvVeicLeve.Click += new EventHandler(this.btnRmvVeicLeveClick);


            btnEncMenu.Text = "Voltar Menu Principal";
            btnEncMenu.Size = new Size(200, 30);
            btnEncMenu.Location = new Point(200, 300);
            btnEncMenu.Click += new EventHandler(this.btnEncMenuClick);
            btnEncMenu.BackColor = Color.White;

            
            pictureBox = new PictureBox();
            pictureBox.Size = new Size(600,600);
            pictureBox.Location = new Point(0,0);
            pictureBox.Load("Logo_rent_vehicles.png");
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;





            this.Size = new Size(600, 600);

            this.Controls.Add(btnCadastrarVeicLeve);
            this.Controls.Add(btnListarVeicLeve);
            this.Controls.Add(btnAtlzVeicLeve);
            this.Controls.Add(btnRmvVeicLeve);
            this.Controls.Add(btnEncMenu);

             this.Controls.Add(pictureBox);

        }
        private void btnCadastrarVeicLeveClick(object sender, EventArgs e)
        {
            CadVeicLeveVisual cadastroVeicLeve = new CadVeicLeveVisual();
            cadastroVeicLeve.Show();
        }

        private void btnListarVeicLeveClick(object sender, EventArgs e)
        {
            ListarVeicLeveVisual listarVeicLeve = new ListarVeicLeveVisual();
            listarVeicLeve.Show();
        }

         private void btnAtlzVeicLeveClick(object sender, EventArgs e)
        {
            AtlzVeicLeveVisual atualizarVeicLeve = new AtlzVeicLeveVisual();
            atualizarVeicLeve.Show();
        }
          private void btnRmvVeicLeveClick(object sender, EventArgs e)
        {
            DltVeicLeveVisual deletarVeicLeve = new DltVeicLeveVisual();
            deletarVeicLeve.Show();
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

