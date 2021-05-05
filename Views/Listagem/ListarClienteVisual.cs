using System;
using System.Windows.Forms;
using System.Drawing;
using Views.lib;


namespace View
{
    public class ListarClienteVisual : Form
    {
        
        private ListView listagemClientes = new ListView();

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private PictureBox pictureBoxCadastroCliente = new PictureBox();

        public ListarClienteVisual()
        {
            //Visual Listagem do cliente

            this.Text = "Listagem de Cliente";                      //Inserindo titulo da página
            this.BackColor = Color.White;

            this.AutoScroll = false;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.HorizontalScroll.Maximum = 0;
            this.AutoScroll = true;

            
            listagemClientes = new LibsListView(new Point(20, 15), new Size(110, 40));


            listagemClientes.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listagemClientes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listagemClientes.Columns.Add("Data de Nascimento", -2, HorizontalAlignment.Left);
            listagemClientes.Columns.Add("Cpf", -2, HorizontalAlignment.Left);
            listagemClientes.Columns.Add("Dias para Devolução", -2, HorizontalAlignment.Left);
            listagemClientes.FullRowSelect = true;
            listagemClientes.GridLines = true;
            listagemClientes.AllowColumnReorder = true;
            listagemClientes.Sorting = SortOrder.Ascending;

            ListViewItem item = new ListViewItem("1");
           
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            listagemClientes.Items.Add(item);









            btnConfirmar = new LibsButtons("Confirmar Cadastro", new Point(18, 550), new Size(200, 30));
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);


            //Criando botões
            btnCancelar = new LibsButtons("Cancelar", new Point(230, 550), new Size(200, 30));
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);


            pictureBoxCadastroCliente = new PictureBox();
            pictureBoxCadastroCliente.Size = new Size(600, 600);
            pictureBoxCadastroCliente.Location = new Point(0, 0);
            pictureBoxCadastroCliente.Load("Images\\Logo_rent_vehicles.png");
            pictureBoxCadastroCliente.SizeMode = PictureBoxSizeMode.Normal;




            this.Size = new Size(600, 450);



            this.Controls.Add(listagemClientes);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);

            this.Controls.Add(pictureBoxCadastroCliente);

        }

        private void btnConfirmarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Confirmar cadastro?", "Cadastro de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
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

    }

}