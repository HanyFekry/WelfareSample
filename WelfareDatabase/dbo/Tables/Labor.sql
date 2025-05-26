CREATE TABLE [dbo].[Labor] (
    [LaborID]                 BIGINT          NOT NULL,
    [NationalID]              CHAR (14)       NOT NULL,
    [FullName]                NVARCHAR (200)  NOT NULL,
    [BirthDate]               DATE            NULL,
    [FK_GenderID]             INT             NULL,
    [FK_MaritalStatusID]      INT             NULL,
    [FK_OccupationID]         INT             NOT NULL,
    [MobileNo]                CHAR (13)       NOT NULL,
    [FK_LastDirectorateID]    INT             NULL,
    [FK_LastBusinessNatureID] INT             NULL,
    [FK_LastExecutionPartyID] BIGINT          NULL,
    [RegistrationNo]          VARCHAR (20)    NULL,
    [RegistrationDate]        DATE            NULL,
    [InsuranceNo]             CHAR (9)        NULL,
    [FK_InsuranceSectorID]    INT             NULL,
    [InsurancePeriod]         INT             NULL,
    [DeathDate]               DATE            NULL,
    [IsBeneficiary]           BIT             DEFAULT (CONVERT([bit],(1))) NOT NULL,
    [Notes]                   NVARCHAR (1000) NULL,
    CONSTRAINT [PK_Labor] PRIMARY KEY CLUSTERED ([LaborID] ASC),
    CONSTRAINT [FK_Labor_BusinessNature] FOREIGN KEY ([FK_LastBusinessNatureID]) REFERENCES [dbo].[BusinessNature] ([BusinessNatureID]),
    CONSTRAINT [FK_Labor_Directorate] FOREIGN KEY ([FK_LastDirectorateID]) REFERENCES [dbo].[Directorate] ([DirectorateID]),
    CONSTRAINT [FK_Labor_Gender] FOREIGN KEY ([FK_GenderID]) REFERENCES [dbo].[Gender] ([GenderID]),
    CONSTRAINT [FK_Labor_MaritalStatus] FOREIGN KEY ([FK_MaritalStatusID]) REFERENCES [dbo].[MaritalStatus] ([MaritalStatusID]),
    CONSTRAINT [FK_Labor_Occupation] FOREIGN KEY ([FK_OccupationID]) REFERENCES [dbo].[Occupation] ([OccupationID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Labor_Party] FOREIGN KEY ([FK_LastExecutionPartyID]) REFERENCES [dbo].[Party] ([PartyID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Labor_FK_GenderID]
    ON [dbo].[Labor]([FK_GenderID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Labor_FK_LastBusinessNatureID]
    ON [dbo].[Labor]([FK_LastBusinessNatureID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Labor_FK_LastDirectorateID]
    ON [dbo].[Labor]([FK_LastDirectorateID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Labor_FK_LastExecutionPartyID]
    ON [dbo].[Labor]([FK_LastExecutionPartyID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Labor_FK_MaritalStatusID]
    ON [dbo].[Labor]([FK_MaritalStatusID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Labor_FK_OccupationID]
    ON [dbo].[Labor]([FK_OccupationID] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'the worker''s status must be Beneficiary or  Not Beneficiary, default is Beneficiary(1)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Labor', @level2type = N'COLUMN', @level2name = N'IsBeneficiary';

