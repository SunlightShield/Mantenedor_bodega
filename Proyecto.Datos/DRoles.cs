using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Proyecto.Datos
{
    public class DRoles
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConn();//Devuelve ls sqlConnection
                SqlCommand Comando = new SqlCommand("rol_listar", SqlCon);//hacemos referencia a la base de datos
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally//se ejecuta despues del try o el catch
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();//cerramos coneccion
            }

        }
    }
}
