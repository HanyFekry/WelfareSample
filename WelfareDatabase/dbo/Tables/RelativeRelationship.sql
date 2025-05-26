CREATE TABLE [dbo].[RelativeRelationship] (
    [RelativeRelationshipID] INT           NOT NULL,
    [Code]                   NVARCHAR (30) NOT NULL,
    [Text]                   NVARCHAR (50) NOT NULL,
    [Text2]                  NVARCHAR (50) NULL,
    CONSTRAINT [PK_RelativeRelationship] PRIMARY KEY CLUSTERED ([RelativeRelationshipID] ASC)
);

