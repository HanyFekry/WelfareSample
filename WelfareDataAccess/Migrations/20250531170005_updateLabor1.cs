using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WelfareDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateLabor1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdatedUserName",
                table: "Labor",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                comment: "User name of the user who last updated the request record",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedUserId",
                table: "Labor",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true,
                comment: "User ID of the user who last updated the request record",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Labor",
                type: "datetime2",
                nullable: true,
                comment: "Date and time when the request record was last updated",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdatedUserName",
                table: "Labor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldComment: "User name of the user who last updated the request record");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedUserId",
                table: "Labor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "User ID of the user who last updated the request record");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Labor",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Date and time when the request record was last updated");
        }
    }
}
