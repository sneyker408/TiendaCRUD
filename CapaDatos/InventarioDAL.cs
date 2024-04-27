using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class InventarioDAL
    {
        ContextoDB _db;

        public int Guardar(Inventario inventario, int id = 0, bool esActualizacion = false)
        {

            _db = new ContextoDB();

            int resultado;

            if (esActualizacion)
            {
                inventario.InventarioID = id;

                _db.Entry(inventario).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = inventario.InventarioID;
            }
            else
            {
                _db.Inventarios.Add(inventario);
                _db.SaveChanges();

                resultado = inventario.InventarioID;
            }

            return resultado;
        }

        public Inventario LeerPorId(int id)
        {

            _db = new ContextoDB();

            return _db.Inventarios.Find(id);
        }
    }
}
