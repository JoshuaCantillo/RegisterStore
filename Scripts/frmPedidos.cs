using RegisterStore.Logic;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace RegisterStore.Scripts
{
    public partial class frmPedidos : Form
    {


        public string tienda;

        public string accion;


        public string hora;
        public string fecha;





        public frmPedidos(string tienda)
        {
            InitializeComponent();
            this.tienda = tienda;
            resetear();
        }

        public void resetear()
        {
            buscar_proveedor("");

            txtbuscar.Text = "";

            txtbuscar.Focus();

            int conteo = tbproveedores.Rows.Count;
            limpiar_tabla();

            btconfirmar.Enabled = false;

            txttotal.Text = "$ 0";
            txtsubtotal.Text = "$ 0";
            txtdescuento.Text = "0";
            txtbuscar.Enabled = true;

            bteditar.Text = "EDITAR";
            bteliminar.Text = "ELIMINAR";

            btconfirmar.Enabled = false;
            bteditar.Enabled = false;
            bteliminar.Enabled = false;
            btañadir.Enabled = true;
            btbuscar.Enabled = true;
            cbestado.Enabled = false;
            txtdescuento.ReadOnly = true;
            txttotal.ReadOnly = true;
            txtsubtotal.ReadOnly = true;

            accion = "nuevo";


            if (tbproveedores.Rows.Count != 0)
            {
                lbidproveedor.Text = tbproveedores.Rows[0].Cells[0].Value.ToString();
            }
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

        public void limpiar_tabla()
        {
            if (tbproductos.RowCount != 0)
            {
                int index = 0;
                for (int i = 0; i < tbproductos.RowCount; i++)
                {
                    tbproductos.Rows.RemoveAt(index);
                    index += 1;
                }
                limpiar_tabla();
            }
        }

        public void buscar_proveedor(string arg)
        {
            Proveedores proveedores = new Proveedores();
            //Asignando los datos al datagrid

            tbproveedores.DataSource = null;
            tbproveedores.DataSource = proveedores.buscar_proveedor(arg);

            //Ocultando las columnas inecesarias

            tbproveedores.Columns[0].Visible = false;



            int total = tbproveedores.RowCount;
            lbcontador.Text = total.ToString();

        }


        public void sumar()
        {
            int length = tbproductos.Rows.Count;
            if (length != 0)
            {
                float total = 0;
                float subtotal = 0;
                for (int i = 0; i < length; i++)
                {
                    float tot = float.Parse(tbproductos.Rows[i].Cells[9].Value.ToString());
                    float sub = float.Parse(tbproductos.Rows[i].Cells[10].Value.ToString());

                    total += tot;
                    subtotal += sub;
                }

                float descuentoTotal = 0;
                if (!txtdescuento.Text.Equals(""))
                {
                    descuentoTotal = float.Parse(txtdescuento.Text) / 100;
                }

                subtotal = subtotal - (subtotal * descuentoTotal);

                txttotal.Text = "$ " + total.ToString("N", new CultureInfo("es-CO"));
                txtsubtotal.Text = "$ " + subtotal.ToString("N", new CultureInfo("es-CO"));
            }
        }



        public bool recorrer_tabla(string funcion)
        {
            bool respuesta = false;

            Pedidos pedidos = new Pedidos();

            if (funcion.Equals("editar"))
            {


                pedidos.Idpedido = Int32.Parse(lbidpedido.Text);

                if (pedidos.eliminar_subpedido())
                {
                    for (int i = 0; i < tbproductos.Rows.Count; i++)
                    {

                        pedidos.Iproveedor = Int32.Parse(lbidproveedor.Text);

                        pedidos.Idproducto = Int32.Parse(tbproductos.Rows[i].Cells[0].Value.ToString());



                        pedidos.Unidades = Int32.Parse(tbproductos.Rows[i].Cells[7].Value.ToString());
                        pedidos.Compra = Int32.Parse(tbproductos.Rows[i].Cells[6].Value.ToString());
                        pedidos.Descuento = Int32.Parse(tbproductos.Rows[i].Cells[8].Value.ToString());
                        pedidos.Total = Int32.Parse(tbproductos.Rows[i].Cells[9].Value.ToString());
                        pedidos.Subtotal = Int32.Parse(tbproductos.Rows[i].Cells[10].Value.ToString());

                        pedidos.Estado = cbestado.SelectedItem.ToString();

                        if (pedidos.modificar_subpedido())
                        {
                            respuesta = true;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < tbproductos.Rows.Count; i++)
                    {

                        pedidos.Iproveedor = Int32.Parse(lbidproveedor.Text);

                        pedidos.Idproducto = Int32.Parse(tbproductos.Rows[i].Cells[0].Value.ToString());



                        pedidos.Unidades = Int32.Parse(tbproductos.Rows[i].Cells[7].Value.ToString());
                        pedidos.Compra = Int32.Parse(tbproductos.Rows[i].Cells[6].Value.ToString());
                        pedidos.Descuento = Int32.Parse(tbproductos.Rows[i].Cells[8].Value.ToString());
                        pedidos.Total = Int32.Parse(tbproductos.Rows[i].Cells[9].Value.ToString());
                        pedidos.Subtotal = Int32.Parse(tbproductos.Rows[i].Cells[10].Value.ToString());

                        pedidos.Estado = cbestado.SelectedItem.ToString();

                        if (pedidos.registrar_subpedido())
                        {
                            respuesta = true;
                        }
                    }
                }
            }
            return respuesta;
        }


        private void btañadir_Click(object sender, EventArgs e)
        {
            subbuscarProductos addProductos = new subbuscarProductos("pedidos", tienda, Int32.Parse(lbidproveedor.Text));
            AddOwnedForm(addProductos);
            addProductos.ShowDialog();
        }

        private void tbproveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbidproveedor.Text = tbproveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
            limpiar_tabla();
            txttotal.Text = "$ 0";
            txtsubtotal.Text = "$ 0";
            txtdescuento.Text = "0";
        }

        private void tbproductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int precio = int.Parse(tbproductos.Rows[e.RowIndex].Cells[6].Value.ToString());
            int unidades = int.Parse(tbproductos.Rows[e.RowIndex].Cells[7].Value.ToString());
            float descuento = float.Parse(tbproductos.Rows[e.RowIndex].Cells[8].Value.ToString()) / 100;
            if (descuento > 1)
            {
                MessageBox.Show("El descuento ingresado no es valido, por favor verifique", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbproductos.Rows[e.RowIndex].Cells[8].Value = "0";
                descuento = 0;
            }
            int total = precio * unidades;
            descuento = total * descuento;
            float subtotal = total - descuento;
            tbproductos.Rows[e.RowIndex].Cells[9].Value = total.ToString();
            tbproductos.Rows[e.RowIndex].Cells[10].Value = subtotal.ToString();

            sumar();
        }

        private void txtdescuento_Leave(object sender, EventArgs e)
        {
            sumar();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_proveedor(txtbuscar.Text);
        }

        private void btconfirmar_Click(object sender, EventArgs e)
        {
            if (tbproductos.RowCount > 0)
            {
                try
                {
                    Dashboard ds = Owner as Dashboard;
                    Pedidos pedidos = new Pedidos();

                    string total = txttotal.Text;
                    string subtotal = txtsubtotal.Text;
                    total = total.Replace("$", string.Empty);
                    subtotal = subtotal.Replace("$", string.Empty);

                    total = total.Replace(" ", string.Empty);
                    subtotal = subtotal.Replace(" ", string.Empty);

                    pedidos.Iproveedor = Int32.Parse(lbidproveedor.Text);
                    pedidos.Total = float.Parse(total);
                    pedidos.Subtotal = float.Parse(subtotal);
                    pedidos.Fecha = fecha;
                    pedidos.Hora = hora;
                    pedidos.Estado = cbestado.SelectedItem.ToString();
                    pedidos.Descuento = Int32.Parse(txtdescuento.Text);

                    if (cbestado.SelectedItem.ToString().Equals("PAGADO"))
                    {
                        pedidos.Pago = pedidos.Fecha;
                    }
                    else if (cbestado.SelectedItem.ToString().Equals("PENDIENTE"))
                    {
                        pedidos.Fecha = "SIN CONFIRMAR";
                        pedidos.Hora = "SIN CONFIRMAR";
                    }
                    else
                    {
                        pedidos.Pago = "PENDIENTE";
                    }

                    pedidos.Tienda = tienda;


                    if (pedidos.registrar_pedido())
                    {
                        if (recorrer_tabla("registrar"))
                        {
                            MessageBox.Show("Se registró el pedido correctamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            resetear();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al registrar el pedido,por favor intente nuevamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al registrar el pedido,por favor intente nuevamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió el siguiente error: " + ex.ToString(), "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbproductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
            {
                if (MessageBox.Show("DESEA DESASOCIAR EL PRODUCTO SELECCIONADO DEL PEDIDO ACTUAL", "RegisterStore", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tbproductos.Rows.RemoveAt(tbproductos.CurrentRow.Index);
                }
            }
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            accion = "EDITAR";
            subfrmPedidos subpedidos = new subfrmPedidos(tienda);
            AddOwnedForm(subpedidos);
            subpedidos.ShowDialog();
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            if (bteditar.Text.Equals("EDITAR"))
            {
                if (!cbestado.SelectedItem.ToString().Equals("RECIBIDO") || !cbestado.SelectedItem.ToString().Equals("PAGADO"))
                {
                    tbproductos.Enabled = true;
                    btañadir.Enabled = true;
                    bteliminar.Enabled = false;

                    txtdescuento.ReadOnly = false;

                    cbestado.Enabled = true;

                    bteditar.Text = "GUARDAR";
                }


            }
            else
            {
                if (tbproductos.RowCount > 0)
                {
                    Pedidos pedidos = new Pedidos();
                    pedidos.Idpedido = int.Parse(lbidpedido.Text);
                    pedidos.Total = float.Parse(eliminar_formato(txttotal.Text));
                    pedidos.Subtotal = float.Parse(eliminar_formato(txtsubtotal.Text));
                    pedidos.Descuento = int.Parse(eliminar_formato(txtdescuento.Text));
                    pedidos.Fecha = fecha;
                    pedidos.Hora = hora;
                    pedidos.Estado = cbestado.SelectedItem.ToString();
                    pedidos.Pago = fecha;

                    try
                    {
                        if (pedidos.modificar_pedido())
                        {
                            if (recorrer_tabla("editar"))
                            {
                                MessageBox.Show("Se modificó el pedido correctamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                resetear();
                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un error al modificar el pedido,por favor intente nuevamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al modificar el pedido,por favor intente nuevamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine(ex.ToString());
                    }
                }
            }
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            hora = DateTime.Now.ToString("hh:mm tt");
            fecha = DateTime.Now.ToShortDateString();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            resetear();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            if (bteliminar.Text.Equals("ELIMINAR"))
            {
                bteditar.Enabled = false;
                btañadir.Enabled = false;
                btbuscar.Enabled = false;
                btconfirmar.Enabled = false;

                txtdescuento.ReadOnly = true;
                txtbuscar.ReadOnly = true;

                tbproductos.Enabled = false;
                tbproveedores.Enabled = false;

                bteliminar.Text = "CONFIRMAR";

            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar el pedido?", "RegisterStore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Pedidos pedidos = new Pedidos();

                        pedidos.Idpedido = int.Parse(lbidpedido.Text);

                        if (pedidos.eliminar_pedido())
                        {
                            if (pedidos.eliminar_subpedido())
                            {
                                MessageBox.Show("Se eliminó correctamente el pedido", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un error al tratar de eliminar los productos del pedido", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al tratar de eliminar el pedido", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        resetear();
                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
    }
}
