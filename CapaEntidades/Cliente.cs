using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
       
namespace CapaEntidades
{
    [Table("Clientes")] // Especifica el nombre de la tabla en la base de datos

    public class Cliente
    {            
        [Key]
        public int ClienteID { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre del cliente no puede tener más de 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido del cliente es obligatorio.")]
        [StringLength(100, ErrorMessage = "El apellido del cliente no puede tener más de 100 caracteres.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El correo electrónico del cliente es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
        public string CorreoElectronico { get; set; }

        [Required(ErrorMessage = "La dirección del cliente es obligatoria.")]
        [StringLength(255, ErrorMessage = "La dirección del cliente no puede tener más de 255 caracteres.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El número de teléfono del cliente es obligatorio.")]
        [StringLength(20, ErrorMessage = "El número de teléfono del cliente no puede tener más de 20 caracteres.")]
        public string NumeroTelefono { get; set; }
    }      
}
