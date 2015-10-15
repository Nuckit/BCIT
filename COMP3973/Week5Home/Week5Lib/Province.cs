using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Week5Lib
{
    public class Province
    {
        [Key]
        [StringLength(2)]
        public string ProvinceCode { get; set; }

        [Required]
        [StringLength(20)]
        public string ProvinceName { get; set; }
        
        public List<City> Cities { get; set; }
    }
}