CREATE TABLE [dbo].[Request] (
    [RequestId]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [RequestNo]         NVARCHAR (14)  NOT NULL,
    [FK_LaborId]        INT            NOT NULL,
    [FK_DirectorateID]  INT            NOT NULL,
    [FK_WelfareTypeID]  INT            NOT NULL,
    [FK_StatusID]       INT            NOT NULL,
    [CreatedDate]       DATETIME2 (7)  NOT NULL,
    [CreatedByUserId]   VARCHAR (100)  NOT NULL,
    [CreatedByUserName] NVARCHAR (200) NOT NULL,
    [UpdatedUserId]     VARCHAR (100)  NULL,
    [UpdatedDate]       DATETIME2 (7)  NULL,
    [UpdatedUserName]   NVARCHAR (200) NULL,
    [Version]           ROWVERSION     NOT NULL,
    [DueAmount]         DECIMAL (8, 2) NOT NULL,
    [LaborMobileNo]     NVARCHAR (12)  NULL,
    [Notes]             NVARCHAR (256) NULL,
    CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED ([RequestId] ASC),
    CONSTRAINT [FK_Request_Directorate_FK_DirectorateID] FOREIGN KEY ([FK_DirectorateID]) REFERENCES [dbo].[Directorate] ([DirectorateID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Request_RequestStatus_FK_StatusID] FOREIGN KEY ([FK_StatusID]) REFERENCES [dbo].[RequestStatus] ([RequestStatusID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Request_WelfareType_FK_WelfareTypeID] FOREIGN KEY ([FK_WelfareTypeID]) REFERENCES [dbo].[WelfareType] ([WelfareTypeID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Request_FK_DirectorateID]
    ON [dbo].[Request]([FK_DirectorateID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Request_FK_StatusID]
    ON [dbo].[Request]([FK_StatusID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Request_FK_WelfareTypeID]
    ON [dbo].[Request]([FK_WelfareTypeID] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identifier for the directorate associated with the request', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Request', @level2type = N'COLUMN', @level2name = N'FK_DirectorateID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identifier for the type of request', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Request', @level2type = N'COLUMN', @level2name = N'FK_WelfareTypeID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identifier for the current status of a current workflow', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Request', @level2type = N'COLUMN', @level2name = N'FK_StatusID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Date and time when the request was created', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Request', @level2type = N'COLUMN', @level2name = N'CreatedDate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'User ID of the user who created the request record', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Request', @level2type = N'COLUMN', @level2name = N'CreatedByUserId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'User name of the user who created the request record', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Request', @level2type = N'COLUMN', @level2name = N'CreatedByUserName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'User ID of the user who last updated the request record', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Request', @level2type = N'COLUMN', @level2name = N'UpdatedUserId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Date and time when the request record was last updated', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Request', @level2type = N'COLUMN', @level2name = N'UpdatedDate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'User name of the user who last updated the request record', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Request', @level2type = N'COLUMN', @level2name = N'UpdatedUserName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Timestamp for version control of the request record', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Request', @level2type = N'COLUMN', @level2name = N'Version';

