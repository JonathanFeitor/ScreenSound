using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class AddInformationTableMusic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Music", new string[] { "Name", "LaunchYear" }, new object[] { "Without Me", 2002 });
            migrationBuilder.InsertData("Music", new string[] { "Name", "LaunchYear" }, new object[] { "Venon", 2018 });
            migrationBuilder.InsertData("Music", new string[] { "Name", "LaunchYear" }, new object[] { "Lose Yourself", 2002 });
            migrationBuilder.InsertData("Music", new string[] { "Name", "LaunchYear" }, new object[] { "Ghost", 2021 });
            migrationBuilder.InsertData("Music", new string[] { "Name", "LaunchYear" }, new object[] { "Yummy", 2020 });
            migrationBuilder.InsertData("Music", new string[] { "Name", "LaunchYear" }, new object[] { "What Do You Mean", 2015 });
            migrationBuilder.InsertData("Music", new string[] { "Name", "LaunchYear" }, new object[] { "Just A Lil Bit", 2005 });
            migrationBuilder.InsertData("Music", new string[] { "Name", "LaunchYear" }, new object[] { "Many Men", 2003 });
            migrationBuilder.InsertData("Music", new string[] { "Name", "LaunchYear" }, new object[] { "21 Questions", 2003 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artist");
        }
    }
}
