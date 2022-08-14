using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SouqStore.Models
{
    public partial class Product
    {
        public Product()
        {
            Cart = new HashSet<Cart>();
            ProductImage = new HashSet<ProductImage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public decimal? Price { get; set; }
        public int? Catid { get; set; }
        public string Photo { get; set; }
        public string Type { get; set; }
        public string SupplierName { get; set; }
        public DateTime? EntryDate { get; set; }
        public string ReveiwUrl { get; set; }
        public int? Quntity { get; set; }

        public virtual Category Cat { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<ProductImage> ProductImage { get; set; }
    }
}
