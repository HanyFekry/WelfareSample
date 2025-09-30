namespace S3.MoL.WelfareManagement.Domain.Entities;
/// <summary>
/// Table storing business natures
/// </summary>
public class BusinessNature
{
    /// <summary>
    /// Unique identifier for the business nature
    /// </summary>
    public int BusinessNatureId { get; set; }

    /// <summary>
    /// Code representing the business nature
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// English text description of the business nature
    /// </summary>
    public string Text { get; set; } = null!;

    /// <summary>
    /// Arabic text description of the business nature
    /// </summary>
    public string Text2 { get; set; } = null!;

    /// <summary>
    /// Indicates if the business nature is deleted
    /// </summary>
    public bool IsDeleted { get; set; }

    /// <summary>
    /// Indicates if the business nature is active
    /// </summary>
    public bool IsActive { get; set; }

    public ICollection<Labor> Labors { get; set; } = new List<Labor>();
}

