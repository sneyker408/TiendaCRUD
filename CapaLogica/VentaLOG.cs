using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class VentaLOG
    {
        VentaDAL _ventaDAL;

        public int GuardarVenta(Venta venta)
        {
            _ventaDAL = new VentaDAL();
            return _ventaDAL.Guardar(venta);
        }
        public List<Venta> ObtenerVentas()
        {
            _ventaDAL = new VentaDAL();

            return _ventaDAL.LeerVentas();
        }

        public List<DetalleVenta> ObtenerDetalleVentas()
        {
            _ventaDAL = new VentaDAL();

            return _ventaDAL.LeerDetalleVentas();
        }

        public string ExtraerNombreEmpleado(int idEmpleado)
        {
            _ventaDAL = new VentaDAL();
            return _ventaDAL.ObtenerNombreEmpleadoDesdeBD(idEmpleado);

        }

        public string ExtraerNombreProducto(int idEmpleado)
        {
            _ventaDAL = new VentaDAL();
            return _ventaDAL.ObtenerNombreProdcutoDesdeBD(idEmpleado);

        }
    }
}
