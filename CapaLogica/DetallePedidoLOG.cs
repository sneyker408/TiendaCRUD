using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class DetallePedidoLOG
    {
        DetallePedidoDAL _detallePedidoDAL;

        public int GuardarDetallePedido(DetallePedido detallePedido, int id = 0, bool esActualizacion = false)
        {
            _detallePedidoDAL = new DetallePedidoDAL();

            return _detallePedidoDAL.Guardar(detallePedido, id, esActualizacion);
        }

    }
}
