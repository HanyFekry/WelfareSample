CREATE TABLE [dbo].[DisabilityWelfareRequest] (
    [RequestId]       BIGINT        NOT NULL,
    [EventDate]       DATETIME2 (7) NOT NULL,
    [DisabilityRatio] DECIMAL (2)   NULL,
    CONSTRAINT [PK_DisabilityWelfareRequest] PRIMARY KEY CLUSTERED ([RequestId] ASC),
    CONSTRAINT [FK_DisabilityWelfareRequest_Request_RequestId] FOREIGN KEY ([RequestId]) REFERENCES [dbo].[Request] ([RequestId]) ON DELETE CASCADE
);

