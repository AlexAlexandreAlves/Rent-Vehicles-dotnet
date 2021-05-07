using System;
using System.Windows.Forms;
using System.Drawing;
using Views.lib;


namespace Views
{
    public class ListarVeicLeveVisual : Form
    {

        private ListView listagemVeicLeve = new ListView();

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private PictureBox pictureListarVeicLeve = new PictureBox();

        public ListarVeicLeveVisual()
        {
            //Visual Listagem das locaçoes

            this.Text = "Listagem de VeiculosLeves";                      //Inserindo titulo da página
            this.BackColor = Color.White;

            this.AutoScroll = false;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.HorizontalScroll.Maximum = 0;
            this.AutoScroll = true;


            listagemVeicLeve = new LibsListView(new Point(20, 15), new Size(500, 350));


            listagemVeicLeve.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listagemVeicLeve.Columns.Add("Marca do Veiculo", -2, HorizontalAlignment.Left);
            listagemVeicLeve.Columns.Add("Modelo do Veiculo", -2, HorizontalAlignment.Left);
            listagemVeicLeve.Columns.Add("Ano do veiculo", -2, HorizontalAlignment.Left);
            listagemVeicLeve.Columns.Add("Valor para Locação", -2, HorizontalAlignment.Left);
             listagemVeicLeve.Columns.Add("Cor do Veiculo", -2, HorizontalAlignment.Left);
            listagemVeicLeve.FullRowSelect = true;
            listagemVeicLeve.GridLines = true;
            listagemVeicLeve.AllowColumnReorder = true;
            listagemVeicLeve.Sorting = SortOrder.Ascending;

            ListViewItem item = new ListViewItem("1");

            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            listagemVeicLeve.Items.Add(item);





            btnConfirmar = new LibsButtons("Confirmar Cadastro", new Point(18, 550), new Size(200, 30));
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);


            //Criando botões
            btnCancelar = new LibsButtons("Cancelar", new Point(230, 550), new Size(200, 30));
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);


            pictureListarVeicLeve = new PictureBox();
            pictureListarVeicLeve.Size = new Size(600, 600);
            pictureListarVeicLeve.Location = new Point(0, 0);
            pictureListarVeicLeve.Load("Images\\Logo_rent_vehicles.png");
            pictureListarVeicLeve.SizeMode = PictureBoxSizeMode.Normal;



            this.Size = new Size(600, 450);



            this.Controls.Add(listagemVeicLeve);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);

            this.Controls.Add(pictureListarVeicLeve);

        }

        private void btnConfirmarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Listagem Executada?", "Listagem de Veiculos Leves", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Listagem de Veiculos Leves executada com sucesso!");
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Listagem não concluída!");
            }
            else
            {
                MessageBox.Show("Opção desconhecida!");
            }
            this.Close();

        }

        private void btnCancelarClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar e sair da listagem?", "Listagem de Veiculos Leves", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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