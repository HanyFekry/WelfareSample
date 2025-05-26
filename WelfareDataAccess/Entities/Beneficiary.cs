namespace S3.MoL.WelfareManagement.Domain.Entities;
public class Beneficiary
{
    /// <summary>
    /// Unique identifier for Beneficiary
    /// </summary>
    public long BeneficiaryId { get; set; }

    /// <summary>
    /// Unique identifier for labor associated with request
    /// </summary>
    public long? LaborId { get; set; }

    /// <summary>
    /// Identifier of social request if applicable
    /// </summary>
    public long SocialWelfareRequestId { get; set; }

    /// <summary>
    /// Beneficiary name
    /// </summary>
    public string BeneficiaryName { get; set; } = null!;

    /// <summary>
    /// National identification number of the labor
    /// </summary>
    public string NationalId { get; set; } = null!;

    /// <summary>
    /// Relationship to dead employee
    /// </summary>
    public int RelativeRelationTypeId { get; set; }

    public string? Iban { get; set; }

    /// <summary>
    /// Amount to be disbursed for beneficiary
    /// </summary>
    public decimal Amount { get; set; }

    public RelativeRelationType RelativeRelationType { get; set; } = null!;

    public SocialWelfareRequest SocialWelfareRequest { get; set; } = null!;
}

