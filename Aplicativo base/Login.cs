using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Aplicativo_base
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 158, this.Height / 2 - 124);
            pnlLogin.Visible = true;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(173, 216, 255);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(124, 216, 230);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChamarLogin();
            //codigo login! vef no MYSQL


        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void PnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cmdLogin.Text != "")
            {
                cmdSenha.Focus();
                Thread.Sleep(350);
                
            }
            if (e.KeyCode == Keys.Enter && cmdSenha.Text != "")
            {
                ChamarLogin();
               
            }

            if (e.KeyCode == Keys.Down)
            {
                cmdSenha.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                cmdLogin.Focus();
            }
        }
        private void ChamarLogin()
        {
            if (cmdLogin.Text == "" || cmdSenha.Text == "")
            {
                notifyIcon1.ShowBalloonTip(2000, "ERRO", "Não deixe os Campos Vazios!", ToolTipIcon.Info);
                return;
            }

            if (cmdLogin.Text == "teste" && cmdSenha.Text == "123")
            {
                Limpar();
                notifyIcon1.ShowBalloonTip(2000, "Sucesso", "Logado com Sucesso!", ToolTipIcon.Info);
                
            }
            else
            {
                notifyIcon1.ShowBalloonTip(2000, "ERRO", "Nome/Senha Invalida!", ToolTipIcon.Info);
                return;
            }
        }
        
        private void Limpar()
        {
            cmdLogin.Text = "";
            cmdSenha.Text = "";
            cmdLogin.Focus();
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 158, this.Height / 2 - 124);
        }
    }
}

