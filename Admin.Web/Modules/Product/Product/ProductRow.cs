using Admin.souqcom;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Admin.Product
{
    [ConnectionKey("souq"), Module("Product"), TableName("[dbo].[Product]")]
    [DisplayName("Product"), InstanceName("Product")]
    [ReadPermission("Product")]
    [ModifyPermission("Product")]
    public sealed class ProductRow : Row<ProductRow.RowFields>, IIdRow, INameRow
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

        [DisplayName("Decription")]
        public string Decription
        {
            get => fields.Decription[this];
            set => fields.Decription[this] = value;
        }

        [DisplayName("Price"), Size(18)]
        public decimal? Price
        {
            get => fields.Price[this];
            set => fields.Price[this] = value;
        }

        [DisplayName("Catid"), ForeignKey("[dbo].[Category]", "id"), LeftJoin("jCatid"), TextualField("CatidName")]
        [LookupEditor(typeof(CategoryRow))]
        public int? Catid
        {
            get => fields.Catid[this];
            set => fields.Catid[this] = value;
        }

        [DisplayName("Photo"),ImageUploadEditor]
        public string Photo
        {
            get => fields.Photo[this];
            set => fields.Photo[this] = value;
        }

        [DisplayName("Type"), Column("type"), Size(50)]
        public string Type
        {
            get => fields.Type[this];
            set => fields.Type[this] = value;
        }

        [DisplayName("Supplier Name"), Size(50)]
        public string SupplierName
        {
            get => fields.SupplierName[this];
            set => fields.SupplierName[this] = value;
        }

        [DisplayName("Entry Date")]
        public DateTime? EntryDate
        {
            get => fields.EntryDate[this];
            set => fields.EntryDate[this] = value;
        }

        [DisplayName("Reveiw Url")]
        public string ReveiwUrl
        {
            get => fields.ReveiwUrl[this];
            set => fields.ReveiwUrl[this] = value;
        }

        [DisplayName("Quntity"), Column("quntity")]
        public int? Quntity
        {
            get => fields.Quntity[this];
            set => fields.Quntity[this] = value;
        }

        [DisplayName("Catid Name"), Expression("jCatid.[Name]")]
        public string CatidName
        {
            get => fields.CatidName[this];
            set => fields.CatidName[this] = value;
        }

        [DisplayName("Catid Photo"), Expression("jCatid.[Photo]")]
        public string CatidPhoto
        {
            get => fields.CatidPhoto[this];
            set => fields.CatidPhoto[this] = value;
        }

        [DisplayName("Catid Description"), Expression("jCatid.[Description]")]
        public string CatidDescription
        {
            get => fields.CatidDescription[this];
            set => fields.CatidDescription[this] = value;
        }

        public ProductRow()
            : base()
        {
        }

        public ProductRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Name;
            public StringField Decription;
            public DecimalField Price;
            public Int32Field Catid;
            public StringField Photo;
            public StringField Type;
            public StringField SupplierName;
            public DateTimeField EntryDate;
            public StringField ReveiwUrl;
            public Int32Field Quntity;

            public StringField CatidName;
            public StringField CatidPhoto;
            public StringField CatidDescription;
        }
    }
}
