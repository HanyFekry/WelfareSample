using S3.MoL.WelfareManagement.Domain.Enums;

namespace S3.MoL.WelfareManagement.Domain.Entities
{
    public class DisbursementPaymentData
    {
        public long DisbursementPaymentDataId { get; set; }
        public long WelfareRequestId { get; set; }
        public int DisbursementRequestId { get; set; }
        public WelfareRequestStatuses WelfareRequestStatusId { get; set; }
        public WelfareTypes WelfareTypeId { get; set; }
        public string BeneficiaryNationalId { get; set; } = default!;
    }
}
