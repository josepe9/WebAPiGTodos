using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPiGTodos.WebT.Models
{
    public class Depto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(2)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        public ICollection<Ciudad> Ciudades { get; set; }
    }
}
