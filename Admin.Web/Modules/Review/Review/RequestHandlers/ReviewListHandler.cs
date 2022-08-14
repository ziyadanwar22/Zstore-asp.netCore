using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Admin.Review.ReviewRow>;
using MyRow = Admin.Review.ReviewRow;

namespace Admin.Review
{
    public interface IReviewListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ReviewListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IReviewListHandler
    {
        public ReviewListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}