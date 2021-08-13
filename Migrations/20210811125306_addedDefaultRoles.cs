using Microsoft.EntityFrameworkCore.Migrations;

namespace MotelListings.Migrations
{
    public partial class addedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f2c30014-e221-46f5-bbe6-0cf39a315aa2", "ea850981-dafa-487a-bb1e-39a3afc4110e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52f3dedd-29bf-4b78-a323-a8ea2fbd4b45", "48b4ea16-66f0-41c5-84c7-1e8c86a50938", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52f3dedd-29bf-4b78-a323-a8ea2fbd4b45");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2c30014-e221-46f5-bbe6-0cf39a315aa2");
        }
    }
}
