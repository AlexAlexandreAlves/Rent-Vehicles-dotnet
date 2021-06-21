using System;
using System.Windows.Forms;
using System.Drawing;
using Views.lib;

namespace Views
{
    public class CadVeicPesaVisual : Form
    {

        private Model.VeiculoPesado veiculoPesado = new Model.VeiculoPesado();
        private Label lblMarca = new Label();       //Label cria o "nome" para as caixas de texto

        private Label lblModelo = new Label();

        private Label lblAno = new Label();

        private Label lblPreco = new Label();

        private Label lblRestricoes = new Label();

        private TextBox txtMarca = new TextBox();   //TextBox cria caixas para inserção de texto

        private TextBox txtModelo = new TextBox();

        private MaskedTextBox txtAno = new MaskedTextBox();

        private MaskedTextBox txtPreco = new MaskedTextBox();

        private DateTimePicker anoVeiculoPesado = new DateTimePicker();

        private TextBox txtRestricoes = new TextBox();

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private RadioButton radioButton1 = new RadioButton();

        private RadioButton radioButton2 = new RadioButton();

        private GroupBox groupBox1 = new GroupBox();

        private PictureBox pictureBox = new PictureBox();





        public CadVeicPesaVisual(string id = "")
        {
            //Visual Cadastrar Nome do Veiculo Pesado

            this.Text = "Cadastro de Veiculos Pesados";                      //Inserindo titulo da página
            this.BackColor = Color.White;

            this.AutoScroll = false;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.HorizontalScroll.Maximum = 0;
            this.AutoScroll = true;

            lblMarca = new LibsLabel("Marca do Veiculo:", new Point(20, 15), new Size(110, 40));
            //Inserindo nome do Veiculo


            txtMarca.Location = new Point(20, 60);                       //Trabalhando com a localização da caixa de texto
            txtMarca.Size = new Size(200, 80);                               //Trabalhando com o tamanho da caixa de texto


            //Visual Cadastrar Modelo

            lblModelo = new LibsLabel("Modelo do Veiculo:", new Point(20, 100), new Size(110, 40));
            txtModelo = new LibsTextBoX(new Point(20, 150), new Size(200, 80));



            //Visual Cadastrar Ano 

            lblAno = new LibsLabel("Ano do Veiculo:", new Point(20, 200), new Size(90, 40));

            //txtAno = new LibsMaskedTextBox(new Point(20, 250), new Size(70, 80), "00/00/0000");

            anoVeiculoPesado = new LibsTimePickerView(new Point(20, 250), new Size(120, 120));
            // anoVeiculoLeve.Format = DateTimePickerFormat.Time;
            anoVeiculoPesado.Format = DateTimePickerFormat.Custom;
            anoVeiculoPesado.CustomFormat = "yyyy";
            anoVeiculoPesado.ShowCheckBox = true;
            // anoVeiculoLeve.ShowUpDown = true;



            //Visual Cadastrar Valor de locação

            lblPreco = new LibsLabel("Valor para locação:", new Point(20, 320), new Size(110, 40));

            txtPreco = new LibsMaskedTextBox(new Point(20, 368), new Size(70, 80), "$9999.00");



            //Visual Cadastrar Restrições se obter alguma 

            lblRestricoes = new LibsLabel("Se o veiculo possuir restrições, insira aqui:", new Point(20, 400), new Size(200, 40));

            txtRestricoes = new LibsTextBoX(new Point(20, 450), new Size(400, 80));




            groupBox1.Location = new Point(20, 500);
            groupBox1.Size = new Size(350, 100);
            groupBox1.Text = "Selecione se o veiculo ja foi locado ou não locado";

            radioButton1.Location = new Point(20, 25);
            radioButton1.Size = new Size(100, 15);
            radioButton1.Text = "Ja Locado";

            radioButton2.Location = new Point(20, 45);
            radioButton2.Size = new Size(150, 35);
            radioButton2.Text = "Sem Locações";



            //Visual Botão de confirmação
            //Criando botões
            btnConfirmar = new LibsButtons("Confirmar Cadastro", new Point(18, 630), new Size(200, 30));
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);
            btnConfirmar.BackColor = Color.White;

            //Criando botões
            btnCancelar = new LibsButtons("Cancelar", new Point(230, 630), new Size(200, 30));
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);
            btnCancelar.BackColor = Color.White;

            pictureBox = new PictureBox();
            pictureBox.Size = new Size(700, 700);
            pictureBox.Location = new Point(0, 0);
            pictureBox.Load("Logo_rent_vehicles.png");
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;

            if (!id.Trim().Equals(""))
            {
                try
                {
                    this.veiculoPesado = Controller.VeiculoPesado.GetVeiculoPesado(id);
                    this.txtMarca.Text = this.veiculoPesado.Marca;
                }
                catch (Exception error)
                {
                    throw error;
                }
            }



            this.Size = new Size(600, 450);     //Trabalhando com o tamanho da janela   

            this.Controls.Add(lblMarca);         //Chamando e adicionando os métodos acima 
            this.Controls.Add(txtMarca);
            this.Controls.Add(lblModelo);
            this.Controls.Add(txtModelo);
            this.Controls.Add(lblAno);
            // this.Controls.Add(txtAno);
            this.Controls.Add(anoVeiculoPesado);
            this.Controls.Add(lblPreco);
            this.Controls.Add(txtPreco);
            this.Controls.Add(lblRestricoes);
            this.Controls.Add(txtRestricoes);
            this.Controls.Add(groupBox1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);


            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);

            this.Controls.Add(pictureBox);

        }

        private void btnConfirmarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Confirmar cadastro?", "Cadastro de Veiculos Pesados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {

                if (veiculoPesado.Id > 0)
                {

                    this.veiculoPesado.Marca = this.txtMarca.Text;
                    this.veiculoPesado.Modelo = this.txtModelo.Text;
                    this.veiculoPesado.Ano = this.anoVeiculoPesado.Value.Year;
                    // this.veiculoLeve.Preco  = Convert.ToDouble(this.txtPreco.Text);
                    this.veiculoPesado.Restricoes = this.txtRestricoes.Text;
                    Controller.VeiculoPesado.AtualizarVeiculoPesado(this.veiculoPesado);

                }
                else
                {
                    Controller.VeiculoPesado.CriarVeiculoPesado(
                        this.txtMarca.Text,
                        this.txtModelo.Text,
                        this.anoVeiculoPesado.Value.Year.ToString(),
                        this.txtPreco.Text.Substring(2),
                        this.txtRestricoes.Text
                    );
                }

                MessageBox.Show("Veiculo cadastrado com sucesso!");
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Cadastro de Veiculo não concluído!");
            }
            else
            {
                MessageBox.Show("Opção desconhecida!");
            }
            this.Close();

        }

        private void btnCancelarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar o cadastro?", "Cadastro de Veiculos Pesados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
