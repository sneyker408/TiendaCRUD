using CapaEntidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CategoriaLOG
    {

        CategoriaDAL _categoriaDAL;

        public int GuardarCategoria(Categoria categoria, int id = 0, bool Actualizacion = false)
        {
            _categoriaDAL = new CategoriaDAL();

            return _categoriaDAL.Guardar(categoria, id, Actualizacion);
        }

        public string ObtenerCategoriaPorId(int idCategoria)
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.ObtenerNombreCategoriaDesdeBD(idCategoria);

        }

        public int ActualizarCategoria(Categoria categoria, int id)
        {
            _categoriaDAL = new CategoriaDAL();

            return _categoriaDAL.Guardar(categoria, id, true);
        }

        public List<Categoria> ObtenerCategorias(bool inactivo = false)
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.Categorias(inactivo);

        }
    }
}
