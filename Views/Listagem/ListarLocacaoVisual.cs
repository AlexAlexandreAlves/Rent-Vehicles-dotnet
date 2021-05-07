using System;
using System.Windows.Forms;
using System.Drawing;
using Views.lib;


namespace Views
{
    public class ListarLocacaoVisual : Form
    {

        private ListView listagemLocacoes = new ListView();

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private PictureBox pictureListarLocacoes = new PictureBox();

        public ListarLocacaoVisual()
        {
            //Visual Listagem das locaçoes

            this.Text = "Listagem de Locacoes";                      //Inserindo titulo da página
            this.BackColor = Color.White;

            this.AutoScroll = false;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.HorizontalScroll.Maximum = 0;
            this.AutoScroll = true;


            listagemLocacoes = new LibsListView(new Point(20, 15), new Size(500, 350));

            listagemLocacoes.Size = new Size(250,380);


            listagemLocacoes.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listagemLocacoes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listagemLocacoes.Columns.Add("Data da locação", -2, HorizontalAlignment.Left);
            listagemLocacoes.FullRowSelect = true;
            listagemLocacoes.GridLines = true;
            listagemLocacoes.AllowColumnReorder = true;
            listagemLocacoes.Sorting = SortOrder.Ascending;

            ListViewItem item = new ListViewItem("1");

            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            listagemLocacoes.Items.Add(item);





            btnConfirmar = new LibsButtons("Confirmar Cadastro", new Point(18, 550), new Size(200, 30));
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);


            //Criando botões
            btnCancelar = new LibsButtons("Cancelar", new Point(230, 550), new Size(200, 30));
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);


            pictureListarLocacoes = new PictureBox();
            pictureListarLocacoes.Size = new Size(600, 600);
            pictureListarLocacoes.Location = new Point(0, 0);
            pictureListarLocacoes.Load("Images\\Logo_rent_vehicles.png");
            pictureListarLocacoes.SizeMode = PictureBoxSizeMode.Normal;



            this.Size = new Size(600, 450);



            this.Controls.Add(listagemLocacoes);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);

            this.Controls.Add(pictureListarLocacoes);

        }

        private void btnConfirmarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Listagens Executadas?", "Listagem de Locações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Locações Exibidas");
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Listagem de Locações não exibidas!");
            }
            else
            {
                MessageBox.Show("Opção desconhecida!");
            }
            this.Close();

        }

        private void btnCancelarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar a listagem?", "Listagem de Locações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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