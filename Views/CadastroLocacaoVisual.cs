using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class CadastroLocacaoVisual : Form
    {

        private Label lblNome = new Label();       //Label cria o "nome" para as caixas de texto

        private Label lblDataLocacao = new Label();

        private TextBox txtNome = new TextBox();   //TextBox cria caixas para inserção de texto

        private TextBox txtDataLocacao = new TextBox();

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();




        public CadastroLocacaoVisual()
        {
            //Visual Cadastrar Nome de Locações

            this.Text = "Cadastro de Locações";                      //Inserindo titulo da página
            this.BackColor = Color.LightYellow;

            lblNome.Text = "Nome do cliente:";                                  //Inserindo nome do cliente
            lblNome.Location = new Point(20, 15);                       //Trabalhando com a localização da string inserida acima
            lblNome.Size = new Size(300, 40);                                   //Trabalhando com o tamanho do valor inserido


            txtNome.Location = new Point(20, 60);                       //Trabalhando com a localização da caixa de texto
            txtNome.Size = new Size(200, 80);                               //Trabalhando com o tamanho da caixa de texto


            //Visual Cadastrar data de locação 


            lblDataLocacao.Text = "Data de Locação:";
            lblDataLocacao.Location = new Point(20, 100);
            lblDataLocacao.Size = new Size(500, 40);


            txtDataLocacao.Location = new Point(20, 150);
            txtDataLocacao.Size = new Size(200, 80);


            //Visual Botão de confirmação

            //Criando botões

            btnConfirmar.Text = "Confirmar Cadastro";
            btnConfirmar.Size = new Size(200, 30);
            btnConfirmar.Location = new Point(18, 250);
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);
            btnConfirmar.BackColor = Color.White;

            //Criando botões
            btnCancelar.Text = "Cancelar";
            btnCancelar.Size = new Size(200, 30);
            btnCancelar.Location = new Point(230, 250);
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);
            btnCancelar.BackColor = Color.White;


            this.Size = new Size(600, 450);     //Trabalhando com o tamanho da janela   

            this.Controls.Add(lblNome);         //Chamando e adicionando os métodos acima 
            this.Controls.Add(txtNome);
            this.Controls.Add(lblDataLocacao);
            this.Controls.Add(txtDataLocacao);


            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);

        }

        private void btnConfirmarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Confirmar cadastro?", "Cadastro de Locação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
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