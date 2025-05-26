namespace S3.MoL.WelfareManagement.Domain.Entities;
public class BatchRequestAction
{
    public long BatchRequestActionId { get; set; }

    /// <summary>
    /// Reason for workflow action, if applicable
    /// </summary>
    public int? WorkflowReasonId { get; set; }

    /// <summary>
    /// Parent request identifier
    /// </summary>
    public int BatchRequestId { get; set; }

    /// <summary>
    /// Current step in workflow for the action
    /// </summary>
    public int BatchRequestStepId { get; set; }

    /// <summary>
    /// Type of action performed
    /// </summary>
    public int ActionTypeId { get; set; }

    /// <summary>
    /// User name of the user who created the request record
    /// </summary>
    public string CreatedByUserName { get; set; } = null!;

    /// <summary>
    /// Date and time when the request was created
    /// </summary>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// User ID of the user who created the request record
    /// </summary>
    public string CreatedByUserId { get; set; } = null!;

    public ActionType ActionType { get; set; } = null!;

    public BatchRequest BatchRequest { get; set; } = null!;

    public BatchRequestStep BatchRequestStep { get; set; } = null!;

    public WorkflowReason? WorkflowReason { get; set; }
}

