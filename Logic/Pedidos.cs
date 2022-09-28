using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterStore.Logic
{
    internal class Pedidos
    {

        #region variables privadas
        private int _idpedido;
        private int _iproveedor;
        private float _total;
        private float _subtotal;
        private string _fecha;
        private string _hora;
        private string _estado;
        private string _pago;
        private string _tienda;

        private int _idproducto;
        private int _unidades;
        private int _compra;
        private int _descuento;




        #endregion


        #region variables publicas

        public Conexion conexion = new Conexion();

        public int Idpedido { get => _idpedido; set => _idpedido = value; }
        public int Iproveedor { get => _iproveedor; set => _iproveedor = value; }
        public float Total { get => _total; set => _total = value; }
        public float Subtotal { get => _subtotal; set => _subtotal = value; }
        public string Fecha { get => _fecha; set => _fecha = value; }
        public string Hora { get => _hora; set => _hora = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Pago { get => _pago; set => _pago = value; }
        public string Tienda { get => _tienda; set => _tienda = value; }
        public int Idproducto { get => _idproducto; set => _idproducto = value; }
        public int Unidades { get => _unidades; set => _unidades = value; }
        public int Compra { get => _compra; set => _compra = value; }
        public int Descuento { get => _descuento; set => _descuento = value; }


        #endregion


        #region constructores

        public Pedidos(int idpedido, int iproveedor, float total, float subtotal, string fecha, string hora, string estado, string pago, string tienda, int idproducto, int unidades, int compra, int descuento)
        {
            Idpedido = idpedido;
            Iproveedor = iproveedor;
            Total = total;
            Subtotal = subtotal;
            Fecha = fecha;
            Hora = hora;
            Estado = estado;
            Pago = pago;
            Tienda = tienda;
            Idproducto = idproducto;
            Unidades = unidades;
            Compra = compra;
            Descuento = descuento;
        }

        public Pedidos()
        {
        }



        #endregion


        #region metodos publicos

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
            tabla.Columns.Add("Stock", typeof(string));
            // Consulta a la base de datos

            try
            {
                SqlCommand sql = new SqlCommand(String.Format("SELECT P.idproducto,P.codigo,P.nombre,P.laboratorio,P.presentacion,P.cantidad,P.compra,E.stock FROM productos as P INNER JOIN existencias as E ON P.idproducto=E.idproducto INNER JOIN subproveedores as S ON P.idproducto=S.idproducto WHERE S.idproveedor='"+Iproveedor+"' and (P.nombre like '%"+arg+"%' or P.laboratorio like '%"+arg+"%' or P.codigo like '%"+arg+"%') and tienda='"+Tienda+"'"), conexion.conectar());
                SqlDataReader rd = sql.ExecuteReader();
                while (rd.Read())
                {

                    //Llenando la tabla

                    tabla.Rows.Add(rd.GetSqlInt32(0), rd.GetSqlString(1), rd.GetSqlString(2), rd.GetSqlString(3), rd.GetSqlString(4), rd.GetSqlString(5), rd.GetSqlInt32(6), rd.GetSqlInt32(7));
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
            return tabla;
        }

        public DataTable buscar_pedido(string arg,string tienda)
        {
            DataTable tabla = new DataTable();

            //Diseño de la cabecera de la tabla 

            tabla.Columns.Add("IdPedido", typeof(string));
            tabla.Columns.Add("IdProveedor", typeof(string));
            tabla.Columns.Add("Total", typeof(string));
            tabla.Columns.Add("Subtotal", typeof(string));
            tabla.Columns.Add("Descuento", typeof(string));
            tabla.Columns.Add("Fecha", typeof(string));
            tabla.Columns.Add("Hora", typeof(string));
            tabla.Columns.Add("Estado", typeof(string));
            tabla.Columns.Add("Fecha de pago", typeof(string));
            tabla.Columns.Add("Tienda", typeof(string));
            tabla.Columns.Add("Nombre", typeof(string));
            // Consulta a la base de datos

            try
            {
                SqlCommand sql = new SqlCommand(String.Format("SELECT P.*,S.nombre FROM pedidos as P INNER JOIN proveedores as S ON P.idproveedor=S.idproveedor WHERE (P.fecha like '%"+arg+ "%' or S.nombre like '%" + arg + "%' or P.estado like '%" + arg + "%') and  P.tienda like '%" + tienda + "%'"), conexion.conectar());
                SqlDataReader rd = sql.ExecuteReader();
                while (rd.Read())
                {

                    //Llenando la tabla

                    tabla.Rows.Add(rd.GetInt32(0), rd.GetInt32(1), rd.GetSqlDecimal(2), rd.GetSqlDecimal (3), rd.GetInt32(4), rd.GetSqlString(5), rd.GetString(6), rd.GetString(7), rd.GetString(8), rd.GetString(9),rd.GetString(10));
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Se presentó el siguiente error al buscar el pedido: "+ex.ToString());
            }
            return tabla;
        }

        public DataTable llenar_productos()
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
            // Consulta a la base de datos

            try
            {
                SqlCommand sql = new SqlCommand(String.Format("SELECT P.codigo,P.nombre,P.laboratorio,P.presentacion,P.cantidad,P.compra,E.stock,S.unidades,S.descuento,S.total,S.subtotal FROM productos as P INNER JOIN existencias as E ON P.idproducto=E.idproducto INNER JOIN subpedidos as S ON P.idproducto=S.idproducto WHERE S.idpedido='"+Idpedido+"' and tienda='"+Tienda+"'"), conexion.conectar());
                SqlDataReader rd = sql.ExecuteReader();
                while (rd.Read())
                {

                    //Llenando la tabla

                    tabla.Rows.Add(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetInt32(5), rd.GetInt32(6), rd.GetInt32(7), rd.GetInt32(8), rd.GetInt32(9), rd.GetInt32(10));
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Se presentó el siguiente error al buscar el pedido: " + ex.ToString());
            }
            return tabla;
        }


        public bool registrar_pedido()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("INSERT INTO pedidos(idproveedor,total,subtotal,descuento,fecha,hora,estado,pago,tienda) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",Iproveedor,Total,Subtotal,Descuento,Fecha,Hora,Estado,Pago,Tienda ), conexion.conectar());
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

        public int obtener_idpedido()
        {
            int id = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(String.Format("SELECT MAX(idpedido) FROM pedidos"), conexion.conectar());
                id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.ToString());
            }
            return id;
        }


        public bool registrar_subpedido()
        {
            bool confirmacion = false;

            int idpedido = obtener_idpedido();

            if (idpedido!=-1)
            {
                System.Console.WriteLine(Idproducto.ToString());
                try
                {
                    SqlCommand sql = new SqlCommand(string.Format("INSERT INTO subpedidos(idpedido,idproveedor,idproducto,unidades,compra,descuento,total,subtotal) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", idpedido, Iproveedor, Idproducto, Unidades, Compra,Descuento, Total, Subtotal), conexion.conectar());
                    if (sql.ExecuteNonQuery() != 0)
                    {
                        if (Estado.Equals("RECIBIDO") || Estado.Equals("PAGADO"))
                        {
                            if (add_existencias())
                            {
                                confirmacion = true;
                            }
                        }
                        else
                        {
                            confirmacion = true;
                        }
                    }

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.ToString());
                }

            }

            return confirmacion;
        }

        public int obtener_stock()
        {
            int actual=0;
            int nuevo=0;

            SqlCommand sql = new SqlCommand(String.Format("SELECT stock FROM existencias WHERE idproducto='"+Idproducto+"'"), conexion.conectar());
            SqlDataReader rd = sql.ExecuteReader();
            while (rd.Read())
            {
                actual = rd.GetInt32(0);
            }

            nuevo =Unidades+ actual;
            return nuevo;
        }

        public bool add_existencias()
        {
            bool respuesta = false;

            int stock = obtener_stock();

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("UPDATE existencias SET stock='{0}' where idproducto='{1}'",stock,Idproducto), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    respuesta = true;
                }

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }


            return respuesta;
        }



        #endregion









    }
}
