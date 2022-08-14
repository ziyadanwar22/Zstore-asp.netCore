using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Admin.souqcom
{
    [ConnectionKey("souq"), Module("souqcom"), TableName("[dbo].[Cart]")]
    [DisplayName("Cart"), InstanceName("Cart")]
    [ReadPermission("Cart")]
    [ModifyPermission("Cart")]
    public sealed class CartRow : Row<CartRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("User Id"), QuickSearch, NameProperty]
        public string UserId
        {
            get => fields.UserId[this];
            set => fields.UserId[this] = value;
        }

        [DisplayName("Product"), ForeignKey("[dbo].[Product]", "id"), LeftJoin("jProduct"), TextualField("ProductName")]
        public int? ProductId
        {
            get => fields.ProductId[this];
            set => fields.ProductId[this] = value;
        }

        [DisplayName("Qty")]
        public int? Qty
        {
            get => fields.Qty[this];
            set => fields.Qty[this] = value;
        }

        [DisplayName("Product Name"), Expression("jProduct.[Name]")]
        public string ProductName
        {
            get => fields.ProductName[this];
            set => fields.ProductName[this] = value;
        }

        [DisplayName("Product Decription"), Expression("jProduct.[Decription]")]
        public string ProductDecription
        {
            get => fields.ProductDecription[this];
            set => fields.ProductDecription[this] = value;
        }

        [DisplayName("Product Price"), Expression("jProduct.[Price]")]
        public decimal? ProductPrice
        {
            get => fields.ProductPrice[this];
            set => fields.ProductPrice[this] = value;
        }

        [DisplayName("Product Catid"), Expression("jProduct.[Catid]")]
        public int? ProductCatid
        {
            get => fields.ProductCatid[this];
            set => fields.ProductCatid[this] = value;
        }

        [DisplayName("Product Photo"), Expression("jProduct.[Photo]")]
        public string ProductPhoto
        {
            get => fields.ProductPhoto[this];
            set => fields.ProductPhoto[this] = value;
        }

        [DisplayName("Product Type"), Expression("jProduct.[type]")]
        public string ProductType
        {
            get => fields.ProductType[this];
            set => fields.ProductType[this] = value;
        }

        [DisplayName("Product Supplier Name"), Expression("jProduct.[SupplierName]")]
        public string ProductSupplierName
        {
            get => fields.ProductSupplierName[this];
            set => fields.ProductSupplierName[this] = value;
        }

        [DisplayName("Product Entry Date"), Expression("jProduct.[EntryDate]")]
        public DateTime? ProductEntryDate
        {
            get => fields.ProductEntryDate[this];
            set => fields.ProductEntryDate[this] = value;
        }

        [DisplayName("Product Reveiw Url"), Expression("jProduct.[ReveiwUrl]")]
        public string ProductReveiwUrl
        {
            get => fields.ProductReveiwUrl[this];
            set => fields.ProductReveiwUrl[this] = value;
        }

        [DisplayName("Product Quntity"), Expression("jProduct.[quntity]")]
        public int? ProductQuntity
        {
            get => fields.ProductQuntity[this];
            set => fields.ProductQuntity[this] = value;
        }

        public CartRow()
            : base()
        {
        }

        public CartRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField UserId;
            public Int32Field ProductId;
            public Int32Field Qty;

            public StringField ProductName;
            public StringField ProductDecription;
            public DecimalField ProductPrice;
            public Int32Field ProductCatid;
            public StringField ProductPhoto;
            public StringField ProductType;
            public StringField ProductSupplierName;
            public DateTimeField ProductEntryDate;
            public StringField ProductReveiwUrl;
            public Int32Field ProductQuntity;
        }
    }
}
