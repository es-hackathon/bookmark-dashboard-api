using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookmark.Persistance.Migrations.Application
{
    public partial class InitialcommitApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    DisplayIcon = table.Column<string>(nullable: true),
                    ExpireDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardFavorite",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CardsId = table.Column<Guid>(nullable: true),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardFavorite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardFavorite_Cards_CardsId",
                        column: x => x.CardsId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupShared",
                columns: table => new
                {
                    CardsId = table.Column<Guid>(nullable: false),
                    GroupsId = table.Column<Guid>(nullable: false),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupShared", x => new { x.CardsId, x.GroupsId });
                    table.ForeignKey(
                        name: "FK_GroupShared_Cards_CardsId",
                        column: x => x.CardsId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupShared_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "DisplayIcon", "ExpireDate", "LastModified", "LastModifiedBy", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("9cd60c95-6ee6-4a13-8549-c194841d4b21"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Github account", "Bookmark", null, null, null, "Github Project Onion Architecture", "https://github.com/Amitpnk" },
                    { new Guid("25e5c8fb-d6ea-46c4-9c1f-3f7473726825"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Github account", "Bookmark", null, null, null, "Github Project Clean Architecture", "https://github.com/Amitpnk" },
                    { new Guid("28e29545-2aeb-4e34-a5db-3ad5939c7257"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Github account", "Bookmark", null, null, null, "Github account", "https://github.com/Amitpnk" },
                    { new Guid("99109f67-9d1d-43a4-992f-ff4a34ceae68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Github account", "Bookmark", null, null, null, "Github account", "https://github.com/Amitpnk" },
                    { new Guid("abd3542e-870f-4001-94f6-b1988ef34995"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Github account", "Bookmark", null, null, null, "Github account", "https://github.com/Amitpnk" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("7b3500ba-234a-49b5-a363-398023b37457"), "Github account", true, "Github account" },
                    { new Guid("a0285e2b-1c68-499f-affe-61fb357e4dc4"), "c-sharp corner", true, "c-sharp corner" },
                    { new Guid("9a1d4ac4-e22a-4f32-960f-470715c228fb"), "Code project", true, "Code project" },
                    { new Guid("d53dbc44-fdc3-4c1f-9657-1d8ff9c06bca"), "Microsoft extension", true, "Microsoft extension" }
                });

            migrationBuilder.InsertData(
                table: "GroupShared",
                columns: new[] { "CardsId", "GroupsId", "User" },
                values: new object[] { new Guid("9cd60c95-6ee6-4a13-8549-c194841d4b21"), new Guid("7b3500ba-234a-49b5-a363-398023b37457"), "1ecc6f29-9c64-446f-bce9-4f64e80e3789" });

            migrationBuilder.InsertData(
                table: "GroupShared",
                columns: new[] { "CardsId", "GroupsId", "User" },
                values: new object[] { new Guid("25e5c8fb-d6ea-46c4-9c1f-3f7473726825"), new Guid("a0285e2b-1c68-499f-affe-61fb357e4dc4"), "1ecc6f29-9c64-446f-bce9-4f64e80e3789" });

            migrationBuilder.CreateIndex(
                name: "IX_CardFavorite_CardsId",
                table: "CardFavorite",
                column: "CardsId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupShared_GroupsId",
                table: "GroupShared",
                column: "GroupsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardFavorite");

            migrationBuilder.DropTable(
                name: "GroupShared");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
