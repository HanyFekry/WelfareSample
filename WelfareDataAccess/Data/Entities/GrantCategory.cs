namespace S3.MoL.WelfareManagement.Domain.Entities
{
    public class GrantCategory
    {
        /// <summary>
        /// Unique identifier for the GrantCategory
        /// </summary>
        public int GrantCategoryId { get; set; }

        /// <summary>
        /// Code representing the GrantCategory
        /// </summary>
        public string Code { get; set; } = null!;

        /// <summary>
        /// English text description of the GrantCategory
        /// </summary>
        public string Text { get; set; } = null!;

        /// <summary>
        /// Arabic text description of the GrantCategory
        /// </summary>
        public string? Text2 { get; set; }

        public bool IsActive { get; set; }
        public ICollection<GrantType> GrantTypes { get; set; } = new List<GrantType>();
    }
}
