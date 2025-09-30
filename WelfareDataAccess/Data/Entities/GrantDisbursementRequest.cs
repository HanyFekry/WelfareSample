
namespace S3.MoL.WelfareManagement.Domain.Entities;
public class GrantDisbursementRequest : ITrackCreatedEntityEx, ITrackUpdatedEntityEx
{
    public int GrantDisbursementRequestId { get; set; }

    public string DisbursementNo { get; set; } = null!;
    public long RequestUUID { get; set; }

    public string Title { get; set; } = null!;

    public string? Notes { get; set; }

    public decimal? TotalAmount { get; set; }
    /// <summary>
    /// Identifier for the current status of a current workflow
    /// </summary>
    public int RequestStatusId { get; set; }

    /// <summary>
    /// Date and time when the request record was last updated
    /// </summary>
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    /// User name of the user who last updated the request record
    /// </summary>
    public string? UpdatedUserName { get; set; }

    /// <summary>
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

    public string? DisbursementRequestAttachmentPath { get; set; } = default!;

    public string? DisbursementPaymentDataPath { get; set; } = default!;
    public long GrantId { get; set; }
    public bool IsDisbursed { get; set; }
    /// <summary>
    /// Identifier for the last step in the disbursement request workflow
    /// </summary>
    public int? LastDisbursementRequestStepId { get; set; }
    /// <summary>
    /// User ID of the user who last updated the request record
    /// </summary>
    public string? UpdatedUserId { get; set; }

    public ICollection<GrantDisbursementRequestAction>? DisbursementRequestActions { get; set; } = new List<GrantDisbursementRequestAction>();
    public ICollection<StepConfiguration>? StepConfigurations { get; set; }

    public Grant Grant { get; set; } = default!;
}

