using System.Threading.Tasks;

namespace VirtoCommerce.Storefront.Model.CustomerReviews
{
    public interface ICustomerReviewService
    {

        Task UpdateVotesAsync(CustomerReviewVote[] customerReviewVotes);

        Task<CustomerReview[]> SearchCustomerReviewsAsync(CustomerReviewSearchCriteria criteria);
    }
}
