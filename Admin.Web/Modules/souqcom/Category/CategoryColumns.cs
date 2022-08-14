using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Admin.souqcom.Columns
{
    [ColumnsScript("souqcom.Category")]
    [BasedOnRow(typeof(CategoryRow), CheckNames = true)]
    public class CategoryColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
    }
}