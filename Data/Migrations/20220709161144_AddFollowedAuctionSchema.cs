using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bid.it.Data.Migrations
{
    public partial class AddFollowedAuctionSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Auctions_AspNetUsers_IdApplicationUser",
                table: "Auctions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Auctions",
                table: "Auctions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Auctions",
                newName: "Auction");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "ApplicationUser");

            migrationBuilder.RenameColumn(
                name: "AuctionId",
                table: "Auction",
                newName: "IdAuction");

            migrationBuilder.RenameIndex(
                name: "IX_Auctions_IdApplicationUser",
                table: "Auction",
                newName: "IX_Auction_IdApplicationUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auction",
                table: "Auction",
                column: "IdAuction");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUser",
                table: "ApplicationUser",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FollowedAuction",
                columns: table => new
                {
                    IdUser = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdAuction = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowedAuction", x => new { x.IdUser, x.IdAuction });
                    table.ForeignKey(
                        name: "FK_FollowedAuction_ApplicationUser_IdUser",
                        column: x => x.IdUser,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FollowedAuction_Auction_IdAuction",
                        column: x => x.IdAuction,
                        principalTable: "Auction",
                        principalColumn: "IdAuction",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseHistory",
                columns: table => new
                {
                    IdPurchaseHistory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdAuction = table.Column<int>(type: "int", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseHistory", x => x.IdPurchaseHistory);
                    table.ForeignKey(
                        name: "FK_PurchaseHistory_ApplicationUser_IdUser",
                        column: x => x.IdUser,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseHistory_Auction_IdAuction",
                        column: x => x.IdAuction,
                        principalTable: "Auction",
                        principalColumn: "IdAuction",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FollowedAuction_IdAuction",
                table: "FollowedAuction",
                column: "IdAuction");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseHistory_IdAuction",
                table: "PurchaseHistory",
                column: "IdAuction");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseHistory_IdUser",
                table: "PurchaseHistory",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_ApplicationUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_ApplicationUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_ApplicationUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_ApplicationUser_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Auction_ApplicationUser_IdApplicationUser",
                table: "Auction",
                column: "IdApplicationUser",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_ApplicationUser_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_ApplicationUser_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_ApplicationUser_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_ApplicationUser_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Auction_ApplicationUser_IdApplicationUser",
                table: "Auction");

            migrationBuilder.DropTable(
                name: "FollowedAuction");

            migrationBuilder.DropTable(
                name: "PurchaseHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Auction",
                table: "Auction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUser",
                table: "ApplicationUser");

            migrationBuilder.RenameTable(
                name: "Auction",
                newName: "Auctions");

            migrationBuilder.RenameTable(
                name: "ApplicationUser",
                newName: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "IdAuction",
                table: "Auctions",
                newName: "AuctionId");

            migrationBuilder.RenameIndex(
                name: "IX_Auction_IdApplicationUser",
                table: "Auctions",
                newName: "IX_Auctions_IdApplicationUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auctions",
                table: "Auctions",
                column: "AuctionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_AspNetUsers_IdApplicationUser",
                table: "Auctions",
                column: "IdApplicationUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
