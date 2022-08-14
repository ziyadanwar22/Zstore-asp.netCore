using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Admin.ProductImage.ProductImageRow>;
using MyRow = Admin.ProductImage.ProductImageRow;

namespace Admin.ProductImage
{
    public interface IProductImageListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductImageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductImageListHandler
    {
        public ProductImageListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}