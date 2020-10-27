using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPiGTodos.WebT.Models
{
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(5)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        public int DeptoId { get; set; }

        public Depto Depto { get; set; }

        public ICollection<Tercero> Terceros { get; set; }

    }
}
