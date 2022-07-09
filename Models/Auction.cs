using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bid.it.Models
{

    public class Auction
    {
        public Auction()
        {
            AuctionName = IdAuction.ToString();
        }

        [Key]
        public int IdAuction { get; set; }

        public string IdApplicationUser { get; set; }

        [ForeignKey("IdApplicationUser")]
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Auction name cannot be longer than 20 characters.")]
        [Display(Name = "Auction Name")]
        public string AuctionName { get; set; }
        public DateTime AuctionStart { get; set; } = DateTime.UtcNow;

        [Required]
        [Display(Name = "Duration in hours")]
        public int Duration { get; set; } = 2;

        [Required]
        [StringLength(3000, ErrorMessage = "Description cannot be longer than 20 characters.")]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Current price")]
        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }
        public virtual ICollection<PurchaseHistory> PurchaseHistories { get; set; }

        public virtual ICollection<FollowedAuction> FollowedAuctions { get; set; }
    }
}
