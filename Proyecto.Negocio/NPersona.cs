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
    public class NPersona
    {
        public static DataTable Listar()
        {
            DPersona Datos = new DPersona();
            return Datos.Listar();
        }

        public static DataTable ListarProveedores()
        {
            DPersona Datos = new DPersona();
            return Datos.ListarProveedores();
        }

        public static DataTable ListarClientes()
        {
            DPersona Datos = new DPersona();
            return Datos.ListarClientes();
        }

        public static DataTable Buscar(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.Buscar(Valor);
        }

        public static DataTable BuscarProveedores(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarProveedores(Valor);
        }

        public static DataTable BuscarClientes(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarClientes(Valor);
        }

        public static string Insertar(string TipoPersona, string Nombre, string tipoDocumento, string numDocumento, string Direccion, string Telefono, string Email)
        {
            DPersona Datos = new DPersona();

            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La persona ya se encuentra registrada";
            }
            else
            {
                Persona Obj = new Persona();
                Obj.TipoPersona = TipoPersona;
                Obj.Nombre = Nombre;
                Obj.TipoDocumento = tipoDocumento;
                Obj.NumeroDocumento = numDocumento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int id, string tipoPersona, string NombreAnterior, string Nombre, string tipoDocumento, string numDocumento, string Direccion, string Telefono, string Email)
        {
            DPersona Datos = new DPersona();
            Persona Obj = new Persona();

            if (NombreAnterior.Equals(Nombre)) //esto es para verificar que el correo es correcto
            {
                Obj.IdPersona = id;
                Obj.TipoPersona = tipoPersona;
                Obj.Nombre = Nombre;
                Obj.TipoDocumento = tipoDocumento;
                Obj.NumeroDocumento = numDocumento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "Una persona con ese nombre ya existe";
                }
                else
                {
                    Obj.IdPersona = id;
                    Obj.TipoPersona = tipoPersona;
                    Obj.Nombre = Nombre;
                    Obj.TipoDocumento = tipoDocumento;
                    Obj.NumeroDocumento = numDocumento;
                    Obj.Direccion = Direccion;
                    Obj.Telefono = Telefono;
                    Obj.Email = Email;
                    return Datos.Actualizar(Obj);
                }
            }

        }

        public static string Eliminar(int Id)
        {
            DPersona Datos = new DPersona();
            return Datos.Eliminar(Id);
        }
    }
}
