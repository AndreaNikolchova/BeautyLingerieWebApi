
using BeautyLingerie.Services.Review.Contracts;

using BeautyLingerie.ViewModels.Review;
using Microsoft.AspNetCore.Mvc;

namespace BeautyLingerie.WebApi.Controllers
{
    public class ReviewController : Controller
    {
        private IReviewService reviewService;

        public ReviewController(IReviewService reviewService)
        {
            this.reviewService = reviewService;

        }
        [HttpGet("/reviews/{productId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ReviewViewModel>))]
        public async Task<IActionResult> GetAllReviewsByProductId(Guid productId)
        {
            var model = await reviewService.GetReviewsByProductIdAsync(productId);
            return Ok(model);
        }
        [HttpPost("/reviews/add/{productId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ReviewViewModel>))]
        public async Task<IActionResult> AddReview([FromBody] ReviewCreateViewModel model)
        {
            await reviewService.AddReviewAsync(model);
            return Ok();
        }
    }
}
