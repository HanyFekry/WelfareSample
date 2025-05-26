namespace S3.MoL.WelfareManagement.Domain.Entities;
public class MemorandumAttachment
{
    public int MemorandumAttachmentId { get; set; }

    public int MemorandumId { get; set; }

    public string AttachmentPath { get; set; } = null!;

    public int AttachmentTypeId { get; set; }

    public AttachmentType AttachmentType { get; set; } = null!;

    public Memorandum Memorandum { get; set; } = null!;
}

