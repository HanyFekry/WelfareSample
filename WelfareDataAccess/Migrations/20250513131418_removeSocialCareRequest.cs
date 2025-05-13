using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WelfareDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class removeSocialCareRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialCareRequest");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SocialCareRequest",
                columns: table => new
                {
                    RequestID = table.Column<long>(type: "bigint", nullable: false, comment: "Unique identifier for request record"),
                    DeadRelativeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Name to dead relative  in case of relative death event if applicable"),
                    FK_DeadRelativeRelationTypeID = table.Column<int>(type: "int", nullable: true, comment: "Relationship to dead relative if applicable"),
                    DeservedAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false, comment: "\r\nit is the amount that is entitled or due to the individual based on the specific event or service requested. This amount is calculated according to the guidelines and regulations governing the labor care services, and it may vary depending on the nature of the event, such as marriage, birth of a newborn, or death."),
                    DisabilityPercent = table.Column<byte>(type: "tinyint", nullable: true, comment: "Percent of disability in case of disability events if applicable"),
                    EventDate = table.Column<DateOnly>(type: "date", nullable: false, comment: "EventDate refers to the date of the event for which the care request service is required, such as the date of a marriage, the birth of a newborn, a death, and so on."),
                    EventEndDate = table.Column<DateOnly>(type: "date", nullable: true, comment: "EventDate refers to the date of the event for which the care request service is required, such as the date of a marriage, the birth of a newborn, a death, and so on."),
                    IsTwins = table.Column<bool>(type: "bit", nullable: true, comment: "A flag indicating whether the current request involves twins in case of newborn event if applicable"),
                    FK_LaborID = table.Column<long>(type: "bigint", nullable: true, comment: "Unique identifier for labor associated with request"),
                    WifeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Wife name in case of marriage event if applicable")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaborCareRequestDetails", x => x.RequestID);
                });
        }
    }
}
