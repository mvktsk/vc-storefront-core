using System;
using VirtoCommerce.Storefront.Model.Common;
namespace VirtoCommerce.Storefront.Model.CustomerReviews
{
    public partial class CustomerReviewVote : Entity
    {
        public string AuthorId { get; set; }
        public string ReviewRate { get; set; }
        public string CustomerReviewId { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
