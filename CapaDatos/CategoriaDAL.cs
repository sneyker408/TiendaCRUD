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

        ContextoBD _db;

        public int Guardar(Categoria categoria, int id = 0, bool esActualizacion = false)
        {
            _db = new ContextoBD();

            int resultado;

            if (esActualizacion)
            {
                categoria.CategoriaId = id;

                _db.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = categoria.CategoriaId;
            }
            else
            {
                _db.Categorias.Add(categoria);
                _db.SaveChanges();

                resultado = categoria.CategoriaId;
            }

            return resultado;
        }

        public List<Categoria> Leer()
        {
            _db = new ContextoBD();

            return _db.Categorias.ToList();
        }

        public Categoria LeerPorId(int id)
        {
            _db = new ContextoBD();

            return _db.Categorias.Find(id);
        }

        

        public List<Categoria> Categorias(bool inactivo = false)
        {
            _db = new ContextoBD();

            if (inactivo)
            {
                return _db.Categorias.Where(c => c.Estado == false).ToList();
            }
            else
            {
                return _db.Categorias.Where(c => c.Estado == true).ToList();
            }
        }

        public string ObtenerNombreCategoriaDesdeBD(int idCategoria)
        {
            string nombreCategoria = string.Empty;
            _db = new ContextoBD();
            Categoria categoria = _db.Categorias.FirstOrDefault(m => m.CategoriaId == idCategoria);
            if (categoria != null)
            {
                nombreCategoria = categoria.NombreCategoria;
            }
            return nombreCategoria;
        }

        public int EliminarCategoria(int id)
        {
            _db = new ContextoBD();
            int resultado = 0;

            var categoria = _db.Categorias.Find(id);

            if (categoria != null)
            {
                categoria.Estado = false;
                _db.SaveChanges();

                resultado = categoria.CategoriaId;
            }

            return resultado;
        }
    }
}
