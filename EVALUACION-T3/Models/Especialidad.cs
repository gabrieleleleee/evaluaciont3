using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EVALUACION_T3.Models
{
    public class Especialidad
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEspecialidad { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(150)]
        public string Descripcion { get; set; }

    }
}
