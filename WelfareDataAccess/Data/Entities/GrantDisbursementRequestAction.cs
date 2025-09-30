using S3.MoL.WelfareManagement.Domain.Enums;

namespace S3.MoL.WelfareManagement.Domain.Entities;
public class GrantDisbursementRequestAction
{
    public long DisbursementRequestActionId { get; set; }

    /// <summary>
    /// Reason for workflow action, if applicable
    /// </summary>
    public int? PaymentChannelId { get; set; }

    /// <summary>
    /// Parent request identifier
    /// </summary>
    public int GrantDisbursementRequestId { get; set; }

    /// <summary>
    /// Current step in workflow for the action
    /// </summary>
    public DisbursementRequestSteps DisbursementRequestStepId { get; set; }

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

    public string? Notes { get; set; } = default!;
    public string? TransactionInfo { get; set; }
    public DateTime? DisbursementDate { get; set; }


    public ActionType ActionType { get; set; } = null!;

    public DisbursementRequestStep DisbursementRequestStep { get; set; } = null!;

    public PaymentChannel? PaymentChannel { get; set; }
    public GrantDisbursementRequest GrantDisbursementRequest { get; set; } = default!;
}

