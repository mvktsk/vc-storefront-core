using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VirtoCommerce.Storefront.Infrastructure;
using VirtoCommerce.Storefront.Model;
using VirtoCommerce.Storefront.Model.Common;
using VirtoCommerce.Storefront.Model.CustomerReviews;


namespace VirtoCommerce.Storefront.Controllers.Api
{
    [StorefrontApiRoute("review")]
    public class ApiCustomerReviewController : StorefrontControllerBase
    {
        private readonly ICustomerReviewService _customerReviewService;
        public ApiCustomerReviewController(IWorkContextAccessor workContextAccessor, ICustomerReviewService customerReviewService,
                                           IStorefrontUrlBuilder urlBuilder)
            : base(workContextAccessor, urlBuilder)
        {
            _customerReviewService = customerReviewService;
        }

        [HttpPost("vote")]
        public async Task<ActionResult> UpdateVotes([FromBody]CustomerReviewVote[] customerReviewVotes)
        {
            await _customerReviewService.UpdateVotesAsync(customerReviewVotes);
            return Ok();
        }

        [HttpPost("")]
        public async Task<ActionResult> SearchReviews([FromBody]CustomerReviewSearchCriteria criteria)
        {
            var result = (await _customerReviewService.SearchCustomerReviewsAsync(criteria));

            return Ok(result);
        }

    }
}
