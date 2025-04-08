namespace BeautyLingerie.Services.Review
{
    using BeautyLingerie.Data;
    using BeautyLingerie.Data.Models;
    using BeautyLingerie.Services.Review.Contracts;
    using BeautyLingerie.ViewModels.Review;
    using Microsoft.EntityFrameworkCore;

    public class ReviewService : IReviewService
    { 
        private readonly BeautyLingerieDbContext dbContext;

        public ReviewService(BeautyLingerieDbContext context)
        {
            dbContext = context;
        }

        public async Task<ReviewViewModel> AddReviewAsync(ReviewCreateViewModel model)
        {
            var review = new Review
            {
                Id = Guid.NewGuid(),
                ProductId = model.ProductId,
                UserId = dbContext.Users.FirstOrDefault(u=>u.Email == model.Email)!.Id,
                Rating = model.Rating,
                Comment = model.Comment,
                CreatedAt = DateTime.UtcNow
            };

            dbContext.Reviews.Add(review); 
            await dbContext.SaveChangesAsync();

            return new ReviewViewModel
            {
                Id = review.Id,
                Rating = review.Rating,
                Comment = review.Comment,
                CreatedAt = review.CreatedAt,
                Email = dbContext.Users.Where(u => u.Id == review.UserId)
                    .Select(u => u.Email)
                    .FirstOrDefault()!
            };
        }

        public async Task<ReviewViewModel?> GetReviewByIdAsync(Guid reviewId)
        {
            var review = await dbContext.Reviews
                .Include(r => r.User)
                .FirstOrDefaultAsync(r => r.Id == reviewId);

            if (review == null)
                return null;

            return new ReviewViewModel
            {
                Id = review.Id,
                ProductId = review.ProductId,
                Rating = review.Rating,
                Comment = review.Comment,
                CreatedAt = review.CreatedAt,
                Email = dbContext.Users.Where(u => u.Id == review.UserId)
                    .Select(u => u.Email)
                    .FirstOrDefault()!
            };
        }

        public async Task<IEnumerable<ReviewViewModel>> GetReviewsByProductIdAsync(Guid productId)
        {
            var reviews = await dbContext.Reviews
                .Include(r => r.User)
                .Where(r => r.ProductId == productId)
                .OrderByDescending(r => r.CreatedAt)
                .ToListAsync();

            return reviews.Select(r => new ReviewViewModel
            {
                Id = r.Id,
                ProductId = r.ProductId,
                Rating = r.Rating,
                Comment = r.Comment,
                CreatedAt = r.CreatedAt,
                Email = dbContext.Users.Where(u => u.Id == r.UserId)
                    .Select(u => u.Email)
                    .FirstOrDefault()!
            });
        }

        public async Task<IEnumerable<ReviewViewModel>> GetReviewsByUserAsync(string email)
        {
            var reviews = await dbContext.Reviews
                .Include(r => r.User)
                .Where(r => r.UserId == dbContext.Users.Where(u=>u.Email==email).First().Id)
                .OrderByDescending(r => r.CreatedAt)
                .ToListAsync();

            return reviews.Select(r => new ReviewViewModel
            {
                Id = r.Id,
                ProductId = r.ProductId,
                Rating = r.Rating,
                Comment = r.Comment,
                CreatedAt = r.CreatedAt,
                Email = dbContext.Users.Where(u => u.Id == r.UserId)
                    .Select(u => u.Email)
                    .FirstOrDefault()!
            });
        }

        public async Task<bool> UpdateReviewAsync(ReviewEditViewModel model)
        {
            var review = await dbContext.Reviews.FindAsync(model.Id);

            if (review == null)
                return false;

            review.Rating = model.Rating;
            review.Comment = model.Comment;

            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteReviewAsync(Guid reviewId)
        {
            var review = await dbContext.Reviews.FindAsync(reviewId);

            if (review == null)
                return false;

            dbContext.Reviews.Remove(review);
            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
