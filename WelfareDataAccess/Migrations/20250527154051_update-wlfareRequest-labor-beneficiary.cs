using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WelfareDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatewlfareRequestlaborbeneficiary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FK_InsuranceSectorID",
                table: "Labor");

            migrationBuilder.DropColumn(
                name: "InsurancePeriod",
                table: "Labor");

            migrationBuilder.RenameIndex(
                name: "IX_RequestAttachments_FK_RequestId",
                table: "WelfareRequestAttachment",
                newName: "IX_WelfareRequestAttachment_FK_RequestId");

            migrationBuilder.RenameIndex(
                name: "IX_RequestAttachments_FK_AttachmentTypeId",
                table: "WelfareRequestAttachment",
                newName: "IX_WelfareRequestAttachment_FK_AttachmentTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_WelfareRequestAttachment_FK_RequestId",
                table: "WelfareRequestAttachment",
                newName: "IX_RequestAttachments_FK_RequestId");

            migrationBuilder.RenameIndex(
                name: "IX_WelfareRequestAttachment_FK_AttachmentTypeId",
                table: "WelfareRequestAttachment",
                newName: "IX_RequestAttachments_FK_AttachmentTypeId");

            migrationBuilder.AddColumn<int>(
                name: "FK_InsuranceSectorID",
                table: "Labor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsurancePeriod",
                table: "Labor",
                type: "int",
                nullable: true);
        }
    }
}
