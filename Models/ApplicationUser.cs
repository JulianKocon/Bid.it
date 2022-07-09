using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bid.it.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Auctions = new HashSet<Auction>();
        }

        [Column(TypeName = "money")]
        public decimal Money { get; set; }

        public virtual ICollection<Auction> Auctions { get; set; }
        public virtual ICollection<PurchaseHistory> PurchaseHistories { get; set; }

        public virtual ICollection<FollowedAuction> FollowedAuctions { get; set; }
    }
}
