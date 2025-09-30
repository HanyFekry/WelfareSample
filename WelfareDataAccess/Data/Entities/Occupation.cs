namespace S3.MoL.WelfareManagement.Domain.Entities;
public class Occupation
{
    /// <summary>
    /// Unique identifier for each occupation record
    /// </summary>
    public int OccupationId { get; set; }

    /// <summary>
    /// Code representing the occupation
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// English text description of the occupation
    /// </summary>
    public string Text { get; set; } = null!;

    /// <summary>
    /// Arabic text description of the occupation
    /// </summary>
    public string? Text2 { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public ICollection<Labor> Labors { get; set; } = new List<Labor>();
}

