CREATE TABLE [dbo].[WelfareCategory] (
    [WelfareCategoryId] TINYINT       NOT NULL,
    [Code]              NVARCHAR (30) NOT NULL,
    [Text]              NVARCHAR (50) NOT NULL,
    [Text2]             NVARCHAR (50) NULL,
    CONSTRAINT [PK_WelfareCategory] PRIMARY KEY CLUSTERED ([WelfareCategoryId] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Monetary or ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'WelfareCategory';

