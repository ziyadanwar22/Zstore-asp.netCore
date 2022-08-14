using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Admin.ProductImage.ProductImageRow>;
using MyRow = Admin.ProductImage.ProductImageRow;

namespace Admin.ProductImage
{
    public interface IProductImageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductImageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductImageRetrieveHandler
    {
        public ProductImageRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}