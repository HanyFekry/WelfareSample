using S3.MoL.WelfareManagement.Domain.Enums;

namespace S3.MoL.WelfareManagement.Domain.Entities
{
    public sealed class StepConfiguration
    {
        public string Role { get; set; } = null!;
        public ActionTypes ActionTypeID { get; set; }
    }
}
