CREATE TABLE [dbo].[BusinessNature] (
    [BusinessNatureID] INT            NOT NULL,
    [Code]             NVARCHAR (30)  NOT NULL,
    [Text]             NVARCHAR (250) NOT NULL,
    [Text2]            NVARCHAR (250) NOT NULL,
    [IsDeleted]        BIT            NOT NULL,
    [IsActive]         BIT            DEFAULT (CONVERT([bit],(1))) NOT NULL,
    CONSTRAINT [PK_BusinessNature] PRIMARY KEY CLUSTERED ([BusinessNatureID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Table storing business natures', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BusinessNature';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Unique identifier for the business nature', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BusinessNature', @level2type = N'COLUMN', @level2name = N'BusinessNatureID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Code representing the business nature', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BusinessNature', @level2type = N'COLUMN', @level2name = N'Code';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'English text description of the business nature', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BusinessNature', @level2type = N'COLUMN', @level2name = N'Text';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Arabic text description of the business nature', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BusinessNature', @level2type = N'COLUMN', @level2name = N'Text2';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicates if the business nature is deleted', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BusinessNature', @level2type = N'COLUMN', @level2name = N'IsDeleted';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicates if the business nature is active', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BusinessNature', @level2type = N'COLUMN', @level2name = N'IsActive';

