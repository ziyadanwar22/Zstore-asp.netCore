using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Admin.souqcom.CartRow>;
using MyRow = Admin.souqcom.CartRow;

namespace Admin.souqcom
{
    public interface ICartListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CartListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICartListHandler
    {
        public CartListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}