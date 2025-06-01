using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WelfareDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateWelfareRequestStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WelfareRequest_WelfareRequestStatus_WelfareRequestStatusId1",
                table: "WelfareRequest");

            migrationBuilder.DropIndex(
                name: "IX_WelfareRequest_WelfareRequestStatusId1",
                table: "WelfareRequest");

            migrationBuilder.DropColumn(
                name: "WelfareRequestStatusId1",
                table: "WelfareRequest");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareRequest_FK_WelfareRequestStatusID",
                table: "WelfareRequest",
                column: "FK_WelfareRequestStatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_WelfareRequest_WelfareRequestStatus_FK_WelfareRequestStatusID",
                table: "WelfareRequest",
                column: "FK_WelfareRequestStatusID",
                principalTable: "WelfareRequestStatus",
                principalColumn: "RequestStatusID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WelfareRequest_WelfareRequestStatus_FK_WelfareRequestStatusID",
                table: "WelfareRequest");

            migrationBuilder.DropIndex(
                name: "IX_WelfareRequest_FK_WelfareRequestStatusID",
                table: "WelfareRequest");

            migrationBuilder.AddColumn<int>(
                name: "WelfareRequestStatusId1",
                table: "WelfareRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WelfareRequest_WelfareRequestStatusId1",
                table: "WelfareRequest",
                column: "WelfareRequestStatusId1");

            migrationBuilder.AddForeignKey(
                name: "FK_WelfareRequest_WelfareRequestStatus_WelfareRequestStatusId1",
                table: "WelfareRequest",
                column: "WelfareRequestStatusId1",
                principalTable: "WelfareRequestStatus",
                principalColumn: "RequestStatusID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
