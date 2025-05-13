using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WelfareDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialWelfareDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeneficiaryType",
                columns: table => new
                {
                    BeneficiaryTypeId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficiaryType", x => x.BeneficiaryTypeId);
                });

            migrationBuilder.CreateTable(
                name: "BusinessNature",
                columns: table => new
                {
                    BusinessNatureID = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for the business nature"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Code representing the business nature"),
                    Text = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, comment: "English text description of the business nature"),
                    Text2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, comment: "Arabic text description of the business nature"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates if the business nature is deleted"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Indicates if the business nature is active")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessNature", x => x.BusinessNatureID);
                },
                comment: "Table storing business natures");

            migrationBuilder.CreateTable(
                name: "Directorate",
                columns: table => new
                {
                    DirectorateID = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for the directorate"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Code representing the directorate"),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "English text description of the directorate"),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Arabic text description of the directorate"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates if the directorate is deleted"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Indicates if the directorate is active"),
                    FK_GovernorateID = table.Column<int>(type: "int", nullable: false, comment: "Foreign key to the Governorate table")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directorate", x => x.DirectorateID);
                },
                comment: "Table storing directorates");

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderID = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for the gender"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Code representing the gender"),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "English text description of the gender"),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Arabic text description of the gender"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderID);
                },
                comment: "Table storing gender information");

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    MaritalStatusID = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for each marital status record"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Code representing the marital status"),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "English text description of the marital status"),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Arabic text description of the marital status"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.MaritalStatusID);
                });

            migrationBuilder.CreateTable(
                name: "MedicalServiceProvider",
                columns: table => new
                {
                    MedicalServiceProviderId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IBAN = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalServiceProvider", x => x.MedicalServiceProviderId);
                });

            migrationBuilder.CreateTable(
                name: "NotificationReceiverType",
                columns: table => new
                {
                    NotificationReceiverTypeID = table.Column<int>(type: "int", nullable: false, comment: "A unique identifier for each notification receiver type."),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "A unique code representing the notification receiver type."),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "The English description or name of the notification receiver type."),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "An optional Arabic description or additional information for the notification receiver type.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationReceiverType", x => x.NotificationReceiverTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Occupation",
                columns: table => new
                {
                    OccupationID = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for each occupation record"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Code representing the occupation"),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "English text description of the occupation"),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Arabic text description of the occupation"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupation", x => x.OccupationID);
                });

            migrationBuilder.CreateTable(
                name: "PartyType",
                columns: table => new
                {
                    PartyTypeID = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates if the business nature is deleted"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Indicates if the business nature is active")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyType", x => x.PartyTypeID);
                });

            migrationBuilder.CreateTable(
                name: "RelativeRelationship",
                columns: table => new
                {
                    RelativeRelationshipID = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelativeRelationship", x => x.RelativeRelationshipID);
                });

            migrationBuilder.CreateTable(
                name: "RelativeRelationType",
                columns: table => new
                {
                    RelativeRelationTypeID = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelativeRelationType", x => x.RelativeRelationTypeID);
                });

            migrationBuilder.CreateTable(
                name: "RequesterRelevance",
                columns: table => new
                {
                    RequesterRelevantID = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequesterRelevant", x => x.RequesterRelevantID);
                },
                comment: "Labor or Medical provider or Other");

            migrationBuilder.CreateTable(
                name: "RequestStatus",
                columns: table => new
                {
                    RequestStatusID = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for each request status record"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Code representing the request status"),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "English text description of the request status"),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Arabic text description of the request status")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStatus", x => x.RequestStatusID);
                });

            migrationBuilder.CreateTable(
                name: "RequestType",
                columns: table => new
                {
                    RequestTypeID = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for each request type"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Code representing the request type"),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "English text description of the request type"),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Arabic text description of the request type")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestType", x => x.RequestTypeID);
                });

            migrationBuilder.CreateTable(
                name: "SocialCareRequest",
                columns: table => new
                {
                    RequestID = table.Column<long>(type: "bigint", nullable: false, comment: "Unique identifier for request record"),
                    FK_LaborID = table.Column<long>(type: "bigint", nullable: true, comment: "Unique identifier for labor associated with request"),
                    EventDate = table.Column<DateOnly>(type: "date", nullable: false, comment: "EventDate refers to the date of the event for which the care request service is required, such as the date of a marriage, the birth of a newborn, a death, and so on."),
                    DeservedAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false, comment: "\r\nit is the amount that is entitled or due to the individual based on the specific event or service requested. This amount is calculated according to the guidelines and regulations governing the labor care services, and it may vary depending on the nature of the event, such as marriage, birth of a newborn, or death."),
                    EventEndDate = table.Column<DateOnly>(type: "date", nullable: true, comment: "EventDate refers to the date of the event for which the care request service is required, such as the date of a marriage, the birth of a newborn, a death, and so on."),
                    FK_DeadRelativeRelationTypeID = table.Column<int>(type: "int", nullable: true, comment: "Relationship to dead relative if applicable"),
                    DeadRelativeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Name to dead relative  in case of relative death event if applicable"),
                    WifeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Wife name in case of marriage event if applicable"),
                    DisabilityPercent = table.Column<byte>(type: "tinyint", nullable: true, comment: "Percent of disability in case of disability events if applicable"),
                    IsTwins = table.Column<bool>(type: "bit", nullable: true, comment: "A flag indicating whether the current request involves twins in case of newborn event if applicable")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaborCareRequestDetails", x => x.RequestID);
                });

            migrationBuilder.CreateTable(
                name: "WelfareCategory",
                columns: table => new
                {
                    WelfareCategoryId = table.Column<byte>(type: "tinyint", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelfareCategory", x => x.WelfareCategoryId);
                },
                comment: "Monetary or ");

            migrationBuilder.CreateTable(
                name: "Party",
                columns: table => new
                {
                    PartyID = table.Column<long>(type: "bigint", nullable: false),
                    FK_PartyTypeID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Party", x => x.PartyID);
                    table.ForeignKey(
                        name: "FK_Party_PartyType",
                        column: x => x.FK_PartyTypeID,
                        principalTable: "PartyType",
                        principalColumn: "PartyTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WelfareType",
                columns: table => new
                {
                    WelfareTypeID = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for each Welfare type"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Code representing the Welfare type"),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "English text description of the Welfare type"),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Arabic text description of the Welfare type"),
                    FK_WelfareCategoryId = table.Column<byte>(type: "tinyint", nullable: false),
                    WelfareAmount = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    MaximumLimit = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelfareType", x => x.WelfareTypeID);
                    table.ForeignKey(
                        name: "FK_WelfareType_WelfareCategory_FK_WelfareCategoryId",
                        column: x => x.FK_WelfareCategoryId,
                        principalTable: "WelfareCategory",
                        principalColumn: "WelfareCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Labor",
                columns: table => new
                {
                    LaborID = table.Column<long>(type: "bigint", nullable: false),
                    NationalID = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: true),
                    FK_GenderID = table.Column<int>(type: "int", nullable: true),
                    FK_MaritalStatusID = table.Column<int>(type: "int", nullable: true),
                    FK_OccupationID = table.Column<int>(type: "int", nullable: false),
                    MobileNo = table.Column<string>(type: "char(13)", unicode: false, fixedLength: true, maxLength: 13, nullable: false),
                    FK_LastDirectorateID = table.Column<int>(type: "int", nullable: true),
                    FK_LastBusinessNatureID = table.Column<int>(type: "int", nullable: true),
                    FK_LastExecutionPartyID = table.Column<long>(type: "bigint", nullable: true),
                    RegistrationNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    RegistrationDate = table.Column<DateOnly>(type: "date", nullable: true),
                    InsuranceNo = table.Column<string>(type: "char(9)", unicode: false, fixedLength: true, maxLength: 9, nullable: true),
                    FK_InsuranceSectorID = table.Column<int>(type: "int", nullable: true),
                    InsurancePeriod = table.Column<int>(type: "int", nullable: true),
                    DeathDate = table.Column<DateOnly>(type: "date", nullable: true),
                    IsBeneficiary = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "the worker's status must be Beneficiary or  Not Beneficiary, default is Beneficiary(1)"),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labor", x => x.LaborID);
                    table.ForeignKey(
                        name: "FK_Labor_BusinessNature",
                        column: x => x.FK_LastBusinessNatureID,
                        principalTable: "BusinessNature",
                        principalColumn: "BusinessNatureID");
                    table.ForeignKey(
                        name: "FK_Labor_Directorate",
                        column: x => x.FK_LastDirectorateID,
                        principalTable: "Directorate",
                        principalColumn: "DirectorateID");
                    table.ForeignKey(
                        name: "FK_Labor_Gender",
                        column: x => x.FK_GenderID,
                        principalTable: "Gender",
                        principalColumn: "GenderID");
                    table.ForeignKey(
                        name: "FK_Labor_MaritalStatus",
                        column: x => x.FK_MaritalStatusID,
                        principalTable: "MaritalStatus",
                        principalColumn: "MaritalStatusID");
                    table.ForeignKey(
                        name: "FK_Labor_Occupation",
                        column: x => x.FK_OccupationID,
                        principalTable: "Occupation",
                        principalColumn: "OccupationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Labor_Party",
                        column: x => x.FK_LastExecutionPartyID,
                        principalTable: "Party",
                        principalColumn: "PartyID");
                });

            migrationBuilder.CreateTable(
                name: "AttachmentType",
                columns: table => new
                {
                    AttachmentTypeID = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for the attachment type"),
                    FK_WelfareTypeID = table.Column<int>(type: "int", nullable: false, comment: "Foreign key to the LaborCareType table"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Code representing the attachment type"),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "English text description of the attachment type"),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Arabic text description of the attachment type"),
                    SizeLimit = table.Column<int>(type: "int", nullable: true, comment: "Limit on the size of the attachment"),
                    MimeTypes = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false, comment: "Allowed MIME types for the attachment"),
                    Mandatory = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates if the attachment type is mandatory"),
                    MaxFileCount = table.Column<int>(type: "int", nullable: false, comment: "Number of files allowed for the attachment type")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachmentType", x => x.AttachmentTypeID);
                    table.ForeignKey(
                        name: "FK_AttachmentType_WelfareType_FK_WelfareTypeID",
                        column: x => x.FK_WelfareTypeID,
                        principalTable: "WelfareType",
                        principalColumn: "WelfareTypeID",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Table storing attachment types");

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    RequestId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNo = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    FK_LaborId = table.Column<int>(type: "int", nullable: false),
                    FK_DirectorateID = table.Column<int>(type: "int", nullable: false, comment: "Identifier for the directorate associated with the request"),
                    FK_WelfareTypeID = table.Column<int>(type: "int", nullable: false, comment: "Identifier for the type of request"),
                    FK_StatusID = table.Column<int>(type: "int", nullable: false, comment: "Identifier for the current status of a current workflow"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the request was created"),
                    CreatedByUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, comment: "User ID of the user who created the request record"),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "User name of the user who created the request record"),
                    UpdatedUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, comment: "User ID of the user who last updated the request record"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date and time when the request record was last updated"),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "User name of the user who last updated the request record"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false, comment: "Timestamp for version control of the request record"),
                    DueAmount = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    LaborMobileNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_Request_Directorate_FK_DirectorateID",
                        column: x => x.FK_DirectorateID,
                        principalTable: "Directorate",
                        principalColumn: "DirectorateID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_RequestStatus_FK_StatusID",
                        column: x => x.FK_StatusID,
                        principalTable: "RequestStatus",
                        principalColumn: "RequestStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_WelfareType_FK_WelfareTypeID",
                        column: x => x.FK_WelfareTypeID,
                        principalTable: "WelfareType",
                        principalColumn: "WelfareTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DisabilityWelfareRequest",
                columns: table => new
                {
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisabilityRatio = table.Column<decimal>(type: "decimal(2,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisabilityWelfareRequest", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_DisabilityWelfareRequest_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "RequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalWelfareRequest",
                columns: table => new
                {
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    FK_MedicalServiceProviderId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FK_BeneficiaryTypeId = table.Column<int>(type: "int", nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    BeneficiaryNId = table.Column<int>(type: "int", unicode: false, fixedLength: true, maxLength: 14, nullable: true),
                    BeneficiaryIBAN = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    NoOfPrescriptions = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalWelfareRequest", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_MedicalWelfareRequest_BeneficiaryType_FK_BeneficiaryTypeId",
                        column: x => x.FK_BeneficiaryTypeId,
                        principalTable: "BeneficiaryType",
                        principalColumn: "BeneficiaryTypeId");
                    table.ForeignKey(
                        name: "FK_MedicalWelfareRequest_MedicalServiceProvider_FK_MedicalServiceProviderId",
                        column: x => x.FK_MedicalServiceProviderId,
                        principalTable: "MedicalServiceProvider",
                        principalColumn: "MedicalServiceProviderId");
                    table.ForeignKey(
                        name: "FK_MedicalWelfareRequest_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "RequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestAttachments",
                columns: table => new
                {
                    RequestAttachmentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_RequestId = table.Column<long>(type: "bigint", nullable: false),
                    FK_AttachmentTypeId = table.Column<int>(type: "int", nullable: false),
                    AttachmentPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestAttachments_1", x => x.RequestAttachmentId);
                    table.ForeignKey(
                        name: "FK_RequestAttachments_AttachmentType_FK_AttachmentTypeId",
                        column: x => x.FK_AttachmentTypeId,
                        principalTable: "AttachmentType",
                        principalColumn: "AttachmentTypeID");
                    table.ForeignKey(
                        name: "FK_RequestAttachments_Request_FK_RequestId",
                        column: x => x.FK_RequestId,
                        principalTable: "Request",
                        principalColumn: "RequestId");
                });

            migrationBuilder.CreateTable(
                name: "SocialWelfareRequest",
                columns: table => new
                {
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NationalId = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: false),
                    IsTwin = table.Column<bool>(type: "bit", nullable: true),
                    RequesterName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FK_RelativeRelationshipId = table.Column<int>(type: "int", nullable: true),
                    FK_RequesterRelevanceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialWelfareRequest", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_SocialWelfareRequest_RelativeRelationship_FK_RelativeRelationshipId",
                        column: x => x.FK_RelativeRelationshipId,
                        principalTable: "RelativeRelationship",
                        principalColumn: "RelativeRelationshipID");
                    table.ForeignKey(
                        name: "FK_SocialWelfareRequest_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "RequestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SocialWelfareRequest_RequesterRelevance_FK_RequesterRelevanceId",
                        column: x => x.FK_RequesterRelevanceId,
                        principalTable: "RequesterRelevance",
                        principalColumn: "RequesterRelevantID");
                });

            migrationBuilder.CreateTable(
                name: "Beneficiary",
                columns: table => new
                {
                    BeneficiaryID = table.Column<long>(type: "bigint", nullable: false, comment: "Unique identifier for Beneficiary")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_LaborID = table.Column<long>(type: "bigint", nullable: true, comment: "Unique identifier for labor associated with request"),
                    FK_SocialWelfareRequestId = table.Column<long>(type: "bigint", nullable: false, comment: "Identifier of social request if applicable"),
                    BeneficiaryName = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false, comment: "Beneficiary name"),
                    NationalID = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: false, comment: "National identification number of the labor"),
                    FK_RelativeRelationTypeID = table.Column<int>(type: "int", nullable: false, comment: "Relationship to dead employee"),
                    IBAN = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(8,2)", nullable: false, comment: "Amount to be disbursed for beneficiary")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiary", x => x.BeneficiaryID);
                    table.ForeignKey(
                        name: "FK_Beneficiary_RelativeRelationType_FK_RelativeRelationTypeID",
                        column: x => x.FK_RelativeRelationTypeID,
                        principalTable: "RelativeRelationType",
                        principalColumn: "RelativeRelationTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Beneficiary_SocialWelfareRequest_FK_SocialWelfareRequestId",
                        column: x => x.FK_SocialWelfareRequestId,
                        principalTable: "SocialWelfareRequest",
                        principalColumn: "RequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentType_FK_WelfareTypeID",
                table: "AttachmentType",
                column: "FK_WelfareTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiary_FK_RelativeRelationTypeID",
                table: "Beneficiary",
                column: "FK_RelativeRelationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiary_FK_SocialWelfareRequestId",
                table: "Beneficiary",
                column: "FK_SocialWelfareRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Labor_FK_GenderID",
                table: "Labor",
                column: "FK_GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Labor_FK_LastBusinessNatureID",
                table: "Labor",
                column: "FK_LastBusinessNatureID");

            migrationBuilder.CreateIndex(
                name: "IX_Labor_FK_LastDirectorateID",
                table: "Labor",
                column: "FK_LastDirectorateID");

            migrationBuilder.CreateIndex(
                name: "IX_Labor_FK_LastExecutionPartyID",
                table: "Labor",
                column: "FK_LastExecutionPartyID");

            migrationBuilder.CreateIndex(
                name: "IX_Labor_FK_MaritalStatusID",
                table: "Labor",
                column: "FK_MaritalStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Labor_FK_OccupationID",
                table: "Labor",
                column: "FK_OccupationID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalWelfareRequest_FK_BeneficiaryTypeId",
                table: "MedicalWelfareRequest",
                column: "FK_BeneficiaryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalWelfareRequest_FK_MedicalServiceProviderId",
                table: "MedicalWelfareRequest",
                column: "FK_MedicalServiceProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Party_FK_PartyTypeID",
                table: "Party",
                column: "FK_PartyTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Request_FK_DirectorateID",
                table: "Request",
                column: "FK_DirectorateID");

            migrationBuilder.CreateIndex(
                name: "IX_Request_FK_StatusID",
                table: "Request",
                column: "FK_StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Request_FK_WelfareTypeID",
                table: "Request",
                column: "FK_WelfareTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestAttachments_FK_AttachmentTypeId",
                table: "RequestAttachments",
                column: "FK_AttachmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestAttachments_FK_RequestId",
                table: "RequestAttachments",
                column: "FK_RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialWelfareRequest_FK_RelativeRelationshipId",
                table: "SocialWelfareRequest",
                column: "FK_RelativeRelationshipId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialWelfareRequest_FK_RequesterRelevanceId",
                table: "SocialWelfareRequest",
                column: "FK_RequesterRelevanceId");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareType_FK_WelfareCategoryId",
                table: "WelfareType",
                column: "FK_WelfareCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beneficiary");

            migrationBuilder.DropTable(
                name: "DisabilityWelfareRequest");

            migrationBuilder.DropTable(
                name: "Labor");

            migrationBuilder.DropTable(
                name: "MedicalWelfareRequest");

            migrationBuilder.DropTable(
                name: "NotificationReceiverType");

            migrationBuilder.DropTable(
                name: "RequestAttachments");

            migrationBuilder.DropTable(
                name: "RequestType");

            migrationBuilder.DropTable(
                name: "SocialCareRequest");

            migrationBuilder.DropTable(
                name: "RelativeRelationType");

            migrationBuilder.DropTable(
                name: "SocialWelfareRequest");

            migrationBuilder.DropTable(
                name: "BusinessNature");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "Occupation");

            migrationBuilder.DropTable(
                name: "Party");

            migrationBuilder.DropTable(
                name: "BeneficiaryType");

            migrationBuilder.DropTable(
                name: "MedicalServiceProvider");

            migrationBuilder.DropTable(
                name: "AttachmentType");

            migrationBuilder.DropTable(
                name: "RelativeRelationship");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "RequesterRelevance");

            migrationBuilder.DropTable(
                name: "PartyType");

            migrationBuilder.DropTable(
                name: "Directorate");

            migrationBuilder.DropTable(
                name: "RequestStatus");

            migrationBuilder.DropTable(
                name: "WelfareType");

            migrationBuilder.DropTable(
                name: "WelfareCategory");
        }
    }
}
