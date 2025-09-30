namespace S3.MoL.WelfareManagement.Domain.Entities;
public class RelativeRelationType
{
    public int RelativeRelationTypeId { get; set; }

    public string Code { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string? Text2 { get; set; }

    public ICollection<Beneficiary> Beneficiaries { get; set; } = new List<Beneficiary>();
}

