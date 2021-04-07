using System;
using System.Windows.Forms;
using System.Drawing;

namespace Programa
{
    public class CadastroClienteVisual : Form
    {
        public CadastroClienteVisual()
        {
            //Visual Cadastrar Nome do cliente

            this.Text = "Cadastro de Cliente";
            Label lblTitulo = new Label();
            lblTitulo.Text = "Nome do cliente:";
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Size = new Size(300,40);

            TextBox txtUsuario = new TextBox();
            txtUsuario.Location = new Point(180,60);
            txtUsuario.Size = new Size(200,80);

            lblTitulo.Text = "Nome do cliente:";
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Size = new Size(300,40);



            //Visual Cadastrar data de nascimento 

            Label lblDtNascimento = new Label();
            lblDtNascimento.Text = "Data de Nascimento:";
            lblDtNascimento.Location = new Point(20, 20);
            lblDtNascimento.Size = new Size(300,40);

            TextBox txtDataNascimento = new TextBox();
            txtDataNascimento.Location = new Point(180,60);
            txtDataNascimento.Size = new Size(200,80);

            lblDtNascimento.Text = "Data de nascimento:";
            lblDtNascimento.Location = new Point(20, 20);
            lblDtNascimento.Size = new Size(300,40);
            

           




            
            //Visual Botão de confirmação
            
            Button btnConfirmar = new Button();
            btnConfirmar.Text = "Confirmar Cadastro";
            btnConfirmar.Size = new Size(200,30);
            btnConfirmar.Location = new Point(180,360);
            
            this.Size = new Size(900, 450);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(txtUsuario);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(lblDtNascimento);
            this.Controls.Add(txtDataNascimento);



        }
    }
}
