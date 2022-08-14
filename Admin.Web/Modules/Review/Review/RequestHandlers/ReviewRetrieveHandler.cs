using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Admin.Review.ReviewRow>;
using MyRow = Admin.Review.ReviewRow;

namespace Admin.Review
{
    public interface IReviewRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ReviewRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IReviewRetrieveHandler
    {
        public ReviewRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}