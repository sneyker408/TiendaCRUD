using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductoDAL
    {
        ContextoDB _db;

        public int Guardar(Producto producto, int id = 0, bool esActualizacion = false)
        {

            _db = new ContextoDB();

            int resultado;

            if (esActualizacion)
            {
                producto.ProductoID = id;

                _db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = producto.ProductoID;
            }
            else
            {
                _db.Productos.Add(producto);
                _db.SaveChanges();

                resultado = producto.ProductoID;
            }

            return resultado;
        }

        public List<Producto> Leer()
        {

            _db = new ContextoDB();

            return _db.Productos.Where(p => p.Estado == true).ToList();
        }

        public Producto LeerPorId(int id)
        {

            _db = new ContextoDB();

            return _db.Productos.Find(id);
        }
    }
}
