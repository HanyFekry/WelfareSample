CREATE TABLE [dbo].[NotificationReceiverType] (
    [NotificationReceiverTypeID] INT           NOT NULL,
    [Code]                       NVARCHAR (30) NOT NULL,
    [Text]                       NVARCHAR (50) NOT NULL,
    [Text2]                      NVARCHAR (50) NULL,
    CONSTRAINT [PK_NotificationReceiverType] PRIMARY KEY CLUSTERED ([NotificationReceiverTypeID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'A unique identifier for each notification receiver type.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'NotificationReceiverType', @level2type = N'COLUMN', @level2name = N'NotificationReceiverTypeID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'A unique code representing the notification receiver type.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'NotificationReceiverType', @level2type = N'COLUMN', @level2name = N'Code';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'The English description or name of the notification receiver type.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'NotificationReceiverType', @level2type = N'COLUMN', @level2name = N'Text';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'An optional Arabic description or additional information for the notification receiver type.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'NotificationReceiverType', @level2type = N'COLUMN', @level2name = N'Text2';

