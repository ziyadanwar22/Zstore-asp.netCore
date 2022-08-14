using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Admin.ProductImage.ProductImageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Admin.ProductImage.ProductImageRow;

namespace Admin.ProductImage
{
    public interface IProductImageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductImageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductImageSaveHandler
    {
        public ProductImageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}