using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Required]        
        public Province Province { get; set; }
    }
}