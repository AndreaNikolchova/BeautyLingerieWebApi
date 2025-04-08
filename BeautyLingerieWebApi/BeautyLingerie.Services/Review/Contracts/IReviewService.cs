using BeautyLingerie.ViewModels.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyLingerie.Services.Review.Contracts
{
    public interface IReviewService
    {
        Task<ReviewViewModel> AddReviewAsync(ReviewCreateViewModel model);

        Task<ReviewViewModel?> GetReviewByIdAsync(Guid reviewId);

        Task<IEnumerable<ReviewViewModel>> GetReviewsByProductIdAsync(Guid productId);

        Task<IEnumerable<ReviewViewModel>> GetReviewsByUserAsync(string email);

        Task<bool> UpdateReviewAsync(ReviewEditViewModel model);

        Task<bool> DeleteReviewAsync(Guid reviewId);
    }

}
