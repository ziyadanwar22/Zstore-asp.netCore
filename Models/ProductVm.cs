using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SouqStore.Models
{
    public class ProductVm
    {
        [Required]
        [Display(Name ="Category Name")]
        [MinLength(10)]
        public string CatName { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        [MaxLength(20)]
        public string ProName{ get; set; }
        public decimal Proprice { get; set; }
        public decimal ProQty { get; set; }
    }
}
