CREATE TABLE [dbo].[RequestType] (
    [RequestTypeID] INT           NOT NULL,
    [Code]          NVARCHAR (30) NOT NULL,
    [Text]          NVARCHAR (50) NOT NULL,
    [Text2]         NVARCHAR (50) NULL,
    [IsMemorandum]  BIT           DEFAULT (CONVERT([bit],(0))) NOT NULL,
    CONSTRAINT [PK_RequestType] PRIMARY KEY CLUSTERED ([RequestTypeID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Unique identifier for each request type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RequestType', @level2type = N'COLUMN', @level2name = N'RequestTypeID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Code representing the request type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RequestType', @level2type = N'COLUMN', @level2name = N'Code';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'English text description of the request type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RequestType', @level2type = N'COLUMN', @level2name = N'Text';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Arabic text description of the request type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RequestType', @level2type = N'COLUMN', @level2name = N'Text2';

