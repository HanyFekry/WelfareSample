using S3.MoL.WelfareManagement.Domain.Enums;

namespace S3.MoL.WelfareManagement.Domain.Entities
{
    public class WelfareLocalActionType
    {
        public WelfareLocalActionTypes WelfareLocalActionTypeId { get; set; }

        public string Code { get; set; } = null!;

        public string Text { get; set; } = null!;

        public string? Text2 { get; set; }


        public ICollection<WelfareLocalAction> WelfareLocalActions { get; set; } = new List<WelfareLocalAction>();
    }
}