using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WelfareDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RequestWorkflow : Migration
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
                    AttachmentEntityType = table.Column<int>(type: "int", nullable: false, comment: "Enum value(WelfareRequest,Memo,Batch)"),
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
                name: "BatchRequest",
                columns: table => new
                {
                    BatchRequestId = table.Column<int>(type: "int", nullable: false),
                    BatchNo = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date and time when the request record was last updated"),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "User name of the user who last updated the request record"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the request was created"),
                    CreatedByUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, comment: "User ID of the user who created the request record"),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "User name of the user who created the request record"),
                    UpdatedUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, comment: "User ID of the user who last updated the request record")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchRequest", x => x.BatchRequestId);
                });

            migrationBuilder.CreateTable(
                name: "BatchRequestStep",
                columns: table => new
                {
                    BatchRequestStepId = table.Column<int>(type: "int", nullable: false),
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Arabic text description of the request step"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code representing the request step"),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "English text description of the request step")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchRequestStep", x => x.BatchRequestStepId);
                });

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
                    Text2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Arabic text description of the request type"),
                    IsMemorandum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestType", x => x.RequestTypeID);
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
                    WorkflowType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowReason", x => x.WorkflowReasonId);
                });

            migrationBuilder.CreateTable(
                name: "BatchRequestAttachment",
                columns: table => new
                {
                    BatchAttachmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_BatchId = table.Column<int>(type: "int", nullable: false),
                    FK_AttachmentTypeId = table.Column<int>(type: "int", nullable: false),
                    AttachmentPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchRequestAttachment", x => x.BatchAttachmentId);
                    table.ForeignKey(
                        name: "FK_BatchRequestAttachment_AttachmentType_FK_AttachmentTypeId",
                        column: x => x.FK_AttachmentTypeId,
                        principalTable: "AttachmentType",
                        principalColumn: "AttachmentTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BatchRequestAttachment_BatchRequest_FK_BatchId",
                        column: x => x.FK_BatchId,
                        principalTable: "BatchRequest",
                        principalColumn: "BatchRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActionTypeBatchRequestStep",
                columns: table => new
                {
                    ActionTypesActionTypeId = table.Column<int>(type: "int", nullable: false),
                    BatchRequestStepsBatchRequestStepId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionTypeBatchRequestStep", x => new { x.ActionTypesActionTypeId, x.BatchRequestStepsBatchRequestStepId });
                    table.ForeignKey(
                        name: "FK_ActionTypeBatchRequestStep_ActionType_ActionTypesActionTypeId",
                        column: x => x.ActionTypesActionTypeId,
                        principalTable: "ActionType",
                        principalColumn: "ActionTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActionTypeBatchRequestStep_BatchRequestStep_BatchRequestStepsBatchRequestStepId",
                        column: x => x.BatchRequestStepsBatchRequestStepId,
                        principalTable: "BatchRequestStep",
                        principalColumn: "BatchRequestStepId",
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
                    BeneficiaryNId = table.Column<int>(type: "int", nullable: true),
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
                name: "Memorandum",
                columns: table => new
                {
                    MemorandumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    FK_RequestType = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "User name of the user who last updated the request record"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the request was created"),
                    CreatedByUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, comment: "User ID of the user who created the request record"),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "User name of the user who created the request record"),
                    UpdatedUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, comment: "User ID of the user who last updated the request record"),
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
                name: "BatchRequestAction",
                columns: table => new
                {
                    BatchRequestActionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_WorkflowReasonID = table.Column<int>(type: "int", nullable: true, comment: "Reason for workflow action, if applicable"),
                    FK_BatchRequestID = table.Column<int>(type: "int", nullable: false, comment: "Parent request identifier"),
                    FK_BatchRequestStepId = table.Column<int>(type: "int", nullable: false, comment: "Current step in workflow for the action"),
                    FK_ActionTypeID = table.Column<int>(type: "int", nullable: false, comment: "Type of action performed"),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "User name of the user who created the request record"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the request was created"),
                    CreatedByUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, comment: "User ID of the user who created the request record")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchRequestAction", x => x.BatchRequestActionId);
                    table.ForeignKey(
                        name: "FK_BatchRequestAction_ActionType_FK_ActionTypeID",
                        column: x => x.FK_ActionTypeID,
                        principalTable: "ActionType",
                        principalColumn: "ActionTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BatchRequestAction_BatchRequestStep_FK_BatchRequestStepId",
                        column: x => x.FK_BatchRequestStepId,
                        principalTable: "BatchRequestStep",
                        principalColumn: "BatchRequestStepId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BatchRequestAction_BatchRequest_FK_BatchRequestID",
                        column: x => x.FK_BatchRequestID,
                        principalTable: "BatchRequest",
                        principalColumn: "BatchRequestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BatchRequestAction_WorkflowReason_FK_WorkflowReasonID",
                        column: x => x.FK_WorkflowReasonID,
                        principalTable: "WorkflowReason",
                        principalColumn: "WorkflowReasonId");
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
                name: "MemorandumAttachments",
                columns: table => new
                {
                    MemorandumAttachmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_MemorandumId = table.Column<int>(type: "int", nullable: false),
                    AttachmentPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FK_AttachmentTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemorandumAttachments", x => x.MemorandumAttachmentId);
                    table.ForeignKey(
                        name: "FK_MemorandumAttachments_AttachmentType_FK_AttachmentTypeId",
                        column: x => x.FK_AttachmentTypeId,
                        principalTable: "AttachmentType",
                        principalColumn: "AttachmentTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemorandumAttachments_Memorandum_FK_MemorandumId",
                        column: x => x.FK_MemorandumId,
                        principalTable: "Memorandum",
                        principalColumn: "MemorandumId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WelfareRequest",
                columns: table => new
                {
                    WelfareRequestId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNo = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    FK_LaborId = table.Column<int>(type: "int", nullable: false),
                    FK_DirectorateID = table.Column<int>(type: "int", nullable: false, comment: "Identifier for the directorate associated with the request"),
                    FK_WelfareTypeID = table.Column<int>(type: "int", nullable: false, comment: "Identifier for the type of request"),
                    FK_RequestStatusID = table.Column<int>(type: "int", nullable: false, comment: "Identifier for the current status of a current workflow"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time when the request was created"),
                    CreatedByUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, comment: "User ID of the user who created the request record"),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "User name of the user who created the request record"),
                    UpdatedUserId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, comment: "User ID of the user who last updated the request record"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date and time when the request record was last updated"),
                    UpdatedUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "User name of the user who last updated the request record"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false, comment: "Timestamp for version control of the request record"),
                    DueAmount = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    LaborMobileNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    FK_MemorandumId = table.Column<int>(type: "int", nullable: true),
                    FK_BatchId = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelfareRequest", x => x.WelfareRequestId);
                    table.ForeignKey(
                        name: "FK_WelfareRequest_BatchRequest_FK_BatchId",
                        column: x => x.FK_BatchId,
                        principalTable: "BatchRequest",
                        principalColumn: "BatchRequestId");
                    table.ForeignKey(
                        name: "FK_WelfareRequest_Directorate_FK_DirectorateID",
                        column: x => x.FK_DirectorateID,
                        principalTable: "Directorate",
                        principalColumn: "DirectorateID",
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
                        name: "FK_WelfareRequest_WelfareType_FK_WelfareTypeID",
                        column: x => x.FK_WelfareTypeID,
                        principalTable: "WelfareType",
                        principalColumn: "WelfareTypeID",
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
                name: "DisabilityWelfareRequest",
                columns: table => new
                {
                    WelfareRequestId = table.Column<long>(type: "bigint", nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisabilityRatio = table.Column<decimal>(type: "decimal(2,0)", nullable: true)
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
                name: "SocialWelfareRequest",
                columns: table => new
                {
                    WelfareRequestId = table.Column<long>(type: "bigint", nullable: false),
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
                        principalColumn: "WelfareRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionTypeBatchRequestStep_BatchRequestStepsBatchRequestStepId",
                table: "ActionTypeBatchRequestStep",
                column: "BatchRequestStepsBatchRequestStepId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionTypeWelfareRequestStep_WelfareRequestStepsWelfareRequestStepId",
                table: "ActionTypeWelfareRequestStep",
                column: "WelfareRequestStepsWelfareRequestStepId");

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentType_FK_WelfareTypeID",
                table: "AttachmentType",
                column: "AttachmentEntityType");

            migrationBuilder.CreateIndex(
                name: "IX_BatchRequestAction_FK_ActionTypeID",
                table: "BatchRequestAction",
                column: "FK_ActionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_BatchRequestAction_FK_BatchRequestID",
                table: "BatchRequestAction",
                column: "FK_BatchRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_BatchRequestAction_FK_BatchRequestStepId",
                table: "BatchRequestAction",
                column: "FK_BatchRequestStepId");

            migrationBuilder.CreateIndex(
                name: "IX_BatchRequestAction_FK_WorkflowReasonID",
                table: "BatchRequestAction",
                column: "FK_WorkflowReasonID");

            migrationBuilder.CreateIndex(
                name: "IX_BatchRequestAttachment_FK_AttachmentTypeId",
                table: "BatchRequestAttachment",
                column: "FK_AttachmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BatchRequestAttachment_FK_BatchId",
                table: "BatchRequestAttachment",
                column: "FK_BatchId");

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
                name: "IX_Memorandum_FK_RequestType",
                table: "Memorandum",
                column: "FK_RequestType");

            migrationBuilder.CreateIndex(
                name: "IX_MemorandumAttachments_FK_AttachmentTypeId",
                table: "MemorandumAttachments",
                column: "FK_AttachmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MemorandumAttachments_FK_MemorandumId",
                table: "MemorandumAttachments",
                column: "FK_MemorandumId");

            migrationBuilder.CreateIndex(
                name: "IX_Party_FK_PartyTypeID",
                table: "Party",
                column: "FK_PartyTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SocialWelfareRequest_FK_RelativeRelationshipId",
                table: "SocialWelfareRequest",
                column: "FK_RelativeRelationshipId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialWelfareRequest_FK_RequesterRelevanceId",
                table: "SocialWelfareRequest",
                column: "FK_RequesterRelevanceId");

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
                name: "IX_WelfareRequest_FK_BatchId",
                table: "WelfareRequest",
                column: "FK_BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareRequest_FK_MemorandumId",
                table: "WelfareRequest",
                column: "FK_MemorandumId");

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
                name: "IX_RequestAttachments_FK_AttachmentTypeId",
                table: "WelfareRequestAttachment",
                column: "FK_AttachmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestAttachments_FK_RequestId",
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
                name: "ActionTypeBatchRequestStep");

            migrationBuilder.DropTable(
                name: "ActionTypeWelfareRequestStep");

            migrationBuilder.DropTable(
                name: "BatchRequestAction");

            migrationBuilder.DropTable(
                name: "BatchRequestAttachment");

            migrationBuilder.DropTable(
                name: "Beneficiary");

            migrationBuilder.DropTable(
                name: "DisabilityWelfareRequest");

            migrationBuilder.DropTable(
                name: "Labor");

            migrationBuilder.DropTable(
                name: "MedicalWelfareRequest");

            migrationBuilder.DropTable(
                name: "MemorandumAttachments");

            migrationBuilder.DropTable(
                name: "NotificationReceiverType");

            migrationBuilder.DropTable(
                name: "WelfareRequestAction");

            migrationBuilder.DropTable(
                name: "WelfareRequestAttachment");

            migrationBuilder.DropTable(
                name: "WelfareTypesAttachmentTypes");

            migrationBuilder.DropTable(
                name: "BatchRequestStep");

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
                name: "PartyType");

            migrationBuilder.DropTable(
                name: "BatchRequest");

            migrationBuilder.DropTable(
                name: "Directorate");

            migrationBuilder.DropTable(
                name: "Memorandum");

            migrationBuilder.DropTable(
                name: "RequestStatus");

            migrationBuilder.DropTable(
                name: "WelfareType");

            migrationBuilder.DropTable(
                name: "RequestType");

            migrationBuilder.DropTable(
                name: "WelfareCategory");
        }
    }
}
