namespace S3.MoL.WelfareManagement.Domain.Entities;
public class Memorandum : ITrackCreatedEntityEx, ITrackUpdatedEntityEx
{
    public int MemorandumId { get; set; }

    public string Title { get; set; } = null!;

    public string? Notes { get; set; }
    public string MemorandumNo { get; set; } = default!;

    public int RequestType { get; set; }

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

    /// <summary>
    /// Date and time when the request record was last updated
    /// </summary>
    public DateTime? UpdatedDate { get; set; }

    public RequestType RequestTypeNavigation { get; set; } = null!;

    public ICollection<MemorandumAttachment> MemorandumAttachments { get; set; } = new List<MemorandumAttachment>();

    public ICollection<WelfareRequest> WelfareRequests { get; set; } = new List<WelfareRequest>();
}

