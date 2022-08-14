using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Admin.Review.ReviewRow;

namespace Admin.Review
{
    public interface IReviewDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ReviewDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IReviewDeleteHandler
    {
        public ReviewDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}