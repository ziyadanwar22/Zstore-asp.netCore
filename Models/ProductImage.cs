using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SouqStore.Models
{
    public partial class ProductImage
    {
        public int Id { get; set; }
        public int? Productid { get; set; }
        public string Image { get; set; }

        public virtual Product Product { get; set; }
    }
}
