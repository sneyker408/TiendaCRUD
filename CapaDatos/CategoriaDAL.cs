using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CategoriaDAL
    {
        ContextoDB _db;

        public int Guardar(Categoria categoria, int id = 0, bool esActualizacion = false)
        {

            _db = new ContextoDB();

            int resultado;

            if (esActualizacion)
            {
                categoria.CategoriaID = id;

                _db.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = categoria.CategoriaID;
            }
            else
            {
                _db.Categorias.Add(categoria);
                _db.SaveChanges();

                resultado = categoria.CategoriaID;
            }

            return resultado;
        }

        public List<Categoria> Leer()
        {

            _db = new ContextoDB();

            return _db.Categorias.ToList();
        }

        public Categoria LeerPorId(int id)
        {

            _db = new ContextoDB();

            return _db.Categorias.Find(id);
        }
    }
}
