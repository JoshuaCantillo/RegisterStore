using System;
using System.Data;
using System.Data.SqlClient;

namespace RegisterStore.Logic
{
    internal class Tiendas
    {
        #region variables privadas

        private int _idtienda;
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _antiguo;


        #endregion

        #region variables publicas
        public Conexion conexion = new Conexion();
        public int Idtienda { get => _idtienda; set => _idtienda = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Antiguo { get => _antiguo; set => _antiguo = value; }

        #endregion

        #region constructores


        public Tiendas(int idtienda, string nombre, string direccion, string telefono, string antiguo)
        {
            Idtienda = idtienda;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Antiguo = antiguo;
        }

        public Tiendas()
        {
        }



        #endregion

        #region metodos

        public DataTable buscar_tienda(string arg)
        {
            DataTable tabla = new DataTable();

            //Diseño de la cabecera de la tabla 

            tabla.Columns.Add("IdTienda", typeof(string));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Dirección", typeof(string));
            tabla.Columns.Add("Teléfono", typeof(string));

            try
            {
                SqlCommand sql = new SqlCommand(String.Format("SELECT * FROM tiendas WHERE nombre like '%" + arg + "%'"), conexion.conectar());
                SqlDataReader rd = sql.ExecuteReader();
                while (rd.Read())
                {

                    //Llenando la tabla

                    tabla.Rows.Add(rd.GetSqlInt32(0), rd.GetSqlString(1), rd.GetSqlString(2), rd.GetSqlString(3));
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
            return tabla;
        }

        public bool crear_tienda()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("INSERT INTO tiendas(nombre,direccion,telefono) values('{0}','{1}','{2}')", Nombre.ToUpper(), Direccion.ToUpper(), Telefono), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    if (leer_idproducto())
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

        public bool crear_existencias(int idproducto)
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("INSERT INTO existencias(idproducto,stock,tienda) values('{0}','{1}','{2}')", idproducto, 0, Nombre.ToUpper()), conexion.conectar());
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


        public bool leer_idproducto()
        {
            bool confirmacion = false;
            try
            {
                SqlCommand sql = new SqlCommand(String.Format("SELECT idproducto FROM productos"), conexion.conectar());
                SqlDataReader rd = sql.ExecuteReader();
                while (rd.Read())
                {

                    if (crear_existencias(rd.GetInt32(0)))
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

        public bool modificar_tienda()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("UPDATE tiendas SET nombre='{0}',direccion='{1}',telefono='{2}' where idtienda='{3}'", Nombre.ToUpper(), Direccion.ToUpper(), Telefono, Idtienda), conexion.conectar()); ;
                if (sql.ExecuteNonQuery() != 0)
                {
                    if (modificar_existencias())
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

        public bool eliminar_tienda()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("DELETE FROM tiendas where idtienda='{0}'", Idtienda), conexion.conectar());
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
                SqlCommand sql = new SqlCommand(string.Format("DELETE FROM existencias where tienda='{0}'", Nombre), conexion.conectar());
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




        public bool modificar_existencias()
        {
            bool confirmacion = false;
            try
            {
                SqlCommand sql = new SqlCommand(string.Format("UPDATE existencias SET tienda='{0}' where tienda='{1}'", Nombre.ToUpper(), Antiguo.ToUpper()), conexion.conectar()); ;
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
