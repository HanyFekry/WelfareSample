using S3.MoL.WelfareManagement.Domain.Enums;

namespace S3.MoL.WelfareManagement.Domain.Entities;
public class ServiceDeliveryMethod
{
    public ServiceDeliveryMethods ServiceDeliveryMethodId { get; set; }

    public string Code { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string? Text2 { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public ICollection<WelfareRequest> WelfareRequests { get; set; } = new List<WelfareRequest>();
    public int ExpirationDurationInDays { get; set; }

    //public ICollection<MedicalWelfareRequest> MedicalWelfareRequests { get; set; } = new List<MedicalWelfareRequest>();

    //public ICollection<SocialWelfareRequest> SocialWelfareRequests { get; set; } = new List<SocialWelfareRequest>();
}

