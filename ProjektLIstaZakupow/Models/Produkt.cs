using System.ComponentModel.DataAnnotations;

namespace ProjektLIstaZakupow.Models
{
    public class Produkt
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Nazwa { get; set; }

        public string? Rodzaj { get; set; }
        public bool CzyKupione { get; set; }
    }
}