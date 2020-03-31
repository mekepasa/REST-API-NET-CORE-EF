using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicioRESTASP.NETCoreEF.Models
{
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor teclea el campo Clave")]
        [Range(1, 999)]
        public int Clave { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "Por favor teclea el campo Nombre")]
        [Column(TypeName = "VARCHAR(80)")]
        public string Nombre { get; set; }
    }
}
