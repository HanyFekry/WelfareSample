namespace S3.MoL.WelfareManagement.Domain.Entities;
public class DisabilityWelfareRequest : WelfareRequest
{
    public long RequestId { get; set; }

    public DateTime EventDate { get; set; }

    public decimal? DisabilityRatio { get; set; }
    public string? Description { get; set; }
}

