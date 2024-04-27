using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ClienteLOG
    {
        ClienteDAL _clienteDAL;

        public int GuardarCliente(Cliente cliente, int id = 0, bool esActualizacion = false)
        {
            _clienteDAL = new ClienteDAL();

            return _clienteDAL.Guardar(cliente, id, esActualizacion);
        }

    }
}
