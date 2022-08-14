using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Admin.ProductImage.Columns
{
    [ColumnsScript("ProductImage.ProductImage")]
    [BasedOnRow(typeof(ProductImageRow), CheckNames = true)]
    public class ProductImageColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public String ProductidName { get; set; }
        [EditLink]
        public string Image { get; set; }
    }
}