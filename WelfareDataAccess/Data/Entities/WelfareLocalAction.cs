using S3.MoL.WelfareManagement.Domain.Enums;

namespace S3.MoL.WelfareManagement.Domain.Entities;
public class WelfareLocalAction
{
    public long WelfareLocalActionId { get; set; }
    /// <summary>
    /// User ID of the user who created the request record
    /// </summary>
    public string CreatedByUserId { get; set; } = null!;


    /// <summary>
    /// Reason for workflow action, if applicable
    /// </summary>
    public int? WorkflowReasonId { get; set; }

    /// <summary>
    /// Parent request identifier
    /// </summary>
    public long WelfareRequestId { get; set; }

    /// <summary>
    /// Type of action performed
    /// </summary>
    public WelfareLocalActionTypes WelfareLocalActionTypeId { get; set; }

    public string? Notes { get; set; } = default!;

    public string? AttachmentPath { get; set; } = default!;

    /// <summary>
    /// User name of the user who created the request record
    /// </summary>
    public string CreatedByUserName { get; set; } = null!;

    /// <summary>
    /// Date and time when the request was created
    /// </summary>
    public DateTime CreatedDate { get; set; }

    public WelfareLocalActionType WelfareLocalActionType { get; set; } = null!;

    public WelfareRequest WelfareRequest { get; set; } = null!;

    public WorkflowReason? WorkflowReason { get; set; }
}

