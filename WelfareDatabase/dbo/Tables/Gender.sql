CREATE TABLE [dbo].[Gender] (
    [GenderID]  INT           NOT NULL,
    [Code]      NVARCHAR (30) NOT NULL,
    [Text]      NVARCHAR (50) NOT NULL,
    [Text2]     NVARCHAR (50) NULL,
    [IsDeleted] BIT           NOT NULL,
    [IsActive]  BIT           DEFAULT (CONVERT([bit],(1))) NOT NULL,
    CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED ([GenderID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Table storing gender information', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Gender';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Unique identifier for the gender', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Gender', @level2type = N'COLUMN', @level2name = N'GenderID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Code representing the gender', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Gender', @level2type = N'COLUMN', @level2name = N'Code';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'English text description of the gender', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Gender', @level2type = N'COLUMN', @level2name = N'Text';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Arabic text description of the gender', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Gender', @level2type = N'COLUMN', @level2name = N'Text2';

