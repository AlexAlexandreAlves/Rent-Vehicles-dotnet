using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{

    public class LocacaoVisual : Form
    {


        private Button btnCadastrarLoc = new Button();

        private Button btnListarLoc = new Button();

        private Button btnAtlzLoc = new Button();

        private Button btnRmvLoc = new Button();

        private Button btnEncMenu = new Button();

        public LocacaoVisual()
        {

            this.Text = "Menu Locação";
            this.BackColor = Color.LightYellow;



            btnCadastrarLoc.Text = "Cadastrar Locação";
            btnCadastrarLoc.Size = new Size(200, 30);
            btnCadastrarLoc.Location = new Point(200, 50);
            btnCadastrarLoc.Click += new EventHandler(this.btnCadastrarLocClick);

            btnListarLoc.Text = "Lista de Locações Cadastradas";
            btnListarLoc.Size = new Size(200, 30);
            btnListarLoc.Location = new Point(200, 100);


            btnAtlzLoc.Text = "Atualizar Locações Cadastradas";
            btnAtlzLoc.Size = new Size(200, 30);
            btnAtlzLoc.Location = new Point(200, 150);

            btnRmvLoc.Text = "Remover Locação Cadastrada";
            btnRmvLoc.Size = new Size(200, 30);
            btnRmvLoc.Location = new Point(200, 200);

            btnEncMenu.Text = "Encerrar Menu";
            btnEncMenu.Size = new Size(200, 30);
            btnEncMenu.Location = new Point(200, 300);
            btnEncMenu.Click += new EventHandler(this.btnEncMenuClick);
            btnEncMenu.BackColor = Color.White;



            this.Size = new Size(600, 600);


            this.Controls.Add(btnCadastrarLoc);
            this.Controls.Add(btnListarLoc);
            this.Controls.Add(btnAtlzLoc);
            this.Controls.Add(btnRmvLoc);

            this.Controls.Add(btnEncMenu);

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



