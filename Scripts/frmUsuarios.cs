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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            resetear();

            this.ActiveControl = txtbuscar;
        }

        public void resetear()
        {
            buscar_usuarios("");
            llenar_campos(0);

            txtnombre.Enabled = false;
            txtclave.Enabled = false;
            cbtienda.Enabled = false;
            cbtipo.Enabled = false;

            btagregar.Text = "AGREGAR";
            bteditar.Text = "EDITAR";
            bteliminar.Text = "ELIMINAR";

            btagregar.Enabled = true;
            bteditar.Enabled = true;
            bteliminar.Enabled = true;

        }

        public void llenar_campos(int index)
        {
            if (tbusuarios.RowCount != 0)
            {
                lbid.Text = tbusuarios.Rows[index].Cells[0].Value.ToString();
                txtnombre.Text = tbusuarios.Rows[index].Cells[1].Value.ToString();
                txtclave.Text = tbusuarios.Rows[index].Cells[2].Value.ToString();
                cbtipo.Text = tbusuarios.Rows[index].Cells[3].Value.ToString();
                cbtienda.Text= tbusuarios.Rows[index].Cells[4].Value.ToString();
            }
        }

        public void buscar_usuarios(string arg)
        {
            Usuarios usuarios = new Usuarios();
            //Asignando los datos al datagrid

            tbusuarios.DataSource = null;
            tbusuarios.DataSource = usuarios.buscar_usuario(arg);

            //Ocultando las columnas inecesarias

            tbusuarios.Columns[0].Visible = false;



            int total = tbusuarios.RowCount;
            lbcontador.Text = total.ToString();


        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_registerstore_dbDataSet.tiendas' Puede moverla o quitarla según sea necesario.
            this.tiendasTableAdapter1.Fill(this._registerstore_dbDataSet.tiendas);
            // TODO: esta línea de código carga datos en la tabla 'registerstoreDataSet.tiendas' Puede moverla o quitarla según sea necesario.
            this.tiendasTableAdapter.Fill(this.registerstoreDataSet.tiendas);

            txtnombre.PlaceholderText = "NOMBRE USUARIO";
            txtclave.PlaceholderText = "*******";
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            if (btagregar.Text.Equals("AGREGAR"))
            {
                btagregar.Text="GUARDAR";

                txtnombre.Text = "";
                txtclave.Text = "";

                

                bteditar.Enabled = false;
                bteliminar.Enabled = false;

                txtnombre.Enabled = true;
                txtclave.Enabled = true;
                cbtienda.Enabled = true;
                cbtipo.Enabled = true;

                txtnombre.Focus();
            }
            else
            {
                if (!txtnombre.Text.Equals(String.Empty) || !txtnombre.Text.Equals(String.Empty))
                {
                    String nombre = txtnombre.Text;
                    string clave = txtclave.Text;
                    string tipo = cbtipo.SelectedItem.ToString();
                    string tienda = cbtienda.Text.ToString();

                    Usuarios usuarios = new Usuarios();

                    usuarios.Nombre = nombre;
                    usuarios.Clave = clave;
                    usuarios.Tipo = tipo;
                    usuarios.Tienda = tienda;

                    if (usuarios.crear_usuario())
                    {
                        MessageBox.Show("Se creó el usuario correctamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetear();
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error al crear el usuario", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tbusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenar_campos(e.RowIndex);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_usuarios(txtbuscar.Text);
            llenar_campos(0);
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            if (bteditar.Text.Equals("EDITAR"))
            {
                txtnombre.Enabled = true;
                txtclave.Enabled = true;
                cbtienda.Enabled = true;
                cbtipo.Enabled = true;

                bteditar.Enabled = true;
                btagregar.Enabled = false;
                bteliminar.Enabled = false;

                txtnombre.Focus();

                bteditar.Text = "GUARDAR";

            }
            else
            {
                if (!txtnombre.Text.Equals(String.Empty) || !txtnombre.Text.Equals(String.Empty))
                {
                    String nombre = txtnombre.Text;
                    string clave = txtclave.Text;
                    string tipo = cbtipo.SelectedItem.ToString();
                    string tienda = cbtienda.Text.ToString();

                    Usuarios usuarios = new Usuarios();

                    usuarios.Idusuario = Int32.Parse(lbid.Text);
                    usuarios.Nombre = nombre;
                    usuarios.Clave = clave;
                    usuarios.Tipo = tipo;
                    usuarios.Tienda = tienda;

                    if (usuarios.modificar_usuario())
                    {
                        MessageBox.Show("Se modificó el usuario correctamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetear();
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error al modificar el usuario", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            if (bteliminar.Text.Equals("ELIMINAR"))
            {
                bteliminar.Text = "CONFIRMAR";

                btagregar.Enabled = false;
                bteliminar.Enabled = true;
                bteditar.Enabled = false;


            }
            else
            {
                if ((MessageBox.Show("¿Desea eliminar el usuario?", "RegisterStore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) && tbusuarios.Rows.Count!=1)
                {
                    Usuarios usuarios = new Usuarios();
                    usuarios.Idusuario = Int32.Parse(lbid.Text);

                    if (usuarios.eliminar_usuario())
                    {
                        MessageBox.Show("Se eliminó el usuario correctamente", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetear();
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error al eliminar el usuario", "RegisterStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    resetear();
                }
                    
            }
        }
    }
}
