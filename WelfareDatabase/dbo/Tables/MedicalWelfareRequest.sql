CREATE TABLE [dbo].[MedicalWelfareRequest] (
    [RequestId]                   BIGINT         NOT NULL,
    [FK_MedicalServiceProviderId] INT            NULL,
    [Description]                 NVARCHAR (250) NOT NULL,
    [FK_BeneficiaryTypeId]        INT            NULL,
    [BeneficiaryName]             NVARCHAR (120) NULL,
    [BeneficiaryNId]              INT            NULL,
    [BeneficiaryIBAN]             NVARCHAR (120) NULL,
    [NoOfPrescriptions]           TINYINT        NULL,
    CONSTRAINT [PK_MedicalWelfareRequest] PRIMARY KEY CLUSTERED ([RequestId] ASC),
    CONSTRAINT [FK_MedicalWelfareRequest_BeneficiaryType_FK_BeneficiaryTypeId] FOREIGN KEY ([FK_BeneficiaryTypeId]) REFERENCES [dbo].[BeneficiaryType] ([BeneficiaryTypeId]),
    CONSTRAINT [FK_MedicalWelfareRequest_MedicalServiceProvider_FK_MedicalServiceProviderId] FOREIGN KEY ([FK_MedicalServiceProviderId]) REFERENCES [dbo].[MedicalServiceProvider] ([MedicalServiceProviderId]),
    CONSTRAINT [FK_MedicalWelfareRequest_Request_RequestId] FOREIGN KEY ([RequestId]) REFERENCES [dbo].[Request] ([RequestId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_MedicalWelfareRequest_FK_BeneficiaryTypeId]
    ON [dbo].[MedicalWelfareRequest]([FK_BeneficiaryTypeId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_MedicalWelfareRequest_FK_MedicalServiceProviderId]
    ON [dbo].[MedicalWelfareRequest]([FK_MedicalServiceProviderId] ASC);

