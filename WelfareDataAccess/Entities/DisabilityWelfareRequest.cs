namespace WelfareDataAccess.Entities;
public class DisabilityWelfareRequest : Request
{
    //public long RequestId { get; set; }

    public DateTime EventDate { get; set; }

    public decimal? DisabilityRatio { get; set; }

    //public Request Request { get; set; } = null!;
}

