using System;
using System.Collections.Generic;

namespace WelfareDataAccess.Entities;
public class RequestAttachment
{
    public long RequestAttachmentId { get; set; }

    public long RequestId { get; set; }

    public int AttachmentTypeId { get; set; }

    public string AttachmentPath { get; set; } = null!;

    public AttachmentType AttachmentType { get; set; } = null!;

    public Request Request { get; set; } = null!;
}

