using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Admin.souqcom.CartRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Admin.souqcom.CartRow;

namespace Admin.souqcom
{
    public interface ICartSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CartSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICartSaveHandler
    {
        public CartSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}