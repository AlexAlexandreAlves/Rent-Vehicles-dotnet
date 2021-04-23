using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{

    public class MenuPrincipalVisual : Form
    {

        private Button btnCliente = new Button();

        private Button btnLocacoes = new Button();

        private Button btnVeiculosLeves = new Button();

        private Button btnVeiculosPesados = new Button();

        private Button btnEncMenu = new Button();

        public MenuPrincipalVisual()
        {

            this.Text = "Menu Principal";
            this.BackColor = Color.LightYellow;

            btnCliente.Text = "Cliente";
            btnCliente.Size = new Size(200, 30);
            btnCliente.Location = new Point(200, 50);
            btnCliente.Click += new EventHandler(this.btnClienteClick);


            btnLocacoes.Text = "Locações";
            btnLocacoes.Size = new Size(200, 30);
            btnLocacoes.Location = new Point(200, 100);
            btnLocacoes.Click += new EventHandler(this.btnLocacoesClick);


            btnVeiculosLeves.Text = "Veiculos Leves";
            btnVeiculosLeves.Size = new Size(200, 30);
            btnVeiculosLeves.Location = new Point(200, 150);
            // btnVeiculosLeves.Click += new EventHandler(this.btnVeiculosLevesClick);



            btnVeiculosPesados.Text = "Veiculos Pesados";
            btnVeiculosPesados.Size = new Size(200, 30);
            btnVeiculosPesados.Location = new Point(200, 200);
            //  btnVeiculosPesados.Click += new EventHandler(this.btnVeiculosPesadosClick);

            btnEncMenu.Text = "Encerrar Menu";
            btnEncMenu.Size = new Size(200, 30);
            btnEncMenu.Location = new Point(200, 300);
            btnEncMenu.Click += new EventHandler(this.btnEncMenuClick);
            btnEncMenu.BackColor = Color.White;



            this.Size = new Size(600, 380);

            this.Controls.Add(btnCliente);
            this.Controls.Add(btnLocacoes);
            this.Controls.Add(btnVeiculosLeves);
            this.Controls.Add(btnVeiculosPesados);

            this.Controls.Add(btnEncMenu);

        }

        private void btnClienteClick(object sender, EventArgs e)
        {
            ClienteVisual clienteVisual = new ClienteVisual();
            clienteVisual.Show();
        }
        private void btnLocacoesClick(object sender, EventArgs e)
        {
            LocacaoVisual locacaoVisual = new LocacaoVisual();
            locacaoVisual.Show();
        }

        //  private void btnVeiculosPesados(object sender, EventArgs e)
        //  {
        ///       CadastroVeicPesaVisual cadastroVeicPesado = new CadastroVeicPesaVisual();
        //      cadastroVeicPesado.Show();
        //  }

        //    private void btnVeiculosLeves(object sender, EventArgs e)
        //   {
        //      CadastroVeicLeveVisual cadastroVeicLeve = new CadastroVeicLeveVisual();
        //     cadastroVeicLeve.Show();
        //   }


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
