using CapaEntidades;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace CapaDatos
{
    public class ContextoBD : DbContext
    {

        public ContextoBD()
            : base("name=ContextoBD")
        {
        }


        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVentas { get; set; }

        public virtual DbSet<Empleado> Empleados { get; set; }

        public virtual DbSet<Categoria> Categorias { get; set; }

        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<Fabricante> Fabricantes { get; set; }
    }
}