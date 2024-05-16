using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class VentaDAL
    {
        ContextoBD _db;

        public int Guardar(Venta venta, int id = 0, bool esActualizacion = false)
        {
            _db = new ContextoBD();
            int resultado;

            if (esActualizacion)
            {
                venta.VentaId = id;

                _db.Entry(venta).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
            else
            {
                _db.Ventas.Add(venta);
                _db.SaveChanges();
            }

            resultado = venta.VentaId;

            return resultado;
        }

        public List<Venta> LeerVentas()
        {
            _db = new ContextoBD();

            return _db.Ventas.ToList();
        }

        public List<DetalleVenta> LeerDetalleVentas()
        {
            _db = new ContextoBD();

            return _db.DetalleVentas.ToList();
        }

        public string ObtenerNombreEmpleadoDesdeBD(int idEmpleado)
        {
            string nombreFabricante = string.Empty;
            _db = new ContextoBD();
            Empleado fabricante = _db.Empleados.FirstOrDefault(m => m.EmpleadoId == idEmpleado);
            if (fabricante != null)
            {
                nombreFabricante = fabricante.Nombre;
            }
            return nombreFabricante;
        }

        public string ObtenerNombreProdcutoDesdeBD(int idProduco)
        {
            string nombreProducto = string.Empty;
            _db = new ContextoBD();
            Producto fabricante = _db.Productos.FirstOrDefault(m => m.ProductoId == idProduco);
            if (fabricante != null)
            {
                nombreProducto = fabricante.Nombre;
            }
            return nombreProducto;
        }
    }
}
