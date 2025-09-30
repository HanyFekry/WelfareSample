namespace S3.MoL.WelfareManagement.Domain.Entities;
public class ActionType
{
    public int ActionTypeId { get; set; }

    public string Code { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string? Text2 { get; set; }

    public ICollection<DisbursementRequestAction> DisbursementRequestActions { get; set; } = new List<DisbursementRequestAction>();

    public ICollection<WelfareRequestAction> WelfareRequestActions { get; set; } = new List<WelfareRequestAction>();
    public ICollection<DisbursementRequestStep>? DisbursementRequestSteps { get; set; } = new List<DisbursementRequestStep>();
    public ICollection<WelfareRequestStep>? WelfareRequestSteps { get; set; } = new List<WelfareRequestStep>();
    public ICollection<GrantAction>? GrantActions { get; set; }
    public ICollection<GrantDisbursementRequestAction>? GrantDisbursementRequestActions { get; set; }
}

