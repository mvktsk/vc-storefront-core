using System.Linq;
using System.Threading.Tasks;
using VirtoCommerce.Storefront.AutoRestClients.CustomerReviewVotes.WebModuleApi;
using VirtoCommerce.Storefront.Domain.CustomerReview;
using VirtoCommerce.Storefront.Infrastructure;
using VirtoCommerce.Storefront.Model.Caching;
using VirtoCommerce.Storefront.Model.CustomerReviews;

namespace VirtoCommerce.Storefront.Domain
{
    public class CustomerReviewService : ICustomerReviewService
    {
        private readonly IManagedModule _customerReviewsApi;
        private readonly IStorefrontMemoryCache _memoryCache;
        private readonly IApiChangesWatcher _apiChangesWatcher;

        public CustomerReviewService(IManagedModule customerReviewsApi, IStorefrontMemoryCache memoryCache, IApiChangesWatcher apiChangesWatcher)
        {
            _customerReviewsApi = customerReviewsApi;
            _memoryCache = memoryCache;
            _apiChangesWatcher = apiChangesWatcher;
        }

        public async Task<Model.CustomerReviews.CustomerReview[]> SearchCustomerReviewsAsync(CustomerReviewSearchCriteria criteria)
        {
            var result = (await _customerReviewsApi.SearchCustomerReviewsAsync(criteria.ToSearchCriteriaDto()));
            return result.Results.Select(x => x.ToCustomerReview()).ToArray();
        }


        public async Task UpdateVotesAsync(CustomerReviewVote[] customerReviewVotes)
        {
            var customerReviewVotesDto = customerReviewVotes.Select(x => x.ToCustomerReviewVoteDto()).ToList();

            await _customerReviewsApi.UpdateVotesAsync(customerReviewVotesDto);
        }
    }
}
