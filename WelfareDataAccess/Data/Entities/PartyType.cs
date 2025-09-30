namespace S3.MoL.WelfareManagement.Domain.Entities;
public class PartyType
{
    public int PartyTypeId { get; set; }

    public string Code { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string? Text2 { get; set; }

    /// <summary>
    /// Indicates if the business nature is deleted
    /// </summary>
    public bool IsDeleted { get; set; }

    /// <summary>
    /// Indicates if the business nature is active
    /// </summary>
    public bool IsActive { get; set; }

    public ICollection<Party> Parties { get; set; } = new List<Party>();
}

