using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Proyecto.Entidades;

namespace Proyecto.Datos
{
    public class Darticulo
    {
            public DataTable Listar()
            {
                SqlDataReader Resultado;
                DataTable Tabla = new DataTable();
                SqlConnection SqlCon = new SqlConnection();
                try
                {
                    SqlCon = Conexion.getInstancia().CrearConn();//Devuelve ls sqlConnection
                    SqlCommand Comando = new SqlCommand("articulo_listar", SqlCon);//hacemos referencia a la base de datos
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
            public DataTable Buscar(string Valor)
            {
                SqlDataReader Resultado;
                DataTable Tabla = new DataTable();
                SqlConnection SqlCon = new SqlConnection();
                try
                {
                    SqlCon = Conexion.getInstancia().CrearConn();//Devuelve ls sqlConnection
                    SqlCommand Comando = new SqlCommand("articulo_buscar", SqlCon);//hacemos referencia a la base de datos
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;//filtamos con el valor obtenido
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

        public DataTable BuscarVenta(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConn();//Devuelve ls sqlConnection
                SqlCommand Comando = new SqlCommand("articulo_buscar_venta", SqlCon);//hacemos referencia a la base de datos
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;//filtamos con el valor obtenido
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

        public DataTable BuscarCodigo(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConn();
                SqlCommand Comando = new SqlCommand("articulo_buscar_codigo", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable BuscarCodigoVenta(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConn();
                SqlCommand Comando = new SqlCommand("articulo_buscar_codigo_venta", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public string Existe(string Valor)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConn();
                SqlCommand Comando = new SqlCommand("articulo_existe", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;//salida
                Comando.Parameters.Add(ParExiste);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Respuesta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        public string Insertar(Articulo Obj)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConn();
                SqlCommand Comando = new SqlCommand("articulo_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria",SqlDbType.Int).Value = Obj.IdCategoria;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Obj.Codigo;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                Comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = Obj.PrecioVenta;
                Comando.Parameters.Add("@stock", SqlDbType.Int).Value = Obj.Stock;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                Comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = Obj.Imagen;
                Comando.Parameters.Add("@stock_minimo", SqlDbType.Int).Value = Obj.Stock_minimo;
                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "ok" : "No se pudo ingresar el registro";// el : representa otra opcion
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }


        public string Actualizar(Articulo Obj)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConn();
                SqlCommand Comando = new SqlCommand("articulo_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Obj.IdArticulo;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.IdCategoria;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Obj.Codigo;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                Comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = Obj.PrecioVenta;
                Comando.Parameters.Add("@stock", SqlDbType.Int).Value = Obj.Stock;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                Comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = Obj.Imagen;
                Comando.Parameters.Add("@stock_minimo", SqlDbType.Int).Value = Obj.Stock_minimo;
                SqlCon.Open();//abrir coneccion.
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "ok" : "No se pudo actualizar el registro";// el : representa otra opcion
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        public string Eliminar(int Id)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConn();
                SqlCommand Comando = new SqlCommand("articulo_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id;
                SqlCon.Open();//abrir coneccion.
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "ok" : "No se pudo eliminar el registro";// el : representa otra opcion
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        public string Activar(int Id)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConn();
                SqlCommand Comando = new SqlCommand("articulo_activar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id;
                SqlCon.Open();//abrir coneccion.
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "ok" : "No se pudo activar el registro";// el : representa otra opcion
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        public string Desactivar(int Id)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConn();
                SqlCommand Comando = new SqlCommand("articulo_desactivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id;
                SqlCon.Open();//abrir coneccion.
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "ok" : "No se pudo desactivar el registro";// el : representa otra opcion
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

    }
}
