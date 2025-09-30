namespace S3.MoL.WelfareManagement.Domain.Entities;
public class BeneficiaryType
{
    public int BeneficiaryTypeId { get; set; }

    public string Code { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string? Text2 { get; set; }

    public ICollection<MedicalWelfareRequest> MedicalWelfareRequests { get; set; } = new List<MedicalWelfareRequest>();
}

