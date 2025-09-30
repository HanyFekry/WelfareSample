namespace S3.MoL.WelfareManagement.Domain.Entities;
public class MedicalWelfareRequest : WelfareRequest
{
    //public long WelfareRequestId { get; set; }

    public int? MedicalServiceProviderId { get; set; }

    public string? Description { get; set; }

    public byte? NoOfPrescriptions { get; set; }
    public DateOnly? EventDate { get; set; }
    public MedicalServiceProvider? MedicalServiceProvider { get; set; }
    public bool IsReviewed { get; set; }

}



