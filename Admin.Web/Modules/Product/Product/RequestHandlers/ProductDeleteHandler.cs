using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Admin.Product.ProductRow;

namespace Admin.Product
{
    public interface IProductDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProductDeleteHandler
    {
        public ProductDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}