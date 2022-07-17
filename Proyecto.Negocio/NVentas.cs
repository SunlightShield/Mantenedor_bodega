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
    public class NVentas
    {
        public static DataTable Listar()
        {
            DVentas Datos = new DVentas();
            return Datos.Listar();
        }

        public static DataTable Buscar(string valor)
        {
            DVentas Datos = new DVentas();
            return Datos.Buscar(valor);
        }
        public static DataTable ConsultaFechas(DateTime FechaInicio, DateTime FechaFin)
        {
            DVentas Datos = new DVentas();
            return Datos.ConsultaFechas(FechaInicio, FechaFin);
        }

        public static DataTable ListarDetalle(int Id)
        {
            DVentas Datos = new DVentas();
            return Datos.ListarDetalle(Id);
        }

        public static string Insertar(int IdClientes, int IdUsuario, string TipoComprobante, string SerieComprobante, string NumComprobante, decimal Impuesto, decimal Total, DataTable Detalles)
        {
            DVentas Datos = new DVentas();
            Ventas obj = new Ventas();
            obj.IdCliente = IdClientes;
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
            DVentas Datos = new DVentas();
            return Datos.Anular(Id);
        }

    }
}
