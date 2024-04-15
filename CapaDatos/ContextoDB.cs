using CapaEntidades;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CapaDatos
{
    public partial class ContextoDB : DbContext
    {
        public ContextoDB()
            : base("name=ContextoDB")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
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
