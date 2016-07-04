using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public partial class Customer
    {
        
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(40,ErrorMessage = "The Company Name field must be a string with a maximum length of 40.")]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(30, ErrorMessage = "The Contact Name field must be a string with a maximum length of 30.")]
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(30, ErrorMessage = "The Contact Title field must be a string with a maximum length of 30.")]
        [Display(Name = "Contact Title")]
        public string ContactTitle { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(60, ErrorMessage = "The Address field must be a string with a maximum length of 60.")]
        public string Address { get; set; }

        [StringLength(15, ErrorMessage = "The City field must be a string with a maximum length of 15.")]
        public string City { get; set; }

        [StringLength(15, ErrorMessage = "The Region field must be a string with a maximum length of 15.")]
        public string Region { get; set; }

        [StringLength(10, ErrorMessage = "The Postal Code field must be a string with a maximum length of 10.")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [StringLength(15, ErrorMessage = "The Country field must be a string with a maximum length of 15.")]
        public string Country { get; set; }

        [StringLength(24, ErrorMessage = "The Phone field must be a string with a maximum length of 24.")]
        public string Phone { get; set; }

        [StringLength(24, ErrorMessage = "The Fax field must be a string with a maximum length of 24.")]
        public string Fax { get; set; }
     
        public virtual ICollection<Order> Order { get; set; }
    }
}
