using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Inventario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventarioID { get; set; }

        [Required(ErrorMessage = "El producto del inventario es obligatorio.")]
        public int ProductoID { get; set; }

        [Required(ErrorMessage = "La cantidad en stock del inventario es obligatoria.")]
        [Range(0, int.MaxValue, ErrorMessage = "La cantidad en stock del inventario debe ser un valor positivo.")]
        public int CantidadStock { get; set; }

        [Required(ErrorMessage = "La fecha de última reposición del inventario es obligatoria.")]
        public DateTime FechaUltimaReposicion { get; set; }

        [Required(ErrorMessage = "El proveedor del inventario es obligatorio.")]
        public int ProveedorID { get; set; }
    }
}
