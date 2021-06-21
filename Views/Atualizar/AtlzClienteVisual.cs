using System;
using System.Windows.Forms;
using System.Drawing;
using Views.lib;
using System.Collections.Generic;

namespace Views
{
    public class AtlzClienteVisual : Form
    {

        private Label lblId = new Label();       //Label cria o "nome" para as caixas de texto

        private TextBox txtId = new TextBox();   //TextBox cria caixas para inserção de texto

        private ComboBox cbBox;

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private PictureBox pictureBox = new PictureBox();






        public AtlzClienteVisual()
        {
            //Visual Cadastrar Nome de Locações

            this.Text = "Atualizar Cliente";                      //Inserindo titulo da página
            this.BackColor = Color.White;


            lblId = new LibsLabel("Informe o Id do cliente que deseja atualizar:", new Point(20, 30), new Size(150, 30));

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

            cbBox = new LibsComboBox(new Point(20, 70), new Size(150, 80), options);



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
            DialogResult resultado = MessageBox.Show("Confirmar atualização?", "Atualização de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                string comboValue = this.cbBox.Text; // "1 - João"
                int pos = comboValue.IndexOf("-"); // 2
                //  01234567
                // "1 - João"
                string clienteId = comboValue.Substring(0, pos - 1); // "1 ".Trim() === "1"
                CadClienteVisual cadastro = new CadClienteVisual(clienteId);
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
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar a atualização?", "Atualização de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
