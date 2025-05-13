namespace WelfareDataAccess.Entities;
public class SocialWelfareRequest : Request
{
    //public long RequestId { get; set; }

    public DateTime EventDate { get; set; }

    public string NationalId { get; set; } = null!;

    public bool? IsTwin { get; set; }

    public string? RequesterName { get; set; }

    public int? RelativeRelationshipId { get; set; }

    public int? RequesterRelevanceId { get; set; }

    public ICollection<Beneficiary> Beneficiaries { get; set; } = new List<Beneficiary>();

    public RelativeRelationship? RelativeRelationship { get; set; }

    public RequesterRelevance? RequesterRelevance { get; set; }

    //public Request Request { get; set; } = null!;
}

