using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposteria.BL
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del Cliente")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese el teléfono")]
        [MinLength(8, ErrorMessage = "El teléfono debe ser de 8 digítos")]
        [MaxLength(8, ErrorMessage = "El teléfono debe ser de 8 digítos")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Ingrese ´la dirección")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        public string Direccion { get; set; }
        public bool Activo { get; set; }
    }
}
