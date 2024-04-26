using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    [Table("Inventarios")] // Especifica el nombre de la tabla en la base de datos

    public class Inventario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventarioID { get; set; }

        [ForeignKey("Producto")]
        public int ProductoID { get; set; }
        public Producto Producto { get; set; }

        [Required(ErrorMessage = "La cantidad en stock es obligatoria.")]
        [Range(0, int.MaxValue, ErrorMessage = "La cantidad en stock debe ser mayor o igual a cero.")]
        public int CantidadStock { get; set; }

        [Required(ErrorMessage = "La fecha de última reposición es obligatoria.")]
        public DateTime FechaUltimaReposicion { get; set; }

        [ForeignKey("Proveedor")]
        public int ProveedorID { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}
