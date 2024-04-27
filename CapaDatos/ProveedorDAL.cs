using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProveedorDAL
    {
        ContextoDB _db;

        public int Guardar(Proveedor proveedor, int id = 0, bool esActualizacion = false)
        {

            _db = new ContextoDB();

            int resultado;

            if (esActualizacion)
            {
                proveedor.ProveedorID = id;

                _db.Entry(proveedor).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = proveedor.ProveedorID;
            }
            else
            {
                _db.Proveedor.Add(proveedor);
                _db.SaveChanges();

                resultado = proveedor.ProveedorID;
            }

            return resultado;
        }

        public Proveedor LeerPorId(int id)
        {

            _db = new ContextoDB();

            return _db.Proveedor.Find(id);
        }
    }
}
