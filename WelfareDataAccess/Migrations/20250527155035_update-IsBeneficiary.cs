using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WelfareDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateIsBeneficiary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsBeneficiary",
                table: "Labor",
                type: "bit",
                nullable: false,
                computedColumnSql: "CASE WHEN [DeathDate] IS NOT NULL OR [HasFullDisability] = 1 THEN CAST(0 AS bit) ELSE CAST(1 AS bit) END",
                stored: true,
                comment: "the worker's status must be Beneficiary or  Not Beneficiary, default is Beneficiary(1)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComputedColumnSql: "CASE WHEN [DeathDate] IS NULL AND [HasFullDisability] = 0 THEN CAST(1 AS bit) ELSE CAST(0 AS bit) END",
                oldStored: true,
                oldComment: "the worker's status must be Beneficiary or  Not Beneficiary, default is Beneficiary(1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                oldComputedColumnSql: "CASE WHEN [DeathDate] IS NOT NULL OR [HasFullDisability] = 1 THEN CAST(0 AS bit) ELSE CAST(1 AS bit) END",
                oldStored: true,
                oldComment: "the worker's status must be Beneficiary or  Not Beneficiary, default is Beneficiary(1)");
        }
    }
}
