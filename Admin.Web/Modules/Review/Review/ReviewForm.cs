using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Admin.Review.Forms
{
    [FormScript("Review.Review")]
    [BasedOnRow(typeof(ReviewRow), CheckNames = true)]
    public class ReviewForm
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Descriptin { get; set; }
    }
}