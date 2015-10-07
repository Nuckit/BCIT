using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week4.Models.Northwind
{
    [MetadataType(typeof(RegionMetadata))]
    public partial class Region
    {
    }

    public class RegionMetadata
    {
        [Required]
        public object RegionID { get; set; }

        [Required]
        [Display(Name = "REGION DESCRIPTION")]
        [StringLength(10, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 1)]
        public object RegionDescription { get; set; }
    }
}