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
    public partial class frmProductos : Form
    {
        public int fila;
        public string tienda;
        public frmProductos(string tienda)
        {
            InitializeComponent();
            this.tienda = tienda;
            resetear();

            txtbuscar.Focus();
        }

        public void resetear()
        {
            this.ActiveControl = txtbuscar;

            txtbuscar.Text = "";
            txtbuscar.Focus();
            buscar_producto("");
        }

        public void buscar_producto(string arg)
        {
            Productos productos = new Productos();
            Dashboard ds= Owner as Dashboard;
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


            llenar_campos(0);
            fila = 0;
        }

        public string darFormato(string srt)
        {
            string retorno="";
            try
            {

                int valor = int.Parse(srt);
                string conversion = valor.ToString("N", new CultureInfo("es-CO"));
                String[] arreglo = conversion.Split(',');

                retorno = arreglo[0];

            }
            catch (Exception ex)
            {
            }
            return retorno;
        }
        public void llenar_campos(int index)
        {
            if (tbproductos.RowCount != 0)
            {
                lbid.Text = tbproductos.Rows[index].Cells[0].Value.ToString();
                lbproducto.Text = tbproductos.Rows[index].Cells[2].Value.ToString();
                txtlaboratorio.Text = tbproductos.Rows[index].Cells[3].Value.ToString();
                txtpresentacion.Text= tbproductos.Rows[index].Cells[4].Value.ToString();
                txtcantidad.Text = tbproductos.Rows[index].Cells[5].Value.ToString();
                txtprecio.Text ="$ "+ darFormato(tbproductos.Rows[index].Cells[7].Value.ToString());
                txtdisponibles.Text = tbproductos.Rows[index].Cells[9].Value.ToString()+" Unid.";
                fila = index;
            }
        }

        private void btinspeccionar_Click(object sender, EventArgs e)
        {
            if (tbproductos.Rows.Count!=0)
            {
                subfrmProductos addProductos = new subfrmProductos();
                AddOwnedForm(addProductos);

                addProductos.resetear();
                addProductos.lbidproducto.Text = tbproductos.Rows[fila].Cells[0].Value.ToString();
                addProductos.txtcodigo.Text = tbproductos.Rows[fila].Cells[1].Value.ToString();
                addProductos.txtproducto.Text = tbproductos.Rows[fila].Cells[2].Value.ToString();
                addProductos.txtlaboratorio.Text = tbproductos.Rows[fila].Cells[3].Value.ToString();
                addProductos.txtpresentacion.Text = tbproductos.Rows[fila].Cells[4].Value.ToString();
                addProductos.txtcantidad.Text = tbproductos.Rows[fila].Cells[5].Value.ToString();
                addProductos.txtventa.Text = darFormato(tbproductos.Rows[fila].Cells[7].Value.ToString());
                addProductos.txtcompra.Text = darFormato(tbproductos.Rows[fila].Cells[6].Value.ToString());
                addProductos.txtiva.Text = tbproductos.Rows[fila].Cells[8].Value.ToString();

                addProductos.ShowDialog();
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_producto(txtbuscar.Text);
        }

        private void tbproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int index = e.RowIndex;
                llenar_campos(index);
            }
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            subfrmProductos addProductos = new subfrmProductos();
            AddOwnedForm(addProductos);
            addProductos.accion = "agregar";
            addProductos.txtcodigo.Focus();
            addProductos.bteditar.Enabled = false;
            addProductos.bteliminar.Enabled = false;
            addProductos.ShowDialog();
        }

        private void btresetear_Click(object sender, EventArgs e)
        {
            resetear();
        }

        private void tbproductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            llenar_campos(e.RowIndex);
        }
    }
}
