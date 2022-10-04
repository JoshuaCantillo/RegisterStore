using System;
using System.Data;
using System.Data.SqlClient;

namespace RegisterStore.Logic
{
    internal class Usuarios
    {

        #region variables privadas

        private int _idusuario;
        private string _nombre;
        private string _clave;
        private string _tipo;
        private string _tienda;

        #endregion

        #region Variablre publicas

        public int Idusuario { get => _idusuario; set => _idusuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Clave { get => _clave; set => _clave = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Tienda { get => _tienda; set => _tienda = value; }

        public Conexion conexion = new Conexion();

        #endregion

        #region Constructores


        public Usuarios(int idusuario, string nombre, string clave, string tipo, string tienda)
        {
            Idusuario = idusuario;
            Nombre = nombre;
            Clave = clave;
            Tipo = tipo;
            Tienda = tienda;
        }

        public Usuarios()
        {
        }



        #endregion


        #region Metodos

        public Boolean login()
        {
            bool rt = false;
            SqlCommand _sql = new SqlCommand(String.Format("select * from usuarios where nombre='{0}' and clave='{1}'", Nombre, Clave), conexion.conectar());
            SqlDataReader _rd = _sql.ExecuteReader();
            while (_rd.HasRows)
            {
                rt = true;
                break;
            }
            return rt;
        }

        public String obtener_tienda()
        {
            String tienda = "";
            SqlCommand _sql = new SqlCommand(String.Format("select tienda from usuarios where nombre='{0}' and clave='{1}'", Nombre, Clave), conexion.conectar());
            SqlDataReader _rd = _sql.ExecuteReader();
            while (_rd.Read())
            {
                tienda = _rd.GetString(0);
            }
            return tienda;
        }


        public String obtener_tipo()
        {
            String tipo_usuario = "";
            SqlCommand _sql = new SqlCommand(String.Format("select * from usuarios where nombre='{0}' and clave='{1}'", Nombre, Clave), conexion.conectar());
            SqlDataReader _rd = _sql.ExecuteReader();
            while (_rd.Read())
            {
                tipo_usuario = _rd.GetString(3);
            }
            return tipo_usuario;
        }

        public DataTable buscar_usuario(string arg)
        {
            DataTable tabla = new DataTable();

            //Diseño de la cabecera de la tabla 

            tabla.Columns.Add("IdUsuario", typeof(string));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Contraseña", typeof(string));
            tabla.Columns.Add("Tipo", typeof(string));
            tabla.Columns.Add("Tienda", typeof(string));

            try
            {
                SqlCommand sql = new SqlCommand(String.Format("SELECT * FROM usuarios WHERE nombre like '%" + arg + "%' or tienda like '%" + arg + "%'"), conexion.conectar());
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

        public bool crear_usuario()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("INSERT INTO usuarios(nombre,clave,tipo,tienda) values('{0}','{1}','{2}','{3}')", Nombre, Clave, Tipo.ToUpper(), Tienda.ToUpper()), conexion.conectar());
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

        public bool modificar_usuario()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("UPDATE usuarios SET nombre='{0}',clave='{1}',tipo='{2}' ,tienda='{3}' where idusuario='{4}'", Nombre, Clave, Tipo.ToUpper(), Tienda.ToUpper(), Idusuario), conexion.conectar()); ;
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

        public bool eliminar_usuario()
        {
            bool confirmacion = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("DELETE FROM usuarios where idusuario='{0}'", Idusuario), conexion.conectar());
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
