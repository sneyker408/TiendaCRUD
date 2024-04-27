using CapaDatos;
using CapaEntidades;
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

        public int GuardarCategoria(Categoria categoria, int id = 0, bool esActualizacion = false)
        {
            _categoriaDAL = new CategoriaDAL();

            return _categoriaDAL.Guardar(categoria, id, esActualizacion);
        }

    }
}
