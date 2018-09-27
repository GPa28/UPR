using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UltimatePowerRankings.Data.Migrations
{
    public partial class AddTopTenListTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TopTenLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    One = table.Column<string>(nullable: true),
                    Two = table.Column<string>(nullable: true),
                    Three = table.Column<string>(nullable: true),
                    Four = table.Column<string>(nullable: true),
                    Five = table.Column<string>(nullable: true),
                    Six = table.Column<string>(nullable: true),
                    Seven = table.Column<string>(nullable: true),
                    Eight = table.Column<string>(nullable: true),
                    Nine = table.Column<string>(nullable: true),
                    Ten = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopTenLists", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TopTenLists");
        }
    }
}
