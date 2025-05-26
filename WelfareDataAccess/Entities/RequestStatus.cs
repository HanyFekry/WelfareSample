namespace S3.MoL.WelfareManagement.Domain.Entities;
public class RequestStatus
{
    /// <summary>
    /// Unique identifier for each request status record
    /// </summary>
    public int RequestStatusId { get; set; }

    /// <summary>
    /// Code representing the request status
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// English text description of the request status
    /// </summary>
    public string Text { get; set; } = null!;

    /// <summary>
    /// Arabic text description of the request status
    /// </summary>
    public string? Text2 { get; set; }

    public ICollection<WelfareRequest> WelfareRequests { get; set; } = new List<WelfareRequest>();
}

