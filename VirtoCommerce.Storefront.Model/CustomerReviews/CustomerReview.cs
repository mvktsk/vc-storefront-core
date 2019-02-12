using System;
using VirtoCommerce.Storefront.Model.Common;

namespace VirtoCommerce.Storefront.Model.CustomerReviews
{
    public partial class CustomerReview : Entity
    {
        public string AuthorNickname { get; set; }
        public string Content { get; set; }
        public bool? IsActive { get; set; }
        public string ProductID { get; set; }

        public string UserReviewRate { get; set; }

        public int HelpfullVotesCount { get; set; }
        public int UselessVotesCount { get; set; }
        public int TotalVotesCount { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
