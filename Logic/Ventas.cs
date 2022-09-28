using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterStore.Logic
{
    internal class Ventas
    {

        #region Variables privadas

        private int _idventa;
        private string _fecha;
        private string _hora;
        private float _total;
        private float _subtotal;
        private int _descuento;
        private int _abono;
        private string _medio;
        private string _referencia;
        private string _estado;
        private string _tienda;

        private int _idproducto;
        private int _unidades;





        #endregion


        #region Variables publicas

        public Conexion conexion = new Conexion();

        public int Idventa { get => _idventa; set => _idventa = value; }
        public string Fecha { get => _fecha; set => _fecha = value; }
        public string Hora { get => _hora; set => _hora = value; }
        public float Total { get => _total; set => _total = value; }
        public float Subtotal { get => _subtotal; set => _subtotal = value; }
        public int Descuento { get => _descuento; set => _descuento = value; }
        public int Abono { get => _abono; set => _abono = value; }
        public string Medio { get => _medio; set => _medio = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Tienda { get => _tienda; set => _tienda = value; }
        public int Idproducto { get => _idproducto; set => _idproducto = value; }
        public int Unidades { get => _unidades; set => _unidades = value; }
        public string Referencia { get => _referencia; set => _referencia = value; }

        #endregion


        #region Constructores

        public Ventas(int idventa, string fecha, string hora, float total, float subtotal, int descuento, int abono, string medio, string estado, string tienda, int idproducto, int unidades, string referencia)
        {
            Idventa = idventa;
            Fecha = fecha;
            Hora = hora;
            Total = total;
            Subtotal = subtotal;
            Descuento = descuento;
            Abono = abono;
            Medio = medio;
            Estado = estado;
            Tienda = tienda;
            Idproducto = idproducto;
            Unidades = unidades;
            Referencia = referencia;
        }

        public Ventas()
        {
        }



        #endregion


        #region Metodos

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
            tabla.Columns.Add("Venta", typeof(string));
            tabla.Columns.Add("Stock", typeof(string));
            tabla.Columns.Add("Tienda", typeof(string));
            // Consulta a la base de datos

            try
            {
                SqlCommand sql = new SqlCommand(String.Format("SELECT P.idproducto,P.codigo,P.nombre,P.laboratorio,P.presentacion,P.cantidad,P.venta, E.stock,E.tienda from productos as P INNER JOIN existencias as E ON P.idproducto=E.idproducto  WHERE (P.codigo like'%" + arg + "%' or P.nombre like '%" + arg + "%' or P.laboratorio like '%" + arg + "%') and tienda like '%" + Tienda + "%' "), conexion.conectar());
                SqlDataReader rd = sql.ExecuteReader();
                while (rd.Read())
                {

                    //Llenando la tabla

                    tabla.Rows.Add(rd.GetSqlInt32(0), rd.GetSqlString(1), rd.GetSqlString(2), rd.GetSqlString(3), rd.GetSqlString(4), rd.GetSqlString(5), rd.GetSqlInt32(6), rd.GetSqlInt32(7),rd.GetSqlString(8));
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
            return tabla;
        }





        public bool registrar_venta()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("INSERT INTO ventas(fecha,hora,total,subtotal,descuento,abono,medio,referencia,estado,tienda) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", Fecha,Hora,Total,Subtotal,Descuento,Abono,Medio,Referencia,Estado,Tienda), conexion.conectar());
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



        public void obtener_idventa()
        {
            
            try
            {
                SqlCommand cmd = new SqlCommand(String.Format("SELECT MAX(idventa) FROM ventas"), conexion.conectar());
                Idventa = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.ToString());
            }
        }

        public bool registrar_subventa()
        {
            bool confirmacion = false;

            obtener_idventa();

            if (Idventa != -1)
            {
                try
                {
                    SqlCommand sql = new SqlCommand(string.Format("INSERT INTO subventas(idventa,idproducto,unidades,total,subtotal,descuento) values('{0}','{1}','{2}','{3}','{4}','{5}')", Idventa, Idproducto,Unidades,Total,Subtotal,Descuento), conexion.conectar());
                    if (sql.ExecuteNonQuery() != 0)
                    {
                        if (!this.Estado.Equals("ENCARGO"))
                        {
                            if (restar_existencias())
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
                int actual = 0;
                int nuevo = 0;

                SqlCommand sql = new SqlCommand(String.Format("SELECT stock FROM existencias WHERE idproducto='" + Idproducto + "'"), conexion.conectar());
                SqlDataReader rd = sql.ExecuteReader();
                while (rd.Read())
                {
                    actual = rd.GetInt32(0);
                }

                nuevo = actual - Unidades;
                return nuevo;
            }

            public bool restar_existencias()
            {
                bool respuesta = false;

                int stock = obtener_stock();

                try
                {
                    SqlCommand sql = new SqlCommand(string.Format("UPDATE existencias SET stock='{0}' where idproducto='{1}'", stock, Idproducto), conexion.conectar());
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
