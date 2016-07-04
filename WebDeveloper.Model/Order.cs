using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{

    public partial class Order
    {
        [Key]
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public int? EmployeeID { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? OrderDate { get; set; }

        [Display(Name = "Required Date")]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? RequiredDate { get; set; }

        [Display(Name = "Shipped Date")]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ShippedDate { get; set; }

        [Display(Name = "Ship Via")]
        public int? ShipVia { get; set; }

        [Column(TypeName = "money")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? Freight { get; set; }

        [Display(Name = "Ship Name")]
        [StringLength(40, ErrorMessage = "The Contact Title field must be a string with a maximum length of 40.")]
        public string ShipName { get; set; }

        [Display(Name = "Ship Address")]
        [StringLength(60, ErrorMessage = "The Contact Title field must be a string with a maximum length of 60.")]
        public string ShipAddress { get; set; }

        [Display(Name = "Ship City")]
        [StringLength(15, ErrorMessage = "The Contact Title field must be a string with a maximum length of 15.")]
        public string ShipCity { get; set; }

        [Display(Name = "Ship Region")]
        [StringLength(15, ErrorMessage = "The Contact Title field must be a string with a maximum length of 15.")]
        public string ShipRegion { get; set; }

        [Display(Name = "Ship Postal Code")]
        [StringLength(10, ErrorMessage = "The Contact Title field must be a string with a maximum length of 10.")]
        public string ShipPostalCode { get; set; }

        [Display(Name = "Ship Country")]
        [StringLength(15, ErrorMessage = "The Contact Title field must be a string with a maximum length of 15.")]
        public string ShipCountry { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
