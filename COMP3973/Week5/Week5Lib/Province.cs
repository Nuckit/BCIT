using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Week5Lib
{
    public class Province
    {
        [Key]
        [StringLength(2)]
        public string Code { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        
        public IList<City> Cities { get; set; }
    }
}