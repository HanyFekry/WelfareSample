namespace S3.MoL.WelfareManagement.Domain.Entities
{
    public class GrantBeneficiary
    {
        public long GrantBeneficiaryId { get; set; }
        public string Name { get; set; } = default!;
        public string NationalId { get; set; } = default!;
        public string Occupation { get; set; }
        public string MobileNo { get; set; } = null!;
        public string Address { get; set; } = default!;
        public string IBan { get; set; } = null!;
        public string BankName { get; set; } = default!;
        public string BranchName { get; set; } = default!;
        public long? LaborId { get; set; }
        public ICollection<Grant>? Grants { get; set; }

    }
}
