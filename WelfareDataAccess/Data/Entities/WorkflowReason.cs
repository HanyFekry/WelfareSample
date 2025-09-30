using S3.MoL.WelfareManagement.Domain.Enums;

namespace S3.MoL.WelfareManagement.Domain.Entities;
public class WorkflowReason
{
    public int WorkflowReasonId { get; set; }

    public string Code { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string? Text2 { get; set; }

    public RequestTypes RequestType { get; set; }
    public bool IsDeleted { get; set; } = false;
    public bool IsActive { get; set; } = true;

    //public ICollection<DisbursementRequestAction> DisbursementRequestActions { get; set; } = new List<DisbursementRequestAction>();

    public ICollection<WelfareRequestAction> WelfareRequestActions { get; set; } = new List<WelfareRequestAction>();

    public ICollection<WelfareLocalAction> WelfareLocalActions { get; set; } = new List<WelfareLocalAction>();
    public ICollection<GrantAction> GrantActions { get; set; } = new List<GrantAction>();
}

