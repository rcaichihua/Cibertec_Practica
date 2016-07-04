using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public partial class Supplier
    {
        public Supplier()
        {
            Product = new HashSet<Product>();
        }

        [Key]
        public int SupplierID { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "The Company Name field must be a string with a maximum length of 40.")]
        public string CompanyName { get; set; }

        [StringLength(30, ErrorMessage = "The Contact Name field must be a string with a maximum length of 30.")]
        public string ContactName { get; set; }

        [StringLength(30, ErrorMessage = "The Contact Title field must be a string with a maximum length of 30.")]
        public string ContactTitle { get; set; }

        [StringLength(60, ErrorMessage = "The Address field must be a string with a maximum length of 60.")]
        public string Address { get; set; }

        [StringLength(15, ErrorMessage = "The City field must be a string with a maximum length of 15.")]
        public string City { get; set; }

        [StringLength(15, ErrorMessage = "The Region field must be a string with a maximum length of 15.")]
        public string Region { get; set; }

        [StringLength(10, ErrorMessage = "The Postal Code field must be a string with a maximum length of 10.")]
        public string PostalCode { get; set; }

        [StringLength(15, ErrorMessage = "The Country field must be a string with a maximum length of 15.")]
        public string Country { get; set; }

        [StringLength(24, ErrorMessage = "The Phone field must be a string with a maximum length of 24.")]
        public string Phone { get; set; }
        [StringLength(24, ErrorMessage = "The Fax field must be a string with a maximum length of 24.")]
        public string Fax { get; set; }

        [Column(TypeName = "ntext")]
        public string HomePage { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
