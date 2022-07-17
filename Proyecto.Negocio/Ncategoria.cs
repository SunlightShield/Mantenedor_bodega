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
    public class Ncategoria
    {
        public static DataTable Listar()
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.Listar();//llamamos la funcion desde Datos
        }

        public static DataTable Buscar(string Valor)
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.Buscar(Valor);
        }

        public static DataTable Seleccionar()
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.Seleccionar();//llamamos la funcion desde Datos
        }

        public static string Insertar(string Nombre, string Descripcion)
        {
            Dcategoria Datos = new Dcategoria();

            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La categoria ya existe";
            }
            else
            {
                Categoria Obj = new Categoria();
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int Id, string NombreAnt, string Nombre, string Descripcion)
        {
            Dcategoria Datos = new Dcategoria();
            Categoria Obj = new Categoria();

            if (NombreAnt.Equals(Nombre))//si el nombre anterior es igual al del registro, solo se actualiza sin validar
            {
                Obj.IdCategoria = Id;
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);//se valida y luego se actualiza el registro
                if (Existe.Equals("1"))
                {
                    return "La categoria ya existe";
                }
                else
                {
                    Obj.IdCategoria = Id;
                    Obj.Nombre = Nombre;
                    Obj.Descripcion = Descripcion;
                    return Datos.Actualizar(Obj);
                }
            }
            
        }

        public static string Eliminar(int Id)
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.Desactivar(Id);
        }
    }
}
