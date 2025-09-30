using S3.MoL.WelfareManagement.Domain.Enums;

namespace S3.MoL.WelfareManagement.Domain.Entities;
public class WelfareRequest : ITrackCreatedEntityEx, ITrackUpdatedEntityEx
{
    public long WelfareRequestId { get; set; }
    public long RequestUUID { get; set; }

    public string RequestNo { get; set; } = null!;

    public long LaborId { get; set; }

    /// <summary>
    /// Identifier for the directorate associated with the request
    /// </summary>
    public int DirectorateId { get; set; }

    /// <summary>
    /// Identifier for the type of request
    /// </summary>
    public int WelfareTypeId { get; set; }

    /// <summary>
    /// Identifier for the current status of a current workflow
    /// </summary>
    public int RequestStatusId { get; set; }

    /// <summary>
    /// Identifier for the current status of the welfare request
    /// </summary>
    public WelfareRequestStatuses WelfareRequestStatusId { get; set; }

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

    public decimal? DueAmount { get; set; }

    public string? LaborMobileNo { get; set; }

    public int? MemorandumId { get; set; }

    public int? DisbursementId { get; set; }
    public int? LastWelfareRequestStepId { get; set; }
    public string? Notes { get; set; }
    public bool? IsEligible { get; set; }
    public string? AssignedToUserId { get; set; }
    public string? AssignedToUserName { get; set; }
    public string? EligibilityReason { get; set; }
    public string? AssignedUserRole { get; set; }
    public bool IsSystemCancelled { get; set; }
    public ServiceDeliveryMethods? ServiceDeliveryMethodId { get; set; }

    public ServiceDeliveryMethod? ServiceDeliveryMethod { get; set; }
    public Labor Labor { get; set; } = default!;
    public DisbursementRequest? DisbursementRequest { get; set; }

    public Directorate Directorate { get; set; } = null!;

    public Memorandum? Memorandum { get; set; }

    public RequestStatus RequestStatus { get; set; } = null!;

    public WelfareRequestStatus WelfareRequestStatus { get; set; } = default!;

    public WelfareType WelfareType { get; set; } = null!;
    public ICollection<StepConfiguration>? StepConfigurations { get; set; }

    public ICollection<WelfareRequestAction>? WelfareRequestActions { get; set; } = new List<WelfareRequestAction>();

    public ICollection<WelfareRequestAttachment>? WelfareRequestAttachments { get; set; } = new List<WelfareRequestAttachment>();

    public ICollection<WelfareLocalAction> WelfareLocalActions { get; set; } = new List<WelfareLocalAction>();
}

