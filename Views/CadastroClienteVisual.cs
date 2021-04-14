using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class CadastroClienteVisual : Form
    {

        private Label lblNome = new Label();       //Label cria o "nome" para as caixas de texto

        private Label lblDtNascimento = new Label();

        private Label lblCpf = new Label();

        private Label lblDiasDevolucao = new Label();

        private TextBox txtNome = new TextBox();   //TextBox cria caixas para inserção de texto

        private TextBox txtDataNascimento = new TextBox();

        private TextBox txtCpf = new TextBox();

        private ComboBox cbDiasDevolucao = new ComboBox();

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private RadioButton radioButton1 = new RadioButton();

        private RadioButton radioButton2 = new RadioButton();

        private GroupBox groupBox1 = new GroupBox();   





        public CadastroClienteVisual()
        {
            //Visual Cadastrar Nome do cliente

            this.Text = "Cadastro de Cliente";                      //Inserindo titulo da página
            this.BackColor = Color.LightYellow;

            lblNome.Text = "Nome do cliente:";                                  //Inserindo nome do cliente
            lblNome.Location = new Point(20, 15);                       //Trabalhando com a localização da string inserida acima
            lblNome.Size = new Size(300, 40);                                   //Trabalhando com o tamanho do valor inserido


            txtNome.Location = new Point(20, 60);                       //Trabalhando com a localização da caixa de texto
            txtNome.Size = new Size(200, 80);                               //Trabalhando com o tamanho da caixa de texto


            //Visual Cadastrar data de nascimento 


            lblDtNascimento.Text = "Data de Nascimento:";
            lblDtNascimento.Location = new Point(20, 100);
            lblDtNascimento.Size = new Size(500, 40);


            txtDataNascimento.Location = new Point(20, 150);
            txtDataNascimento.Size = new Size(200, 80);

            //Visual Cadastrar CPF 


            lblCpf.Text = "CPF do Cliente:";
            lblCpf.Location = new Point(20, 200);
            lblCpf.Size = new Size(300, 40);


            txtCpf.Location = new Point(20, 250);
            txtCpf.Size = new Size(200, 80);


            //Visual Cadastrar Dias para Devolução


            lblDiasDevolucao.Text = "Dias para Devolução:";
            lblDiasDevolucao.Location = new Point(20, 300);
            lblDiasDevolucao.Size = new Size(300, 40);



            cbDiasDevolucao.Location = new Point(20, 360);
            cbDiasDevolucao.Size = new Size(200, 80);
            cbDiasDevolucao.Items.AddRange(new object[] { "2", "4", "6", "8" });


            groupBox1.Location = new Point(20,450);
            groupBox1.Size = new Size(200, 80);
            groupBox1.Text = "Selecione o sexo do solicitante";

            radioButton1.Location = new Point(20,20);
            radioButton1.Size = new Size(10, 15);
            radioButton1.Text = "Masculino";

            radioButton2.Location = new Point(20,20);
            radioButton2.Size = new Size(10, 15);
            radioButton2.Text = "Feminino";



            //Visual Botão de confirmação
            //Criando botões

            btnConfirmar.Text = "Confirmar Cadastro";
            btnConfirmar.Size = new Size(200, 30);
            btnConfirmar.Location = new Point(18, 550);
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);

            //Criando botões
            btnCancelar.Text = "Cancelar";
            btnCancelar.Size = new Size(200, 30);
            btnCancelar.Location = new Point(230, 550);

            this.Size = new Size(600, 450);     //Trabalhando com o tamanho da janela   

            this.Controls.Add(lblNome);         //Chamando e adicionando os métodos acima 
            this.Controls.Add(txtNome);
            this.Controls.Add(lblDtNascimento);
            this.Controls.Add(txtDataNascimento);
            this.Controls.Add(lblCpf);
            this.Controls.Add(txtCpf);
            this.Controls.Add(lblDiasDevolucao);
            this.Controls.Add(cbDiasDevolucao);
            this.Controls.Add(groupBox1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);


            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);

        }

        private void btnConfirmarClick(object sender, EventArgs e)    //Cria o Evento do botão (Click)
        {
            const string message = "Deseja confirmar cadastro?";        //Cria o evento de confirmação sim ou não do botão
            const string caption = "Confirmar cadastro?";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
    }
}
