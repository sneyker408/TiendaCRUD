using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoID { get; set; }
        
        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre del producto no puede tener más de 100 caracteres.")]
        public string NombreProducto { get; set; }

        [StringLength(255, ErrorMessage = "La descripción del producto no puede tener más de 255 caracteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El precio del producto es obligatorio.")]
        [Range(0, 9999999.99, ErrorMessage = "El precio del producto debe ser un valor entre 0 y 9999999.99.")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El stock disponible del producto es obligatorio.")]
        [Range(0, int.MaxValue, ErrorMessage = "El stock disponible del producto debe ser un valor positivo.")]
        public int StockDisponible { get; set; }

        [StringLength(100, ErrorMessage = "El nombre del fabricante no puede tener más de 100 caracteres.")]
        public string Fabricante { get; set; }

        [Required(ErrorMessage = "La categoría del producto es obligatoria.")]
        public int CategoriaID { get; set; }
    }
}
