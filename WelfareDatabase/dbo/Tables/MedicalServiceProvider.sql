CREATE TABLE [dbo].[MedicalServiceProvider] (
    [MedicalServiceProviderId] INT            NOT NULL,
    [Code]                     NVARCHAR (30)  NOT NULL,
    [Text]                     NVARCHAR (50)  NOT NULL,
    [Text2]                    NVARCHAR (50)  NULL,
    [IBAN]                     NVARCHAR (120) NULL,
    CONSTRAINT [PK_MedicalServiceProvider] PRIMARY KEY CLUSTERED ([MedicalServiceProviderId] ASC)
);

