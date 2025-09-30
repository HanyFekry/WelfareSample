using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WelfareDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class grantCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GrantDisbursementRequest_GrantId",
                table: "GrantDisbursementRequest");

            migrationBuilder.AddColumn<int>(
                name: "GrantCategoryId",
                table: "GrantType",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LastGrantStepId",
                table: "Grants",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DirectorateId",
                table: "Grants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GrantStatusId",
                table: "Grants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RequestStatusId",
                table: "Grants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "RequestUUId",
                table: "Grants",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "GrantCategory",
                columns: table => new
                {
                    GrantCategoryID = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for the gender"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Code representing the gender"),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "English text description of the gender"),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Arabic text description of the gender"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantCategory", x => x.GrantCategoryID);
                },
                comment: "Table storing gender information");

            migrationBuilder.CreateIndex(
                name: "IX_GrantType_GrantCategoryId",
                table: "GrantType",
                column: "GrantCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Grants_DirectorateId",
                table: "Grants",
                column: "DirectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantDisbursementRequest_GrantId",
                table: "GrantDisbursementRequest",
                column: "GrantId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Grants_Directorate_DirectorateId",
                table: "Grants",
                column: "DirectorateId",
                principalTable: "Directorate",
                principalColumn: "DirectorateID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GrantType_GrantCategory_GrantCategoryId",
                table: "GrantType",
                column: "GrantCategoryId",
                principalTable: "GrantCategory",
                principalColumn: "GrantCategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grants_Directorate_DirectorateId",
                table: "Grants");

            migrationBuilder.DropForeignKey(
                name: "FK_GrantType_GrantCategory_GrantCategoryId",
                table: "GrantType");

            migrationBuilder.DropTable(
                name: "GrantCategory");

            migrationBuilder.DropIndex(
                name: "IX_GrantType_GrantCategoryId",
                table: "GrantType");

            migrationBuilder.DropIndex(
                name: "IX_Grants_DirectorateId",
                table: "Grants");

            migrationBuilder.DropIndex(
                name: "IX_GrantDisbursementRequest_GrantId",
                table: "GrantDisbursementRequest");

            migrationBuilder.DropColumn(
                name: "GrantCategoryId",
                table: "GrantType");

            migrationBuilder.DropColumn(
                name: "DirectorateId",
                table: "Grants");

            migrationBuilder.DropColumn(
                name: "GrantStatusId",
                table: "Grants");

            migrationBuilder.DropColumn(
                name: "RequestStatusId",
                table: "Grants");

            migrationBuilder.DropColumn(
                name: "RequestUUId",
                table: "Grants");

            migrationBuilder.AlterColumn<int>(
                name: "LastGrantStepId",
                table: "Grants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GrantDisbursementRequest_GrantId",
                table: "GrantDisbursementRequest",
                column: "GrantId");
        }
    }
}
