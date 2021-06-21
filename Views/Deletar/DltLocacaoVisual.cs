using System;
using System.Windows.Forms;
using System.Drawing;
using Views.lib;
using System.Collections.Generic;

namespace Views
{
    public class DltLocacaoVisual : Form
    {

        private Label lblId = new Label();       //Label cria o "nome" para as caixas de texto

        private LibsCBBox cbBox ;   //TextBox cria caixas para inserção de texto

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private PictureBox pictureBox = new PictureBox();






        public DltLocacaoVisual()
        {
            //Visual Cadastrar Nome de Locações

            this.Text = "Deletar Locação";                      //Inserindo titulo da página
            this.BackColor = Color.White;


            lblId = new LibsLabel("Informe o Id da Locação que deseja deletar:", new Point(20, 30), new Size(250, 30));
            
            IEnumerable<Model.Locacao> locacoes;
            try
            {
                locacoes = Controller.Locacao.ListarLocacoes();
            }
            catch (Exception error)
            {
                throw error;
            }

            List<string> comboLocaoces = new List<string>();
            foreach (Model.Locacao item in locacoes)
            {
                comboLocaoces.Add($"{item.ClienteId} - {item.DataLocacao}");
            }
                string[] opt = comboLocaoces.ToArray();
            
            
            cbBox = new LibsCBBox(new Point(20,70), new Size(200,80), opt);

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
            DialogResult resultado = MessageBox.Show("Deletar Locação?", "Remover locação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    string comboValue = this.cbBox.Text; // "1 - João"
                    int pos = comboValue.IndexOf("-"); // 2
                    //  01234567
                    // "1 - João"
                    string locacaoId = comboValue.Substring(0, pos - 1); // "1 ".Trim() === "1"
                    Controller.Locacao.RemoverLocacao(locacaoId);

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
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar a remoção?", "Remover locação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
