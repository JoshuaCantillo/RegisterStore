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
    public partial class frmTiendas : Form
    {
        public string antiguo;


        public frmTiendas()
        {
            InitializeComponent();
            resetear();
        }


        public void resetear()
        {

            txtbuscar.Text = "";

            txtbuscar.Focus();

            buscar_tienda("");

            txtnombre.Enabled = false;
            txtdireccion.Enabled = false;
            txttelefono.Enabled = false;

            txtnombre.PlaceholderText = "NOMBRE TIENDA";
            txtdireccion.PlaceholderText = "ej. Cll # s # 0-0";
            txttelefono.PlaceholderText = "ej. 3101111111";

            bteditar.Enabled = true;
            bteliminar.Enabled = true;
            btagregar.Enabled = true;

            bteditar.Text = "EDITAR";
            btagregar.Text = "AGREGAR";
            bteliminar.Text = "ELIMINAR";

            this.ActiveControl = txtbuscar;

        }

        public void buscar_tienda(string arg)
        {
            Tiendas tiendas = new Tiendas();
            Dashboard ds = Owner as Dashboard;
            //Asignando los datos al datagrid

            tbtiendas.DataSource = null;
            tbtiendas.DataSource = tiendas.buscar_tienda(arg);

            //Ocultando las columnas inecesarias

            tbtiendas.Columns[0].Visible = false;



            int total = tbtiendas.RowCount;
            lbcontador.Text = total.ToString();


            llenar_campos(0);
        }

        public void llenar_campos(int index)
        {
            if (tbtiendas.RowCount != 0)
            {
                lbid.Text = tbtiendas.Rows[index].Cells[0].Value.ToString();
                txtnombre.Text = tbtiendas.Rows[index].Cells[1].Value.ToString();
                txtdireccion.Text = tbtiendas.Rows[index].Cells[2].Value.ToString();
                txttelefono.Text = tbtiendas.Rows[index].Cells[3].Value.ToString();

                antiguo = tbtiendas.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == Convert.ToChar(Keys.Delete)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            if (btagregar.Text.Equals("AGREGAR"))
            {
                tbtiendas.Enabled = false;

                txtnombre.Text = "";
                txtdireccion.Text = "";
                txttelefono.Text = "";


                txtnombre.Enabled = true;
                txtdireccion.Enabled = true;
                txttelefono.Enabled = true;

                txtnombre.PlaceholderText = "NOMBRE TIENDA";
                txtdireccion.PlaceholderText = "ej. Cll # s # 0-0";
                txttelefono.PlaceholderText = "ej. 3101111111";


                txtnombre.Focus();

                btagregar.Text = "GUARDAR";

            }
            else
            {
                string nombre = txtnombre.Text.ToUpper();
                string direccion = txtdireccion.Text.ToUpper();
                string telefono = txttelefono.Text.ToUpper();

                Tiendas tiendas = new Tiendas();

                tiendas.Nombre = nombre;
                tiendas.Direccion = direccion;
                tiendas.Telefono = telefono;

                if (tiendas.crear_tienda())
                {
                    MessageBox.Show("Se creó la tienda correctamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetear();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al crear la tienda,intente nuevamente por favor", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resetear();
                }
            }
        }

        private void tbtiendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenar_campos(e.RowIndex);
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            if (bteditar.Text.Equals("EDITAR"))
            {
                txtnombre.Enabled = true;
                txtdireccion.Enabled = true;
                txttelefono.Enabled = true;

                btagregar.Enabled = false;
                bteliminar.Enabled = false;

                bteditar.Text = "GUARDAR";

                txtnombre.Focus();

                tbtiendas.Enabled = false;
            }
            else
            {
                int id = Int32.Parse(lbid.Text);
                string nombre = txtnombre.Text.ToUpper();
                string direccion = txtdireccion.Text.ToUpper();
                string telefono = txttelefono.Text.ToUpper();

                Tiendas tiendas = new Tiendas();

                tiendas.Idtienda = id;
                tiendas.Nombre = nombre;
                tiendas.Direccion = direccion;
                tiendas.Telefono = telefono;
                tiendas.Antiguo = antiguo;

                if (tiendas.modificar_tienda())
                {
                    MessageBox.Show("Se modificó la tienda correctamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetear();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al modificar la tienda,intente nuevamente por favor", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            if (bteliminar.Text.Equals("ELIMINAR"))
            {
                btagregar.Enabled = false;
                bteditar.Enabled = false;

                tbtiendas.Enabled = false;

                bteliminar.Text = "CONFIRMAR";

            }
            else if (bteliminar.Text.Equals("CONFIRMAR")) 
            {
                if (MessageBox.Show("¿Desea eliminar la tienda?", "RegisterStore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string nombre = txtnombre.Text;
                    int id = Int32.Parse(lbid.Text);

                    Tiendas tiendas = new Tiendas();

                    tiendas.Idtienda = id;
                    tiendas.Nombre = nombre;

                    if (tiendas.eliminar_tienda())
                    {
                        MessageBox.Show("Se eliominó la tienda correctamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetear();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar la tienda,intente nuevamente por favor", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            resetear();
        }
    }
}
