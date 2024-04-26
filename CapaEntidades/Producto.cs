using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    [Table("Productos")] // Especifica el nombre de la tabla en la base de datos

    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoID { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre del producto no puede tener más de 100 caracteres.")]
        public string NombreProducto { get; set; }

        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El precio del producto es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio del producto debe ser mayor que cero.")]

        public decimal Precio { get; set; }
        [Required(ErrorMessage = "El stock disponible del producto es obligatorio.")]
        [Range(0, int.MaxValue, ErrorMessage = "El stock disponible del producto debe ser mayor o igual a cero.")]

        public int StockDisponible { get; set; }

        public string Fabricante { get; set; }

        public string EstadoPedido { get; set; }

        [Required(ErrorMessage = "El total del pedido es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El total del pedido debe ser mayor que cero.")]

        [ForeignKey("Categoria")]
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
    }
}
