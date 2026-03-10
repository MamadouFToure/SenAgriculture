using System.ComponentModel.DataAnnotations;

namespace AppSenAgriculture.Models
{
    // entite representant un lieu dans la base
    public class Lieu
    {
        [Key]
        public int IdLieu { get; set; }

        [Required, MaxLength(100)]
        public string NomLieu { get; set; }

        [MaxLength(200)]
        public string AdresseLieu { get; set; }
    }
}
