CREATE TABLE [dbo].[PartyType] (
    [PartyTypeID] INT           NOT NULL,
    [Code]        NVARCHAR (30) NOT NULL,
    [Text]        NVARCHAR (50) NOT NULL,
    [Text2]       NVARCHAR (50) NULL,
    [IsDeleted]   BIT           NOT NULL,
    [IsActive]    BIT           DEFAULT (CONVERT([bit],(1))) NOT NULL,
    CONSTRAINT [PK_PartyType] PRIMARY KEY CLUSTERED ([PartyTypeID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicates if the business nature is deleted', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'PartyType', @level2type = N'COLUMN', @level2name = N'IsDeleted';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicates if the business nature is active', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'PartyType', @level2type = N'COLUMN', @level2name = N'IsActive';

