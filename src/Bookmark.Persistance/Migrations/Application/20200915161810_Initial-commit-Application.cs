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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CardsId = table.Column<Guid>(nullable: true),
                    GroupsId = table.Column<Guid>(nullable: true),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupShared", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupShared_Cards_CardsId",
                        column: x => x.CardsId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupShared_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "DisplayIcon", "ExpireDate", "LastModified", "LastModifiedBy", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("30d5e915-5f2f-4fb0-be7c-1735b1863cda"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Github account", "Bookmark", null, null, null, "Github Project Onion Architecture", "https://github.com/Amitpnk" },
                    { new Guid("43915137-55a7-4c4c-bfd2-dfaf55d6b0a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Github account", "Bookmark", null, null, null, "Github Project Clean Architecture", "https://github.com/Amitpnk" },
                    { new Guid("76499266-4299-4590-90d7-929b56380f1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Github account", "Bookmark", null, null, null, "Github account", "https://github.com/Amitpnk" },
                    { new Guid("18c8a690-76a2-4c11-9f48-5b3b1a841d37"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Github account", "Bookmark", null, null, null, "Github account", "https://github.com/Amitpnk" },
                    { new Guid("dfc535ac-534c-4f52-bd30-95855022247c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Github account", "Bookmark", null, null, null, "Github account", "https://github.com/Amitpnk" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("286b9890-8fc8-4fc7-bc11-7dec3387460c"), "Github account", true, "Github account" },
                    { new Guid("74069bff-4d1c-488e-bab6-b255c7af8581"), "c-sharp corner", true, "c-sharp corner" },
                    { new Guid("182b52ef-22e3-4440-993f-07cf75da41ac"), "Code project", true, "Code project" },
                    { new Guid("d6c3b553-cea4-4cc8-985d-814a7cb491a8"), "Microsoft extension", true, "Microsoft extension" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardFavorite_CardsId",
                table: "CardFavorite",
                column: "CardsId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupShared_CardsId",
                table: "GroupShared",
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
