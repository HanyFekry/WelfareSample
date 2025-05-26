namespace S3.MoL.WelfareManagement.Domain.Entities;
public class WorkflowReason
{
    public int WorkflowReasonId { get; set; }

    public string Code { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string? Text2 { get; set; }

    public string WorkflowType { get; set; } = null!;

    public ICollection<BatchRequestAction> BatchRequestActions { get; set; } = new List<BatchRequestAction>();

    public ICollection<WelfareRequestAction> WelfareRequestActions { get; set; } = new List<WelfareRequestAction>();
}

