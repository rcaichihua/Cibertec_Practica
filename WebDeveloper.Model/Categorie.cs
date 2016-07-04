using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public partial class Categorie
    {
        
        public Categorie()
        {
            Product = new HashSet<Product>();
        }

        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(15, ErrorMessage = "The Category Name field must be a string with a maximum length of 30.")]
        [Display(Name = "Category Name")]      
        public string CategoryName { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }
        
        public virtual ICollection<Product> Product { get; set; }
    }
}
