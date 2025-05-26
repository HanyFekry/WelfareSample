namespace S3.MoL.WelfareManagement.Domain.Entities;
public class BatchRequestStep
{
    public int BatchRequestStepId { get; set; }

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

    public ICollection<BatchRequestAction> BatchRequestActions { get; set; } = new List<BatchRequestAction>();
    //List of actions related to this step
    public ICollection<ActionType> ActionTypes { get; set; } = new List<ActionType>();
}

