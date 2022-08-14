using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Admin.Review.ReviewRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Admin.Review.ReviewRow;

namespace Admin.Review
{
    public interface IReviewSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ReviewSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IReviewSaveHandler
    {
        public ReviewSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}