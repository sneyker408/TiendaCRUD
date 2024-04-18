using System;   
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetallePedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DetallePedidoID { get; set; }

        [Required(ErrorMessage = "El pedido es obligatorio.")]
        public int PedidoID { get; set; }

        [Required(ErrorMessage = "El producto del detalle del pedido es obligatorio.")]
        public int ProductoID { get; set; }

        [Required(ErrorMessage = "La cantidad del detalle del pedido es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad del detalle del pedido debe ser un valor positivo.")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El precio unitario del detalle del pedido es obligatorio.")]
        [Range(0, 9999999.99, ErrorMessage = "El precio unitario del detalle del pedido debe ser un valor entre 0 y 9999999.99.")]
        public decimal PrecioUnitario { get; set; }


        // propiedades de navgacion 

        public List<DetallePedido> Detalles { get; set; } 
    }
}
