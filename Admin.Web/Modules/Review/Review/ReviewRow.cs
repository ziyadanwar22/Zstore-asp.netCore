using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Admin.Review
{
    [ConnectionKey("souq"), Module("Review"), TableName("[dbo].[Review]")]
    [DisplayName("Review"), InstanceName("Review")]
    [ReadPermission("Review")]
    [ModifyPermission("Review")]
    public sealed class ReviewRow : Row<ReviewRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Name"), QuickSearch, NameProperty]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Email")]
        public string Email
        {
            get => fields.Email[this];
            set => fields.Email[this] = value;
        }

        [DisplayName("Subject")]
        public string Subject
        {
            get => fields.Subject[this];
            set => fields.Subject[this] = value;
        }

        [DisplayName("Descriptin")]
        public string Descriptin
        {
            get => fields.Descriptin[this];
            set => fields.Descriptin[this] = value;
        }

        public ReviewRow()
            : base()
        {
        }

        public ReviewRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Name;
            public StringField Email;
            public StringField Subject;
            public StringField Descriptin;
        }
    }
}
