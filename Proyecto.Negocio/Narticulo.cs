using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto.Datos;
using Proyecto.Entidades;


namespace Proyecto.Negocio
{
    public class Narticulo
    {
        public static DataTable Listar()
        {
            Darticulo Datos = new Darticulo();//creamos un objeto
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            Darticulo Datos = new Darticulo();
            return Datos.Buscar(Valor);
        }

        public static DataTable BuscarVenta(string Valor)
        {
            Darticulo Datos = new Darticulo();
            return Datos.BuscarVenta(Valor);
        }
        public static DataTable BuscarCodigo(string Valor)
        {
            Darticulo Datos = new Darticulo();
            return Datos.BuscarCodigo(Valor);
        }

        public static DataTable BuscarCodigoVenta(string Valor)
        {
            Darticulo Datos = new Darticulo();
            return Datos.BuscarCodigoVenta(Valor);
        }
        public static String Insertar(int IdCategoria, string Codigo, string Nombre, decimal PrecioVenta, int Stock, string Descripcion, string Imagen, int Stock_minimo)
        {
            Darticulo Datos = new Darticulo();//aqui recibiremmos los parametros

            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "El articulo ya existe";
            }
            else
            {
                Articulo Obj = new Articulo();
                Obj.IdCategoria = IdCategoria;
                Obj.Codigo = Codigo;
                Obj.Nombre = Nombre;
                Obj.PrecioVenta = PrecioVenta;
                Obj.Stock = Stock;
                Obj.Descripcion = Descripcion;
                Obj.Imagen = Imagen;
                Obj.Stock_minimo = Stock_minimo;
                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int Id, int IdCategoria,string Codigo, string NombreAnt, string Nombre, decimal PrecioVenta, int Stock, string Descripcion, string Imagen, int Stock_minimo)
        {
            Darticulo Datos = new Darticulo();
            Articulo Obj = new Articulo();

            if (NombreAnt.Equals(Nombre))//si el nombre anterior es igual al del registro, solo se actualiza sin validar
            {
                Obj.IdArticulo = Id;
                Obj.IdCategoria = IdCategoria;
                Obj.Codigo = Codigo;
                Obj.Nombre = Nombre;
                Obj.PrecioVenta = PrecioVenta;
                Obj.Stock = Stock;
                Obj.Descripcion = Descripcion;
                Obj.Imagen = Imagen;
                Obj.Stock_minimo = Stock_minimo;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);//se valida y luego se actualiza el registro
                if (Existe.Equals("1"))
                {
                    return "El articulo ya existe";
                }
                else
                {
                    Obj.IdArticulo = Id;
                    Obj.IdCategoria = IdCategoria;
                    Obj.Codigo = Codigo;
                    Obj.Nombre = Nombre;
                    Obj.PrecioVenta = PrecioVenta;
                    Obj.Stock = Stock;
                    Obj.Descripcion = Descripcion;
                    Obj.Imagen = Imagen;
                    return Datos.Actualizar(Obj);
                }
            }

        }

        public static string Eliminar(int Id)
        {
            Darticulo Datos = new Darticulo();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            Darticulo Datos = new Darticulo();
            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            Darticulo Datos = new Darticulo();
            return Datos.Desactivar(Id);
        }
    }
}
