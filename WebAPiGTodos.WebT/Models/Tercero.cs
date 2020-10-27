using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPiGTodos.WebT.Models
{
    public class Tercero
    {
        [Key]
        public int Id { get; set; }

        [StringLength(15)]
        [Required]
        public string Documento { get; set; }

        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        [Display(Name = "Fecha Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime? FechaNac { get; set; }

        public int CiudadID { get; set; }

        [StringLength(50)]
        public string Direccion { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public Ciudad Ciudad { get; set; }

    }
}
