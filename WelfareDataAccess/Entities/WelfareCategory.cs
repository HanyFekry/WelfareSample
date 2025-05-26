namespace S3.MoL.WelfareManagement.Domain.Entities;
/// <summary>
/// Monetary or 
/// </summary>
public class WelfareCategory
{
    public byte WelfareCategoryId { get; set; }

    public string Code { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string? Text2 { get; set; }

    public ICollection<WelfareType> WelfareTypes { get; set; } = new List<WelfareType>();
}

