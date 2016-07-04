using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public partial class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Supplier")]
        public int? SupplierID { get; set; }

        [Display(Name = "Category")]
        public int? CategoryID { get; set; }

        [StringLength(20, ErrorMessage = "The Contact Title field must be a string with a maximum length of 20.")]
        [Display(Name = "Quantity PerUnit")]
        public string QuantityPerUnit { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Unit Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? UnitPrice { get; set; }

        [Range(0, short.MaxValue, ErrorMessage = "Please enter valid Number")]
        [Display(Name = "Units In Stock")]
        public short? UnitsInStock { get; set; } 

        [Range(0, short.MaxValue, ErrorMessage = "Please enter valid Number")]
        [Display(Name = "Units On Order")]
        public short? UnitsOnOrder { get; set; }

        [Display(Name = "Reorder Level")]
        [Range(0, short.MaxValue, ErrorMessage = "Please enter valid Number")]
        public short? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

        public virtual Categorie Categorie { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
