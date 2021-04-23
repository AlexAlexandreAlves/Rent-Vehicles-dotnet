using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
//Estou desmanchando este menu
    public class Menu : Form
    {


        private Button btnCadastroVeicPesado = new Button();

        private Button btnListarVeicPesado = new Button();

        private Button btnAtlzVeicPesado = new Button();

        private Button btnRmvVeicPesado = new Button();


        private Button btnEncMenu = new Button();


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





            this.Size = new Size(600, 900);



            //Buttons Veiculos Pesados

            this.Controls.Add(btnCadastroVeicPesado);
            this.Controls.Add(btnListarVeicPesado);
            this.Controls.Add(btnAtlzVeicPesado);
            this.Controls.Add(btnRmvVeicPesado);




            this.Controls.Add(btnEncMenu);


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
