using SharedModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace SharedModels
{
    public class Viking
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El número de batallas ganadas es requerido.")]
        [Range(0, int.MaxValue, ErrorMessage = "El número de batallas ganadas debe ser un número positivo.")]
        public int NumeroBatallasGanadas { get; set; }

        [Required(ErrorMessage = "El tipo de arma favorita es requerido.")]
        public string TipoArmaFavorita { get; set; }

        [Required(ErrorMessage = "El nivel de honor es requerido.")]
        public string NivelHonor { get; set; }

        [Required(ErrorMessage = "La causa de muerte gloriosa es requerida.")]
        public string CausaMuerteGloriosa { get; set; }

        public string Clasificacion { get; set; }

        public int ValhallaPoints { get; set; }
    }
}