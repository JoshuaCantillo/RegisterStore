using System;
using System.Data;
using System.Data.SqlClient;

namespace RegisterStore.Logic
{


    internal class Proveedores
    {


        #region variables privadas

        private int _idproveedor;
        private int _idproducto;
        private string _nombre;
        private string _tipo;
        private string _empresa;
        private string _celular;



        #endregion

        #region variables publicas

        public Conexion conexion = new Conexion();
        public int Idproveedor { get => _idproveedor; set => _idproveedor = value; }
        public int Idproducto { get => _idproducto; set => _idproducto = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Empresa { get => _empresa; set => _empresa = value; }
        public string Celular { get => _celular; set => _celular = value; }

        #endregion


        #region constructores

        public Proveedores(int idproveedor, int idproducto, string nombre, string tipo, string empresa, string celular)
        {
            Idproveedor = idproveedor;
            Idproducto = idproducto;
            Nombre = nombre;
            Tipo = tipo;
            Empresa = empresa;
            Celular = celular;
        }

        public Proveedores()
        {
        }

        #endregion

        #region metodos publicos

        public DataTable buscar_proveedor(string arg)
        {
            DataTable tabla = new DataTable();

            //Diseño de la cabecera de la tabla 

            tabla.Columns.Add("IdProveedor", typeof(string));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Tipo", typeof(string));
            tabla.Columns.Add("Empresa", typeof(string));
            tabla.Columns.Add("Celular", typeof(string));
            // Consulta a la base de datos

            try
            {
                SqlCommand sql = new SqlCommand(String.Format("SELECT * FROM proveedores  WHERE nombre like '%" + arg + "%'or empresa like '%" + arg + "%' "), conexion.conectar());
                SqlDataReader rd = sql.ExecuteReader();
                while (rd.Read())
                {

                    //Llenando la tabla

                    tabla.Rows.Add(rd.GetSqlInt32(0), rd.GetSqlString(1), rd.GetSqlString(2), rd.GetSqlString(3), rd.GetSqlString(4));
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
            return tabla;
        }

        public DataTable llenar_producto(int arg)
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
            // Consulta a la base de datos

            try
            {
                SqlCommand sql = new SqlCommand(String.Format("SELECT P.* FROM productos as P INNER JOIN subproveedores as S ON P.idproducto=S.idproducto WHERE S.idproveedor =" + arg + ""), conexion.conectar());
                SqlDataReader rd = sql.ExecuteReader();
                while (rd.Read())
                {

                    //Llenando la tabla

                    tabla.Rows.Add(rd.GetSqlInt32(0), rd.GetSqlString(1), rd.GetSqlString(2), rd.GetSqlString(3), rd.GetSqlString(4), rd.GetSqlString(5), rd.GetSqlInt32(7));
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
            return tabla;
        }

        public bool registrar_proveedor()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("INSERT INTO proveedores(nombre,tipo,empresa,celular) values('{0}','{1}','{2}','{3}')", Nombre.ToUpper(), Tipo.ToUpper(), Empresa.ToUpper(), Celular), conexion.conectar());
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

        public void registrar_subproveedor()
        {
            try
            {

                SqlCommand sql = new SqlCommand(string.Format("INSERT INTO subproveedores(idproveedor,idproducto) values('{0}','{1}')", Idproveedor, Idproducto), conexion.conectar());
                sql.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }


        }

        public int obtener_idproveedor()
        {
            int id = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(String.Format("SELECT MAX(idproveedor) FROM proveedores"), conexion.conectar());
                id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.ToString());
            }
            return id;
        }





        public bool modificar_proveedor()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("UPDATE proveedores SET nombre='{0}',tipo='{1}',empresa='{2}',celular='{3}' where idproveedor='{4}'", Nombre.ToUpper(), Tipo.ToUpper(), Empresa.ToUpper(), Celular, Idproveedor), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    if (eliminar_registros())
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

        public bool eliminar_registros()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("DELETE FROM subproveedores where idproveedor='{0}'", Idproveedor), conexion.conectar());
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

        public bool eliminar_proveedor()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("DELETE FROM proveedores where idproveedor='{0}'", Idproveedor), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    if (eliminar_registros())
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

        #endregion
    }
}
