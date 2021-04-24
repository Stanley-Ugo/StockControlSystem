using Microsoft.EntityFrameworkCore.Migrations;

namespace StockControlSystem.Migrations
{
    public partial class AddingSt_StkjournalTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "St_Stkjournal",
                columns: table => new
                {
                    Stk_Coy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Stk_Branch = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Stk_Year = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Stk_Month = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Stk_Loc = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Stk_Type = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Stk_Account = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Stk_Debit = table.Column<decimal>(type: "money", nullable: false),
                    Stk_Credit = table.Column<decimal>(type: "money", nullable: false),
                    Stk_Rem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stk_Update = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stk_Period = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_St_Stkjournal_Stk_Account",
                table: "St_Stkjournal",
                column: "Stk_Account",
                unique: true,
                filter: "[Stk_Account] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_St_Stkjournal_Stk_Branch",
                table: "St_Stkjournal",
                column: "Stk_Branch",
                unique: true,
                filter: "[Stk_Branch] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_St_Stkjournal_Stk_Coy",
                table: "St_Stkjournal",
                column: "Stk_Coy",
                unique: true,
                filter: "[Stk_Coy] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_St_Stkjournal_Stk_Loc",
                table: "St_Stkjournal",
                column: "Stk_Loc",
                unique: true,
                filter: "[Stk_Loc] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_St_Stkjournal_Stk_Month",
                table: "St_Stkjournal",
                column: "Stk_Month",
                unique: true,
                filter: "[Stk_Month] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_St_Stkjournal_Stk_Type",
                table: "St_Stkjournal",
                column: "Stk_Type",
                unique: true,
                filter: "[Stk_Type] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_St_Stkjournal_Stk_Year",
                table: "St_Stkjournal",
                column: "Stk_Year",
                unique: true,
                filter: "[Stk_Year] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "St_Stkjournal");
        }
    }
}
