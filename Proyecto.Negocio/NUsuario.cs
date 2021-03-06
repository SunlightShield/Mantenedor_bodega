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
    public class NUsuario
    {
        public static DataTable Listar()
        {
            DUsuario Datos = new DUsuario();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Buscar(Valor);
        }

        public static DataTable IniciarSesion(string Email, string Clave)
        {
            DUsuario Datos = new DUsuario();
            return Datos.IniciarSesion(Email, Clave);
        }

        public static string Insertar(int idRol,string Nombre,string tipoDocumento,string numDocumento,string Direccion,string Telefono,string Email, string Clave)
        {
            DUsuario Datos = new DUsuario();

            string Existe = Datos.Existe(Email);
            if (Existe.Equals("1"))
            {
                return "El usuario con ese email ya existe";
            }
            else
            {
                Usuario Obj = new Usuario();
                Obj.IdRol = idRol;
                Obj.Nombre = Nombre;
                Obj.TipoDocumento = tipoDocumento;
                Obj.NumDocumento = numDocumento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                Obj.Clave = Clave;
                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int id, int idRol, string Nombre, string tipoDocumento, string numDocumento, string Direccion, string Telefono, string emailAnterior, string Email, string Clave)
        {
            DUsuario Datos = new DUsuario();
            Usuario Obj = new Usuario();

            if (emailAnterior.Equals(Email)) //esto es para verificar que el correo es correcto
            {
                Obj.IdUsuario = id;
                Obj.IdRol = idRol;
                Obj.Nombre = Nombre;
                Obj.TipoDocumento = tipoDocumento;
                Obj.NumDocumento = numDocumento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                Obj.Clave = Clave;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Email);
                if (Existe.Equals("1"))
                {
                    return "El usuario con ese email ya existe";
                }
                else
                {
                    Obj.IdUsuario = id;
                    Obj.IdRol = idRol;
                    Obj.Nombre = Nombre;
                    Obj.TipoDocumento = tipoDocumento;
                    Obj.NumDocumento = numDocumento;
                    Obj.Direccion = Direccion;
                    Obj.Telefono = Telefono;
                    Obj.Email = Email;
                    Obj.Clave = Clave;
                    return Datos.Actualizar(Obj);
                }
            }

        }

        public static string Eliminar(int Id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Desactivar(Id);
        }
    }
}
