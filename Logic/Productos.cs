using System;
using System.Data;
using System.Data.SqlClient;

namespace RegisterStore.Logic
{
    public class Productos
    {
        #region Variables privadas
        private int _idProducto;
        private string _codigo;
        private string _nombre;
        private string _laboratorio;
        private string _presentacion;
        private string _cantidad;
        private int _compra;
        private int _venta;
        private int _iva;
        private int _stock;
        private string _tienda;


        #endregion


        #region Variables publicas

        public Conexion conexion = new Conexion();
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Laboratorio { get => _laboratorio; set => _laboratorio = value; }
        public string Presentacion { get => _presentacion; set => _presentacion = value; }
        public string Cantidad { get => _cantidad; set => _cantidad = value; }
        public int Compra { get => _compra; set => _compra = value; }
        public int Venta { get => _venta; set => _venta = value; }
        public int Iva { get => _iva; set => _iva = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public string Tienda { get => _tienda; set => _tienda = value; }

        #endregion

        #region Constructores

        public Productos()
        {
        }

        public Productos(int idProducto, string codigo, string nombre, string laboratorio, string presentacion, string cantidad, int compra, int venta, int iva, int stock, string tienda)
        {
            IdProducto = idProducto;
            Codigo = codigo;
            Nombre = nombre;
            Laboratorio = laboratorio;
            Presentacion = presentacion;
            Cantidad = cantidad;
            Compra = compra;
            Venta = venta;
            Iva = iva;
            Stock = stock;
            Tienda = tienda;
        }


        #endregion

        #region Metodos publicos

        public DataTable buscar_producto(string arg)
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
            tabla.Columns.Add("Venta", typeof(string));
            tabla.Columns.Add("Iva", typeof(string));
            tabla.Columns.Add("Stock", typeof(string));
            tabla.Columns.Add("Tienda", typeof(string));
            // Consulta a la base de datos

            try
            {
                SqlCommand sql = new SqlCommand(String.Format("SELECT P.*, E.stock,E.tienda from productos as P INNER JOIN existencias as E ON P.idproducto=E.idproducto  WHERE (P.codigo like'%" + arg + "%' or P.nombre like '%" + arg + "%' or P.laboratorio like '%" + arg + "%') and tienda like '%" + Tienda + "%' order by nombre ASC "), conexion.conectar());
                SqlDataReader rd = sql.ExecuteReader();
                while (rd.Read())
                {

                    //Llenando la tabla

                    tabla.Rows.Add(rd.GetSqlInt32(0), rd.GetSqlString(1), rd.GetSqlString(2), rd.GetSqlString(3), rd.GetSqlString(4), rd.GetSqlString(5), rd.GetSqlInt32(6), rd.GetSqlInt32(7), rd.GetSqlInt32(8), rd.GetSqlInt32(9), rd.GetSqlString(10));
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
            return tabla;
        }

        public bool registrar_producto()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("INSERT INTO productos(codigo,nombre,laboratorio,presentacion,cantidad,compra,venta,iva) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", Codigo, Nombre.ToUpper(), Laboratorio.ToUpper(), Presentacion.ToUpper(), Cantidad.ToUpper(), Compra, Venta, Iva), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    if (buscar_tiendas())
                    {
                        confirmacion = true;
                    }
                }

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }


            return confirmacion;
        }

        public int obtener_idproducto()
        {
            int id = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(String.Format("SELECT MAX(idproducto) FROM productos"), conexion.conectar());
                id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.ToString());
            }
            return id;
        }

        public bool buscar_tiendas()
        {
            bool respuesta = false;
            try
            {
                SqlCommand sql = new SqlCommand(String.Format("SELECT nombre FROM tiendas"), conexion.conectar());
                SqlDataReader rd = sql.ExecuteReader();
                while (rd.Read())
                {
                    if (crear_existencias(rd.GetString(0)))
                    {
                        respuesta = true;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.ToString());
            }
            return respuesta;
        }

        public bool crear_existencias(string tienda)
        {
            bool respuesta = false;
            try
            {
                int id = obtener_idproducto();
                if (id > 0)
                {

                    SqlCommand sql = new SqlCommand(string.Format("INSERT INTO existencias(idproducto,stock,tienda) values('{0}','{1}','{2}')", id, 0, tienda), conexion.conectar());
                    if (sql.ExecuteNonQuery() != 0)
                    {
                        respuesta = true;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.ToString());
            }
            return respuesta;
        }

        public bool modificar_producto()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("UPDATE productos SET codigo='{0}',nombre='{1}',laboratorio='{2}',presentacion='{3}',cantidad='{4}',compra='{5}',venta='{6}',iva='{7}' where idproducto='{8}'", Codigo, Nombre.ToUpper(), Laboratorio.ToUpper(), Presentacion.ToUpper(), Cantidad, Compra, Venta, Iva, IdProducto), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    confirmacion = true;
                }

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }


            return confirmacion;
        }

        public bool eliminar_producto()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("DELETE FROM productos where idproducto='{0}'", IdProducto), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    if (eliminar_existencias())
                    {
                        confirmacion = true;
                    }
                }

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }


            return confirmacion;
        }
        public bool eliminar_existencias()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("DELETE FROM existencias where idproducto='{0}'", IdProducto), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    confirmacion = true;
                }

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }


            return confirmacion;
        }

        #endregion

    }
}
