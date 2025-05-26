using S3.MoL.WelfareManagement.Domain.Enums;

namespace S3.MoL.WelfareManagement.Domain.Entities;
/// <summary>
/// Table storing attachment types
/// </summary>
public class AttachmentType
{
    /// <summary>
    /// Unique identifier for the attachment type
    /// </summary>
    public int AttachmentTypeId { get; set; }

    /// <summary>
    /// Enum value(WelfareRequest,Memo,Batch)
    /// </summary>
    public AttachmentEntityType AttachmentEntityType { get; set; }

    /// <summary>
    /// Code representing the attachment type
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// English text description of the attachment type
    /// </summary>
    public string Text { get; set; } = null!;

    /// <summary>
    /// Arabic text description of the attachment type
    /// </summary>
    public string? Text2 { get; set; }

    /// <summary>
    /// Limit on the size of the attachment
    /// </summary>
    public int? SizeLimit { get; set; }

    /// <summary>
    /// Allowed MIME types for the attachment
    /// </summary>
    public string MimeTypes { get; set; } = null!;

    /// <summary>
    /// Indicates if the attachment type is mandatory
    /// </summary>
    public bool Mandatory { get; set; }

    /// <summary>
    /// Number of files allowed for the attachment type
    /// </summary>
    public int MaxFileCount { get; set; }

    public ICollection<BatchRequestAttachment> BatchRequestAttachments { get; set; } = new List<BatchRequestAttachment>();

    public ICollection<MemorandumAttachment> MemorandumAttachments { get; set; } = new List<MemorandumAttachment>();

    public ICollection<WelfareRequestAttachment> WelfareRequestAttachments { get; set; } = new List<WelfareRequestAttachment>();

    public ICollection<WelfareType> WelfareTypes { get; set; } = new List<WelfareType>();
}

