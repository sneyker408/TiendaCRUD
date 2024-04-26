using System;   
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    [Table("DetallePedidos")] // Especifica el nombre de la tabla en la base de datos

    public class DetallePedido
    {
        [Key]
        public int DetallePedidoID { get; set; }

        [ForeignKey("Pedido")]
        public int PedidoID { get; set; }
        public Pedido Pedido { get; set; }

        [ForeignKey("Producto")]
        public int ProductoID { get; set; }
        public Producto Producto { get; set; }

        [Required(ErrorMessage = "La cantidad del producto en el pedido es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad del producto en el pedido debe ser al menos uno.")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El precio unitario del producto es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio unitario del producto debe ser mayor que cero.")]
        public decimal PrecioUnitario { get; set; }
    } 
}
