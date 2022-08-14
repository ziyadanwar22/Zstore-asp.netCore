using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Admin.ProductImage
{
    [ConnectionKey("souq"), Module("ProductImage"), TableName("[dbo].[ProductImage]")]
    [DisplayName("Product Image"), InstanceName("Product Image")]
    [ReadPermission("Images")]
    [ModifyPermission("Images")]
    public sealed class ProductImageRow : Row<ProductImageRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Productid"), ForeignKey("[dbo].[Product]", "id"), LeftJoin("jProductid"), TextualField("ProductidName")]
        public int? Productid
        {
            get => fields.Productid[this];
            set => fields.Productid[this] = value;
        }

        [DisplayName("Image"), Column("image"), QuickSearch, NameProperty]
        public string Image
        {
            get => fields.Image[this];
            set => fields.Image[this] = value;
        }

        [DisplayName("Productid Name"), Expression("jProductid.[Name]")]
        public string ProductidName
        {
            get => fields.ProductidName[this];
            set => fields.ProductidName[this] = value;
        }

        [DisplayName("Productid Decription"), Expression("jProductid.[Decription]")]
        public string ProductidDecription
        {
            get => fields.ProductidDecription[this];
            set => fields.ProductidDecription[this] = value;
        }

        [DisplayName("Productid Price"), Expression("jProductid.[Price]")]
        public decimal? ProductidPrice
        {
            get => fields.ProductidPrice[this];
            set => fields.ProductidPrice[this] = value;
        }

        [DisplayName("Productid Catid"), Expression("jProductid.[Catid]")]
        public int? ProductidCatid
        {
            get => fields.ProductidCatid[this];
            set => fields.ProductidCatid[this] = value;
        }

        [DisplayName("Productid Photo"), Expression("jProductid.[Photo]")]
        public string ProductidPhoto
        {
            get => fields.ProductidPhoto[this];
            set => fields.ProductidPhoto[this] = value;
        }

        [DisplayName("Productid Type"), Expression("jProductid.[type]")]
        public string ProductidType
        {
            get => fields.ProductidType[this];
            set => fields.ProductidType[this] = value;
        }

        [DisplayName("Productid Supplier Name"), Expression("jProductid.[SupplierName]")]
        public string ProductidSupplierName
        {
            get => fields.ProductidSupplierName[this];
            set => fields.ProductidSupplierName[this] = value;
        }

        [DisplayName("Productid Entry Date"), Expression("jProductid.[EntryDate]")]
        public DateTime? ProductidEntryDate
        {
            get => fields.ProductidEntryDate[this];
            set => fields.ProductidEntryDate[this] = value;
        }

        [DisplayName("Productid Reveiw Url"), Expression("jProductid.[ReveiwUrl]")]
        public string ProductidReveiwUrl
        {
            get => fields.ProductidReveiwUrl[this];
            set => fields.ProductidReveiwUrl[this] = value;
        }

        [DisplayName("Productid Quntity"), Expression("jProductid.[quntity]")]
        public int? ProductidQuntity
        {
            get => fields.ProductidQuntity[this];
            set => fields.ProductidQuntity[this] = value;
        }

        public ProductImageRow()
            : base()
        {
        }

        public ProductImageRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field Productid;
            public StringField Image;

            public StringField ProductidName;
            public StringField ProductidDecription;
            public DecimalField ProductidPrice;
            public Int32Field ProductidCatid;
            public StringField ProductidPhoto;
            public StringField ProductidType;
            public StringField ProductidSupplierName;
            public DateTimeField ProductidEntryDate;
            public StringField ProductidReveiwUrl;
            public Int32Field ProductidQuntity;
        }
    }
}
