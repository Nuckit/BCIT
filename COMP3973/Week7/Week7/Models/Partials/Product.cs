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
        
        [UIHint("_SupplierDropDownList")]
        [Display(Name = "Supplier")]
        public object SupplierID { get; set; }
        
        [UIHint("_CategoryDropDownList")]
        [Display(Name = "Category")]
        public object CategoryID { get; set; }

        [ScaffoldColumn(false)]
        public object QuantityPerUnit { get; set; }
        
        [Required]
        [DataType(DataType.Currency, ErrorMessage = "Input type is not in currency format")]
        [Display(Name = "Unit Price")]
        public object UnitPrice { get; set; }

        [ScaffoldColumn(false)]
        public object UnitsInStock { get; set; }

        [ScaffoldColumn(false)]
        public object UnitsOnOrder { get; set; }

        [ScaffoldColumn(false)]
        public object ReorderLevel { get; set; }

        [ScaffoldColumn(false)]
        public object Discontinued { get; set; }
    }
}