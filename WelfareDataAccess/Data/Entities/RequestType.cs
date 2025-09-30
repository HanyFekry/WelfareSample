namespace S3.MoL.WelfareManagement.Domain.Entities;
public class RequestType
{
    /// <summary>
    /// Unique identifier for each request type
    /// </summary>
    public int RequestTypeId { get; set; }

    /// <summary>
    /// Code representing the request type
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// English text description of the request type
    /// </summary>
    public string Text { get; set; } = null!;

    /// <summary>
    /// Arabic text description of the request type
    /// </summary>
    public string? Text2 { get; set; }

    public bool IsMemorandum { get; set; }

    public ICollection<Memorandum> Memoranda { get; set; } = new List<Memorandum>();
}

