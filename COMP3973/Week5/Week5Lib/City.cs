using System.ComponentModel.DataAnnotations;

namespace Week5Lib
{
    public class City
    {
        [Required]
        public int CityId { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        public int Population { get; set; }

        public Province Province { get; set; }
    }
}