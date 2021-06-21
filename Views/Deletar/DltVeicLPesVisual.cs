using System;
using System.Windows.Forms;
using System.Drawing;
using Views.lib;
using System.Collections.Generic;
namespace Views
{
    public class DltVeicPesVisual : Form
    {

        private Label lblId = new Label();       //Label cria o "nome" para as caixas de texto

        private LibsCBBox cbId;

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private PictureBox pictureBox = new PictureBox();






        public DltVeicPesVisual()
        {
            //Visual Cadastrar Nome de Locações

            this.Text = "Deletar Veiculo";                      //Inserindo titulo da página
            this.BackColor = Color.White;


            lblId = new LibsLabel("Informe o Id e o Modelo do veiculo que deseja deletar:", new Point(20, 30), new Size(250, 30));
            
            IEnumerable<Model.VeiculoPesado> veiculosPesados;
            try
            {
                veiculosPesados = Controller.VeiculoPesado.ListarVeicPesado();
            }
            catch (Exception error)
            {
                throw error;
            }

            List<string> comboVeicPesad = new List<string>();
            foreach (Model.VeiculoPesado item in veiculosPesados)
            {
                comboVeicPesad.Add($"{item.Id} - {item.Modelo}");
            }
                string[] opt = comboVeicPesad.ToArray();
            
            
            
            
            cbId = new LibsCBBox(new Point(20, 80), new Size(100, 80), opt);


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
            this.Controls.Add(cbId);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);
        
            this.Controls.Add(pictureBox);

        }

        private void btnConfirmarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Deletar Veiculo?", "Remover Veiculo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                    try
                {
                    string comboValue = this.cbId.Text; // "1 - João"
                    int pos = comboValue.IndexOf("-"); // 2
                    //  01234567
                    // "1 - João"
                    string veicPesId = comboValue.Substring(0, pos - 1); // "1 ".Trim() === "1"
                    Controller.VeiculoPesado.RemoverVeiculosPesados(veicPesId);

                }
                catch (Exception error)
                {
                    Console.WriteLine("ErroID" + error.Message);
                }



                MessageBox.Show("Remoção salva com sucesso!");
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Remoção não concluído!");
            }
            else
            {
                MessageBox.Show("Opção desconhecida!");
            }
            this.Close();

        }

        private void btnCancelarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar a remoção?", "Remover Veiculo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
