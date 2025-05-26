CREATE TABLE [dbo].[AttachmentType] (
    [AttachmentTypeID] INT           NOT NULL,
    [FK_WelfareTypeID] INT           NOT NULL,
    [Code]             NVARCHAR (30) NOT NULL,
    [Text]             NVARCHAR (50) NOT NULL,
    [Text2]            NVARCHAR (50) NULL,
    [SizeLimit]        INT           NULL,
    [MimeTypes]        VARCHAR (200) NOT NULL,
    [Mandatory]        BIT           NOT NULL,
    [MaxFileCount]     INT           NOT NULL,
    CONSTRAINT [PK_AttachmentType] PRIMARY KEY CLUSTERED ([AttachmentTypeID] ASC),
    CONSTRAINT [FK_AttachmentType_WelfareType_FK_WelfareTypeID] FOREIGN KEY ([FK_WelfareTypeID]) REFERENCES [dbo].[WelfareType] ([WelfareTypeID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AttachmentType_FK_WelfareTypeID]
    ON [dbo].[AttachmentType]([FK_WelfareTypeID] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Table storing attachment types', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'AttachmentType';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Unique identifier for the attachment type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'AttachmentType', @level2type = N'COLUMN', @level2name = N'AttachmentTypeID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Foreign key to the LaborCareType table', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'AttachmentType', @level2type = N'COLUMN', @level2name = N'FK_WelfareTypeID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Code representing the attachment type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'AttachmentType', @level2type = N'COLUMN', @level2name = N'Code';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'English text description of the attachment type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'AttachmentType', @level2type = N'COLUMN', @level2name = N'Text';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Arabic text description of the attachment type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'AttachmentType', @level2type = N'COLUMN', @level2name = N'Text2';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Limit on the size of the attachment', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'AttachmentType', @level2type = N'COLUMN', @level2name = N'SizeLimit';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Allowed MIME types for the attachment', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'AttachmentType', @level2type = N'COLUMN', @level2name = N'MimeTypes';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicates if the attachment type is mandatory', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'AttachmentType', @level2type = N'COLUMN', @level2name = N'Mandatory';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Number of files allowed for the attachment type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'AttachmentType', @level2type = N'COLUMN', @level2name = N'MaxFileCount';

