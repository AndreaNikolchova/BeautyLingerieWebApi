
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
        [HttpGet("/review/{reviewId}")]
      
        public async Task<IActionResult> GetReviewById(Guid reviewId)
        {
            var model = await reviewService.GetReviewByIdAsync(reviewId);
            return Ok(model);
        }
        [HttpPost("/reviews/add/{productId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ReviewViewModel>))]
        public async Task<IActionResult> AddReview([FromBody] ReviewCreateViewModel model)
        {
            await reviewService.AddReviewAsync(model);
            return Ok();
        }
        [HttpPut("/reviews/edit/{productId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ReviewEditViewModel>))]
        public async Task<IActionResult> EditReview([FromBody] ReviewEditViewModel model)
        {
            await reviewService.UpdateReviewAsync(model);
            return Ok();
        }
        [HttpDelete("/reviews/delete/{productId}")]
        public async Task<IActionResult> Delete(Guid reviewId)
        {
            await reviewService.DeleteReviewAsync(reviewId);
            return Ok();
        }
    }
}
