using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Admin.souqcom.CartRow;

namespace Admin.souqcom
{
    public interface ICartDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CartDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICartDeleteHandler
    {
        public CartDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}