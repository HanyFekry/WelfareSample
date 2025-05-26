CREATE TABLE [dbo].[SocialWelfareRequest] (
    [RequestId]                 BIGINT        NOT NULL,
    [EventDate]                 DATETIME2 (7) NOT NULL,
    [NationalId]                CHAR (14)     NOT NULL,
    [IsTwin]                    BIT           NULL,
    [RequesterName]             NVARCHAR (60) NULL,
    [FK_RelativeRelationshipId] INT           NULL,
    [FK_RequesterRelevanceId]   INT           NULL,
    CONSTRAINT [PK_SocialWelfareRequest] PRIMARY KEY CLUSTERED ([RequestId] ASC),
    CONSTRAINT [FK_SocialWelfareRequest_RelativeRelationship_FK_RelativeRelationshipId] FOREIGN KEY ([FK_RelativeRelationshipId]) REFERENCES [dbo].[RelativeRelationship] ([RelativeRelationshipID]),
    CONSTRAINT [FK_SocialWelfareRequest_Request_RequestId] FOREIGN KEY ([RequestId]) REFERENCES [dbo].[Request] ([RequestId]) ON DELETE CASCADE,
    CONSTRAINT [FK_SocialWelfareRequest_RequesterRelevance_FK_RequesterRelevanceId] FOREIGN KEY ([FK_RequesterRelevanceId]) REFERENCES [dbo].[RequesterRelevance] ([RequesterRelevantID])
);


GO
CREATE NONCLUSTERED INDEX [IX_SocialWelfareRequest_FK_RelativeRelationshipId]
    ON [dbo].[SocialWelfareRequest]([FK_RelativeRelationshipId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_SocialWelfareRequest_FK_RequesterRelevanceId]
    ON [dbo].[SocialWelfareRequest]([FK_RequesterRelevanceId] ASC);

