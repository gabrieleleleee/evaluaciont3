using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EVALUACION_T3.Models
{
    public class Aventurero
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAventurero { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        [ForeignKey("IdEspecialidad")]
        public Especialidad? Especialidad { get; set; }
        public int IdEspecialidad { get; set; }

        public ICollection<Especialidad>? Especialidades { get; set; }
    }
}
