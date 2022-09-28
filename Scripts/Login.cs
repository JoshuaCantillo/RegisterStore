using RegisterStore.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterStore.Scripts
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            resetear();
        }

        public void resetear()
        {
            txtusuario.Text = "";
            txtclave.Text = "";
            lberror.Visible = false;

            this.ActiveControl = txtusuario;
        }

        private void btingresar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            try
            {
                usuarios.Nombre = txtusuario.Text;
                usuarios.Clave = txtclave.Text;
                if (usuarios.login())
                {
                    Dashboard ds = new Dashboard();
                    ds.Visible = true;
                    ds.txtusuario.Text = txtusuario.Text.ToUpper()+ " / " + usuarios.obtener_tipo().ToUpper();
                    string tienda = usuarios.obtener_tienda();
                    ds.lbtienda.Text = tienda;
                    ds.tienda = tienda;
                    this.Dispose(false);
                }
                else
                {
                    lberror.Visible = true;
                    txtusuario.Text = "";
                    txtclave.Text = "";
                    txtusuario.Focus();
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Ocurrió el siguiente error al iniciar sesión: " + ex.ToString());
            }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btingresar.PerformClick();
            }

        }

        private void btver_Click(object sender, EventArgs e)
        {
            if (txtclave.UseSystemPasswordChar == true)
            {
                txtclave.UseSystemPasswordChar = false;
            }
            else
            {
                txtclave.UseSystemPasswordChar = true;
            }
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btingresar.PerformClick();
            }
        }
    }
}
