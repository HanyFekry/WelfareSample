namespace S3.MoL.WelfareManagement.Domain.Entities;
public class SocialWelfareRequest : WelfareRequest
{

    public DateOnly EventDate { get; set; }

    public string NationalId { get; set; } = null!;

    public bool? IsTwin { get; set; }

    public string? RequesterName { get; set; }

    public int? RelativeRelationshipId { get; set; }

    public int? RequesterRelevanceId { get; set; }

    public ICollection<Beneficiary> Beneficiaries { get; set; } = new List<Beneficiary>();

    public RelativeRelationship? RelativeRelationship { get; set; }

    public RequesterRelevance? RequesterRelevance { get; set; }
}

