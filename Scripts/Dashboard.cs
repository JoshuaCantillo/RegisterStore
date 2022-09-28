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
    public partial class Dashboard : Form
    {

        #region variables publicas
        public string tienda;


        #endregion

        public Dashboard()
        {
            InitializeComponent();
        }
        private void abrirForm(object frm)
        {
            if (this.pnescritorio.Controls.Count > 0)
            {
                this.pnescritorio.Controls.RemoveAt(0);
                Form sub = frm as Form;
                sub.TopLevel = false;
                sub.Dock = DockStyle.Fill;
                this.pnescritorio.Controls.Add(sub);
                this.pnescritorio.Tag = sub;    
                sub.Show();
            }
            else
            {
                Form sub = frm as Form;
                sub.TopLevel = false;
                sub.Dock = DockStyle.Fill;
                this.pnescritorio.Controls.Add(sub);
                this.pnescritorio.Tag = sub;
                sub.Show();
            }
        }

        public void resetearBotones()
        {
            btproductos.Checked = false;
            btproveedores.Checked = false;
            btpedidos.Checked = false;
            btventas.Checked = false;
            bttiendas.Checked = false;
            btusuarios.Checked = false;
        }

        private void btproductos_Click(object sender, EventArgs e)
        {
            resetearBotones();
            abrirForm(new frmProductos(tienda));
            btproductos.Checked = true;
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de cerrar la aplicación", "RegisterStore", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btproveedores_Click(object sender, EventArgs e)
        {
            resetearBotones();
            abrirForm(new frmProveedores(tienda));
            btproveedores.Checked = true;
        }

        private void btpedidos_Click(object sender, EventArgs e)
        {
            resetearBotones();
            abrirForm(new frmPedidos(tienda));
            btpedidos.Checked = true;
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm tt");
            lbfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            resetearBotones();
            abrirForm(new frmVentas(tienda));
            btventas.Checked = true;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            resetearBotones();
            abrirForm(new frmTiendas());
            bttiendas.Checked = true;
        }

        private void btusuarios_Click(object sender, EventArgs e)
        {
            resetearBotones();
            abrirForm(new frmUsuarios());
            btusuarios.Checked = true;
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la sesión actual", "RegisterStore", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Visible = true;
                this.Close();
            }
        }
    }
}
