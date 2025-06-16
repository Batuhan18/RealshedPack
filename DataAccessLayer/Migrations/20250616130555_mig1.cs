using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    AgentsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profile_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Time = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.AgentsId);
                });

            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    AmenetiesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amenity = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.AmenetiesId);
                });

            migrationBuilder.CreateTable(
                name: "Contact_Messages",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact_Messages", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    SettingsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Site_Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Meta_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Meta_Keywords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo_Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Facebook_Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instagram_Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Twitter_Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.SettingsId);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertiesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slug_Seo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Garage_Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bedrooms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bathrooms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rooms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Garage_Count = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Build_Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentsId = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MainPicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture9 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertiesId);
                    table.ForeignKey(
                        name: "FK_Properties_Agents_AgentsId",
                        column: x => x.AgentsId,
                        principalTable: "Agents",
                        principalColumn: "AgentsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_AgentsId",
                table: "Properties",
                column: "AgentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "Contact_Messages");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Agents");
        }
    }
}
