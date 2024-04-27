using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class InventarioLOG
    {
        InventarioDAL _inventarioDAL;

        public int GuardarInventario(Inventario inventario, int id = 0, bool esActualizacion = false)
        {
            _inventarioDAL = new InventarioDAL();

            return _inventarioDAL.Guardar(inventario, id, esActualizacion);
        }

    }
}
