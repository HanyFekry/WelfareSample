namespace S3.MoL.WelfareManagement.Domain.Entities;
public class ActionType
{
    public int ActionTypeId { get; set; }

    public string Code { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string? Text2 { get; set; }

    public ICollection<BatchRequestAction> BatchRequestActions { get; set; } = new List<BatchRequestAction>();

    public ICollection<WelfareRequestAction> WelfareRequestActions { get; set; } = new List<WelfareRequestAction>();
    public ICollection<BatchRequestStep>? BatchRequestSteps { get; set; } = new List<BatchRequestStep>();
    public ICollection<WelfareRequestStep>? WelfareRequestSteps { get; set; } = new List<WelfareRequestStep>();
}

