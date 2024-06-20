using System.ComponentModel.DataAnnotations;

namespace World.Web.DTO
{
    public class CreateCountrydto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(6)]
        public string ShortName { get; set; }
        [Required]
        [MaxLength(10)]
        public string CountryCode { get; set; }
    }
}
