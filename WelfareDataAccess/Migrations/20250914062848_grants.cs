using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WelfareDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class grants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActionType",
                columns: table => new
                {
                    ActionTypeId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcctionType", x => x.ActionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AttachmentType",
                columns: table => new
                {
                    AttachmentTypeID = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for the attachment type"),
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
                },
                comment: "Table storing attachment types");

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
                name: "DisbursementPaymentData",
                columns: table => new
                {
                    DisbursementPaymentDataId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WelfareRequestId = table.Column<long>(type: "bigint", nullable: false),
                    DisbursementRequestId = table.Column<int>(type: "int", nullable: false),
                    WelfareRequestStatusId = table.Column<int>(type: "int", nullable: false),
                    WelfareTypeId = table.Column<int>(type: "int", nullable: false),
                    BeneficiaryNationalId = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisbursementPaymentData", x => x.DisbursementPaymentDataId);
                });

            migrationBuilder.CreateTable(
                name: "DisbursementRequest",
                columns: table => new
                {
                    DisbursementRequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisbursementNo = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    RequestUUID = table.Column<long>(type: "bigint", nullable: false, comment: "Unique identifier for the request"),
                    Title = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    RequestStatusId = table.Column<int>(type: "int", nullable: false, comment: "Identifier for the current status of a current workflow"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date and time when the request record was last updated"),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "User name of the user who last updated the request record"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the request was created"),
                    CreatedByUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, comment: "User ID of the user who created the request record"),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "User name of the user who created the request record"),
                    DisbursementRequestAttachmentPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "path of Disbursement Request Attachment"),
                    DisbursementPaymentDataPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "path of Disbursement payment data Attachment"),
                    LastDisbursementRequestStepId = table.Column<int>(type: "int", nullable: true, comment: "Identifier for the last step in the disbursement request workflow"),
                    UpdatedUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, comment: "User ID of the user who last updated the request record")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisbursementRequest", x => x.DisbursementRequestId);
                });

            migrationBuilder.CreateTable(
                name: "DisbursementRequestStep",
                columns: table => new
                {
                    DisbursementRequestStepId = table.Column<int>(type: "int", nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Arabic text description of the request step"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code representing the request step"),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "English text description of the request step")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisbursementRequestStep", x => x.DisbursementRequestStepId);
                });

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
                name: "GrantBeneficiaries",
                columns: table => new
                {
                    GrantBeneficiaryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NationalID = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<string>(type: "char(13)", unicode: false, fixedLength: true, maxLength: 13, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    IBan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BranchName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LaborId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantBeneficiaries", x => x.GrantBeneficiaryID);
                });

            migrationBuilder.CreateTable(
                name: "GrantStep",
                columns: table => new
                {
                    GrantStepID = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates if the Grant Step is deleted"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Indicates if the Grant Step is active")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantStep", x => x.GrantStepID);
                });

            migrationBuilder.CreateTable(
                name: "GrantType",
                columns: table => new
                {
                    GrantTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates if the business nature is deleted"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Indicates if the business nature is active")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantType", x => x.GrantTypeId);
                });

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
                name: "PaymentChannel",
                columns: table => new
                {
                    PaymentChannelID = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    AccountNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentChannel", x => x.PaymentChannelID);
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
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Arabic text description of the request type"),
                    IsMemorandum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestType", x => x.RequestTypeID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceDeliveryMethod",
                columns: table => new
                {
                    ServiceDeliveryMethodId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ExpirationDurationInDays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceDeliveryMethod", x => x.ServiceDeliveryMethodId);
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
                name: "WelfareLocalActionType",
                columns: table => new
                {
                    WelfareLocalActionTypeId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelfareLocalActionType", x => x.WelfareLocalActionTypeId);
                });

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
                name: "WelfareRequestStep",
                columns: table => new
                {
                    WelfareRequestStepId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelfareRequestStep", x => x.WelfareRequestStepId);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowReason",
                columns: table => new
                {
                    WorkflowReasonId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequestType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowReason", x => x.WorkflowReasonId);
                });

            migrationBuilder.CreateTable(
                name: "DisbursementRequestStepConfiguration",
                columns: table => new
                {
                    DisbursementRequestId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Role responsible for this step"),
                    ActionTypeID = table.Column<int>(type: "int", nullable: false, comment: "Action type for this step")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisbursementRequestStepConfiguration", x => new { x.DisbursementRequestId, x.Id });
                    table.ForeignKey(
                        name: "FK_DisbursementRequestStepConfiguration_DisbursementRequest_DisbursementRequestId",
                        column: x => x.DisbursementRequestId,
                        principalTable: "DisbursementRequest",
                        principalColumn: "DisbursementRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActionTypeDisbursementRequestStep",
                columns: table => new
                {
                    ActionTypesActionTypeId = table.Column<int>(type: "int", nullable: false),
                    DisbursementRequestStepsDisbursementRequestStepId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionTypeDisbursementRequestStep", x => new { x.ActionTypesActionTypeId, x.DisbursementRequestStepsDisbursementRequestStepId });
                    table.ForeignKey(
                        name: "FK_ActionTypeDisbursementRequestStep_ActionType_ActionTypesActionTypeId",
                        column: x => x.ActionTypesActionTypeId,
                        principalTable: "ActionType",
                        principalColumn: "ActionTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActionTypeDisbursementRequestStep_DisbursementRequestStep_DisbursementRequestStepsDisbursementRequestStepId",
                        column: x => x.DisbursementRequestStepsDisbursementRequestStepId,
                        principalTable: "DisbursementRequestStep",
                        principalColumn: "DisbursementRequestStepId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                        name: "FK_Party_PartyType_FK_PartyTypeID",
                        column: x => x.FK_PartyTypeID,
                        principalTable: "PartyType",
                        principalColumn: "PartyTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DisbursementRequestAction",
                columns: table => new
                {
                    DisbursementRequestActionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_PaymentChannelId = table.Column<int>(type: "int", nullable: true, comment: "approved payment channel"),
                    FK_DisbursementRequestID = table.Column<int>(type: "int", nullable: false, comment: "Parent request identifier"),
                    FK_DisbursementRequestStepId = table.Column<int>(type: "int", nullable: false, comment: "Current step in workflow for the action"),
                    FK_ActionTypeID = table.Column<int>(type: "int", nullable: false, comment: "Type of action performed"),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "User name of the user who created the request record"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the request was created"),
                    CreatedByUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, comment: "User ID of the user who created the request record"),
                    Notes = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    TransactionInfo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DisbursementDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisbursementRequestAction", x => x.DisbursementRequestActionId);
                    table.ForeignKey(
                        name: "FK_DisbursementRequestAction_ActionType_FK_ActionTypeID",
                        column: x => x.FK_ActionTypeID,
                        principalTable: "ActionType",
                        principalColumn: "ActionTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DisbursementRequestAction_DisbursementRequestStep_FK_DisbursementRequestStepId",
                        column: x => x.FK_DisbursementRequestStepId,
                        principalTable: "DisbursementRequestStep",
                        principalColumn: "DisbursementRequestStepId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DisbursementRequestAction_DisbursementRequest_FK_DisbursementRequestID",
                        column: x => x.FK_DisbursementRequestID,
                        principalTable: "DisbursementRequest",
                        principalColumn: "DisbursementRequestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DisbursementRequestAction_PaymentChannel_FK_PaymentChannelId",
                        column: x => x.FK_PaymentChannelId,
                        principalTable: "PaymentChannel",
                        principalColumn: "PaymentChannelID");
                });

            migrationBuilder.CreateTable(
                name: "Grants",
                columns: table => new
                {
                    GrantID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrantTypeId = table.Column<int>(type: "int", nullable: true),
                    GrantCategoryId = table.Column<int>(type: "int", nullable: false),
                    GrantNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "auto generated grant no of the grant"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Description of the grant"),
                    DueAmount = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    InitiateDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DueDate = table.Column<DateOnly>(type: "date", nullable: false),
                    AttachmentPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "Path to the beneficiaries attachment file related to the exceptional grant"),
                    LastGrantStepId = table.Column<int>(type: "int", nullable: false),
                    TotalBeneficiariesNumber = table.Column<int>(type: "int", nullable: false),
                    IsRegistered = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Indicates whether the grant includes registered labors or unregistered beneficiaries"),
                    PaymentChannelId = table.Column<int>(type: "int", nullable: true),
                    TransferNotes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the request was created"),
                    CreatedByUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, comment: "User ID of the user who created the request record"),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "User name of the user who created the request record"),
                    UpdatedUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, comment: "User ID of the user who last updated the request record"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date and time when the request record was last updated"),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "User name of the user who last updated the request record"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false, comment: "Timestamp for version control of the request record"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grants", x => x.GrantID);
                    table.ForeignKey(
                        name: "FK_Grants_GrantType_GrantTypeId",
                        column: x => x.GrantTypeId,
                        principalTable: "GrantType",
                        principalColumn: "GrantTypeId");
                    table.ForeignKey(
                        name: "FK_Grants_PaymentChannel_PaymentChannelId",
                        column: x => x.PaymentChannelId,
                        principalTable: "PaymentChannel",
                        principalColumn: "PaymentChannelID");
                });

            migrationBuilder.CreateTable(
                name: "Memorandum",
                columns: table => new
                {
                    MemorandumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    MemorandumNo = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    FK_RequestType = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "User name of the user who last updated the request record"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the request was created"),
                    CreatedByUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, comment: "User ID of the user who created the request record"),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "User name of the user who created the request record"),
                    UpdatedUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, comment: "User ID of the user who last updated the request record"),
                    MemorandumAttachmentPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "path of memorandum Attachment"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date and time when the request record was last updated")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memorandum", x => x.MemorandumId);
                    table.ForeignKey(
                        name: "FK_Memorandum_RequestType_FK_RequestType",
                        column: x => x.FK_RequestType,
                        principalTable: "RequestType",
                        principalColumn: "RequestTypeID",
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
                name: "ActionTypeWelfareRequestStep",
                columns: table => new
                {
                    ActionTypesActionTypeId = table.Column<int>(type: "int", nullable: false),
                    WelfareRequestStepsWelfareRequestStepId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionTypeWelfareRequestStep", x => new { x.ActionTypesActionTypeId, x.WelfareRequestStepsWelfareRequestStepId });
                    table.ForeignKey(
                        name: "FK_ActionTypeWelfareRequestStep_ActionType_ActionTypesActionTypeId",
                        column: x => x.ActionTypesActionTypeId,
                        principalTable: "ActionType",
                        principalColumn: "ActionTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActionTypeWelfareRequestStep_WelfareRequestStep_WelfareRequestStepsWelfareRequestStepId",
                        column: x => x.WelfareRequestStepsWelfareRequestStepId,
                        principalTable: "WelfareRequestStep",
                        principalColumn: "WelfareRequestStepId",
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
                    DeathDate = table.Column<DateOnly>(type: "date", nullable: true),
                    InsuranceDurationInMonths = table.Column<int>(type: "int", nullable: true),
                    ExclusionReason = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    InsuranceSectorId = table.Column<int>(type: "int", nullable: true),
                    HasFullDisability = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsBeneficiary = table.Column<bool>(type: "bit", nullable: false, computedColumnSql: "case when [DeathDate] IS NOT NULL OR [HasFullDisability]=(1) OR ([InsuranceSectorId] != 4 AND [InsuranceSectorId] != 9 AND [InsuranceSectorId] != NULL) OR [ExclusionReason] IS NOT NULL then CONVERT([bit],(0)) else CONVERT([bit],(1)) end", stored: true, comment: "the worker's status must be Beneficiary or  Not Beneficiary, default is Beneficiary(1)"),
                    UpdatedUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, comment: "User ID of the user who last updated the request record"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date and time when the request record was last updated"),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "User name of the user who last updated the request record")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labor", x => x.LaborID);
                    table.ForeignKey(
                        name: "FK_Labor_BusinessNature_FK_LastBusinessNatureID",
                        column: x => x.FK_LastBusinessNatureID,
                        principalTable: "BusinessNature",
                        principalColumn: "BusinessNatureID");
                    table.ForeignKey(
                        name: "FK_Labor_Directorate_FK_LastDirectorateID",
                        column: x => x.FK_LastDirectorateID,
                        principalTable: "Directorate",
                        principalColumn: "DirectorateID");
                    table.ForeignKey(
                        name: "FK_Labor_Gender_FK_GenderID",
                        column: x => x.FK_GenderID,
                        principalTable: "Gender",
                        principalColumn: "GenderID");
                    table.ForeignKey(
                        name: "FK_Labor_MaritalStatus_FK_MaritalStatusID",
                        column: x => x.FK_MaritalStatusID,
                        principalTable: "MaritalStatus",
                        principalColumn: "MaritalStatusID");
                    table.ForeignKey(
                        name: "FK_Labor_Occupation_FK_OccupationID",
                        column: x => x.FK_OccupationID,
                        principalTable: "Occupation",
                        principalColumn: "OccupationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Labor_Party_FK_LastExecutionPartyID",
                        column: x => x.FK_LastExecutionPartyID,
                        principalTable: "Party",
                        principalColumn: "PartyID");
                });

            migrationBuilder.CreateTable(
                name: "GrantAction",
                columns: table => new
                {
                    GrantActionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_WorkflowReasonID = table.Column<int>(type: "int", nullable: true, comment: "Reason for workflow action, if applicable"),
                    FK_GrantID = table.Column<long>(type: "bigint", nullable: false, comment: "Parent request identifier"),
                    FK_GrantStepId = table.Column<int>(type: "int", nullable: false, comment: "Current step in workflow for the action"),
                    FK_ActionTypeID = table.Column<int>(type: "int", nullable: false, comment: "Type of action performed"),
                    Notes = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedByUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, comment: "User ID of the user who created the request record"),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "User name of the user who created the request record"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the request was created")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantAction", x => x.GrantActionId);
                    table.ForeignKey(
                        name: "FK_GrantAction_ActionType_FK_ActionTypeID",
                        column: x => x.FK_ActionTypeID,
                        principalTable: "ActionType",
                        principalColumn: "ActionTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrantAction_GrantStep_FK_GrantStepId",
                        column: x => x.FK_GrantStepId,
                        principalTable: "GrantStep",
                        principalColumn: "GrantStepID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrantAction_Grants_FK_GrantID",
                        column: x => x.FK_GrantID,
                        principalTable: "Grants",
                        principalColumn: "GrantID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrantAction_WorkflowReason_FK_WorkflowReasonID",
                        column: x => x.FK_WorkflowReasonID,
                        principalTable: "WorkflowReason",
                        principalColumn: "WorkflowReasonId");
                });

            migrationBuilder.CreateTable(
                name: "GrantDisbursementRequest",
                columns: table => new
                {
                    GrantDisbursementRequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisbursementNo = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    RequestUUID = table.Column<long>(type: "bigint", nullable: false, comment: "Unique identifier for the request"),
                    Title = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    RequestStatusId = table.Column<int>(type: "int", nullable: false, comment: "Identifier for the current status of a current workflow"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date and time when the request record was last updated"),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "User name of the user who last updated the request record"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the request was created"),
                    CreatedByUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, comment: "User ID of the user who created the request record"),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "User name of the user who created the request record"),
                    DisbursementRequestAttachmentPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "path of Disbursement Request Attachment"),
                    DisbursementPaymentDataPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "path of Disbursement payment data Attachment"),
                    GrantId = table.Column<long>(type: "bigint", nullable: false),
                    IsDisbursed = table.Column<bool>(type: "bit", nullable: false),
                    LastDisbursementRequestStepId = table.Column<int>(type: "int", nullable: true, comment: "Identifier for the last step in the disbursement request workflow"),
                    UpdatedUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, comment: "User ID of the user who last updated the request record")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantDisbursementRequest", x => x.GrantDisbursementRequestId);
                    table.ForeignKey(
                        name: "FK_GrantDisbursementRequest_Grants_GrantId",
                        column: x => x.GrantId,
                        principalTable: "Grants",
                        principalColumn: "GrantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GrantGrantBeneficiary",
                columns: table => new
                {
                    GrantBeneficiariesGrantBeneficiaryId = table.Column<long>(type: "bigint", nullable: false),
                    GrantsGrantId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantGrantBeneficiary", x => new { x.GrantBeneficiariesGrantBeneficiaryId, x.GrantsGrantId });
                    table.ForeignKey(
                        name: "FK_GrantGrantBeneficiary_GrantBeneficiaries_GrantBeneficiariesGrantBeneficiaryId",
                        column: x => x.GrantBeneficiariesGrantBeneficiaryId,
                        principalTable: "GrantBeneficiaries",
                        principalColumn: "GrantBeneficiaryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrantGrantBeneficiary_Grants_GrantsGrantId",
                        column: x => x.GrantsGrantId,
                        principalTable: "Grants",
                        principalColumn: "GrantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GrantsStepConfiguration",
                columns: table => new
                {
                    GrantId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Role responsible for this step"),
                    ActionTypeID = table.Column<int>(type: "int", nullable: false, comment: "Action type for this step")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantsStepConfiguration", x => new { x.GrantId, x.Id });
                    table.ForeignKey(
                        name: "FK_GrantsStepConfiguration_Grants_GrantId",
                        column: x => x.GrantId,
                        principalTable: "Grants",
                        principalColumn: "GrantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WelfareTypesAttachmentTypes",
                columns: table => new
                {
                    WelfareTypeID = table.Column<int>(type: "int", nullable: false),
                    AttachmentTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelfareTypesAttachmentTypes", x => new { x.WelfareTypeID, x.AttachmentTypeID });
                    table.ForeignKey(
                        name: "FK_WelfareTypesAttachmentTypes_AttachmentType_AttachmentTypeID",
                        column: x => x.AttachmentTypeID,
                        principalTable: "AttachmentType",
                        principalColumn: "AttachmentTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WelfareTypesAttachmentTypes_WelfareType_WelfareTypeID",
                        column: x => x.WelfareTypeID,
                        principalTable: "WelfareType",
                        principalColumn: "WelfareTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GrantLabor",
                columns: table => new
                {
                    GrantsGrantId = table.Column<long>(type: "bigint", nullable: false),
                    LaborsLaborId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantLabor", x => new { x.GrantsGrantId, x.LaborsLaborId });
                    table.ForeignKey(
                        name: "FK_GrantLabor_Grants_GrantsGrantId",
                        column: x => x.GrantsGrantId,
                        principalTable: "Grants",
                        principalColumn: "GrantID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrantLabor_Labor_LaborsLaborId",
                        column: x => x.LaborsLaborId,
                        principalTable: "Labor",
                        principalColumn: "LaborID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WelfareRequest",
                columns: table => new
                {
                    WelfareRequestId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestUUID = table.Column<long>(type: "bigint", nullable: false),
                    RequestNo = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    FK_LaborId = table.Column<long>(type: "bigint", nullable: false),
                    FK_DirectorateID = table.Column<int>(type: "int", nullable: false, comment: "Identifier for the directorate associated with the request"),
                    FK_WelfareTypeID = table.Column<int>(type: "int", nullable: false, comment: "Identifier for the type of request"),
                    FK_RequestStatusID = table.Column<int>(type: "int", nullable: false, comment: "Identifier for the current status of a current workflow"),
                    FK_WelfareRequestStatusID = table.Column<int>(type: "int", nullable: false, comment: "Identifier for the current status of a current workflow"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the request was created"),
                    CreatedByUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, comment: "User ID of the user who created the request record"),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "User name of the user who created the request record"),
                    UpdatedUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, comment: "User ID of the user who last updated the request record"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date and time when the request record was last updated"),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "User name of the user who last updated the request record"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false, comment: "Timestamp for version control of the request record"),
                    DueAmount = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    LaborMobileNo = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    FK_MemorandumId = table.Column<int>(type: "int", nullable: true),
                    FK_DisbursementId = table.Column<int>(type: "int", nullable: true),
                    FK_LastWelfareRequestStepId = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    IsEligible = table.Column<bool>(type: "bit", nullable: true, comment: "Indicates if the request is eligible for disbursement"),
                    AssignedToUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AssignedToUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EligibilityReason = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    AssignedUserRole = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsSystemCancelled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    FK_ServiceDeliveryMethodId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelfareRequest", x => x.WelfareRequestId);
                    table.ForeignKey(
                        name: "FK_WelfareRequest_Directorate_FK_DirectorateID",
                        column: x => x.FK_DirectorateID,
                        principalTable: "Directorate",
                        principalColumn: "DirectorateID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WelfareRequest_DisbursementRequest_FK_DisbursementId",
                        column: x => x.FK_DisbursementId,
                        principalTable: "DisbursementRequest",
                        principalColumn: "DisbursementRequestId");
                    table.ForeignKey(
                        name: "FK_WelfareRequest_Labor_FK_LaborId",
                        column: x => x.FK_LaborId,
                        principalTable: "Labor",
                        principalColumn: "LaborID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WelfareRequest_Memorandum_FK_MemorandumId",
                        column: x => x.FK_MemorandumId,
                        principalTable: "Memorandum",
                        principalColumn: "MemorandumId");
                    table.ForeignKey(
                        name: "FK_WelfareRequest_RequestStatus_FK_RequestStatusID",
                        column: x => x.FK_RequestStatusID,
                        principalTable: "RequestStatus",
                        principalColumn: "RequestStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WelfareRequest_ServiceDeliveryMethod_FK_ServiceDeliveryMethodId",
                        column: x => x.FK_ServiceDeliveryMethodId,
                        principalTable: "ServiceDeliveryMethod",
                        principalColumn: "ServiceDeliveryMethodId");
                    table.ForeignKey(
                        name: "FK_WelfareRequest_WelfareRequestStatus_FK_WelfareRequestStatusID",
                        column: x => x.FK_WelfareRequestStatusID,
                        principalTable: "WelfareRequestStatus",
                        principalColumn: "RequestStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WelfareRequest_WelfareType_FK_WelfareTypeID",
                        column: x => x.FK_WelfareTypeID,
                        principalTable: "WelfareType",
                        principalColumn: "WelfareTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GrantDisbursementRequestAction",
                columns: table => new
                {
                    DisbursementRequestActionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_PaymentChannelId = table.Column<int>(type: "int", nullable: true, comment: "approved payment channel"),
                    FK_GrantDisbursementRequestID = table.Column<int>(type: "int", nullable: false, comment: "Parent request identifier"),
                    FK_DisbursementRequestStepId = table.Column<int>(type: "int", nullable: false, comment: "Current step in workflow for the action"),
                    FK_ActionTypeID = table.Column<int>(type: "int", nullable: false, comment: "Type of action performed"),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "User name of the user who created the request record"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the request was created"),
                    CreatedByUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, comment: "User ID of the user who created the request record"),
                    Notes = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    TransactionInfo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DisbursementDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantDisbursementRequestAction", x => x.DisbursementRequestActionId);
                    table.ForeignKey(
                        name: "FK_GrantDisbursementRequestAction_ActionType_FK_ActionTypeID",
                        column: x => x.FK_ActionTypeID,
                        principalTable: "ActionType",
                        principalColumn: "ActionTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrantDisbursementRequestAction_DisbursementRequestStep_FK_DisbursementRequestStepId",
                        column: x => x.FK_DisbursementRequestStepId,
                        principalTable: "DisbursementRequestStep",
                        principalColumn: "DisbursementRequestStepId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrantDisbursementRequestAction_GrantDisbursementRequest_FK_GrantDisbursementRequestID",
                        column: x => x.FK_GrantDisbursementRequestID,
                        principalTable: "GrantDisbursementRequest",
                        principalColumn: "GrantDisbursementRequestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrantDisbursementRequestAction_PaymentChannel_FK_PaymentChannelId",
                        column: x => x.FK_PaymentChannelId,
                        principalTable: "PaymentChannel",
                        principalColumn: "PaymentChannelID");
                });

            migrationBuilder.CreateTable(
                name: "GrantDisbursementRequestStepConfiguration",
                columns: table => new
                {
                    GrantDisbursementRequestId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Role responsible for this step"),
                    ActionTypeID = table.Column<int>(type: "int", nullable: false, comment: "Action type for this step")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantDisbursementRequestStepConfiguration", x => new { x.GrantDisbursementRequestId, x.Id });
                    table.ForeignKey(
                        name: "FK_GrantDisbursementRequestStepConfiguration_GrantDisbursementRequest_GrantDisbursementRequestId",
                        column: x => x.GrantDisbursementRequestId,
                        principalTable: "GrantDisbursementRequest",
                        principalColumn: "GrantDisbursementRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DisabilityWelfareRequest",
                columns: table => new
                {
                    WelfareRequestId = table.Column<long>(type: "bigint", nullable: false),
                    EventDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DisabilityRatio = table.Column<decimal>(type: "decimal(2,0)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisabilityWelfareRequest", x => x.WelfareRequestId);
                    table.ForeignKey(
                        name: "FK_DisabilityWelfareRequest_WelfareRequest_WelfareRequestId",
                        column: x => x.WelfareRequestId,
                        principalTable: "WelfareRequest",
                        principalColumn: "WelfareRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalWelfareRequest",
                columns: table => new
                {
                    WelfareRequestId = table.Column<long>(type: "bigint", nullable: false),
                    FK_MedicalServiceProviderId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NoOfPrescriptions = table.Column<byte>(type: "tinyint", nullable: true),
                    EventDate = table.Column<DateOnly>(type: "date", nullable: true),
                    IsReviewed = table.Column<bool>(type: "bit", nullable: false),
                    BeneficiaryTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalWelfareRequest", x => x.WelfareRequestId);
                    table.ForeignKey(
                        name: "FK_MedicalWelfareRequest_BeneficiaryType_BeneficiaryTypeId",
                        column: x => x.BeneficiaryTypeId,
                        principalTable: "BeneficiaryType",
                        principalColumn: "BeneficiaryTypeId");
                    table.ForeignKey(
                        name: "FK_MedicalWelfareRequest_MedicalServiceProvider_FK_MedicalServiceProviderId",
                        column: x => x.FK_MedicalServiceProviderId,
                        principalTable: "MedicalServiceProvider",
                        principalColumn: "MedicalServiceProviderId");
                    table.ForeignKey(
                        name: "FK_MedicalWelfareRequest_WelfareRequest_WelfareRequestId",
                        column: x => x.WelfareRequestId,
                        principalTable: "WelfareRequest",
                        principalColumn: "WelfareRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialWelfareRequest",
                columns: table => new
                {
                    WelfareRequestId = table.Column<long>(type: "bigint", nullable: false),
                    EventDate = table.Column<DateOnly>(type: "date", nullable: false),
                    NationalId = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: false),
                    IsTwin = table.Column<bool>(type: "bit", nullable: true),
                    RequesterName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FK_RelativeRelationshipId = table.Column<int>(type: "int", nullable: true),
                    FK_RequesterRelevanceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialWelfareRequest", x => x.WelfareRequestId);
                    table.ForeignKey(
                        name: "FK_SocialWelfareRequest_RelativeRelationship_FK_RelativeRelationshipId",
                        column: x => x.FK_RelativeRelationshipId,
                        principalTable: "RelativeRelationship",
                        principalColumn: "RelativeRelationshipID");
                    table.ForeignKey(
                        name: "FK_SocialWelfareRequest_RequesterRelevance_FK_RequesterRelevanceId",
                        column: x => x.FK_RequesterRelevanceId,
                        principalTable: "RequesterRelevance",
                        principalColumn: "RequesterRelevantID");
                    table.ForeignKey(
                        name: "FK_SocialWelfareRequest_WelfareRequest_WelfareRequestId",
                        column: x => x.WelfareRequestId,
                        principalTable: "WelfareRequest",
                        principalColumn: "WelfareRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WelfareLocalAction",
                columns: table => new
                {
                    WelfareLocalActionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, comment: "User ID of the user who created the request record"),
                    FK_WorkflowReasonID = table.Column<int>(type: "int", nullable: true, comment: "Reason for workflow action, if applicable"),
                    FK_WelfareRequestID = table.Column<long>(type: "bigint", nullable: false, comment: "Parent request identifier"),
                    FK_WelfareLocalActionTypeID = table.Column<int>(type: "int", nullable: false, comment: "Type of action performed"),
                    Notes = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "User name of the user who created the request record"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the request was created")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelfareLocalAction", x => x.WelfareLocalActionId);
                    table.ForeignKey(
                        name: "FK_WelfareLocalAction_WelfareLocalActionType_FK_WelfareLocalActionTypeID",
                        column: x => x.FK_WelfareLocalActionTypeID,
                        principalTable: "WelfareLocalActionType",
                        principalColumn: "WelfareLocalActionTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WelfareLocalAction_WelfareRequest_FK_WelfareRequestID",
                        column: x => x.FK_WelfareRequestID,
                        principalTable: "WelfareRequest",
                        principalColumn: "WelfareRequestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WelfareLocalAction_WorkflowReason_FK_WorkflowReasonID",
                        column: x => x.FK_WorkflowReasonID,
                        principalTable: "WorkflowReason",
                        principalColumn: "WorkflowReasonId");
                });

            migrationBuilder.CreateTable(
                name: "WelfareRequestAction",
                columns: table => new
                {
                    WelfareRequestActionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, comment: "User ID of the user who created the request record"),
                    FK_WorkflowReasonID = table.Column<int>(type: "int", nullable: true, comment: "Reason for workflow action, if applicable"),
                    FK_WelfareRequestID = table.Column<long>(type: "bigint", nullable: false, comment: "Parent request identifier"),
                    FK_WelfareRequestStepId = table.Column<int>(type: "int", nullable: false, comment: "Current step in workflow for the action"),
                    FK_ActionTypeID = table.Column<int>(type: "int", nullable: false, comment: "Type of action performed"),
                    Notes = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "User name of the user who created the request record"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the request was created")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelfareRequestAction", x => x.WelfareRequestActionId);
                    table.ForeignKey(
                        name: "FK_WelfareRequestAction_ActionType_FK_ActionTypeID",
                        column: x => x.FK_ActionTypeID,
                        principalTable: "ActionType",
                        principalColumn: "ActionTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WelfareRequestAction_WelfareRequestStep_FK_WelfareRequestStepId",
                        column: x => x.FK_WelfareRequestStepId,
                        principalTable: "WelfareRequestStep",
                        principalColumn: "WelfareRequestStepId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WelfareRequestAction_WelfareRequest_FK_WelfareRequestID",
                        column: x => x.FK_WelfareRequestID,
                        principalTable: "WelfareRequest",
                        principalColumn: "WelfareRequestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WelfareRequestAction_WorkflowReason_FK_WorkflowReasonID",
                        column: x => x.FK_WorkflowReasonID,
                        principalTable: "WorkflowReason",
                        principalColumn: "WorkflowReasonId");
                });

            migrationBuilder.CreateTable(
                name: "WelfareRequestAttachment",
                columns: table => new
                {
                    WelfareRequestAttachmentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_RequestId = table.Column<long>(type: "bigint", nullable: false),
                    FK_AttachmentTypeId = table.Column<int>(type: "int", nullable: false),
                    AttachmentPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestAttachments_1", x => x.WelfareRequestAttachmentId);
                    table.ForeignKey(
                        name: "FK_WelfareRequestAttachment_AttachmentType_FK_AttachmentTypeId",
                        column: x => x.FK_AttachmentTypeId,
                        principalTable: "AttachmentType",
                        principalColumn: "AttachmentTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WelfareRequestAttachment_WelfareRequest_FK_RequestId",
                        column: x => x.FK_RequestId,
                        principalTable: "WelfareRequest",
                        principalColumn: "WelfareRequestId",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Beneficiary",
                columns: table => new
                {
                    BeneficiaryID = table.Column<long>(type: "bigint", nullable: false, comment: "Unique identifier for Beneficiary")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_LaborID = table.Column<long>(type: "bigint", nullable: true, comment: "Unique identifier for labor associated with request"),
                    FK_SocialWelfareRequestId = table.Column<long>(type: "bigint", nullable: false, comment: "Identifier of social request if applicable"),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false, comment: "Beneficiary name"),
                    NationalID = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: false, comment: "National identification number of the labor"),
                    FK_RelativeRelationTypeID = table.Column<int>(type: "int", nullable: false, comment: "Relationship to dead employee"),
                    IBAN = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(8,2)", nullable: false, comment: "Amount to be disbursed for beneficiary"),
                    IsDisbursed = table.Column<bool>(type: "bit", nullable: false)
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
                        principalColumn: "WelfareRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionTypeDisbursementRequestStep_DisbursementRequestStepsDisbursementRequestStepId",
                table: "ActionTypeDisbursementRequestStep",
                column: "DisbursementRequestStepsDisbursementRequestStepId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionTypeWelfareRequestStep_WelfareRequestStepsWelfareRequestStepId",
                table: "ActionTypeWelfareRequestStep",
                column: "WelfareRequestStepsWelfareRequestStepId");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiary_FK_RelativeRelationTypeID",
                table: "Beneficiary",
                column: "FK_RelativeRelationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiary_FK_SocialWelfareRequestId",
                table: "Beneficiary",
                column: "FK_SocialWelfareRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_DisbursementRequestAction_FK_ActionTypeID",
                table: "DisbursementRequestAction",
                column: "FK_ActionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DisbursementRequestAction_FK_DisbursementRequestID",
                table: "DisbursementRequestAction",
                column: "FK_DisbursementRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_DisbursementRequestAction_FK_DisbursementRequestStepId",
                table: "DisbursementRequestAction",
                column: "FK_DisbursementRequestStepId");

            migrationBuilder.CreateIndex(
                name: "IX_DisbursementRequestAction_FK_PaymentChannelId",
                table: "DisbursementRequestAction",
                column: "FK_PaymentChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantAction_FK_ActionTypeID",
                table: "GrantAction",
                column: "FK_ActionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_GrantAction_FK_GrantID",
                table: "GrantAction",
                column: "FK_GrantID");

            migrationBuilder.CreateIndex(
                name: "IX_GrantAction_FK_GrantStepId",
                table: "GrantAction",
                column: "FK_GrantStepId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantAction_FK_WorkflowReasonID",
                table: "GrantAction",
                column: "FK_WorkflowReasonID");

            migrationBuilder.CreateIndex(
                name: "IX_GrantDisbursementRequest_GrantId",
                table: "GrantDisbursementRequest",
                column: "GrantId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantDisbursementRequestAction_FK_ActionTypeID",
                table: "GrantDisbursementRequestAction",
                column: "FK_ActionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_GrantDisbursementRequestAction_FK_DisbursementRequestStepId",
                table: "GrantDisbursementRequestAction",
                column: "FK_DisbursementRequestStepId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantDisbursementRequestAction_FK_GrantDisbursementRequestID",
                table: "GrantDisbursementRequestAction",
                column: "FK_GrantDisbursementRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_GrantDisbursementRequestAction_FK_PaymentChannelId",
                table: "GrantDisbursementRequestAction",
                column: "FK_PaymentChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantGrantBeneficiary_GrantsGrantId",
                table: "GrantGrantBeneficiary",
                column: "GrantsGrantId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantLabor_LaborsLaborId",
                table: "GrantLabor",
                column: "LaborsLaborId");

            migrationBuilder.CreateIndex(
                name: "IX_Grants_GrantTypeId",
                table: "Grants",
                column: "GrantTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Grants_PaymentChannelId",
                table: "Grants",
                column: "PaymentChannelId");

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
                name: "IX_MedicalWelfareRequest_BeneficiaryTypeId",
                table: "MedicalWelfareRequest",
                column: "BeneficiaryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalWelfareRequest_FK_MedicalServiceProviderId",
                table: "MedicalWelfareRequest",
                column: "FK_MedicalServiceProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Memorandum_FK_RequestType",
                table: "Memorandum",
                column: "FK_RequestType");

            migrationBuilder.CreateIndex(
                name: "IX_Party_FK_PartyTypeID",
                table: "Party",
                column: "FK_PartyTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentChannel_Code",
                table: "PaymentChannel",
                column: "Code",
                unique: true,
                filter: "[IsDeleted] = 0");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentChannel_Text_IsDeleted",
                table: "PaymentChannel",
                columns: new[] { "Text", "IsDeleted" },
                unique: true,
                filter: "[IsDeleted] = 0");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentChannel_Text2_IsDeleted",
                table: "PaymentChannel",
                columns: new[] { "Text2", "IsDeleted" },
                unique: true,
                filter: "[Text2] IS NOT NULL AND [IsDeleted] = 0");

            migrationBuilder.CreateIndex(
                name: "IX_SocialWelfareRequest_FK_RelativeRelationshipId",
                table: "SocialWelfareRequest",
                column: "FK_RelativeRelationshipId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialWelfareRequest_FK_RequesterRelevanceId",
                table: "SocialWelfareRequest",
                column: "FK_RequesterRelevanceId");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareLocalAction_FK_WelfareLocalActionTypeID",
                table: "WelfareLocalAction",
                column: "FK_WelfareLocalActionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareLocalAction_FK_WelfareRequestID",
                table: "WelfareLocalAction",
                column: "FK_WelfareRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareLocalAction_FK_WorkflowReasonID",
                table: "WelfareLocalAction",
                column: "FK_WorkflowReasonID");

            migrationBuilder.CreateIndex(
                name: "IX_Request_FK_DirectorateID",
                table: "WelfareRequest",
                column: "FK_DirectorateID");

            migrationBuilder.CreateIndex(
                name: "IX_Request_FK_StatusID",
                table: "WelfareRequest",
                column: "FK_RequestStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Request_FK_WelfareTypeID",
                table: "WelfareRequest",
                column: "FK_WelfareTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareRequest_FK_DisbursementId",
                table: "WelfareRequest",
                column: "FK_DisbursementId");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareRequest_FK_LaborId",
                table: "WelfareRequest",
                column: "FK_LaborId");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareRequest_FK_MemorandumId",
                table: "WelfareRequest",
                column: "FK_MemorandumId");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareRequest_FK_ServiceDeliveryMethodId",
                table: "WelfareRequest",
                column: "FK_ServiceDeliveryMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareRequest_FK_WelfareRequestStatusID",
                table: "WelfareRequest",
                column: "FK_WelfareRequestStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareRequestAction_FK_ActionTypeID",
                table: "WelfareRequestAction",
                column: "FK_ActionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareRequestAction_FK_WelfareRequestID",
                table: "WelfareRequestAction",
                column: "FK_WelfareRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareRequestAction_FK_WelfareRequestStepId",
                table: "WelfareRequestAction",
                column: "FK_WelfareRequestStepId");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareRequestAction_FK_WorkflowReasonID",
                table: "WelfareRequestAction",
                column: "FK_WorkflowReasonID");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareRequestAttachment_FK_AttachmentTypeId",
                table: "WelfareRequestAttachment",
                column: "FK_AttachmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareRequestAttachment_FK_RequestId",
                table: "WelfareRequestAttachment",
                column: "FK_RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareType_FK_WelfareCategoryId",
                table: "WelfareType",
                column: "FK_WelfareCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareTypesAttachmentTypes_AttachmentTypeID",
                table: "WelfareTypesAttachmentTypes",
                column: "AttachmentTypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionTypeDisbursementRequestStep");

            migrationBuilder.DropTable(
                name: "ActionTypeWelfareRequestStep");

            migrationBuilder.DropTable(
                name: "Beneficiary");

            migrationBuilder.DropTable(
                name: "DisabilityWelfareRequest");

            migrationBuilder.DropTable(
                name: "DisbursementPaymentData");

            migrationBuilder.DropTable(
                name: "DisbursementRequestAction");

            migrationBuilder.DropTable(
                name: "DisbursementRequestStepConfiguration");

            migrationBuilder.DropTable(
                name: "GrantAction");

            migrationBuilder.DropTable(
                name: "GrantDisbursementRequestAction");

            migrationBuilder.DropTable(
                name: "GrantDisbursementRequestStepConfiguration");

            migrationBuilder.DropTable(
                name: "GrantGrantBeneficiary");

            migrationBuilder.DropTable(
                name: "GrantLabor");

            migrationBuilder.DropTable(
                name: "GrantsStepConfiguration");

            migrationBuilder.DropTable(
                name: "MedicalWelfareRequest");

            migrationBuilder.DropTable(
                name: "NotificationReceiverType");

            migrationBuilder.DropTable(
                name: "WelfareLocalAction");

            migrationBuilder.DropTable(
                name: "WelfareRequestAction");

            migrationBuilder.DropTable(
                name: "WelfareRequestAttachment");

            migrationBuilder.DropTable(
                name: "WelfareRequestStepConfiguration");

            migrationBuilder.DropTable(
                name: "WelfareTypesAttachmentTypes");

            migrationBuilder.DropTable(
                name: "RelativeRelationType");

            migrationBuilder.DropTable(
                name: "SocialWelfareRequest");

            migrationBuilder.DropTable(
                name: "GrantStep");

            migrationBuilder.DropTable(
                name: "DisbursementRequestStep");

            migrationBuilder.DropTable(
                name: "GrantDisbursementRequest");

            migrationBuilder.DropTable(
                name: "GrantBeneficiaries");

            migrationBuilder.DropTable(
                name: "BeneficiaryType");

            migrationBuilder.DropTable(
                name: "MedicalServiceProvider");

            migrationBuilder.DropTable(
                name: "WelfareLocalActionType");

            migrationBuilder.DropTable(
                name: "ActionType");

            migrationBuilder.DropTable(
                name: "WelfareRequestStep");

            migrationBuilder.DropTable(
                name: "WorkflowReason");

            migrationBuilder.DropTable(
                name: "AttachmentType");

            migrationBuilder.DropTable(
                name: "RelativeRelationship");

            migrationBuilder.DropTable(
                name: "RequesterRelevance");

            migrationBuilder.DropTable(
                name: "WelfareRequest");

            migrationBuilder.DropTable(
                name: "Grants");

            migrationBuilder.DropTable(
                name: "DisbursementRequest");

            migrationBuilder.DropTable(
                name: "Labor");

            migrationBuilder.DropTable(
                name: "Memorandum");

            migrationBuilder.DropTable(
                name: "RequestStatus");

            migrationBuilder.DropTable(
                name: "ServiceDeliveryMethod");

            migrationBuilder.DropTable(
                name: "WelfareRequestStatus");

            migrationBuilder.DropTable(
                name: "WelfareType");

            migrationBuilder.DropTable(
                name: "GrantType");

            migrationBuilder.DropTable(
                name: "PaymentChannel");

            migrationBuilder.DropTable(
                name: "BusinessNature");

            migrationBuilder.DropTable(
                name: "Directorate");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "Occupation");

            migrationBuilder.DropTable(
                name: "Party");

            migrationBuilder.DropTable(
                name: "RequestType");

            migrationBuilder.DropTable(
                name: "WelfareCategory");

            migrationBuilder.DropTable(
                name: "PartyType");
        }
    }
}
