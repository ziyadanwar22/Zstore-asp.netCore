using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Admin.Review.Columns
{
    [ColumnsScript("Review.Review")]
    [BasedOnRow(typeof(ReviewRow), CheckNames = true)]
    public class ReviewColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Descriptin { get; set; }
    }
}