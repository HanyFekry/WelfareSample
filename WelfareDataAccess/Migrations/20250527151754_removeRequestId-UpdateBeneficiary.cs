using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WelfareDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class removeRequestIdUpdateBeneficiary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "SocialWelfareRequest");

            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "DisabilityWelfareRequest");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "EventDate",
                table: "SocialWelfareRequest",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "EventDate",
                table: "DisabilityWelfareRequest",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryName",
                table: "Beneficiary",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                comment: "Beneficiary name",
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldComment: "Beneficiary name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EventDate",
                table: "SocialWelfareRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<long>(
                name: "RequestId",
                table: "SocialWelfareRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EventDate",
                table: "DisabilityWelfareRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<long>(
                name: "RequestId",
                table: "DisabilityWelfareRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryName",
                table: "Beneficiary",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: false,
                comment: "Beneficiary name",
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldComment: "Beneficiary name");
        }
    }
}
