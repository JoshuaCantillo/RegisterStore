using RegisterStore.Logic;
using System;
using System.Windows.Forms;

namespace RegisterStore.Scripts
{
    public partial class frmProveedores : Form
    {
        public string tienda;
        public frmProveedores(string tienda)
        {
            InitializeComponent();
            this.tienda = tienda;

            resetear();
        }

        public void resetear()
        {
            txtbuscar.Text = "";
            txtbuscar.Focus();

            txtnombre.ReadOnly = true;
            txtlaboratorio.ReadOnly = true;
            cbtipo.Enabled = false;
            txtcelular.ReadOnly = true;

            btañadir.Enabled = false;
            btagregar.Enabled = true;
            bteditar.Enabled = true;
            bteliminar.Enabled = true;

            bteditar.Text = "Editar";
            btagregar.Text = "Agregar";
            bteliminar.Text = "Eliminar";

            txtnombre.Text = "";
            txtcelular.Text = "";
            txtlaboratorio.Text = "";
            txtbuscar.Text = "";

            tbproveedores.Enabled = true;
            limpiar_tabla();


            buscar_proveedor("");
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

            llenar_campos(0);
        }

        public void llenar_campos(int index)
        {
            if (tbproveedores.RowCount != 0)
            {
                string tipo = tbproveedores.Rows[index].Cells[2].Value.ToString();
                lbid.Text = tbproveedores.Rows[index].Cells[0].Value.ToString();
                txtnombre.Text = tbproveedores.Rows[index].Cells[1].Value.ToString();
                txtlaboratorio.Text = tbproveedores.Rows[index].Cells[3].Value.ToString();
                txtcelular.Text = tbproveedores.Rows[index].Cells[4].Value.ToString();

                cbtipo.SelectedItem = tipo;

                llenar_tabla(Int32.Parse(tbproveedores.Rows[index].Cells[0].Value.ToString()));
            }
        }


        public void llenar_tabla(int idproveedor)
        {
            Proveedores proveedores = new Proveedores();
            //Asignando los datos al datagrid

            tbproductos.DataSource = null;
            tbproductos.DataSource = proveedores.llenar_producto(idproveedor);

            //Ocultando las columnas inecesarias


            tbproductos.Columns[0].Visible = false;

            int total = tbproductos.RowCount;
            lbcontadorProductos.Text = total.ToString();

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


        public void enviar_productos(int id)
        {
            if (tbproductos.RowCount != 0)
            {
                Proveedores proveedores = new Proveedores();
                proveedores.Idproveedor = id;
                int index = 0;
                for (int i = 0; i < tbproductos.RowCount; i++)
                {
                    proveedores.Idproducto = Int32.Parse(tbproductos.Rows[index].Cells[0].Value.ToString());
                    proveedores.registrar_subproveedor();
                    index += 1;
                }
            }
        }

        private void btañadir_Click(object sender, EventArgs e)
        {
            subbuscarProductos addProductos = new subbuscarProductos("proveedores", tienda, Int32.Parse(lbid.Text));
            AddOwnedForm(addProductos);
            addProductos.ShowDialog();
        }

        private void tbproveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenar_campos(e.RowIndex);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_proveedor(txtbuscar.Text);
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            if (btagregar.Text.Equals("Agregar"))
            {
                bteditar.Enabled = false;
                bteliminar.Enabled = false;
                txtnombre.ReadOnly = false;
                txtcelular.ReadOnly = false;
                txtlaboratorio.ReadOnly = false;
                cbtipo.Enabled = true;

                btañadir.Enabled = true;
                tbproductos.Enabled = true;
                btagregar.Text = "Guardar";

                txtnombre.Text = "";
                txtcelular.Text = "";
                txtlaboratorio.Text = "";

                limpiar_tabla();

                txtnombre.Focus();

                lbid.Text = "-1";
            }
            else
            {
                if (tbproductos.Rows.Count != 0)
                {
                    if (!txtnombre.Text.Equals("") || !txtlaboratorio.Text.Equals("") || !txtcelular.Text.Equals(""))
                    {
                        Proveedores proveedores = new Proveedores();
                        proveedores.Nombre = txtnombre.Text;
                        proveedores.Empresa = txtlaboratorio.Text;
                        proveedores.Celular = txtcelular.Text;
                        proveedores.Tipo = cbtipo.SelectedItem.ToString();

                        if (proveedores.registrar_proveedor())
                        {
                            proveedores.Idproveedor = proveedores.obtener_idproveedor();
                            enviar_productos(proveedores.obtener_idproveedor());
                            MessageBox.Show("Se registró el proveedor exitosamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetear();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al registrar el proveedor", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor llene todos los campos", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por asigne productos al proveedor", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            if (bteditar.Text.Equals("Editar") && tbproveedores.Rows.Count != 0)
            {
                tbproductos.Enabled = true;
                txtnombre.ReadOnly = false;
                txtcelular.ReadOnly = false;
                txtlaboratorio.ReadOnly = false;
                cbtipo.Enabled = true;
                btañadir.Enabled = true;
                bteliminar.Enabled = false;
                btagregar.Enabled = false;
                bteditar.Enabled = true;

                bteditar.Text = "Guardar";
            }
            else if (bteditar.Text.Equals("Guardar"))
            {
                if (tbproductos.Rows.Count != 0)
                {
                    if (!txtnombre.Text.Equals("") || !txtlaboratorio.Text.Equals("") || !txtcelular.Text.Equals(""))
                    {
                        Proveedores proveedores = new Proveedores();
                        proveedores.Idproveedor = Int32.Parse(lbid.Text);
                        proveedores.Nombre = txtnombre.Text;
                        proveedores.Empresa = txtlaboratorio.Text;
                        proveedores.Celular = txtcelular.Text;
                        proveedores.Tipo = cbtipo.SelectedItem.ToString();

                        if (proveedores.modificar_proveedor())
                        {
                            enviar_productos(Int32.Parse(lbid.Text));
                            MessageBox.Show("Se modificó el proveedor exitosamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetear();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Por favor llene todos los campos", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor asigne productos al proveedor", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            if (bteliminar.Text.Equals("Eliminar") && tbproveedores.Rows.Count != 0)
            {
                bteditar.Enabled = false;
                btagregar.Enabled = false;
                bteliminar.Text = "CONFIRMAR";
            }
            else if (bteliminar.Text.Equals("CONFIRMAR"))
            {
                if (MessageBox.Show("¿Desea eliminar el proveedor?", "RegisterStore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Proveedores proveedores = new Proveedores();
                    proveedores.Idproveedor = Int32.Parse(lbid.Text);
                    if (proveedores.eliminar_proveedor())
                    {
                        MessageBox.Show("Se eliminó el proveedor correctamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetear();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el proveedor, por favor intente de nuevo, si el problema persiste informe al administrador", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resetear();
                    }
                }
            }
        }

        private void tbproductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
            {
                if (MessageBox.Show("DESEA DESASOCIAR EL PRODUCTO SELECCIONADO DEL PROVEEDOR ACTUAL", "RegisterStore", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tbproductos.Rows.RemoveAt(tbproductos.CurrentRow.Index);
                }
                if (tbproductos.Rows.Count == 0)
                {
                    resetear();
                }
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            resetear();
        }
    }
}
