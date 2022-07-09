using Bid.it.Models;

namespace Bid.it.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.ApplicationUsers.Any())
            {
                return;
            }

            var users = new ApplicationUser[]
            {
                new ApplicationUser { Id = "notAGuid1" , UserName = "TestUser1", PasswordHash = "notAHash", Email = "test1@gmail.com", Money = 5000 },
                new ApplicationUser { Id = "notAGuid2" , UserName = "TestUser2",PasswordHash = "notAHash1", Email = "test2@gmail.com", Money = 6000 },
                new ApplicationUser { Id = "notAGuid3" , UserName = "TestUser3",PasswordHash = "notAHash!", Email = "test3@gmail.com", Money = 7000 },
                new ApplicationUser { Id = "notAGuid4" , UserName = "TestUser4",PasswordHash = "notAHash2", Email = "test4@gmail.com", Money = 8000 },
                new ApplicationUser { Id = "notAGuid5" , UserName = "TestUser5",PasswordHash = "notAHash@", Email = "test5@gmail.com", Money = 9000 },
                new ApplicationUser { Id = "notAGuid6", UserName = "TestUser6", PasswordHash = "notAHash3",Email = "test6@gmail.com", Money = 10000 }
            };

            foreach (var user in users)
            {
                context.ApplicationUsers.Add(user);
            }

            context.SaveChanges();

            if (context.Auctions.Any())
            {
                return;
            }

            var auctions = new Auction[]
            {
                new Auction { IdAuction = 1, IdApplicationUser = "notAGuid1", AuctionName = "Nike Air Force 1 white", AuctionStart = DateTime.Parse("20/05/2022"),Duration = 2, Description = "Size US 6", IsAvailable = false},
                new Auction { IdAuction = 2, IdApplicationUser = "notAGuid2", AuctionName = "Razer Basilisk v3 mouse", AuctionStart = DateTime.Parse("20/05/2022"),Duration = 3, Description = "Condition 9/10", IsAvailable = true},
                new Auction { IdAuction = 3, IdApplicationUser = "notAGuid3", AuctionName = "Test auction 1", AuctionStart = DateTime.Parse("20/05/2022"),Duration = 6, Description = "Test description 1", IsAvailable = true},
                new Auction { IdAuction = 4, IdApplicationUser = "notAGuid4", AuctionName = "Test auction 2", AuctionStart = DateTime.Parse("20/05/2022"),Duration = 1, Description = "Test description 2 ", IsAvailable = true},
                new Auction { IdAuction = 5, IdApplicationUser = "notAGuid5", AuctionName = "Test auction 3", AuctionStart = DateTime.Parse("20/05/2022"),Duration = 1, Description = "Test description 3", IsAvailable = true}
            };

            foreach (var auction in auctions)
            {
                context.Auctions.Add(auction);
            }

            context.SaveChanges();

            if (context.PurchaseHistories.Any())
            {
                return;
            }

            var purchases = new PurchaseHistory[]
          {
                new PurchaseHistory {IdPurchaseHistory = 1, IdUser = "notAGuid1", IdAuction = 1, PurchaseDate = DateTime.Parse("20/06/2022"), Price = 200}
          };

            foreach (var purchase in purchases)
            {
                context.PurchaseHistories.Add(purchase);
            }

            context.SaveChanges();
        }
    }
}
