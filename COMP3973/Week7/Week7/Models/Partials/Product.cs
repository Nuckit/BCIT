using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Week7.Models.Validation;

namespace Week7.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {         
    }

    public class ProductMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public object ProductID { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        [MaxWords(3)]
        public object ProductName { get; set; }
    }
}