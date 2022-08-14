using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Admin.souqcom
{
    [ConnectionKey("souq"), Module("souqcom"), TableName("[dbo].[Category]")]
    [DisplayName("Category"), InstanceName("Category")]
    [ReadPermission("Category")]
    [ModifyPermission("Category")]
    [LookupScript]
    public sealed class CategoryRow : Row<CategoryRow.RowFields>, IIdRow, INameRow
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

        [DisplayName("Photo")]
        public string Photo
        {
            get => fields.Photo[this];
            set => fields.Photo[this] = value;
        }

        [DisplayName("Description")]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        public CategoryRow()
            : base()
        {
        }

        public CategoryRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Name;
            public StringField Photo;
            public StringField Description;
        }
    }
}
