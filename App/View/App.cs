using App.Controller;
using System;
using System.Windows.Forms;

namespace App
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTestarCnx_Click(object sender, EventArgs e)
        {
            var usuario = txtBoxUser.Text;
            var password = txtBoxPswd.Text;

            ConexaoFtp.TestarConexao(usuario, password);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            try
            {
                App app = new App();
                var sim = System.Windows.Forms.DialogResult.Yes;
                var mensagem = "Deseja sair?";
                var caption = "Builder";
                MessageBoxButtons botoes = MessageBoxButtons.YesNo;

                var resposta = MessageBox.Show(mensagem, caption, botoes);

                if (resposta == sim)
                    Application.Exit();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
