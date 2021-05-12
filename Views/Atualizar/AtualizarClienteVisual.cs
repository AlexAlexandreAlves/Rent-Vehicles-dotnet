using System;
using System.Windows.Forms;
using System.Drawing;
using Views.lib;
namespace Views
{
    public class AtualizarClienteVisual : Form
    {

        private Label lblNome = new Label();       //Label cria o "nome" para as caixas de texto

        private Label lblDataLocacao = new Label();

        private TextBox txtNome = new TextBox();   //TextBox cria caixas para inserção de texto

        private MaskedTextBox txtDataLocacao = new MaskedTextBox();

        private MonthCalendar calendarioLocacao = new MonthCalendar();

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private PictureBox pictureBoxCadastroLocacao = new PictureBox();

        private ProgressBar barraprogress = new ProgressBar();




        public AtualizarClienteVisual()
        {
            //Visual Cadastrar Nome de Locações

            this.Text = "Atualizar Cliente";                      //Inserindo titulo da página
            this.BackColor = Color.White;


            lblNome = new LibsLabel("Informe o Id do cliente que deseja atualizar:", new Point(20, 30), new Size(250, 30));
            txtNome = new LibsTextBoX(new Point(20, 80), new Size(100, 80));


            //Criando botões

            btnConfirmar = new LibsButtons("Confirmar", new Point(18, 350), new Size(200, 30));
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);
            btnConfirmar.BackColor = Color.White;

            //Criando botões
            btnCancelar = new LibsButtons("Cancelar", new Point(230, 350), new Size(200, 30));
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);
            btnCancelar.BackColor = Color.White;

            pictureBoxCadastroLocacao = new PictureBox();
            pictureBoxCadastroLocacao.Size = new Size(600, 600);
            pictureBoxCadastroLocacao.Location = new Point(0, 0);
            pictureBoxCadastroLocacao.Load("Images\\Logo_rent_vehicles.png");
            pictureBoxCadastroLocacao.SizeMode = PictureBoxSizeMode.Normal;

    

            this.Size = new Size(600, 450);     //Trabalhando com o tamanho da janela   

            this.Controls.Add(lblNome);         //Chamando e adicionando os métodos acima 
            this.Controls.Add(txtNome);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);
        
            this.Controls.Add(pictureBoxCadastroLocacao);

        }

        private void btnConfirmarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Confirmar atualização?", "Atualização de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Atualização salva com sucesso!");
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Atualização não concluído!");
            }
            else
            {
                MessageBox.Show("Opção desconhecida!");
            }
            this.Close();

        }

        private void btnCancelarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar a atualização?", "Atualização de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro Cancelado!");
            }
            else
            {
                MessageBox.Show("Opção desconhecida!");
            }
            this.Close();

        }
    }

}
