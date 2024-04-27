using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DetallePedidoDAL
    {
        ContextoDB _db;

        public int Guardar(DetallePedido detallePedido, int id = 0, bool esActualizacion = false)
        {

            _db = new ContextoDB();

            int resultado;

            if (esActualizacion)
            {
                detallePedido.DetallePedidoID = id;

                _db.Entry(detallePedido).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = detallePedido.DetallePedidoID;
            }
            else
            {
                _db.DetallePedidos.Add(detallePedido);
                _db.SaveChanges();

                resultado = detallePedido.DetallePedidoID;
            }

            return resultado;
        }

        public DetallePedido LeerPorId(int id)
        {

            _db = new ContextoDB();

            return _db.DetallePedidos.Find(id);
        }
    }
}
