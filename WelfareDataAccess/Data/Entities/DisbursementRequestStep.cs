using S3.MoL.WelfareManagement.Domain.Enums;

namespace S3.MoL.WelfareManagement.Domain.Entities;
public class DisbursementRequestStep
{
    public DisbursementRequestSteps DisbursementRequestStepId { get; set; }

    /// <summary>
    /// Arabic text description of the request step
    /// </summary>
    public string? Text2 { get; set; }

    /// <summary>
    /// Code representing the request step
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// English text description of the request step
    /// </summary>
    public string Text { get; set; } = null!;

    public ICollection<DisbursementRequestAction> DisbursementRequestActions { get; set; } = new List<DisbursementRequestAction>();
    //List of actions related to this step
    public ICollection<ActionType> ActionTypes { get; set; } = new List<ActionType>();
    public ICollection<GrantDisbursementRequestAction>? GrantDisbursementRequestActions { get; set; }
}

