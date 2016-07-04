using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{

    public partial class Employee
    {
        
        public Employee()
        {
            Employee1 = new HashSet<Employee>();
            Order = new HashSet<Order>();
        }

        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(10, ErrorMessage = "The First Name field must be a string with a maximum length of 10.")]
        public string FirstName { get; set; }

        [StringLength(30, ErrorMessage = "The Title field must be a string with a maximum length of 30.")]
        public string Title { get; set; }

        [StringLength(25, ErrorMessage = "The Title Of Courtesy field must be a string with a maximum length of 25.")]
        [Display(Name = "Title Of Courtesy")]
        public string TitleOfCourtesy { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? HireDate { get; set; }

        [StringLength(60, ErrorMessage = "The Address field must be a string with a maximum length of 60.")]
        public string Address { get; set; }

        [StringLength(15, ErrorMessage = "The City field must be a string with a maximum length of 15.")]
        public string City { get; set; }

        [StringLength(15, ErrorMessage = "The Region must be a string with a maximum length of 15.")]
        public string Region { get; set; }

        [StringLength(10, ErrorMessage = "The Postal Code field must be a string with a maximum length of 10.")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [StringLength(15, ErrorMessage = "The Country field must be a string with a maximum length of 15.")]
        public string Country { get; set; }

        [StringLength(24, ErrorMessage = "The Home Phone field must be a string with a maximum length of 24.")]
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        [StringLength(4, ErrorMessage = "The Extension field must be a string with a maximum length of 4.")] 
        public string Extension { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Display(Name = "Reports To")]
        public int? ReportsTo { get; set; }

        [StringLength(255)]
        [Display(Name = "Photo Path")]
        public string PhotoPath { get; set; }
        
        public virtual ICollection<Employee> Employee1 { get; set; }

        public virtual Employee Employee2 { get; set; }
        
        public virtual ICollection<Order> Order { get; set; }
    }
}
