using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class PedidoLOG
    {
        PedidoDAL _pedidoDAL;

        public int GuardarPedido(Pedido pedido, int id = 0, bool esActualizacion = false)
        {
            _pedidoDAL = new PedidoDAL();

            return _pedidoDAL.Guardar(pedido, id, esActualizacion);
        }

        public List<Pedido> ObtenerPedido()
        {
            _pedidoDAL = new PedidoDAL();

            return _pedidoDAL.Leer();
        }
    }
}
