using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{

    public class Menu : Form
    {

        public Menu()
        {

            this.Text = "Menu Principal";
            this.BackColor = Color.LightBlue;
            
            //Cliente
            
            Button btnCadastrarCliente = new Button();     
            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.Size = new Size(200, 30);
            btnCadastrarCliente.Location = new Point(900, 100);
            btnCadastrarCliente.Click += new EventHandler(this.btnCadastrarClienteClick);


            Button btnListarCliente = new Button();     
            btnListarCliente.Text = "Listar Clientes";
            btnListarCliente.Size = new Size(200, 30);
            btnListarCliente.Location = new Point(900, 150);


            Button btnAtualizarCliente = new Button();    
            btnAtualizarCliente.Text = "Atualizar Clientes";
            btnAtualizarCliente.Size = new Size(200, 30);
            btnAtualizarCliente.Location = new Point(900, 200);

            
            Button btnRemoverCliente = new Button();     
            btnRemoverCliente.Text = "Remover Clientes";
            btnRemoverCliente.Size = new Size(200, 30);
            btnRemoverCliente.Location = new Point(900, 250);

            //Veiculo Pesado

            Button btnCadastroVeicPesado = new Button();     
            btnCadastroVeicPesado.Text = "Cadastrar Veicuo Pesado";
            btnCadastroVeicPesado.Size = new Size(200, 30);
            btnCadastroVeicPesado.Location = new Point(900, 300);









            
            
            
            
            this.Size = new Size(900, 450); 

            //Buttons Clientes

            this.Controls.Add(btnCadastrarCliente);
            this.Controls.Add(btnListarCliente);
            this.Controls.Add(btnAtualizarCliente);
            this.Controls.Add(btnRemoverCliente);

            

            //Buttons Veiculos Pesados

            this.Controls.Add(btnCadastroVeicPesado);
        }

            private void btnCadastrarClienteClick(object sender, EventArgs e){
                CadastroClienteVisual cadastroCliente = new CadastroClienteVisual();
                cadastroCliente.Show();
            }

    }
}
