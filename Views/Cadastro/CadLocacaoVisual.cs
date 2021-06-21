using System;
using System.Windows.Forms;
using System.Drawing;
using Views.lib;
using System.Collections.Generic;

namespace Views
{
    public class CadLocacaoVisual : Form
    {

        private Label lblCliente = new Label();       //Label cria o "nome" para as caixas de texto

        private Label lblDataLocacao = new Label();

        private LibsComboBox cbCliente;   //TextBox cria caixas para inserção de texto

        private MaskedTextBox txtDataLocacao = new MaskedTextBox();

        private MonthCalendar calendarioLocacao = new MonthCalendar();

        private Label lblveiculoLeves;

        private LibsCBBox cbVeiculoLeves;

        private LibsLabel lblveiculoPesados;

        private LibsCBBox cbVeiculoPesados;

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private PictureBox pictureBox = new PictureBox();

        private ProgressBar barraprogress = new ProgressBar();




        public CadLocacaoVisual()

        {

            this.AutoScroll = false;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.HorizontalScroll.Maximum = 0;
            this.AutoScroll = true;

            //Visual Cadastrar Nome de Locações

            this.Text = "Cadastro de Locações";                      //Inserindo titulo da página
            this.BackColor = Color.White;


            lblCliente = new LibsLabel("Cliente:", new Point(20, 15), new Size(110, 40));

            IEnumerable<Model.Cliente> clientes;
            try
            {
                clientes = Controller.Cliente.ListarClientes();
            }
            catch (Exception error)
            {
                throw error;
            }

            List<string> comboClientes = new List<string>();
            foreach (Model.Cliente item in clientes)
            {
                comboClientes.Add($"{item.Id} - {item.Nome}");
            }
            string[] options = comboClientes.ToArray();
            cbCliente = new LibsComboBox(new Point(20, 60), new Size(200, 80), options);


            //Visual Cadastrar data de locação 

            lblDataLocacao = new LibsLabel("Data de Locação:", new Point(20, 100), new Size(110, 40));
            //txtDataLocacao = new LibsMaskedTextBox(new Point(20, 150), new Size(110, 80), "00/00/0000");

            DateTime dtInicio = new DateTime(2021, 05, 11);
            calendarioLocacao = new LibsCalendarView(new Point(20, 150));
            calendarioLocacao.MaxSelectionCount = 1;
            calendarioLocacao.MinDate = new DateTime(2021, 01, 01);
            calendarioLocacao.MaxDate = new DateTime(2025, 01, 01);
            calendarioLocacao.SelectionRange = new SelectionRange(dtInicio, new DateTime(2021, 01, 01));


            lblveiculoLeves = new LibsLabel("Veiculo Leve:", new Point(20, 340), new Size(110, 40));

            IEnumerable<Model.VeiculoLeve> veiculosLeves;
            try
            {
                veiculosLeves = Controller.VeiculoLeve.ListarVeicLeve();
            }
            catch (Exception error)
            {
                throw error;
            }

            List<string> comboVeicLeve = new List<string>();
            foreach (Model.VeiculoLeve item in veiculosLeves)
            {
                comboVeicLeve.Add($"{item.Id} - {item.Marca} - {item.Modelo} - {item.Ano} - {item.Cor}");
            }
            string[] opt = comboVeicLeve.ToArray();

            cbVeiculoLeves = new LibsCBBox(new Point(20, 400), new Size(200, 80), opt);



            lblveiculoPesados = new LibsLabel("Veiculo Pesado:", new Point(20, 470), new Size(110, 40));

            IEnumerable<Model.VeiculoPesado> veiculoPesados;
            try
            {
                veiculoPesados = Controller.VeiculoPesado.ListarVeicPesado();
            }
            catch (Exception error)
            {
                throw error;
            }

            List<string> comboVeicPesado = new List<string>();
            foreach (Model.VeiculoPesado item in veiculoPesados)
            {
                comboVeicPesado.Add($"{item.Id} - {item.Marca} - {item.Modelo} - {item.Ano} - {item.Restricoes}");
            }
            string[] opt1 = comboVeicPesado.ToArray();

            cbVeiculoPesados = new LibsCBBox(new Point(20, 520), new Size(200, 80), opt1);



            //Visual Botão de confirmação

            //Criando botões

            btnConfirmar = new LibsButtons("Confirmar Cadastro", new Point(18, 570), new Size(200, 30));
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);
            btnConfirmar.BackColor = Color.White;

            //Criando botões
            btnCancelar = new LibsButtons("Cancelar", new Point(230, 570), new Size(200, 30));
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);
            btnCancelar.BackColor = Color.White;

            pictureBox = new PictureBox();
            pictureBox.Size = new Size(600, 600);
            pictureBox.Location = new Point(0, 0);
            pictureBox.Load("Logo_rent_vehicles.png");
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;



            this.Size = new Size(600, 450);     //Trabalhando com o tamanho da janela   

            this.Controls.Add(lblCliente);         //Chamando e adicionando os métodos acima 
            this.Controls.Add(cbCliente);
            this.Controls.Add(lblDataLocacao);
            this.Controls.Add(calendarioLocacao);
            this.Controls.Add(lblveiculoLeves);
            this.Controls.Add(cbVeiculoLeves);
            this.Controls.Add(lblveiculoPesados);
            this.Controls.Add(cbVeiculoPesados);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);

            this.Controls.Add(pictureBox);

        }


        private void btnConfirmarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Confirmar cadastro?", "Cadastro de Locação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                string comboValue = cbCliente.Text; // "1 - João"
                int pos = comboValue.IndexOf("-"); // 2
                //  01234567
                // "1 - João"
                string clienteId = comboValue.Substring(0, pos - 1); // "1 ".Trim() === "1"

                List<Model.VeiculoLeve> veiculoLeves = new List<Model.VeiculoLeve>();
                List<Model.VeiculoPesado> veiculoPesados = new List<Model.VeiculoPesado>();

                if (!this.cbVeiculoLeves.Text.Equals(""))
                {

                    string combo = this.cbVeiculoLeves.Text;
                    int posi = comboValue.IndexOf("-");
                    string strId = combo.Substring(0, posi - 1);
                    int id = Convert.ToInt32(strId);
                    Model.VeiculoLeve veiculo = Controller.VeiculoLeve.GetVeiculosLeves(strId);
                    veiculoLeves.Add(veiculo);

                }

                Controller.Locacao.CriarLocacao(
                   clienteId,
                   this.calendarioLocacao.SelectionRange.Start,
                   veiculoLeves,
                   veiculoPesados
                );

              /*  if (this.cbVeiculoPesados.Text.Equals(""))
                {

                    string combo = this.cbVeiculoPesados.Text;
                    int posi = comboValue.IndexOf("-");
                    string strId = combo.Substring(0, posi - 1);
                    int id = Convert.ToInt32(strId);
                    Model.VeiculoPesado veiculo = Controller.VeiculoPesado.GetVeiculoPesado(strId);
                    veiculoPesados.Add(veiculo);

                }*/




                MessageBox.Show($"Locação cadastrado com sucesso para o Cliente: {clienteId}!");
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
