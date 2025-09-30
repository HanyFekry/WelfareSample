using S3.MoL.WelfareManagement.Domain.Enums;

namespace S3.MoL.WelfareManagement.Domain.Entities;
public class GrantAction
{

    public long GrantActionId { get; set; }

    /// <summary>
    /// Reason for workflow action, if applicable
    /// </summary>
    public int? WorkflowReasonId { get; set; }

    /// <summary>
    /// Parent request identifier
    /// </summary>
    public long GrantId { get; set; }

    /// <summary>
    /// Current step in workflow for the action
    /// </summary>
    public GrantSteps GrantStepId { get; set; }

    /// <summary>
    /// Type of action performed
    /// </summary>
    public int ActionTypeId { get; set; }

    public string? Notes { get; set; } = default!;

    public string? AttachmentPath { get; set; } = default!;
    /// <summary>
    /// User ID of the user who created the request record
    /// </summary>
    public string CreatedByUserId { get; set; } = null!;

    /// <summary>
    /// User name of the user who created the request record
    /// </summary>
    public string CreatedByUserName { get; set; } = null!;

    /// <summary>
    /// Date and time when the request was created
    /// </summary>
    public DateTime CreatedDate { get; set; }

    public ActionType ActionType { get; set; } = null!;

    public Grant Grant { get; set; } = null!;

    public GrantStep GrantStep { get; set; } = null!;

    public WorkflowReason? WorkflowReason { get; set; }
}

