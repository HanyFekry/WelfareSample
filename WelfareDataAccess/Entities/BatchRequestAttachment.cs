namespace S3.MoL.WelfareManagement.Domain.Entities;
public class BatchRequestAttachment
{
    public int BatchAttachmentId { get; set; }

    public int BatchId { get; set; }

    public int AttachmentTypeId { get; set; }

    public string AttachmentPath { get; set; } = null!;

    public AttachmentType AttachmentType { get; set; } = null!;

    public BatchRequest Batch { get; set; } = null!;
}

