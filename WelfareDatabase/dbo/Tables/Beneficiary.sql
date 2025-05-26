CREATE TABLE [dbo].[Beneficiary] (
    [BeneficiaryID]             BIGINT         IDENTITY (1, 1) NOT NULL,
    [FK_LaborID]                BIGINT         NULL,
    [FK_SocialWelfareRequestId] BIGINT         NOT NULL,
    [BeneficiaryName]           NCHAR (10)     NOT NULL,
    [NationalID]                CHAR (14)      NOT NULL,
    [FK_RelativeRelationTypeID] INT            NOT NULL,
    [IBAN]                      NVARCHAR (120) NULL,
    [Amount]                    DECIMAL (8, 2) NOT NULL,
    CONSTRAINT [PK_Beneficiary] PRIMARY KEY CLUSTERED ([BeneficiaryID] ASC),
    CONSTRAINT [FK_Beneficiary_RelativeRelationType_FK_RelativeRelationTypeID] FOREIGN KEY ([FK_RelativeRelationTypeID]) REFERENCES [dbo].[RelativeRelationType] ([RelativeRelationTypeID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Beneficiary_SocialWelfareRequest_FK_SocialWelfareRequestId] FOREIGN KEY ([FK_SocialWelfareRequestId]) REFERENCES [dbo].[SocialWelfareRequest] ([RequestId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Beneficiary_FK_RelativeRelationTypeID]
    ON [dbo].[Beneficiary]([FK_RelativeRelationTypeID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Beneficiary_FK_SocialWelfareRequestId]
    ON [dbo].[Beneficiary]([FK_SocialWelfareRequestId] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Unique identifier for Beneficiary', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Beneficiary', @level2type = N'COLUMN', @level2name = N'BeneficiaryID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Unique identifier for labor associated with request', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Beneficiary', @level2type = N'COLUMN', @level2name = N'FK_LaborID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identifier of social request if applicable', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Beneficiary', @level2type = N'COLUMN', @level2name = N'FK_SocialWelfareRequestId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Beneficiary name', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Beneficiary', @level2type = N'COLUMN', @level2name = N'BeneficiaryName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'National identification number of the labor', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Beneficiary', @level2type = N'COLUMN', @level2name = N'NationalID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Relationship to dead employee', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Beneficiary', @level2type = N'COLUMN', @level2name = N'FK_RelativeRelationTypeID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Amount to be disbursed for beneficiary', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Beneficiary', @level2type = N'COLUMN', @level2name = N'Amount';

