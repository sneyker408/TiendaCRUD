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
        ContextoBD _db;

        public int EliminarCliente(int id)
        {
            _db = new ContextoBD();
            int resultado = 0;

            var cliente = _db.Clientes.Find(id);

            if (cliente != null)
            {
                _db.SaveChanges();

                resultado = cliente.ClienteId;
            }

            return resultado;
        }

        public int Guardar(Cliente cliente, int id = 0, bool esActualizacion = false)
        {
            _db = new ContextoBD();

            int resultado;

            if (esActualizacion)
            {
                cliente.ClienteId = id;

                _db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = cliente.ClienteId;
            }
            else
            {
                _db.Clientes.Add(cliente);
                _db.SaveChanges();

                resultado = cliente.ClienteId;
            }

            return resultado;
        }

        public List<Cliente> Leer()
        {
            _db = new ContextoBD();

            return _db.Clientes.ToList();
        }

        public Cliente LeerPorId(int id)
        {
            _db = new ContextoBD();

            return _db.Clientes.Find(id);
        }

        public List<Cliente> NumeroTelefonoExiste(bool inactivo = false)
        {
            _db = new ContextoBD();

            return _db.Clientes.ToList();
        }
    }
}
