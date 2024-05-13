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

        public int GuardarCliente(Cliente cliente)
        {
            _clienteDAL = new ClienteDAL();

            return _clienteDAL.Guardar(cliente);
        }

        public Cliente ObtenerClientePorId(int codigo)
        {
            _clienteDAL = new ClienteDAL();

            return _clienteDAL.LeerPorId(codigo);
        }

        public int ActualizarCliente(Cliente cliente, int id)
        {
            _clienteDAL = new ClienteDAL();

            return _clienteDAL.Guardar(cliente, id, true);
        }

        public List<Cliente> ObtenerClientes()
        {
            _clienteDAL = new ClienteDAL();

            return _clienteDAL.Leer();
        }

        public bool CorreoElectronicoExiste(string correoElectronico)
        {
            using (var contexto = new ContextoBD())
            {
                return contexto.Clientes.Any(c => c.CorreoElectronico == correoElectronico);
            }
        }

        public int EliminarCliente(int id)
        {
            _clienteDAL = new ClienteDAL();
            return _clienteDAL.EliminarCliente(id);
        }
    }
}
