namespace S3.MoL.WelfareManagement.Domain.Entities;
public class WelfareRequestAttachment
{
    public long WelfareRequestAttachmentId { get; set; }

    public long RequestId { get; set; }

    public int AttachmentTypeId { get; set; }

    public string AttachmentPath { get; set; } = null!;

    public AttachmentType AttachmentType { get; set; } = null!;

    public WelfareRequest Request { get; set; } = null!;
}

