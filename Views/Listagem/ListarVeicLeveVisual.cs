using System;
using System.Windows.Forms;
using System.Drawing;
using Views.lib;
using System.Collections.Generic;

namespace Views
{
    public class ListarVeicLeveVisual : Form
    {

        private ListView listagemVeicLeve = new ListView();

        private Button btnConfirmar = new Button();  //Button cria os botões para ações de Click

        private Button btnCancelar = new Button();

        private PictureBox pictureBox = new PictureBox();

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

            listagemVeicLeve.Size = new Size(545,300);

            

           

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

            

            IEnumerable<Model.VeiculoLeve> veiculoLeves1 = Controller.VeiculoLeve.ListarVeicLeve();
            foreach (Model.VeiculoLeve veiculoLeve in veiculoLeves1){
           
            ListViewItem item = new ListViewItem(Convert.ToString(veiculoLeve.Id));

                item.SubItems.Add(veiculoLeve.Marca);
                item.SubItems.Add(veiculoLeve.Modelo);
                item.SubItems.Add(String.Format("{0:d}",veiculoLeve.Ano));
                item.SubItems.Add(Convert.ToString(veiculoLeve.Preco));
                item.SubItems.Add(veiculoLeve.Cor);
                
                listagemVeicLeve.Items.Add(item);
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



            this.Controls.Add(listagemVeicLeve);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);

            this.Controls.Add(pictureBox);

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