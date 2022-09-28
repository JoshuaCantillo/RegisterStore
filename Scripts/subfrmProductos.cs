using RegisterStore.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterStore.Scripts
{
    public partial class subfrmProductos : Form
    {
        public string accion="";

        public subfrmProductos()
        {
            InitializeComponent();
        }

        public void resetear()
        {
            txtcodigo.Enabled = false;
            txtproducto.Enabled = false;

            txtlaboratorio.Enabled = false;
            txtpresentacion.Enabled = false;


            txtcantidad.Enabled = false;
            txtcompra.Enabled = false;

            txtventa.Enabled = false;
            txtiva.Enabled = false;

            accion = "";

            btguardar.Enabled = false;

            btguardar.FillColor = Color.Lime;
        }


        public string eliminar_formato(string texto)
        {
            string noFormat = "";

            string[] charsToRemove = new string[] { "@", ".", ";", "'", "%", "$", " " };
            foreach (var c in charsToRemove)
            {
                texto = texto.Replace(c, string.Empty);
            }

            noFormat = texto;

            return noFormat;
        }

        public void darFormato(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            try
            {

                string texto = textBox.Text;
                int valor = int.Parse(texto);
                string conversion = valor.ToString("N", new CultureInfo("es-CO"));
                String[] arreglo = conversion.Split(',');

                textBox.Text = arreglo[0];

            }
            catch (Exception ex)
            {
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            accion = "editar";

            bteditar.Enabled = false;
            bteliminar.Enabled = false;

            btguardar.Enabled = true;

            txtcodigo.Enabled = true;
            txtproducto.Enabled = true;

            txtlaboratorio.Enabled = true;
            txtpresentacion.Enabled = true;


            txtcantidad.Enabled = true;
            txtcompra.Enabled = true;

            txtventa.Enabled = true;
            txtiva.Enabled = true;


        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (accion!="" && txtproducto.Text!="" && txtlaboratorio.Text != "" && txtpresentacion.Text != "" && txtcompra.Text != "" && txtventa.Text != "" && txtcantidad.Text != "" && txtiva.Text != "")
            {
                Productos productos = new Productos();
                productos.Codigo = txtcodigo.Text;
                productos.Nombre = txtproducto.Text;
                productos.Laboratorio = txtlaboratorio.Text;
                productos.Presentacion = txtpresentacion.Text;
                productos.Cantidad = txtcantidad.Text;
                productos.Compra = Int32.Parse(eliminar_formato(txtcompra.Text));
                productos.Venta = Int32.Parse(eliminar_formato(txtventa.Text));
                productos.Iva = Int32.Parse(txtiva.Text);
                
                if (accion.Equals("editar"))
                {

                    productos.IdProducto = Int32.Parse(lbidproducto.Text);
                    if (productos.modificar_producto())
                    {
                        MessageBox.Show("Se modificó el producto exitosamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmProductos pro = Owner as frmProductos;
                        pro.resetear();
                    }
                }
                else if (accion.Equals("agregar"))
                {
                    if (productos.registrar_producto())
                    {
                        MessageBox.Show("Se agregó el producto exitosamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmProductos pro = Owner as frmProductos;
                        pro.resetear();
                    }
                }
                else if (accion.Equals("eliminar"))
                {
                    productos.IdProducto = Int32.Parse(lbidproducto.Text);
                    if (productos.eliminar_producto())
                    {
                        if (MessageBox.Show("¿Desea eliminar el producto?", "RegisterStore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            MessageBox.Show("Se eliminó el producto exitosamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            frmProductos pro = Owner as frmProductos;
                            pro.resetear();
                        }
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favo verifique los campos", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            accion = "eliminar";

            bteditar.Enabled = false;
            bteliminar.Enabled = false;

            btguardar.Enabled = true;
            btguardar.FillColor = Color.Red;
        }

        private void txtventa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcompra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtiva_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtventa_Leave(object sender, EventArgs e)
        {
            darFormato(txtventa);
        }

        private void txtcompra_Leave(object sender, EventArgs e)
        {
            darFormato(txtcompra);
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
