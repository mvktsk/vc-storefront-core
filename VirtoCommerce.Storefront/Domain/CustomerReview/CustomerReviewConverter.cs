using VirtoCommerce.Storefront.Model.CustomerReviews;
using reviewDto = VirtoCommerce.Storefront.AutoRestClients.CustomerReviewVotes.WebModuleApi.Models;


namespace VirtoCommerce.Storefront.Domain.CustomerReview
{
    public static partial class CustomerReviewConverter
    {
        public static Model.CustomerReviews.CustomerReview ToCustomerReview(this reviewDto.CustomerReview itemDto)
        {
            var result = new Model.CustomerReviews.CustomerReview
            {
                Id = itemDto.Id,
                AuthorNickname = itemDto.AuthorNickname,
                Content = itemDto.Content,
                CreatedBy = itemDto.CreatedBy,
                CreatedDate = itemDto.CreatedDate,
                IsActive = itemDto.IsActive,
                ModifiedBy = itemDto.ModifiedBy,
                ModifiedDate = itemDto.ModifiedDate,
                ProductID = itemDto.ProductId,

                UserReviewRate = itemDto.UserReviewRate,

                HelpfullVotesCount = (int)itemDto.HelpfullVotesCount,
                UselessVotesCount = (int)itemDto.UselessVotesCount,
                TotalVotesCount = (int)itemDto.TotalVotesCount
            };
            return result;
        }

        public static reviewDto.CustomerReviewSearchCriteria ToSearchCriteriaDto(this CustomerReviewSearchCriteria criteria)
        {
            var result = new reviewDto.CustomerReviewSearchCriteria
            {
                IsActive = criteria.IsActive,
                ProductIds = criteria.ProductIds,
                AuthorId = criteria.AuthorId,

                Skip = criteria.Start,
                Take = criteria.PageSize,
                Sort = criteria.Sort
            };
            return result;
        }

        public static reviewDto.CustomerReviewVote ToCustomerReviewVoteDto(this CustomerReviewVote сustomerReviewVote)
        {
            var result = new reviewDto.CustomerReviewVote
            {
                Id = сustomerReviewVote.Id,
                CustomerReviewId = сustomerReviewVote.CustomerReviewId,
                AuthorId = сustomerReviewVote.AuthorId,
                ReviewRate = сustomerReviewVote.ReviewRate,

                CreatedBy = сustomerReviewVote.CreatedBy,
                CreatedDate = сustomerReviewVote.CreatedDate,
                ModifiedBy = сustomerReviewVote.ModifiedBy,
                ModifiedDate = сustomerReviewVote.ModifiedDate,

            };
            return result;
        }
        public static bool IsVoteEnabled(string userVoteIdx)
        {
            bool retVal = userVoteIdx.Equals("0") || string.IsNullOrEmpty(userVoteIdx);
            return retVal;
        }
        public static bool IsHelpfullVoteVisibled(string userVoteIdx)
        {
            bool retVal = userVoteIdx.Equals("Helpfull") || (userVoteIdx.Equals("0") || string.IsNullOrEmpty(userVoteIdx));
            return retVal;
        }
        public static bool IsUselessVoteVisibled(string userVoteIdx)
        {
            bool retVal = userVoteIdx.Equals("Useless") || (userVoteIdx.Equals("0") || string.IsNullOrEmpty(userVoteIdx));
            return retVal;
        }

    }
}
