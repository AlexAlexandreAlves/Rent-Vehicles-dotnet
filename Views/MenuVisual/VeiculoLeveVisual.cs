using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{

    public class VeiculoLeveVisual : Form
    {
        private Button btnCadastrarVeicLeve = new Button();

        private Button btnListarVeicLeve = new Button();

        private Button btnAtlzVeicLeve = new Button();

        private Button btnRmvVeicLeve = new Button();

        private Button btnEncMenu = new Button();

        private PictureBox pictureBoxVeiculoLeve = new PictureBox();

        public VeiculoLeveVisual()
        {
            
            this.Text = "Menu Veiculos Leves";
            this.BackColor = Color.LightGray;


            btnCadastrarVeicLeve.Text = "Cadastrar Veiculo Leve";
            btnCadastrarVeicLeve.Size = new Size(200, 30);
            btnCadastrarVeicLeve.Location = new Point(200, 50);
            btnCadastrarVeicLeve.Click += new EventHandler(this.btnCadastrarVeicLeveClick);

            btnListarVeicLeve.Text = "Lista De Veiculos Leves Cadastrados";
            btnListarVeicLeve.Size = new Size(200, 40);
            btnListarVeicLeve.Location = new Point(200, 100);


            btnAtlzVeicLeve.Text = "Atualizar Veiculos Leves Cadastrados";
            btnAtlzVeicLeve.Size = new Size(200, 40);
            btnAtlzVeicLeve.Location = new Point(200, 150);

            btnRmvVeicLeve.Text = "Remover Veiculos Leves Cadastrados";
            btnRmvVeicLeve.Size = new Size(200, 40);
            btnRmvVeicLeve.Location = new Point(200, 200);


            btnEncMenu.Text = "Voltar Menu Principal";
            btnEncMenu.Size = new Size(200, 30);
            btnEncMenu.Location = new Point(200, 300);
            btnEncMenu.Click += new EventHandler(this.btnEncMenuClick);
            btnEncMenu.BackColor = Color.White;

            
            pictureBoxVeiculoLeve = new PictureBox();
            pictureBoxVeiculoLeve.Size = new Size(600,600);
            pictureBoxVeiculoLeve.Location = new Point(0,0);
            pictureBoxVeiculoLeve.Load("Images\\supercar-wallpapers-pagani-1.jpg");
            pictureBoxVeiculoLeve.SizeMode = PictureBoxSizeMode.StretchImage;





            this.Size = new Size(600, 600);

            this.Controls.Add(btnCadastrarVeicLeve);
            this.Controls.Add(btnListarVeicLeve);
            this.Controls.Add(btnAtlzVeicLeve);
            this.Controls.Add(btnRmvVeicLeve);
            this.Controls.Add(btnEncMenu);

             this.Controls.Add(pictureBoxVeiculoLeve);

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

