CREATE TABLE [dbo].[Directorate] (
    [DirectorateID]    INT           NOT NULL,
    [Code]             NVARCHAR (30) NOT NULL,
    [Text]             NVARCHAR (50) NOT NULL,
    [Text2]            NVARCHAR (50) NULL,
    [IsDeleted]        BIT           NOT NULL,
    [IsActive]         BIT           DEFAULT (CONVERT([bit],(1))) NOT NULL,
    [FK_GovernorateID] INT           NOT NULL,
    CONSTRAINT [PK_Directorate] PRIMARY KEY CLUSTERED ([DirectorateID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Table storing directorates', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Directorate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Unique identifier for the directorate', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Directorate', @level2type = N'COLUMN', @level2name = N'DirectorateID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Code representing the directorate', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Directorate', @level2type = N'COLUMN', @level2name = N'Code';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'English text description of the directorate', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Directorate', @level2type = N'COLUMN', @level2name = N'Text';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Arabic text description of the directorate', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Directorate', @level2type = N'COLUMN', @level2name = N'Text2';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicates if the directorate is deleted', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Directorate', @level2type = N'COLUMN', @level2name = N'IsDeleted';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicates if the directorate is active', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Directorate', @level2type = N'COLUMN', @level2name = N'IsActive';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Foreign key to the Governorate table', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Directorate', @level2type = N'COLUMN', @level2name = N'FK_GovernorateID';

