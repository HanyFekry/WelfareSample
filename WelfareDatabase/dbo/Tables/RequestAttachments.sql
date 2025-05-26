CREATE TABLE [dbo].[RequestAttachments] (
    [RequestAttachmentId] BIGINT         IDENTITY (1, 1) NOT NULL,
    [FK_RequestId]        BIGINT         NOT NULL,
    [FK_AttachmentTypeId] INT            NOT NULL,
    [AttachmentPath]      NVARCHAR (200) NOT NULL,
    CONSTRAINT [PK_RequestAttachments_1] PRIMARY KEY CLUSTERED ([RequestAttachmentId] ASC),
    CONSTRAINT [FK_RequestAttachments_AttachmentType_FK_AttachmentTypeId] FOREIGN KEY ([FK_AttachmentTypeId]) REFERENCES [dbo].[AttachmentType] ([AttachmentTypeID]),
    CONSTRAINT [FK_RequestAttachments_Request_FK_RequestId] FOREIGN KEY ([FK_RequestId]) REFERENCES [dbo].[Request] ([RequestId])
);


GO
CREATE NONCLUSTERED INDEX [IX_RequestAttachments_FK_AttachmentTypeId]
    ON [dbo].[RequestAttachments]([FK_AttachmentTypeId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_RequestAttachments_FK_RequestId]
    ON [dbo].[RequestAttachments]([FK_RequestId] ASC);

