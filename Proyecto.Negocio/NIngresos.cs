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
    public class NIngresos
    {
        public static DataTable Listar()
        {
            DIngresos Datos = new DIngresos();
            return Datos.Listar();
        }

        public static DataTable Buscar(string valor)
        {
            DIngresos Datos = new DIngresos();
            return Datos.Buscar(valor);
        }

        public static DataTable ListarDetalle(int Id)
        {
            DIngresos Datos = new DIngresos();
            return Datos.ListarDetalle(Id);
        }

        public static string Insertar(int IdProveedor, int IdUsuario, string TipoComprobante, string SerieComprobante, string NumComprobante, decimal Impuesto, decimal Total, DataTable Detalles)
        {
            DIngresos Datos = new DIngresos();
            Ingresos obj = new Ingresos();
            obj.IdProveedor = IdProveedor;
            obj.IdUsuario = IdUsuario;
            obj.TipoComprobante = TipoComprobante;
            obj.SerieComprobante = SerieComprobante;
            obj.NumComprobante = NumComprobante;
            obj.Impuesto = Impuesto;
            obj.Total = Total;
            obj.Detalles = Detalles;
            return Datos.Insertar(obj);
        }
        public static string Anular(int Id)
        {
            DIngresos Datos = new DIngresos();
            return Datos.Anular(Id);
        }

    }
}
