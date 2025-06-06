﻿namespace S3.MoL.WelfareManagement.Domain.Entities;
public class WelfareType
{
    /// <summary>
    /// Unique identifier for each Welfare type
    /// </summary>
    public int WelfareTypeId { get; set; }

    /// <summary>
    /// Code representing the Welfare type
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// English text description of the Welfare type
    /// </summary>
    public string Text { get; set; } = null!;

    /// <summary>
    /// Arabic text description of the Welfare type
    /// </summary>
    public string? Text2 { get; set; }

    public byte WelfareCategoryId { get; set; }

    public decimal? WelfareAmount { get; set; }

    public byte? MaximumLimit { get; set; }

    public WelfareCategory WelfareCategory { get; set; } = null!;

    public ICollection<WelfareRequest> WelfareRequests { get; set; } = new List<WelfareRequest>();

    public ICollection<AttachmentType> AttachmentTypes { get; set; } = new List<AttachmentType>();
}

