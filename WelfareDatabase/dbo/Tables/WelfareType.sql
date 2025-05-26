CREATE TABLE [dbo].[WelfareType] (
    [WelfareTypeID]        INT            NOT NULL,
    [Code]                 NVARCHAR (30)  NOT NULL,
    [Text]                 NVARCHAR (50)  NOT NULL,
    [Text2]                NVARCHAR (50)  NULL,
    [FK_WelfareCategoryId] TINYINT        NOT NULL,
    [WelfareAmount]        DECIMAL (8, 2) NULL,
    [MaximumLimit]         TINYINT        NULL,
    CONSTRAINT [PK_WelfareType] PRIMARY KEY CLUSTERED ([WelfareTypeID] ASC),
    CONSTRAINT [FK_WelfareType_WelfareCategory_FK_WelfareCategoryId] FOREIGN KEY ([FK_WelfareCategoryId]) REFERENCES [dbo].[WelfareCategory] ([WelfareCategoryId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_WelfareType_FK_WelfareCategoryId]
    ON [dbo].[WelfareType]([FK_WelfareCategoryId] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Unique identifier for each Welfare type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'WelfareType', @level2type = N'COLUMN', @level2name = N'WelfareTypeID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Code representing the Welfare type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'WelfareType', @level2type = N'COLUMN', @level2name = N'Code';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'English text description of the Welfare type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'WelfareType', @level2type = N'COLUMN', @level2name = N'Text';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Arabic text description of the Welfare type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'WelfareType', @level2type = N'COLUMN', @level2name = N'Text2';

