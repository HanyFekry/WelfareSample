namespace S3.MoL.WelfareManagement.Domain.Entities
{
    public sealed class PaymentChannel
    {
        public int PaymentChannelID { get; set; }
        public string Code { get; set; } = null!;
        public string Text { get; set; } = null!;
        public string? Text2 { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public string AccountNo { get; set; } = null!;
        public List<DisbursementRequestAction>? DisbursementRequestActions { get; set; }
        public List<Grant>? Grants { get; set; }
        public ICollection<GrantDisbursementRequestAction>? GrantDisbursementRequestActions { get; set; }
    }
}
