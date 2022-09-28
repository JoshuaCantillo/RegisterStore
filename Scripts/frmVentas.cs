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
    public partial class frmVentas : Form
    {

        public string tienda;

        public frmVentas(string tienda)
        {
            InitializeComponent();
            this.tienda = tienda;

            resetear();
        }

        public void resetear()
        {
            txttotal.Text = "$ 0";
            txtsubtotal.Text = "$ 0";
            txtdescuentoventa.Text = "0 %";

            cbestado.SelectedIndex = 0;
            txtabono.Text = "$ 0";

            cbmedio.SelectedIndex = 0;
            txtreferencia.Text = "NO APLICA";

            btconfirmar.Enabled = false;
            bteditar.Enabled = false;
            bteliminar.Enabled = false;

            txtdescuentoventa.Enabled = false;
            cbestado.Enabled = false;
            txtabono.Enabled = false;

            cbmedio.Enabled = false;
            txtreferencia.Enabled = false;



            buscar_producto("");
            limpiar_tabla();

            this.ActiveControl = txtbuscar;
        }


        public string eliminar_formato(string texto)
        {
            string noFormat="";

            string[] charsToRemove = new string[] { "@", ".", ";", "'" ,"%","$"," "};
            foreach (var c in charsToRemove)
            {
                texto = texto.Replace(c, string.Empty);
            }

            noFormat = texto;

            return noFormat;
        }


        public void limpiar_tabla()
        {
            if (tbventa.RowCount != 0)
            {
                int index = 0;
                for (int i = 0; i < tbventa.RowCount; i++)
                {
                    tbventa.Rows.RemoveAt(index);
                    index += 1;
                }
                limpiar_tabla();
            }
        }
        public void buscar_producto(string arg)
        {
            Ventas ventas = new Ventas();
            //Asignando los datos al datagrid
            ventas.Tienda = tienda;
            tbproductos.DataSource = null;
            tbproductos.DataSource = ventas.buscar_producto(arg);

            //Ocultando las columnas inecesarias

            tbproductos.Columns[0].Visible = false;



            int total = tbproductos.RowCount;
            lbcontador.Text = total.ToString();

        }

        public void sumar()
        {
            int length = tbventa.Rows.Count;
            if (length != 0)
            {
                float total = 0;
                float subtotal = 0;

                for (int i = 0; i < length; i++)
                {
                    float tot = float.Parse(eliminar_formato(tbventa.Rows[i].Cells[9].Value.ToString()));
                    float sub = float.Parse(eliminar_formato(tbventa.Rows[i].Cells[10].Value.ToString()));

                    total += tot;
                    subtotal += sub;
                }

                float descuentoTotal = 0;
                if (!txtdescuentoventa.Text.Equals(""))
                {
                    descuentoTotal = float.Parse(eliminar_formato(txtdescuentoventa.Text)) / 100;
                }

                subtotal = subtotal - (subtotal * descuentoTotal);

                txttotal.Text = "$ " + total.ToString("N", new CultureInfo("es-CO"));
                txtsubtotal.Text = "$ " + subtotal.ToString("N", new CultureInfo("es-CO"));
            }
        }


        public bool recorrer_tabla()
        {
            bool respuesta = false;
            for (int i = 0; i < tbventa.Rows.Count; i++)
            {
                Ventas ventas = new Ventas();

                ventas.Idproducto = Int32.Parse(tbventa.Rows[i].Cells[0].Value.ToString());

                ventas.Unidades= Int32.Parse(tbventa.Rows[i].Cells[7].Value.ToString());

                ventas.Total = float.Parse(tbventa.Rows[i].Cells[9].Value.ToString());

                ventas.Subtotal = float.Parse(tbventa.Rows[i].Cells[10].Value.ToString());

                ventas.Descuento = Int32.Parse(tbventa.Rows[i].Cells[8].Value.ToString());

                ventas.Estado = cbestado.SelectedItem.ToString();

                if (ventas.registrar_subventa())
                {
                    respuesta = true;
                }

            }

            return respuesta;
        }


        public void enviar(int index)
        {
            

            string id = tbproductos.Rows[index].Cells[0].Value.ToString();
            string codigo = tbproductos.Rows[index].Cells[1].Value.ToString();
            string nombre = tbproductos.Rows[index].Cells[2].Value.ToString();
            string laboratorio = tbproductos.Rows[index].Cells[3].Value.ToString();
            string presentacion = tbproductos.Rows[index].Cells[4].Value.ToString();
            string cantidad = tbproductos.Rows[index].Cells[5].Value.ToString();
            string precio = tbproductos.Rows[index].Cells[6].Value.ToString();
            string stock = tbproductos.Rows[index].Cells[7].Value.ToString();
            string tienda = tbproductos.Rows[index].Cells[8].Value.ToString();

            string unidades = "1";
            string descuento = "0";
            string total = precio;
            string subtotal = precio;

            if (Int32.Parse(unidades) < Int32.Parse(stock))
            {
                bool rt = false;
                if (tbventa.RowCount != 0)
                {
                    for (int i = 0; i < tbventa.Rows.Count; i++)
                    {
                        string idproducto = tbventa.Rows[i].Cells[0].Value.ToString();
                        if (id == idproducto)
                        {
                            rt = true;
                        }
                    }
                }

                if (rt == false)
                {
                    if (tbventa.DataSource == null)
                    {
                        DataTable tabla = new DataTable();

                        //Diseño de la cabecera de la tabla 

                        tabla.Columns.Add("IdProducto", typeof(string));
                        tabla.Columns.Add("Código", typeof(string));
                        tabla.Columns.Add("Nombre", typeof(string));
                        tabla.Columns.Add("Laboratorio", typeof(string));
                        tabla.Columns.Add("Presentación", typeof(string));
                        tabla.Columns.Add("Cantidad", typeof(string));
                        tabla.Columns.Add("Precio", typeof(string));
                        tabla.Columns.Add("Unidades", typeof(string));
                        tabla.Columns.Add("Descuento", typeof(string));
                        tabla.Columns.Add("Total", typeof(string));
                        tabla.Columns.Add("Subtotal", typeof(string));

                        tabla.Rows.Add(id, codigo, nombre, laboratorio, presentacion, cantidad, precio, unidades, descuento, total, subtotal);

                        tbventa.DataSource = tabla;

                        tbventa.Columns[0].Visible = false;

                        btconfirmar.Enabled = true;
                        txtdescuentoventa.Enabled = true;

                    }
                    else
                    {

                        DataTable dt = new DataTable();
                        dt = tbventa.DataSource as DataTable;
                        DataRow dr;
                        dr = dt.NewRow();
                        dr["IdProducto"] = id;
                        dr["Código"] = codigo;
                        dr["Nombre"] = nombre;
                        dr["Laboratorio"] = laboratorio;
                        dr["Presentación"] = presentacion;
                        dr["Cantidad"] = cantidad;
                        dr["Precio"] = precio;
                        dr["Unidades"] = unidades;
                        dr["Descuento"] = descuento;
                        dr["Total"] = total;
                        dr["Subtotal"] = subtotal;

                        dt.Rows.Add(dr);
                    }
                    btconfirmar.Enabled = true;

                    cbestado.Enabled = true;

                    cbmedio.Enabled = true;

                }
                else
                {
                    MessageBox.Show("El producto seleccionado ya se encuentra relacionado con la venta", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sumar();
            }
            else
            {
                MessageBox.Show("No hay existencias del producto seleccionado,por favor verifique", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbestado.SelectedItem.ToString().Equals("ABONADO"))
            {
                txtabono.Enabled = true;
                txtabono.Focus();
            }
        }

        private void txtabono_Leave(object sender, EventArgs e)
        {

            int abono = int.Parse(eliminar_formato(txtabono.Text));            

            float subtotal = float.Parse(eliminar_formato(txtsubtotal.Text));
            if (abono>subtotal)
            {
                MessageBox.Show("El valor del abono no puede ser superior al subtotal de la compra", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtabono.Text = "$ 0";
            }
            else
            {
                txtabono.Text = "$" + abono.ToString();
            }
        }

        private void txtdescuentoventa_Leave(object sender, EventArgs e)
        {
            int descuento = int.Parse(eliminar_formato(txtdescuentoventa.Text));
            if (descuento>100)
            {
                MessageBox.Show("El descuento no puede ser mayor a un 100%", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdescuentoventa.Text = "0 %";
                sumar();

            }
            else
            {
                sumar();
                txtdescuentoventa.Text = descuento.ToString() + " %";
            }
        }

        private void cbmedio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbmedio.SelectedItem.ToString().Equals("EFECTIVO"))
            {
                txtreferencia.Enabled = true;
                txtreferencia.Focus();
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            resetear();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_producto(txtbuscar.Text);
        }

        private void tbproductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            enviar(tbproductos.CurrentRow.Index);
        }

        private void tbventa_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Ventas ventas = new Ventas();

            ventas.Idproducto = int.Parse(tbventa.Rows[e.RowIndex].Cells[0].Value.ToString());
            int precio = int.Parse(tbventa.Rows[e.RowIndex].Cells[6].Value.ToString());
            int unidades = int.Parse(tbventa.Rows[e.RowIndex].Cells[7].Value.ToString());
            float descuento = float.Parse(tbventa.Rows[e.RowIndex].Cells[8].Value.ToString()) / 100;

            int stock = ventas.obtener_stock();
            if (unidades<=stock && unidades>0)
            {
                if (descuento > 1)
                {
                    MessageBox.Show("El descuento ingresado no es valido, por favor verifique", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbproductos.Rows[e.RowIndex].Cells[8].Value = "0";
                    descuento = 0;
                }
                int total = precio * unidades;
                descuento = total * descuento;
                float subtotal = total - descuento;
                tbventa.Rows[e.RowIndex].Cells[9].Value = total.ToString();
                tbventa.Rows[e.RowIndex].Cells[10].Value = subtotal.ToString();

                sumar();
            }
            else
            {
                MessageBox.Show("No hay suficientes exsistencias del producto por favor verifique la cantidad", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbventa.Rows[e.RowIndex].Cells[7].Value = "1";
            }
            
        }

        private void txtdescuentoventa_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbventa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
            {
                if (MessageBox.Show("DESEA DESASOCIAR EL PRODUCTO SELECCIONADO DEL PEDIDO ACTUAL", "RegisterStore", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tbventa.Rows.RemoveAt(tbventa.CurrentRow.Index);
                }
                if (tbventa.Rows.Count == 0)
                {
                    resetear();
                }
            }
        }

        private void btconfirmar_Click(object sender, EventArgs e)
        {
            float total = float.Parse(eliminar_formato(txttotal.Text));
            float subtotal = float.Parse(eliminar_formato(txtsubtotal.Text));
            int descuento = int.Parse(eliminar_formato(txtdescuentoventa.Text));

            string estado = cbestado.SelectedItem.ToString();
            int abono = int.Parse(eliminar_formato(txtabono.Text));

            string medio = cbmedio.SelectedItem.ToString();
            string referencia = txtreferencia.Text;


            string hora = DateTime.Now.ToString("hh:mm tt");
            string fecha = DateTime.Now.ToShortDateString();


            if (estado.Equals("PAGADO"))
            {
                descuento = 0;
            }

            if (medio.Equals("EFECTIVO"))
            {
                referencia = "NO APLICA";
            }

            if (total>0 && subtotal>=0)
            {
                Ventas ventas = new Ventas();

                ventas.Fecha = fecha;
                ventas.Hora = hora;
                ventas.Total = total;
                ventas.Subtotal = subtotal;
                ventas.Descuento = descuento;
                ventas.Abono = abono;
                ventas.Medio = medio;
                ventas.Referencia = referencia;
                ventas.Estado = estado;
                ventas.Tienda = tienda;

                try
                {
                    if (ventas.registrar_venta())
                    {
                        if (recorrer_tabla())
                        {
                            MessageBox.Show("Se registró correctamente la venta", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al registrar la venta,intente nuevamente por favor", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió el siguiente error al registrar la venta: "+ex.ToString(), "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (tbproductos.Rows.Count == 1)
                {
                    enviar(0);
                }
            }
        }
    }
}
