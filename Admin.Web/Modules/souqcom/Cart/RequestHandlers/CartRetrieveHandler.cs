using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Admin.souqcom.CartRow>;
using MyRow = Admin.souqcom.CartRow;

namespace Admin.souqcom
{
    public interface ICartRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CartRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICartRetrieveHandler
    {
        public CartRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}