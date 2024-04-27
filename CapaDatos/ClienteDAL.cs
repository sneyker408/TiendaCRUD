using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClienteDAL
    {
        ContextoDB _db;

        public int Guardar(Cliente cliente, int id = 0, bool esActualizacion = false)
        {

            _db = new ContextoDB();

            int resultado;

            if (esActualizacion)
            {
                cliente.ClienteID = id;

                _db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = cliente.ClienteID;
            }
            else
            {
                _db.Clientes.Add(cliente);
                _db.SaveChanges();

                resultado = cliente.ClienteID;
            }

            return resultado;
        }

        public Cliente LeerPorId(int id)
        {

            _db = new ContextoDB();

            return _db.Clientes.Find(id);
        }
    }
}
