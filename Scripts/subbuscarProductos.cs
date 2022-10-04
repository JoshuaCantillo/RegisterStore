using RegisterStore.Logic;
using System;
using System.Data;
using System.Windows.Forms;

namespace RegisterStore.Scripts
{
    public partial class subbuscarProductos : Form
    {
        public string modulo;
        public string tienda;
        public Int32 idproveedor;

        public subbuscarProductos(string modulo, string tienda, Int32 idproveedor)
        {
            InitializeComponent();
            this.modulo = modulo;
            this.tienda = tienda;
            this.idproveedor = idproveedor;
            txtbuscar.Focus();

            buscar_producto("");

            this.ActiveControl = txtbuscar;
        }






        public void buscar_producto(string arg)
        {
            if (modulo.Equals("proveedores"))
            {
                Productos productos = new Productos();
                productos.Tienda = tienda;
                //Asignando los datos al datagrid

                tbproductos.DataSource = null;
                tbproductos.DataSource = productos.buscar_producto(arg);

                //Ocultando las columnas inecesarias

                tbproductos.Columns[0].Visible = false;
                tbproductos.Columns[6].Visible = false;
                tbproductos.Columns[7].Visible = false;
                tbproductos.Columns[8].Visible = false;
                tbproductos.Columns[9].Visible = false;
                tbproductos.Columns[10].Visible = false;



                int total = tbproductos.RowCount;
                lbcontador.Text = total.ToString();

            }
            else if (modulo.Equals("pedidos"))
            {

                Pedidos pedidos = new Pedidos();

                pedidos.Tienda = tienda;
                pedidos.Iproveedor = idproveedor;

                tbproductos.DataSource = null;
                tbproductos.DataSource = pedidos.buscar_producto(arg);

                int total = tbproductos.RowCount;
                lbcontador.Text = total.ToString();

                tbproductos.Columns[0].Visible = false;
            }
        }


        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_producto(txtbuscar.Text);
        }

