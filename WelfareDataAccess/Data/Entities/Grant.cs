using S3.MoL.WelfareManagement.Domain.Enums;
using S3.MoL.WelfareManagement.Domain.Interfaces;

namespace S3.MoL.WelfareManagement.Domain.Entities
{
    public class Grant : ITrackCreatedEntityEx, ITrackUpdatedEntityEx, ISoftDelete
    {
        public long GrantId { get; set; }
        public long RequestUUId { get; set; }
        public int RequestStatusId { get; set; }
        public GrantStatuses GrantStatusId { get; set; }
        public int? GrantTypeId { get; set; }
        public GrantCategories GrantCategoryId { get; set; }
        public string GrantNo { get; set; } = default!;
        public string? Description { get; set; }
        public decimal DueAmount { get; set; }
        public DateOnly? InitiateDate { get; set; }
        public DateOnly DueDate { get; set; }
        public string? AttachmentPath { get; set; }
        public GrantSteps? LastGrantStepId { get; set; }
        public int TotalBeneficiariesNumber { get; set; }
        public bool IsRegistered { get; set; }
        public int? PaymentChannelId { get; set; }
        //public string? DisbursementFilePath { get; set; }
        //public DateOnly DisbursementDate { get; set; }
        public string? TransferNotes { get; set; }
        /// <summary>
        /// Identifier for the directorate associated with the request
        /// </summary>
        public int DirectorateId { get; set; }


        /// Date and time when the request was created
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// User ID of the user who created the request record
        /// </summary>
        public string CreatedByUserId { get; set; } = null!;

        /// <summary>
        /// User name of the user who created the request record
        /// </summary>
        public string CreatedByUserName { get; set; } = null!;

        /// <summary>
        /// User ID of the user who last updated the request record
        /// </summary>
        public string? UpdatedUserId { get; set; }

        /// <summary>
        /// Date and time when the request record was last updated
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// User name of the user who last updated the request record
        /// </summary>
        public string? UpdatedUserName { get; set; }

        /// <summary>
        /// Timestamp for version control of the request record
        /// </summary>
        public byte[] Version { get; set; } = null!;


        public Directorate Directorate { get; set; } = null!;
        public ICollection<GrantAction>? GrantActions { get; set; }
        public ICollection<Labor>? Labors { get; set; }
        public ICollection<GrantBeneficiary>? GrantBeneficiaries { get; set; }
        public ICollection<StepConfiguration>? StepConfigurations { get; set; }
        public PaymentChannel? PaymentChannel { get; set; }
        public GrantType? GrantType { get; set; }
        public bool IsDeleted { get; set; } = false;
        public GrantDisbursementRequest? GrantDisbursementRequest { get; set; }
    }
}
