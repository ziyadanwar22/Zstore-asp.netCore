using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Admin.souqcom.Forms
{
    [FormScript("souqcom.Cart")]
    [BasedOnRow(typeof(CartRow), CheckNames = true)]
    public class CartForm
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
    }
}