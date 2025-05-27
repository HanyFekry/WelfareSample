using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WelfareDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateMemoNoLaborIsBenefitiary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestNo",
                table: "WelfareRequest",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AddColumn<string>(
                name: "MemorandumNo",
                table: "Memorandum",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HasFullDisability",
                table: "Labor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsBeneficiary",
                table: "Labor",
                type: "bit",
                nullable: false,
                computedColumnSql: "CASE WHEN [DeathDate] IS NULL AND [HasFullDisability] = 0 THEN CAST(1 AS bit) ELSE CAST(0 AS bit) END",
                stored: true,
                comment: "the worker's status must be Beneficiary or  Not Beneficiary, default is Beneficiary(1)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "the worker's status must be Beneficiary or  Not Beneficiary, default is Beneficiary(1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemorandumNo",
                table: "Memorandum");

            migrationBuilder.DropColumn(
                name: "HasFullDisability",
                table: "Labor");

            migrationBuilder.AlterColumn<string>(
                name: "RequestNo",
                table: "WelfareRequest",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<bool>(
                name: "IsBeneficiary",
                table: "Labor",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "the worker's status must be Beneficiary or  Not Beneficiary, default is Beneficiary(1)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComputedColumnSql: "CASE WHEN [DeathDate] IS NULL AND [HasFullDisability] = 0 THEN CAST(1 AS bit) ELSE CAST(0 AS bit) END",
                oldComment: "the worker's status must be Beneficiary or  Not Beneficiary, default is Beneficiary(1)");
        }
    }
}
