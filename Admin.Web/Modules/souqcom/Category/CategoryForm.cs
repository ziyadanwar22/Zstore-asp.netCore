using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Admin.souqcom.Forms
{
    [FormScript("souqcom.Category")]
    [BasedOnRow(typeof(CategoryRow), CheckNames = true)]
    public class CategoryForm
    {
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
    }
}