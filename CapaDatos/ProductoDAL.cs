﻿using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductoDAL
    {
        ContextoBD _db;

        public int EliminarProducto(int id)
        {
            _db = new ContextoBD();
            int resultado = 0;

            var producto = _db.Productos.Find(id);

            if (producto != null)
            {
                producto.Estado = false;
                _db.SaveChanges();

                resultado = producto.ProductoId;
            }

            return resultado;
        }

        public int Guardar(Producto producto, int id = 0, bool esActualizacion = false)
        {
            _db = new ContextoBD();

            int resultado;

            if (esActualizacion)
            {
                producto.ProductoId = id;

                _db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = producto.ProductoId;
            }
            else
            {
                _db.Productos.Add(producto);
                _db.SaveChanges();

                resultado = producto.ProductoId;
            }

            return resultado;
        }

        public List<Producto> Leer(bool inactivos = false)
        {
            _db = new ContextoBD();
            if(inactivos)
            {
                return _db.Productos.Where(p => p.Estado == false).ToList();
            }
            else
            {
                return _db.Productos.Where(p => p.Estado == true).ToList();
            }
            
        }

        public List<Producto> LeerTodosProdcutos(bool inactivos = false)
        {
            _db = new ContextoBD();
            return _db.Productos.ToList();

        }

        public Producto LeerPorId(int id)
        {
            _db = new ContextoBD();

            return _db.Productos.Find(id);
        }

        public Producto LeerProductoporId(int producto)
        {
            _db = new ContextoBD();
            return _db.Productos.FirstOrDefault(p => p.ProductoId == producto && p.Estado);
        }

        public Producto ObtenerProductoPorNombre(string nombreProducto)
        {
            _db = new ContextoBD();

            return _db.Productos.FirstOrDefault(f => f.Nombre.Contains(nombreProducto));
        }

        public int? ObtenerCategoriaIdPorProductoId(int productoId)
        {
            using (var _db = new ContextoBD())
            {
                // Obtener el producto con el productoId dado
                var producto = _db.Productos.FirstOrDefault(p => p.ProductoId == productoId);

                // Verificar si se encontró el producto
                if (producto != null)
                {
                    // Retornar la CategoriaId del producto encontrado
                    return producto.CategoriaId;
                }
                else
                {
                    // Retornar null si no se encuentra el producto
                    return null;
                }
            }
        }

        public int ObtenerCodigoCategoriaDesdeBD(int codigo)
        {
            _db = new ContextoBD();
            Producto producto = _db.Productos.FirstOrDefault(m => m.ProductoId == codigo);
            if (producto != null)
            {
                return producto.CategoriaId;
            }
            return 0;
        }

        public int ObtenerCodigoFabricanteDesdeBD(int codigo)
        {
            _db = new ContextoBD();
            Producto producto = _db.Productos.FirstOrDefault(m => m.ProductoId == codigo);

            if (producto != null)
            {
                return producto.FabricanteId;
            }
            return 0;

        }

        public List<Producto> ObtenerProdcutoPorCategoria(int categoriaId)
        {
            using (var _db = new ContextoBD())
            {
                return _db.Productos.Where(p => p.CategoriaId == categoriaId).ToList();
            }
        }

        public List<Categoria> ObtenerProdcutoPorEstado(bool estadoActivo)
        {
            _db = new ContextoBD();

            return _db.Categorias.Where(f => f.Estado == estadoActivo).ToList();
        }

        public List<Producto> ObtenerProductoPorCategoria(string nombreCategoria)
        {
            using (var _db = new ContextoBD())
            {
                // Obtener el ID de la categoría
                int? categoriaId = _db.Categorias.FirstOrDefault(c => c.NombreCategoria == nombreCategoria)?.CategoriaId;

                if (categoriaId.HasValue)
                {
                    return _db.Productos.Where(p => p.CategoriaId == categoriaId.Value).ToList();
                }
                else
                {
                    return new List<Producto>(); // Retorna una lista vacía si no se encuentra la categoría
                }
            }
        }

        public List<Producto> ObtenerProductoPorFabricante(string nombrefarbicante)
        {
            using (var _db = new ContextoBD())
            {
                // Obtener el ID de la categoría
                int? FabricanteId = _db.Fabricantes.FirstOrDefault(c => c.NombreFabricante == nombrefarbicante)?.FabricanteId;

                if (FabricanteId.HasValue)
                {
                    return _db.Productos.Where(p => p.FabricanteId == FabricanteId.Value).ToList();
                }
                else
                {
                    return new List<Producto>(); // Retorna una lista vacía si no se encuentra la categoría
                }
            }
        }

        public string ObtenerNombreProductoDesdeBD(int codigo)
        {
            string nombreCategoria = string.Empty;
            _db = new ContextoBD();
            Producto categoria = _db.Productos.FirstOrDefault(m => m.ProductoId == codigo);
            if (categoria != null)
            {
                nombreCategoria = categoria.Nombre;
            }
            return nombreCategoria;
        }

        public string ExtraerExistenciasProduc(int existencias)
        {
            _db = new ContextoBD();

            // Busca el producto por su ID
            Producto producto = _db.Productos.FirstOrDefault(m => m.ProductoId == existencias);

            // Inicializa la variable de nombreCategoria como una cadena vacía
            string nombreCategoria = string.Empty;

            if (producto != null)
            {
                // Convierte las existencias a cadena y asigna a nombreCategoria
                nombreCategoria = producto.Existencias.ToString();
            }

            return nombreCategoria;
        }

        public int ObtenerIdPorNombreProducto(string nombreProducto)
        {
            _db = new ContextoBD();

            // Busca el producto por su nombre
            Producto producto = _db.Productos.FirstOrDefault(m => m.Nombre == nombreProducto);

            // Si se encuentra el producto, devuelve su ID; de lo contrario, devuelve null
            if (producto != null)
            {
                return producto.ProductoId;
            }
            else
            {
                return 0; // Devuelve null si no se encuentra el producto
            }
        }

        public string ExtraerPrecioUnitarioProduc(int productoId)
        {
            _db = new ContextoBD();

            // Busca el producto por su ID
            Producto producto = _db.Productos.FirstOrDefault(m => m.ProductoId == productoId);

            // Inicializa la variable de precioUnitario como una cadena vacía
            string precioUnitario = string.Empty;

            if (producto != null)
            {
                // Convierte el precio unitario a cadena y asigna a precioUnitario
                precioUnitario = producto.PrecioUnitario.ToString();
            }

            return precioUnitario;
        }
    }
}
