using RegisterStore.Logic;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace RegisterStore.Scripts
{
    public partial class subfrmPedidos : Form
    {
        public string tienda;
        public subfrmPedidos(string tienda)
        {
            InitializeComponent();

            this.tienda = tienda;

            buscar_pedidos("");
        }



        public void buscar_pedidos(string arg)
        {
            Pedidos pedidos = new Pedidos();

            //Asignando los datos al datagrid

            tbpedidos.DataSource = null;

            tbpedidos.DataSource = pedidos.buscar_pedido(arg, tienda);

            //Ocultando las columnas inecesarias

            tbpedidos.Columns[0].Visible = false;
            tbpedidos.Columns[1].Visible = false;
            tbpedidos.Columns[8].Visible = false;
            tbpedidos.Columns[9].Visible = false;



            int total = tbpedidos.RowCount;
            lbcontador.Text = total.ToString();
        }

        public void llenar_productos(int idpedido)
        {
            frmPedidos frm = Owner as frmPedidos;
            Pedidos pedidos = new Pedidos();

            pedidos.Idpedido = idpedido;
            pedidos.Tienda = tienda;
            //Asignando los datos al datagrid

            frm.tbproductos.DataSource = null;
            frm.tbproductos.DataSource = pedidos.llenar_productos();

            //Ocultando las columnas inecesarias

            frm.tbproductos.Columns[0].Visible = false;



            int total = frm.tbproductos.RowCount;
            frm.lbcontadorProductos.Text = total.ToString();

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_pedidos(txtbuscar.Text);
        }

        private void tbpedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProveedor = Int32.Parse(tbpedidos.Rows[e.RowIndex].Cells[1].Value.ToString());
            int idPedido = Int32.Parse(tbpedidos.Rows[e.RowIndex].Cells[0].Value.ToString());
            int Total = Int32.Parse(tbpedidos.Rows[e.RowIndex].Cells[2].Value.ToString());
            int Subtotal = Int32.Parse(tbpedidos.Rows[e.RowIndex].Cells[3].Value.ToString());
            int Descuento = Int32.Parse(tbpedidos.Rows[e.RowIndex].Cells[4].Value.ToString());
            string Fecha = tbpedidos.Rows[e.RowIndex].Cells[5].Value.ToString();
            string Hora = tbpedidos.Rows[e.RowIndex].Cells[6].Value.ToString();
            string Estado = tbpedidos.Rows[e.RowIndex].Cells[7].Value.ToString();
            string Pago = tbpedidos.Rows[e.RowIndex].Cells[8].Value.ToString();
            string Tienda = tbpedidos.Rows[e.RowIndex].Cells[9].Value.ToString();
            string nombre = tbpedidos.Rows[e.RowIndex].Cells[10].Value.ToString();

            frmPedidos pedidos = Owner as frmPedidos;

            pedidos.accion = "EDITAR";

            pedidos.txtbuscar.ReadOnly = true;

            pedidos.buscar_proveedor(nombre);
            pedidos.lbidpedido.Text = idPedido.ToString();
            pedidos.lbidproveedor.Text = idProveedor.ToString();
            pedidos.txttotal.Text = Total.ToString("N", new CultureInfo("es-CO"));
            pedidos.txtsubtotal.Text = Subtotal.ToString("N", new CultureInfo("es-CO"));
            pedidos.txtdescuento.Text = Descuento.ToString();

            pedidos.btañadir.Enabled = false;

            if (Estado.Equals("RECIBIDO") || Estado.Equals("PAGADO"))
            {
                pedidos.bteditar.Enabled = false;
            }

            pedidos.btconfirmar.Enabled = false;
            pedidos.tbproductos.Enabled = false;
            pedidos.tbproveedores.Enabled = false;

            pedidos.txtbuscar.ReadOnly = true;
            pedidos.txtdescuento.ReadOnly = true;

            pedidos.bteliminar.Enabled = true;

            pedidos.cbestado.Enabled = false;

            llenar_productos(idPedido);

            this.Close();

        }
    }
}
