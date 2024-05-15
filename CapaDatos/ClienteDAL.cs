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

        public List<Cliente> FiltrarPorNombre(string nombre)
        {
            _db = new ContextoBD();
            return _db.Clientes.Where(p => p.Nombre == nombre).ToList();
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

        public Cliente ObtenerClientePorTelefono(int numeroTelefono)
        {
            _db = new ContextoBD();

            return _db.Clientes.FirstOrDefault(f => f.NumeroTelefono == numeroTelefono);
        }

        public string ObtenercorreoFabricanteDesdeBD(int codigo)
        {
            string correoClien = string.Empty;
            _db = new ContextoBD();
            Cliente cliente = _db.Clientes.FirstOrDefault(m => m.ClienteId == codigo);
            if (cliente != null)
            {
                correoClien = cliente.CorreoElectronico;
            }
            return correoClien;
        }

        public Cliente ObtenerCorreoPorNombre(string nombrecorreo)
        {
            using (var _db = new ContextoBD())
            {
                return _db.Clientes.FirstOrDefault(f => f.CorreoElectronico.Contains(nombrecorreo));
            }
        }

        public string ObtenernumeroFabricanteDesdeBD(int codigo)
        {
            string correoClien = string.Empty;
            _db = new ContextoBD();
            Cliente cliente = _db.Clientes.FirstOrDefault(m => m.ClienteId == codigo);
            if (cliente != null)
            {
                correoClien = cliente.NumeroTelefono.ToString();
            }
            return correoClien;
        }

        public object TodosCorreos()
        {
            _db = new ContextoBD();
            return _db.Clientes.ToList();
        }

        public object TodosTelefonos()
        {
            _db = new ContextoBD();
            return _db.Clientes.ToList();
        }
    }
}
