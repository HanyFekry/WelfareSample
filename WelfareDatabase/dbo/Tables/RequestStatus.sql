CREATE TABLE [dbo].[RequestStatus] (
    [RequestStatusID] INT           NOT NULL,
    [Code]            NVARCHAR (30) NOT NULL,
    [Text]            NVARCHAR (50) NOT NULL,
    [Text2]           NVARCHAR (50) NULL,
    CONSTRAINT [PK_RequestStatus] PRIMARY KEY CLUSTERED ([RequestStatusID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Unique identifier for each request status record', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RequestStatus', @level2type = N'COLUMN', @level2name = N'RequestStatusID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Code representing the request status', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RequestStatus', @level2type = N'COLUMN', @level2name = N'Code';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'English text description of the request status', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RequestStatus', @level2type = N'COLUMN', @level2name = N'Text';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Arabic text description of the request status', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RequestStatus', @level2type = N'COLUMN', @level2name = N'Text2';

