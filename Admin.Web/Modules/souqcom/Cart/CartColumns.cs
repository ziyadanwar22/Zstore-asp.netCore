using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Admin.souqcom.Columns
{
    [ColumnsScript("souqcom.Cart")]
    [BasedOnRow(typeof(CartRow), CheckNames = true)]
    public class CartColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string UserId { get; set; }
        public String ProductName { get; set; }
        public int Qty { get; set; }
    }
}