        private void tbproductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = tbproductos.CurrentRow.Index;
            if (modulo.Equals("proveedores"))
            {

                string id = tbproductos.Rows[index].Cells[0].Value.ToString();
                string codigo = tbproductos.Rows[index].Cells[1].Value.ToString();
                string producto = tbproductos.Rows[index].Cells[2].Value.ToString();
                string laboratorio = tbproductos.Rows[index].Cells[3].Value.ToString();
                string presentacion = tbproductos.Rows[index].Cells[4].Value.ToString();
                string cantidad = tbproductos.Rows[index].Cells[5].Value.ToString();
                string precio = tbproductos.Rows[index].Cells[7].Value.ToString();

                frmProveedores proveedores = Owner as frmProveedores;

                bool rt = false;
                if (proveedores.tbproductos.RowCount != 0)
                {
                    for (int i = 0; i < proveedores.tbproductos.Rows.Count; i++)
                    {
                        string idproducto = proveedores.tbproductos.Rows[i].Cells[0].Value.ToString();
                        if (id == idproducto)
                        {
                            rt = true;
                        }
                    }
                }

                if (rt == false)
                {
                    if (proveedores.tbproductos.DataSource == null)
                    {
                        DataTable tabla = new DataTable();

                        //Diseño de la cabecera de la tabla 

                        tabla.Columns.Add("IdProducto", typeof(string));
                        tabla.Columns.Add("Código", typeof(string));
                        tabla.Columns.Add("Nombre", typeof(string));
                        tabla.Columns.Add("Laboratorio", typeof(string));
                        tabla.Columns.Add("Presentación", typeof(string));
                        tabla.Columns.Add("Cantidad", typeof(string));
                        tabla.Columns.Add("Venta", typeof(string));

                        tabla.Rows.Add(id, codigo, producto, laboratorio, presentacion, cantidad, precio);

                        proveedores.tbproductos.DataSource = tabla;

                        proveedores.tbproductos.Columns[0].Visible = false;

                    }
                    else
                    {

                        DataTable dt = new DataTable();
                        dt = proveedores.tbproductos.DataSource as DataTable;
                        DataRow dr;
                        dr = dt.NewRow();
                        dr["IdProducto"] = id;
                        dr["Código"] = codigo;
                        dr["Nombre"] = producto;
                        dr["Laboratorio"] = laboratorio;
                        dr["Presentación"] = presentacion;
                        dr["Cantidad"] = cantidad;
                        dr["Venta"] = precio;

                        dt.Rows.Add(dr);
                    }
                }
                else
                {
                    MessageBox.Show("El producto seleccionado ya se encuentra relacionado con el proveedor", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string idproducto = tbproductos.Rows[index].Cells[0].Value.ToString();
                string codigo = tbproductos.Rows[index].Cells[1].Value.ToString();
                string nombre = tbproductos.Rows[index].Cells[2].Value.ToString();
                string laboratorio = tbproductos.Rows[index].Cells[3].Value.ToString();
                string presentacion = tbproductos.Rows[index].Cells[4].Value.ToString();
                string cantidad = tbproductos.Rows[index].Cells[5].Value.ToString();
                string compra = tbproductos.Rows[index].Cells[6].Value.ToString();
                string stock = tbproductos.Rows[index].Cells[7].Value.ToString();
                string unidades = "0";
                string descuento = "0";
                string total = "0";
                string subtotal = "0";


                frmPedidos pedidos = Owner as frmPedidos;


                bool rt = false;
                if (pedidos.tbproductos.RowCount != 0)
                {
                    for (int i = 0; i < pedidos.tbproductos.Rows.Count; i++)
                    {
                        string id;
                        id = pedidos.tbproductos.Rows[i].Cells[0].Value.ToString();
                        if (id == idproducto)
                        {
                            rt = true;
                        }
                    }
                }

                if (rt == false)
                {
                    if (pedidos.tbproductos.DataSource == null)
                    {
                        DataTable tabla = new DataTable();

                        //Diseño de la cabecera de la tabla 

                        tabla.Columns.Add("IdProducto", typeof(string));
                        tabla.Columns.Add("Código", typeof(string));
                        tabla.Columns.Add("Nombre", typeof(string));
                        tabla.Columns.Add("Laboratorio", typeof(string));
                        tabla.Columns.Add("Presentación", typeof(string));
                        tabla.Columns.Add("Cantidad", typeof(string));
                        tabla.Columns.Add("Compra", typeof(string));
                        tabla.Columns.Add("Unidades", typeof(string));
                        tabla.Columns.Add("Descuento", typeof(string));
                        tabla.Columns.Add("Total", typeof(string));
                        tabla.Columns.Add("Subtotal", typeof(string));

                        tabla.Rows.Add(idproducto, codigo, nombre, laboratorio, presentacion, cantidad, compra, unidades, descuento, total, subtotal);

                        pedidos.tbproductos.DataSource = tabla;

                        pedidos.tbproductos.Columns[0].Visible = false;

                    }
                    else
                    {

                        DataTable dt = new DataTable();
                        dt = pedidos.tbproductos.DataSource as DataTable;
                        DataRow dr;
                        dr = dt.NewRow();
                        dr["IdProducto"] = idproducto;
                        dr["Código"] = codigo;
                        dr["Nombre"] = nombre;
                        dr["Laboratorio"] = laboratorio;
                        dr["Presentación"] = presentacion;
                        dr["Cantidad"] = cantidad;
                        dr["Compra"] = compra;
                        dr["Unidades"] = "0";
                        dr["Descuento"] = "0";
                        dr["Total"] = "0";
                        dr["Subtotal"] = "0";

                        dt.Rows.Add(dr);

                        pedidos.tbproductos.Columns[0].Visible = false;
                    }

                    if (pedidos.accion.Equals("nuevo"))
                    {
                        pedidos.btconfirmar.Enabled = true;
                        pedidos.txtdescuento.ReadOnly = false;
                        pedidos.btbuscar.Enabled = false;
                        pedidos.cbestado.Enabled = true;
                        pedidos.txtbuscar.ReadOnly = true;
                        pedidos.tbproveedores.Enabled = false;
                    }

                }
                else
                {
                    MessageBox.Show("El producto seleccionado ya se encuentra relacionado al pedido", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
