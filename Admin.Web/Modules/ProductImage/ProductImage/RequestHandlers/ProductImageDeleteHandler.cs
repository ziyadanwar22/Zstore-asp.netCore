using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Admin.ProductImage.ProductImageRow;

namespace Admin.ProductImage
{
    public interface IProductImageDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductImageDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProductImageDeleteHandler
    {
        public ProductImageDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}