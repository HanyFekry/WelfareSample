namespace S3.MoL.WelfareManagement.Domain.Entities;
public class WelfareRequestStep
{
    public int WelfareRequestStepId { get; set; }

    public string Text { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string? Text2 { get; set; }

    public ICollection<WelfareRequestAction> WelfareRequestActions { get; set; } = new List<WelfareRequestAction>();
    //List of actions related to this step
    public ICollection<ActionType> ActionTypes { get; set; } = new List<ActionType>();
}

