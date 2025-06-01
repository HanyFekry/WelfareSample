using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WelfareDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddStepConfigurationToWelfareRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "WelfareRequestAction",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FK_WelfareRequestStatusID",
                table: "WelfareRequest",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Identifier for the current status of a current workflow");

            migrationBuilder.AddColumn<int>(
                name: "WelfareRequestStatusId1",
                table: "WelfareRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WelfareRequestStatus",
                columns: table => new
                {
                    RequestStatusID = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for each Welfare request status record"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Code representing the Welfare request status"),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "English text description of the Welfare request status"),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Arabic text description of the Welfare request status")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelfareRequestStatus", x => x.RequestStatusID);
                });

            migrationBuilder.CreateTable(
                name: "WelfareRequestStepConfiguration",
                columns: table => new
                {
                    WelfareRequestId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Role responsible for this step"),
                    ActionTypeID = table.Column<int>(type: "int", nullable: false, comment: "Action type for this step")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelfareRequestStepConfiguration", x => new { x.WelfareRequestId, x.Id });
                    table.ForeignKey(
                        name: "FK_WelfareRequestStepConfiguration_WelfareRequest_WelfareRequestId",
                        column: x => x.WelfareRequestId,
                        principalTable: "WelfareRequest",
                        principalColumn: "WelfareRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WelfareRequest_WelfareRequestStatus_WelfareRequestStatusId1",
                table: "WelfareRequest");

            migrationBuilder.DropTable(
                name: "WelfareRequestStatus");

            migrationBuilder.DropTable(
                name: "WelfareRequestStepConfiguration");

            migrationBuilder.DropIndex(
                name: "IX_WelfareRequest_WelfareRequestStatusId1",
                table: "WelfareRequest");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "WelfareRequestAction");

            migrationBuilder.DropColumn(
                name: "FK_WelfareRequestStatusID",
                table: "WelfareRequest");

            migrationBuilder.DropColumn(
                name: "WelfareRequestStatusId1",
                table: "WelfareRequest");
        }
    }
}
