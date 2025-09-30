namespace S3.MoL.WelfareManagement.Domain.Entities;
public class NotificationReceiverType
{
    /// <summary>
    /// A unique identifier for each notification receiver type.
    /// </summary>
    public int NotificationReceiverTypeId { get; set; }

    /// <summary>
    /// A unique code representing the notification receiver type.
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// The English description or name of the notification receiver type.
    /// </summary>
    public string Text { get; set; } = null!;

    /// <summary>
    /// An optional Arabic description or additional information for the notification receiver type.
    /// </summary>
    public string? Text2 { get; set; }
}

