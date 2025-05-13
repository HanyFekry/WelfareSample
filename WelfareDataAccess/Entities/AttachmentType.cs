using System;
using System.Collections.Generic;

namespace WelfareDataAccess.Entities;
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
    /// Foreign key to the LaborCareType table
    /// </summary>
    public int WelfareTypeId { get; set; }

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

    public WelfareType WelfareType { get; set; } = null!;

    public ICollection<RequestAttachment> RequestAttachments { get; set; } = new List<RequestAttachment>();
}

