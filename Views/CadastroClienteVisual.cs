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

            this.Text = "Cadastro de Cliente";      //Inserindo titulo da página
            this.BackColor = Color.LightBlue;
            Label lblNome = new Label();
            lblNome.Text = "Nome do cliente:";           //Inserindo nome do cliente
            lblNome.Location = new Point(20, 15);             //Trabalhando com a localização da string inserida acima
            lblNome.Size = new Size(300, 40);                     //Trabalhando com o tamanho do valor inserido

            TextBox txtNome = new TextBox();                  //TextBox cria caixas para inserção de texto
            txtNome.Location = new Point(20, 60);               //Trabalhando com a localização da caixa de texto
            txtNome.Size = new Size(200, 80);                        //Trabalhando com o tamanho da caixa de texto



            //Visual Cadastrar data de nascimento 


            Label lblDtNascimento = new Label();
            lblDtNascimento.Text = "Data de Nascimento:";
            lblDtNascimento.Location = new Point(20, 100);
            lblDtNascimento.Size = new Size(500, 40);

            TextBox txtDataNascimento = new TextBox();
            txtDataNascimento.Location = new Point(20, 150);
            txtDataNascimento.Size = new Size(200, 80);

            //Visual Cadastrar CPF 

            Label lblCpf = new Label();
            lblCpf.Text = "CPF do Cliente:";
            lblCpf.Location = new Point(20, 200);
            lblCpf.Size = new Size(300, 40);

            TextBox txtCpf = new TextBox();
            txtCpf.Location = new Point(20, 250);
            txtCpf.Size = new Size(200, 80);


            //Visual Cadastrar Dias para Devolução

            Label lblDiasDevolução = new Label();
            lblDiasDevolução.Text = "Dias para Devolução:";
            lblDiasDevolução.Location = new Point(20, 300);
            lblDiasDevolução.Size = new Size(300, 40);

            TextBox txtDiasDevolução = new TextBox();
            txtDiasDevolução.Location = new Point(20, 360);
            txtDiasDevolução.Size = new Size(200, 80);


            //Visual Botão de confirmação

            Button btnConfirmar = new Button();     //Criando botões
            btnConfirmar.Text = "Confirmar Cadastro";
            btnConfirmar.Size = new Size(200, 30);
            btnConfirmar.Location = new Point(18, 450);

            Button btnCancelar = new Button();     //Criando botões
            btnCancelar.Text = "Cancelar";
            btnCancelar.Size = new Size(200, 30);
            btnCancelar.Location = new Point(230, 450);

            this.Size = new Size(900, 450);     //Trabalhando com o tamanho da janela   

            this.Controls.Add(lblNome);         //Chamando e adicionando os métodos acima 
            this.Controls.Add(txtNome);
            this.Controls.Add(lblDtNascimento);
            this.Controls.Add(txtDataNascimento);
            this.Controls.Add(lblCpf);
            this.Controls.Add(txtCpf);
            this.Controls.Add(lblDiasDevolução);
            this.Controls.Add(txtDiasDevolução);


            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);




        }
    }
}
