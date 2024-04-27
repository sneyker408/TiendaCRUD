using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ProveedorLOG
    {
        ProveedorDAL _proveedorDAL;

        public int GuardarProveedor(Proveedor proveedor, int id = 0, bool esActualizacion = false)
        {
            _proveedorDAL = new ProveedorDAL();

            return _proveedorDAL.Guardar(proveedor, id, esActualizacion);
        }

    }
}
