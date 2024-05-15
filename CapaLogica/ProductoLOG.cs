using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ProductoLOG
    {
        ProductoDAL _productoDAL;

        public int GuardarProducto(Producto producto)
        {
            _productoDAL = new ProductoDAL();

            return _productoDAL.Guardar(producto);
        }

        public Producto ObtenerProductoPorId(int codigo)
        {
            _productoDAL = new ProductoDAL();

            return _productoDAL.LeerPorId(codigo);
        }

        public int ActualizarProducto(Producto producto, int id)
        {
            _productoDAL = new ProductoDAL();

            return _productoDAL.Guardar(producto, id, true);
        }

        public List<Producto> ObtenerProductos(bool inactivos = false)
        {
            _productoDAL = new ProductoDAL();

            return _productoDAL.Leer(inactivos);
        }

        public int EliminarProducto(int id)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.EliminarProducto(id);
        }

        public List<Categoria> ObtenerProdcutoPorEstado(bool estadoActivo)
        {
            return _productoDAL.ObtenerProdcutoPorEstado(estadoActivo);
        }

        public List<Producto> ObtenerProductoPorCategoria(string nombreCategoria)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.ObtenerProductoPorCategoria(nombreCategoria);
        }

        public List<Producto> ObtenerProductoPorFabricante(string nombrefarbicante)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.ObtenerProductoPorFabricante(nombrefarbicante);
        }

        public int? ObtenerCategoriaProducto(int productoId)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.ObtenerCategoriaIdPorProductoId(productoId);
        }
    }
}
