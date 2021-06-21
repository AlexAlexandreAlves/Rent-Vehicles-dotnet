using System;
using System.Windows.Forms;
using System.Drawing;
using Views.lib;
using System.Collections.Generic;

namespace Views
{
    public class AtlzVeiculoPesadoVisual : Form
    {

        private Label lblId = new Label();       //Label cria o "nome" para as caixas de texto

        private LibsCBBox cbBox;  //TextBox cria caixas para inserção de texto

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private PictureBox pictureBox = new PictureBox();






        public AtlzVeiculoPesadoVisual()
        {
            //Visual Cadastrar Nome de Locações

            this.Text = "Atualizar Veiculo";                      //Inserindo titulo da página
            this.BackColor = Color.White;


            lblId = new LibsLabel("Informe o Id e o Modelo do veiculo que deseja deletar:", new Point(20, 30), new Size(250, 30));
            string[] options = { };
            
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
                comboVeicPesado.Add($"{item.Id} - {item.Modelo}");
            }
            string[] opt = comboVeicPesado.ToArray();
           
            cbBox = new LibsCBBox(new Point(20,70), new Size(100,80),opt);

            //Criando botões

            btnConfirmar = new LibsButtons("Confirmar", new Point(18, 350), new Size(200, 30));
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);
            btnConfirmar.BackColor = Color.White;

            //Criando botões
            btnCancelar = new LibsButtons("Cancelar", new Point(230, 350), new Size(200, 30));
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);
            btnCancelar.BackColor = Color.White;

            pictureBox = new PictureBox();
            pictureBox.Size = new Size(600, 600);
            pictureBox.Location = new Point(0, 0);
            pictureBox.Load("Logo_rent_vehicles.png");
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;

    

            this.Size = new Size(600, 450);     //Trabalhando com o tamanho da janela   

            this.Controls.Add(lblId);         //Chamando e adicionando os métodos acima 
            this.Controls.Add(cbBox);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);
        
            this.Controls.Add(pictureBox);

        }

        private void btnConfirmarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Atualizar Veiculo?", "Atualização de Veiculo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                string comboValue = this.cbBox.Text; // "1 - João"
                int pos = comboValue.IndexOf("-"); // 2
                //  01234567
                // "1 - João"
                string veicPesadoId = comboValue.Substring(0, pos - 1); // "1 ".Trim() === "1"
                CadVeicPesaVisual cadastro = new CadVeicPesaVisual(veicPesadoId);
                cadastro.Show();

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
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar a atualização?", "Atualização de Veiculo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
