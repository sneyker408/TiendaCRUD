using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class PedidoDAL
    {
        ContextoDB _db;

        public int Guardar(Pedido pedido, int id = 0, bool esActualizacion = false)
        {

            _db = new ContextoDB();

            int resultado;

            if (esActualizacion)
            {
                pedido.PedidoID = id;

                _db.Entry(pedido).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = pedido.PedidoID;
            }
            else
            {
                _db.Pedidos.Add(pedido);
                _db.SaveChanges();

                resultado = pedido.PedidoID;
            }

            return resultado;
        }

        public List<Pedido> Leer()
        {

            _db = new ContextoDB();

            return _db.Pedidos.Where(p => p.EstadoPedido == true).ToList();
        }

        public Pedido LeerPorId(int id)
        {

            _db = new ContextoDB();

            return _db.Pedidos.Find(id);
        }
    }
}
