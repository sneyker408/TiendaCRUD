using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(250)]
        public string Descripcion { get; set; }
        [Required]
        public decimal PrecioUnitario { get; set; }
        [Required]
        public int Existencias { get; set; }
        [Required]
        public bool Estado { get; set; }

        [Required]
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria NombreCategoria { get; set; }

        [Required]
        public int FabricanteId { get; set; }
        [ForeignKey("FabricanteId")]
        public Fabricante NombreFabricante { get; set; }

    }
}
