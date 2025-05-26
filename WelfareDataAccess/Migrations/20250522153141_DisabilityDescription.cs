using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WelfareDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DisabilityDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DisabilityWelfareRequest",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AttachmentEntityType",
                table: "AttachmentType",
                type: "int",
                nullable: false,
                comment: "Enum value(WelfareRequest,Memorandum,Batch)",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Enum value(WelfareRequest,Memo,Batch)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "DisabilityWelfareRequest");

            migrationBuilder.AlterColumn<int>(
                name: "AttachmentEntityType",
                table: "AttachmentType",
                type: "int",
                nullable: false,
                comment: "Enum value(WelfareRequest,Memo,Batch)",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Enum value(WelfareRequest,Memorandum,Batch)");
        }
    }
}
