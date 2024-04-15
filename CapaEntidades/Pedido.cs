using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int PedidoID { get; set; }

        [Required(ErrorMessage = "El cliente del pedido es obligatorio.")]
        public int ClienteID { get; set; }

        [Required(ErrorMessage = "La fecha y hora del pedido es obligatoria.")]
        public DateTime FechaHoraPedido { get; set; }

        [Required(ErrorMessage = "El estado del pedido es obligatorio.")]
        [StringLength(50, ErrorMessage = "El estado del pedido no puede tener más de 50 caracteres.")]
        public string EstadoPedido { get; set; }

        [Required(ErrorMessage = "El total del pedido es obligatorio.")]
        [Range(0, 9999999.99, ErrorMessage = "El total del pedido debe ser un valor entre 0 y 9999999.99.")]
        public decimal TotalPedido { get; set; }
    }
}
