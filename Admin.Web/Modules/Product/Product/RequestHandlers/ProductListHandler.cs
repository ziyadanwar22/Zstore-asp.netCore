using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Admin.Product.ProductRow>;
using MyRow = Admin.Product.ProductRow;

namespace Admin.Product
{
    public interface IProductListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductListHandler
    {
        public ProductListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}