using System;
using System.Windows.Forms;
using System.Drawing;

namespace Programa
{
    public class VisualMenu : Form
    {
        public VisualMenu()
        {
            this.Text = "Titulo da Janela";
            Label lblTitulo = new Label();
            lblTitulo.Text = "Nome";
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Size = new Size(300,40);

            TextBox txtUsuario = new TextBox();
            txtUsuario.Location = new Point(180,60);
            txtUsuario.Size = new Size(100,18);

            Button btnConfirmar = new Button();
            btnConfirmar.Text = "Conirmar";
            btnConfirmar.Size = new Size(100,30);
            btnConfirmar.Location = new Point(180,360);
            //btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);







            this.Size = new Size(900, 450);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(txtUsuario);
            this.Controls.Add(btnConfirmar);


        }
    }
}