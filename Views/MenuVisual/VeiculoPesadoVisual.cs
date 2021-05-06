using System;
using System.Windows.Forms;
using System.Drawing;

namespace Views
{

    public class VeiculoPesadoVisual : Form
    {


        private Button btnCadastroVeicPesado = new Button();

        private Button btnListarVeicPesado = new Button();

        private Button btnAtlzVeicPesado = new Button();

        private Button btnRmvVeicPesado = new Button();
        
        private Button btnEncMenu = new Button();

        private PictureBox pictureBoxVeiculoPesado = new PictureBox();


        public VeiculoPesadoVisual()
        {

            this.Text = "Menu Veiculos Pesados";
            this.BackColor = Color.White;



            //Veiculo Pesado


            btnCadastroVeicPesado.Text = "Cadastrar Veiculo Pesado";
            btnCadastroVeicPesado.Size = new Size(200, 30);
            btnCadastroVeicPesado.Location = new Point(200, 50);
            btnCadastroVeicPesado.Click += new EventHandler(this.btnCadastroVeicPesadoClick);

            btnListarVeicPesado.Text = "Lista De Veiculos Pesados Cadastrados";
            btnListarVeicPesado.Size = new Size(200, 40);
            btnListarVeicPesado.Location = new Point(200, 100);


            btnAtlzVeicPesado.Text = "Atualizar Veiculos Pesados Cadastrados";
            btnAtlzVeicPesado.Size = new Size(200, 40);
            btnAtlzVeicPesado.Location = new Point(200, 150);

            btnRmvVeicPesado.Text = "Remover Veiculos Pesados Cadastrados";
            btnRmvVeicPesado.Size = new Size(200, 40);
            btnRmvVeicPesado.Location = new Point(200, 200);


            btnEncMenu.Text = "Voltar Menu Principal";
            btnEncMenu.Size = new Size(200, 30);
            btnEncMenu.Location = new Point(200, 300);
            btnEncMenu.Click += new EventHandler(this.btnEncMenuClick);
            btnEncMenu.BackColor = Color.White;

            pictureBoxVeiculoPesado = new PictureBox();
            pictureBoxVeiculoPesado.Size = new Size(600,600);
            pictureBoxVeiculoPesado.Location = new Point(0,0);
            pictureBoxVeiculoPesado.Load("Images\\Logo_rent_vehicles.png");
            pictureBoxVeiculoPesado.SizeMode = PictureBoxSizeMode.Normal;


            this.Size = new Size(600, 600);



            //Buttons Veiculos Pesados

            this.Controls.Add(btnCadastroVeicPesado);
            this.Controls.Add(btnListarVeicPesado);
            this.Controls.Add(btnAtlzVeicPesado);
            this.Controls.Add(btnRmvVeicPesado);
            this.Controls.Add(btnEncMenu);

            this.Controls.Add(pictureBoxVeiculoPesado);



        }


        private void btnCadastroVeicPesadoClick(object sender, EventArgs e)
        {
            CadastroVeicPesaVisual cadastroVeicPesado = new CadastroVeicPesaVisual();
            cadastroVeicPesado.Show();
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
