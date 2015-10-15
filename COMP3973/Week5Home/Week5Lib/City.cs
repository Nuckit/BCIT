using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week5Lib
{
    public class City
    {        
        public int CityId { get; set; }

        [Required]
        [StringLength(30)]
        public string CityName { get; set; }

        [Required]
        public int Population { get; set; }

        public string ProvinceCode { get; set; }
        
        public Province Province { get; set; }
    }
}