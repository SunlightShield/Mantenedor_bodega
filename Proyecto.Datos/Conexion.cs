using System;
using System.Data.SqlClient;

namespace Proyecto.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "dbsistema";
            this.Servidor = "LAPTOP-O8QQ2BNQ";
            this.Usuario = "root";
            this.Clave = "";
            this.Seguridad = true;
        }

        public SqlConnection CrearConn()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                if (this.Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated security = SSPI";
                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User id = " + this.Usuario + "; Password = " + this.Clave + ";";
                }
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

    }
}
