using System;
using System.Windows.Forms;
using System.Drawing;
using Views.lib;
using System.Collections.Generic;


namespace Views
{
    public class ListarClienteVisual : Form
    {

        private ListView listagemClientes = new ListView();

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private PictureBox pictureBox = new PictureBox();

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


            listagemClientes = new LibsListView(new Point(20, 15), new Size(500, 350));

            listagemClientes.Size = new Size(450, 350);



            listagemClientes.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listagemClientes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listagemClientes.Columns.Add("Data de Nascimento", -2, HorizontalAlignment.Left);
            listagemClientes.Columns.Add("Cpf", -2, HorizontalAlignment.Left);
            listagemClientes.Columns.Add("Dias para Devolução", -2, HorizontalAlignment.Left);
            listagemClientes.FullRowSelect = true;
            listagemClientes.GridLines = true;
            listagemClientes.AllowColumnReorder = true;
            listagemClientes.Sorting = SortOrder.Ascending;

            IEnumerable<Model.Cliente> Clientes = Controller.Cliente.ListarClientes();
            foreach (Model.Cliente cliente in Clientes)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(cliente.Id));
                item.SubItems.Add(cliente.Nome);
                item.SubItems.Add(String.Format("{0:d}",cliente.DtNascimento));
                item.SubItems.Add(cliente.Cpf);
                item.SubItems.Add(Convert.ToString(cliente.DiasParaRetorno));
                listagemClientes.Items.Add(item);

            }




            btnConfirmar = new LibsButtons("Confirmar", new Point(18, 550), new Size(200, 30));
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);


            //Criando botões
            btnCancelar = new LibsButtons("Cancelar", new Point(230, 550), new Size(200, 30));
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);


            pictureBox = new PictureBox();
            pictureBox.Size = new Size(600, 600);
            pictureBox.Location = new Point(0, 0);
            pictureBox.Load("Logo_rent_vehicles.png");
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;



            this.Size = new Size(600, 450);



            this.Controls.Add(listagemClientes);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);

            this.Controls.Add(pictureBox);

        }

        private void btnConfirmarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Listagens Executadas?", "Listagem de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Listagem de cliente executada com sucesso!");
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Listagem de clientes não concluída!");
            }
            else
            {
                MessageBox.Show("Opção desconhecida!");
            }
            this.Close();

        }

        private void btnCancelarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar a listagem?", "Listagem de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Listagem Cancelada!");
            }
            else
            {
                MessageBox.Show("Opção desconhecida!");
            }
            this.Close();

        }

    }

}