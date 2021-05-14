using System;
using System.Windows.Forms;
using System.Drawing;
using Views.lib;
using Controller;
namespace Views
{
    public class CadLocacaoVisual : Form
    {

        private Label lblNome = new Label();       //Label cria o "nome" para as caixas de texto

        private Label lblDataLocacao = new Label();

        private TextBox txtNome = new TextBox();   //TextBox cria caixas para inserção de texto

        private MaskedTextBox txtDataLocacao = new MaskedTextBox();

        private MonthCalendar calendarioLocacao = new MonthCalendar();

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private PictureBox pictureBox = new PictureBox();

        private ProgressBar barraprogress = new ProgressBar();




        public CadLocacaoVisual()
        {
            //Visual Cadastrar Nome de Locações

            this.Text = "Cadastro de Locações";                      //Inserindo titulo da página
            this.BackColor = Color.White;


            lblNome = new LibsLabel("Nome do cliente:", new Point(20, 15), new Size(110, 40));
            txtNome = new LibsTextBoX(new Point(20, 60), new Size(200, 80));


            //Visual Cadastrar data de locação 

            lblDataLocacao = new LibsLabel("Data de Locação:", new Point(20, 100), new Size(110, 40));
            //txtDataLocacao = new LibsMaskedTextBox(new Point(20, 150), new Size(110, 80), "00/00/0000");

            DateTime dtInicio = new DateTime(2021, 05, 11);
            calendarioLocacao = new LibsCalendarView(new Point(20, 150));
            calendarioLocacao.MaxSelectionCount = 10;
            calendarioLocacao.MinDate = new DateTime(2021, 01, 01);
            calendarioLocacao.MaxDate = new DateTime(2025, 01, 01);
            calendarioLocacao.SelectionRange = new SelectionRange(dtInicio, new DateTime(2021, 01, 01));


            //Visual Botão de confirmação

            //Criando botões

            btnConfirmar = new LibsButtons("Confirmar Cadastro", new Point(18, 350), new Size(200, 30));
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);
            btnConfirmar.BackColor = Color.White;

            //Criando botões
            btnCancelar = new LibsButtons("Cancelar", new Point(230, 350), new Size(200, 30));
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);
            btnCancelar.BackColor = Color.White;

            pictureBox = new PictureBox();
            pictureBox.Size = new Size(600, 600);
            pictureBox.Location = new Point(0, 0);
            pictureBox.Load("Images\\Logo_rent_vehicles.png");
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;

          /*/  barraprogress = new ProgressBar();
            barraprogress = new LibsProgressBarView(new Point(20, 335), new Size(350, 20));
            barraprogress.Value = 0;
            barraprogress.Maximum = 50;
            barraprogress.Step = 5;
            barraprogress.Style = ProgressBarStyle.Continuous;/*/


            this.Size = new Size(600, 450);     //Trabalhando com o tamanho da janela   

            this.Controls.Add(lblNome);         //Chamando e adicionando os métodos acima 
            this.Controls.Add(txtNome);
            this.Controls.Add(lblDataLocacao);
            //this.Controls.Add(txtDataLocacao);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);
            this.Controls.Add(calendarioLocacao);

            //this.Controls.Add(barraprogress);
            this.Controls.Add(pictureBox);

        }

        private void btnConfirmarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Confirmar cadastro?", "Cadastro de Locação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Controller.Locacao.CriarLocacao(
                    this.ClienteId,
                    this.StringDataLocacao.Text
                );
                MessageBox.Show("Locação cadastrado com sucesso!");
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Cadastro de Locação não concluído!");
            }
            else
            {
                MessageBox.Show("Opção desconhecida!");
            }
            this.Close();

        }

        private void btnCancelarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar o cadastro?", "Cadastro de Locação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
