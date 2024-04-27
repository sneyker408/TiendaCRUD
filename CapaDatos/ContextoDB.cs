using CapaEntidades;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace CapaDatos
{
    public class ContextoDB : DbContext
    {
        public ContextoDB()
            : base("name=ContextoDB")
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }

        public virtual DbSet<Cliente> Clientes { get; set; }    
        public virtual DbSet<DetallePedido> DetallePedidos { get; set; }

        public virtual DbSet<Inventario> Inventarios { get; set; }

        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set;}
    }
}
