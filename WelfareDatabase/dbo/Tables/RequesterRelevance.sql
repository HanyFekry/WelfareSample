CREATE TABLE [dbo].[RequesterRelevance] (
    [RequesterRelevantID] INT           NOT NULL,
    [Code]                NVARCHAR (30) NOT NULL,
    [Text]                NVARCHAR (50) NOT NULL,
    [Text2]               NVARCHAR (50) NULL,
    CONSTRAINT [PK_RequesterRelevant] PRIMARY KEY CLUSTERED ([RequesterRelevantID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Labor or Medical provider or Other', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RequesterRelevance';

