namespace S3.MoL.WelfareManagement.Domain.Entities;
public class MedicalWelfareRequest
{
    public long RequestId { get; set; }

    public int? MedicalServiceProviderId { get; set; }

    public string Description { get; set; } = null!;

    public int? BeneficiaryTypeId { get; set; }

    public string? BeneficiaryName { get; set; }

    public int? BeneficiaryNid { get; set; }

    public string? BeneficiaryIban { get; set; }

    public byte? NoOfPrescriptions { get; set; }

    public BeneficiaryType? BeneficiaryType { get; set; }

    public MedicalServiceProvider? MedicalServiceProvider { get; set; }
}

