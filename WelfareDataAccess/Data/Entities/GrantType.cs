namespace S3.MoL.WelfareManagement.Domain.Entities
{
    public class GrantType
    {
        //TODO: periodic vs exceptional
        /// <summary>
        /// Unique identifier for each grant type record
        /// </summary>
        public int GrantTypeId { get; set; }

        /// <summary>
        /// Code representing the grant type
        /// </summary>
        public string Code { get; set; } = null!;

        /// <summary>
        /// English text description of the grant type
        /// </summary>
        public string Text { get; set; } = null!;

        /// <summary>
        /// Arabic text description of the grant type
        /// </summary>
        public string? Text2 { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }
        public List<Grant> Grants { get; set; }
        public int? GrantCategoryId { get; set; }
    }
}
