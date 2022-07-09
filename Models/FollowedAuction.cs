using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bid.it.Models
{
    public class FollowedAuction
    {
        [Required]
        public string IdUser { get; set; }
        [ForeignKey("IdUser")]
        public ApplicationUser ApplicationUser { get; set; }
        [Required]
        public int IdAuction { get; set; }
        [ForeignKey("IdAuction")]
        public Auction Auction { get; set; }
    }
}
