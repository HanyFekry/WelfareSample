CREATE TABLE [dbo].[Occupation] (
    [OccupationID] INT           NOT NULL,
    [Code]         NVARCHAR (30) NOT NULL,
    [Text]         NVARCHAR (50) NOT NULL,
    [Text2]        NVARCHAR (50) NULL,
    [IsDeleted]    BIT           NOT NULL,
    [IsActive]     BIT           DEFAULT (CONVERT([bit],(1))) NOT NULL,
    CONSTRAINT [PK_Occupation] PRIMARY KEY CLUSTERED ([OccupationID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Unique identifier for each occupation record', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Occupation', @level2type = N'COLUMN', @level2name = N'OccupationID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Code representing the occupation', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Occupation', @level2type = N'COLUMN', @level2name = N'Code';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'English text description of the occupation', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Occupation', @level2type = N'COLUMN', @level2name = N'Text';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Arabic text description of the occupation', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Occupation', @level2type = N'COLUMN', @level2name = N'Text2';

