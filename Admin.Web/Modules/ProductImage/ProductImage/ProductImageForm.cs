using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Admin.ProductImage.Forms
{
    [FormScript("ProductImage.ProductImage")]
    [BasedOnRow(typeof(ProductImageRow), CheckNames = true)]
    public class ProductImageForm
    {
        public int Productid { get; set; }
        public string Image { get; set; }
    }
}