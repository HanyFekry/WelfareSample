using S3.MoL.WelfareManagement.Domain.Enums;

namespace S3.MoL.WelfareManagement.Domain.Entities;
public class WelfareRequestStatus
{
    /// <summary>
    /// Unique identifier for each request status record
    /// </summary>
    public WelfareRequestStatuses WelfareRequestStatusId { get; set; }

    /// <summary>
    /// Code representing the welfare request status
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// English text description of the welfare request status
    /// </summary>
    public string Text { get; set; } = null!;

    /// <summary>
    /// Arabic text description of the welfare request status
    /// </summary>
    public string? Text2 { get; set; }

    public ICollection<WelfareRequest> WelfareRequests { get; set; } = new List<WelfareRequest>();
}

