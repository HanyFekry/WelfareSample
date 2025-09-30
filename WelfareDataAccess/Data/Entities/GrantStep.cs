using S3.MoL.WelfareManagement.Domain.Enums;

namespace S3.MoL.WelfareManagement.Domain.Entities
{
    public class GrantStep
    {

        /// <summary>
        /// Unique identifier for each marital status record
        /// </summary>
        public GrantSteps GrantStepId { get; set; }

        /// <summary>
        /// Code representing the marital status
        /// </summary>
        public string Code { get; set; } = null!;

        /// <summary>
        /// English text description of the marital status
        /// </summary>
        public string Text { get; set; } = null!;

        /// <summary>
        /// Arabic text description of the marital status
        /// </summary>
        public string? Text2 { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }
        public ICollection<GrantAction>? GrantActions { get; set; }
    }
}
