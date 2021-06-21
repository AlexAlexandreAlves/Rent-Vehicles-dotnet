using System;
using System.Windows.Forms;
using System.Drawing;
using Views.lib;
using Controller;
using System.Text.RegularExpressions;

namespace Views
{

    public class CadClienteVisual : Form
    {
        private Model.Cliente cliente = new Model.Cliente();

        private Label lblNome = new Label();       //Label cria o "nome" para as caixas de texto

        private Label lblDtNascimento = new Label();

        private Label lblCpf = new Label();

        private Label lblDiasDevolucao = new Label();

        private TextBox txtNome = new TextBox();   //TextBox cria caixas para inserção de texto

        private MaskedTextBox txtDataNascimento = new MaskedTextBox();

        private MaskedTextBox txtCpf = new MaskedTextBox();

        private ErrorProvider cpfErroProvider = new ErrorProvider();

        private NumericUpDown nmDiasDevolucao = new NumericUpDown();

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private RadioButton radioButton1 = new RadioButton();

        private RadioButton radioButton2 = new RadioButton();

        private GroupBox groupBox1 = new GroupBox();

        private PictureBox pictureBox = new PictureBox();

        private void btnConfirmarInsert(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Confirmar cadastro?", "Cadastro de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Controller.Cliente.CriarCliente(
                    this.txtNome.Text,
                    this.txtDataNascimento.Text,
                    this.txtCpf.Text,
                    this.nmDiasDevolucao.Value
                );

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Cadastro de cliente não concluído!");
            }
            else
            {
                MessageBox.Show("Opção desconhecida!");
            }
            this.Close();

        }

        private void btnConfirmarUpdate(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Confirmar alteração?", "Alteração de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.cliente.Nome = this.txtNome.Text;
                this.cliente.DtNascimento = Convert.ToDateTime(this.txtDataNascimento.Text);
                this.cliente.Cpf = this.txtCpf.Text;
                this.cliente.DiasParaRetorno = Convert.ToInt32(this.nmDiasDevolucao.Value);
                Controller.Cliente.AtualizarClientes(
                    this.cliente
                );

                MessageBox.Show("Cliente alterado com sucesso!");
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Cadastro de cliente não concluído!");
            }
            else
            {
                MessageBox.Show("Opção desconhecida!");
            }
            this.Close();

        }

        private void btnCancelarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar o cadastro?", "Cadastro de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        public delegate void EventClick(object o, EventArgs e);

        public static EventHandler MethodWithCallback(
            Model.Cliente cliente, 
            EventClick confirm, 
            EventClick update
        )
        {
            if(cliente.Id == 0) {
                return new EventHandler(confirm);    
            }
            return new EventHandler(update);
        }


        public CadClienteVisual(string id = "")
        {            
            if (!id.Trim().Equals(""))
            {
                try
                {
                    this.cliente = Controller.Cliente.GetCliente(id);
                    this.txtNome.Text = this.cliente.Nome;
                }
                catch (Exception error)
                {
                    throw error;
                }
            }

            this.Text = "Cadastro de Cliente";
            this.BackColor = Color.White;
            this.AutoScroll = false;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.HorizontalScroll.Maximum = 0;
            this.AutoScroll = true;

            lblNome = new LibsLabel("Nome do cliente:", new Point(20, 15), new Size(110, 40));
            //Inserindo nome do cliente string, tabalhando com as posições e tamanho

            txtNome = new LibsTextBoX(new Point(20, 60), new Size(200, 80));
            //Trabalhando com a localização da caixa de texto e o tamanho


            //Visual Cadastrar data de nascimento 

            lblDtNascimento = new LibsLabel("Data de Nascimento:", new Point(20, 100), new Size(150, 40));

            txtDataNascimento = new LibsMaskedTextBox(new Point(20, 150), new Size(100, 80), "00/00/0000");

            //Visual Cadastrar CPF 

            lblCpf = new LibsLabel("CPF do Cliente:", new Point(20, 200), new Size(110, 40));

            txtCpf = new LibsMaskedTextBox(new Point(20, 250), new Size(100, 80), "000,000,000-00");
            txtCpf.Validated += new EventHandler(this.cpfValidated);

            cpfErroProvider.SetIconAlignment(this.txtCpf, ErrorIconAlignment.MiddleRight);
            cpfErroProvider.SetIconPadding(this.txtCpf, 2);
            cpfErroProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;


            //Visual Cadastrar Dias para Devolução

            lblDiasDevolucao = new LibsLabel("Dias para Devolução:", new Point(20, 300), new Size(150, 40));



            nmDiasDevolucao.Location = new Point(20, 360);
            nmDiasDevolucao.Size = new Size(50, 80);
            nmDiasDevolucao.Value = 0;
            nmDiasDevolucao.Maximum = 20;
            nmDiasDevolucao.Minimum = 1;




            groupBox1.Location = new Point(20, 400);
            groupBox1.Size = new Size(200, 100);
            groupBox1.Text = "Selecione o sexo do solicitante";

            radioButton1.Location = new Point(20, 25);
            radioButton1.Size = new Size(100, 15);
            radioButton1.Text = "Masculino";

            radioButton2.Location = new Point(20, 45);
            radioButton2.Size = new Size(150, 35);
            radioButton2.Text = "Feminino";




            //Visual Botão de confirmação
            //Criando botões

            btnConfirmar = new LibsButtons("Confirmar Cadastro", new Point(18, 550), new Size(200, 30));
            btnConfirmar.Click += MethodWithCallback(
                cliente, 
                this.btnConfirmarInsert, 
                this.btnConfirmarUpdate
            );


            //Criando botões
            btnCancelar = new LibsButtons("Cancelar", new Point(230, 550), new Size(200, 30));
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);


            pictureBox = new PictureBox();
            pictureBox.Size = new Size(600, 600);
            pictureBox.Location = new Point(0, 0);
            pictureBox.Load("Logo_rent_vehicles.png");
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;
            this.Size = new Size(600, 450);     //Trabalhando com o tamanho da janela   

            this.Controls.Add(lblNome);         //Chamando e adicionando os métodos acima 
            this.Controls.Add(txtNome);
            this.Controls.Add(lblDtNascimento);
            this.Controls.Add(txtDataNascimento);
            this.Controls.Add(lblCpf);
            this.Controls.Add(txtCpf);
            this.Controls.Add(lblDiasDevolucao);
            this.Controls.Add(nmDiasDevolucao);
            this.Controls.Add(groupBox1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);


            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);

            this.Controls.Add(pictureBox);

        }

        private void cpfValidated(object sender, EventArgs e) {
             Regex rgx = new Regex("^\\d{3}\\.\\d{3}\\.\\d{3}-\\d{2}$");
            if (!rgx.IsMatch(this.txtCpf.Text))
            {
                this.cpfErroProvider.SetError(this.txtCpf, "CPF INVALIDO!");
            }else{
                this.cpfErroProvider.SetError(this.txtCpf, String.Empty);
            }

        }
    }
}

