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

        public Producto ObtenerProductoSegunId(int producto)
        {
            _productoDAL= new ProductoDAL();
            return _productoDAL.LeerProductoporId(producto);
        }

        public string ExtraerExistenciasProduc(int producto)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.ExtraerExistenciasProduc(producto);
        }

        public string ExtraerPrecioProduc(int producto)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.ExtraerPrecioUnitarioProduc(producto);
        }

        public int ObtenerIdPorNombre(string nombreCategoria)
        {
            _productoDAL = new ProductoDAL();

            return _productoDAL.ObtenerIdPorNombreProducto(nombreCategoria);
        }

        public string ExtraerNombreProducto(int idproducto)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.ObtenerNombreProductoDesdeBD(idproducto);
        }

        public Producto ObtenerProductoPorNombre(string nombreProducto)
        {
            _productoDAL = new ProductoDAL();

            return _productoDAL.ObtenerProductoPorNombre(nombreProducto);
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

        public List<Producto> ObtenertodsProductos(bool inactivos = false)
        {
            _productoDAL = new ProductoDAL();

            return _productoDAL.LeerTodosProdcutos(inactivos);
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

        public int ExtraerCodigoFabricante(int codigo)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.ObtenerCodigoFabricanteDesdeBD(codigo);
        }

        public int ExtraerCodigoCategoria(int codigo)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.ObtenerCodigoCategoriaDesdeBD(codigo);
        }

        public string ExtraerNombreProduc(int codigo)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.ObtenerNombreProductoDesdeBD(codigo);
        }

        public List<string> ObtenerNombre()
        {
            List<string> productos = new List<string>();

            using (var _db = new ContextoBD())
            {
                productos = _db.Productos.Select(c => c.Nombre).ToList();
            }

            return productos;
        }
    }
}
