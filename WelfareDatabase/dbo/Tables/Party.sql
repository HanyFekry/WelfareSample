CREATE TABLE [dbo].[Party] (
    [PartyID]        BIGINT         NOT NULL,
    [FK_PartyTypeID] INT            NOT NULL,
    [Name]           NVARCHAR (200) NOT NULL,
    CONSTRAINT [PK_Party] PRIMARY KEY CLUSTERED ([PartyID] ASC),
    CONSTRAINT [FK_Party_PartyType] FOREIGN KEY ([FK_PartyTypeID]) REFERENCES [dbo].[PartyType] ([PartyTypeID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Party_FK_PartyTypeID]
    ON [dbo].[Party]([FK_PartyTypeID] ASC);

