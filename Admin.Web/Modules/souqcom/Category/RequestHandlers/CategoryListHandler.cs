using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Admin.souqcom.CategoryRow>;
using MyRow = Admin.souqcom.CategoryRow;

namespace Admin.souqcom
{
    public interface ICategoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CategoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryListHandler
    {
        public CategoryListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}