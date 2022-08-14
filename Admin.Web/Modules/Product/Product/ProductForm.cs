using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Admin.Product.Forms
{
    [FormScript("Product.Product")]
    [BasedOnRow(typeof(ProductRow), CheckNames = true)]
    public class ProductForm
    {
        public string Name { get; set; }
        public string Decription { get; set; }
        public decimal Price { get; set; }
        public int Catid { get; set; }
        public string Photo { get; set; }
        public string Type { get; set; }
        public string SupplierName { get; set; }
        public DateTime EntryDate { get; set; }
        public string ReveiwUrl { get; set; }
        public int Quntity { get; set; }
    }
}