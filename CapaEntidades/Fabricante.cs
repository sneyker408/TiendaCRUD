using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Fabricante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FabricanteId { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreFabricante { get; set; }

        [Required]
        public bool Estado { get; set; }
    }
}
