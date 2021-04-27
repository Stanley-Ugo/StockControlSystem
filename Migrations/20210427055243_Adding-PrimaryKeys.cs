using Microsoft.EntityFrameworkCore.Migrations;

namespace StockControlSystem.Migrations
{
    public partial class AddingPrimaryKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_St_Stkjournal_Stk_Account",
                table: "St_Stkjournal");

            migrationBuilder.DropIndex(
                name: "IX_St_Stkjournal_Stk_Branch",
                table: "St_Stkjournal");

            migrationBuilder.DropIndex(
                name: "IX_St_Stkjournal_Stk_Coy",
                table: "St_Stkjournal");

            migrationBuilder.DropIndex(
                name: "IX_St_Stkjournal_Stk_Loc",
                table: "St_Stkjournal");

            migrationBuilder.DropIndex(
                name: "IX_St_Stkjournal_Stk_Month",
                table: "St_Stkjournal");

            migrationBuilder.DropIndex(
                name: "IX_St_Stkjournal_Stk_Type",
                table: "St_Stkjournal");

            migrationBuilder.DropIndex(
                name: "IX_St_Stkjournal_Stk_Year",
                table: "St_Stkjournal");

            migrationBuilder.AlterColumn<string>(
                name: "Stk_Year",
                table: "St_Stkjournal",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Stk_Type",
                table: "St_Stkjournal",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Stk_Month",
                table: "St_Stkjournal",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Stk_Loc",
                table: "St_Stkjournal",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Stk_Coy",
                table: "St_Stkjournal",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Stk_Branch",
                table: "St_Stkjournal",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Stk_Account",
                table: "St_Stkjournal",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_St_Stkjournal",
                table: "St_Stkjournal",
                columns: new[] { "Stk_Coy", "Stk_Branch", "Stk_Year", "Stk_Month", "Stk_Loc", "Stk_Type", "Stk_Account" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_St_Stkjournal",
                table: "St_Stkjournal");

            migrationBuilder.AlterColumn<string>(
                name: "Stk_Account",
                table: "St_Stkjournal",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Stk_Type",
                table: "St_Stkjournal",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Stk_Loc",
                table: "St_Stkjournal",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Stk_Month",
                table: "St_Stkjournal",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Stk_Year",
                table: "St_Stkjournal",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Stk_Branch",
                table: "St_Stkjournal",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Stk_Coy",
                table: "St_Stkjournal",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
