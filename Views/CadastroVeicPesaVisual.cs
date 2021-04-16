using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class CadastroVeicPesaVisual : Form
    {

        private Label lblMarca = new Label();       //Label cria o "nome" para as caixas de texto

        private Label lblModelo = new Label();

        private Label lblAno = new Label();

        private Label lblPreco = new Label();

        private Label lblRestricoes = new Label();

        private TextBox txtMarca = new TextBox();   //TextBox cria caixas para inserção de texto

        private TextBox txtModelo = new TextBox();

        private TextBox txtAno = new TextBox();

        private TextBox txtPreco = new TextBox();

         private TextBox txtRestricoes = new TextBox();

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private RadioButton radioButton1 = new RadioButton();

        private RadioButton radioButton2 = new RadioButton();

        private GroupBox groupBox1 = new GroupBox();





        public CadastroVeicPesaVisual()
        {
            //Visual Cadastrar Nome do Veiculo Pesado

            this.Text = "Cadastro de Veiculos Pesados";                      //Inserindo titulo da página
            this.BackColor = Color.LightYellow;

            lblMarca.Text = "Marca do Veiculo:";                                  //Inserindo nome do Veiculo
            lblMarca.Location = new Point(20, 15);                       //Trabalhando com a localização da string inserida acima
            lblMarca.Size = new Size(300, 40);                                   //Trabalhando com o tamanho do valor inserido


            txtMarca.Location = new Point(20, 60);                       //Trabalhando com a localização da caixa de texto
            txtMarca.Size = new Size(200, 80);                               //Trabalhando com o tamanho da caixa de texto


            //Visual Cadastrar Modelo


            lblModelo.Text = "Modelo do Veiculo:";
            lblModelo.Location = new Point(20, 100);
            lblModelo.Size = new Size(500, 40);


            txtModelo.Location = new Point(20, 150);
            txtModelo.Size = new Size(200, 80);

            //Visual Cadastrar Ano 


            lblAno.Text = "Ano do Veiculo:";
            lblAno.Location = new Point(20, 200);
            lblAno.Size = new Size(300, 40);


            txtAno.Location = new Point(20, 250);
            txtAno.Size = new Size(200, 80);


            //Visual Cadastrar Valor de locação


            lblPreco.Text = "Valor para locação:";
            lblPreco.Location = new Point(20, 300);
            lblPreco.Size = new Size(300, 40);

            txtPreco.Location = new Point(20, 350);
            txtPreco.Size = new Size(200, 80);

             //Visual Cadastrar Restrições se obter alguma 


            lblRestricoes.Text = "Se o veiculo possuir restrições, insira aqui:";
            lblRestricoes.Location = new Point(20, 400);
            lblRestricoes.Size = new Size(500, 40);


            txtRestricoes.Location = new Point(20, 450);
            txtRestricoes.Size = new Size(200, 80);



            groupBox1.Location = new Point(20, 550);
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

            btnConfirmar.Text = "Confirmar Cadastro";
            btnConfirmar.Size = new Size(200, 30);
            btnConfirmar.Location = new Point(18, 700);
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);
            btnConfirmar.BackColor = Color.White;

            //Criando botões
            btnCancelar.Text = "Cancelar";
            btnCancelar.Size = new Size(200, 30);
            btnCancelar.Location = new Point(230, 700);
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);
            btnCancelar.BackColor = Color.White;
            

            this.Size = new Size(600, 450);     //Trabalhando com o tamanho da janela   

            this.Controls.Add(lblMarca);         //Chamando e adicionando os métodos acima 
            this.Controls.Add(txtMarca);
            this.Controls.Add(lblModelo);
            this.Controls.Add(txtModelo);
            this.Controls.Add(lblAno);
            this.Controls.Add(txtAno);
            this.Controls.Add(lblPreco);
            this.Controls.Add(txtPreco);
            this.Controls.Add(lblRestricoes);
            this.Controls.Add(txtRestricoes);
            this.Controls.Add(groupBox1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);


            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);

        }

        private void btnConfirmarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Confirmar cadastro?", "Cadastro de Veiculos Pesados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
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
