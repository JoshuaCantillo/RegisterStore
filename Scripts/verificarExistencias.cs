using RegisterStore.Logic;
using System;
using System.Windows.Forms;

namespace RegisterStore.Scripts
{
    public partial class verificarExistencias : Form
    {
        public verificarExistencias()
        {
            InitializeComponent();
        }

        public void buscar_producto(string arg)
        {
            Productos productos = new Productos();
            productos.Tienda = "";
            //Asignando los datos al datagrid

            tbproductos.DataSource = null;
            tbproductos.DataSource = productos.buscar_producto(arg);

            //Ocultando las columnas inecesarias

            tbproductos.Columns[0].Visible = false;
            tbproductos.Columns[6].Visible = false;
            tbproductos.Columns[7].Visible = false;
            tbproductos.Columns[8].Visible = false;



            int total = tbproductos.RowCount;
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
