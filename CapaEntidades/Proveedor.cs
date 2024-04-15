using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Proveedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ProveedorID { get; set; }

        [Required(ErrorMessage = "El nombre del proveedor es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre del proveedor no puede tener más de 100 caracteres.")]
        public string NombreProveedor { get; set; }

        [StringLength(255, ErrorMessage = "La dirección del proveedor no puede tener más de 255 caracteres.")]
        public string Direccion { get; set; }

        [StringLength(100, ErrorMessage = "El correo electrónico del proveedor no puede tener más de 100 caracteres.")]
        [EmailAddress(ErrorMessage = "El correo electrónico del proveedor no es válido.")]
        public string CorreoElectronico { get; set; }

        [StringLength(20, ErrorMessage = "El número de teléfono del proveedor no puede tener más de 20 caracteres.")]
        public string NumeroTelefono { get; set; }
    }
}
