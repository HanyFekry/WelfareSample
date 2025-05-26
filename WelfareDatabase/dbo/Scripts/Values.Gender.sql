MERGE INTO [Gender] WITH (SERIALIZABLE) AS [Target]
USING (VALUES
  (7605,N'Gender001',N'Male',N'ذكر',0,1)
 ,(7606,N'Gender002',N'Female',N'انثى',0,1)
) AS [Source] ([GenderID],[Code],[Text],[Text2],[IsDeleted],[IsActive])
ON ([Target].[GenderID] = [Source].[GenderID])
WHEN MATCHED THEN
 UPDATE SET
  [Target].[Code] = [Source].[Code], 
  [Target].[Text] = [Source].[Text], 
  [Target].[Text2] = [Source].[Text2], 
  [Target].[IsDeleted] = [Source].[IsDeleted], 
  [Target].[IsActive] = [Source].[IsActive]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([GenderID],[Code],[Text],[Text2],[IsDeleted],[IsActive])
 VALUES([Source].[GenderID],[Source].[Code],[Source].[Text],[Source].[Text2],[Source].[IsDeleted],[Source].[IsActive])
WHEN NOT MATCHED BY SOURCE THEN 
 DELETE;