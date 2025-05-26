

namespace S3.MoL.WelfareManagement.Domain.Entities;
public class BatchRequest : ITrackCreatedEntityEx, ITrackUpdatedEntityEx
{
    public int BatchRequestId { get; set; }

    public string BatchNo { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? Notes { get; set; }

    public decimal? TotalAmount { get; set; }

    /// <summary>
    /// Date and time when the request record was last updated
    /// </summary>
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    /// User name of the user who last updated the request record
    /// </summary>
    public string? UpdatedUserName { get; set; }

    /// <summary>
    /// Date and time when the request was created
    /// </summary>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// User ID of the user who created the request record
    /// </summary>
    public string CreatedByUserId { get; set; } = null!;

    /// <summary>
    /// User name of the user who created the request record
    /// </summary>
    public string CreatedByUserName { get; set; } = null!;

    /// <summary>
    /// User ID of the user who last updated the request record
    /// </summary>
    public string? UpdatedUserId { get; set; }

    public ICollection<BatchRequestAction> BatchRequestActions { get; set; } = new List<BatchRequestAction>();

    public ICollection<BatchRequestAttachment> BatchRequestAttachments { get; set; } = new List<BatchRequestAttachment>();

    public ICollection<WelfareRequest> WelfareRequests { get; set; } = new List<WelfareRequest>();
}

