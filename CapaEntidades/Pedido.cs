using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    [Table("Pedidos")] // Especifica el nombre de la tabla en la base de datos

    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PedidoID { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "La fecha y hora del pedido son obligatorias.")]
        public DateTime FechaHoraPedido { get; set; }

        [Required(ErrorMessage = "El estado del pedido es obligatorio.")]
        [StringLength(50, ErrorMessage = "El estado del pedido no puede tener más de 50 caracteres.")]
        public bool EstadoPedido { get; set; }

        [Required(ErrorMessage = "El total del pedido es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El total del pedido debe ser mayor que cero.")]
        public decimal TotalPedido { get; set; }
    }
}
