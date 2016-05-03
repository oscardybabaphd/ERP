﻿CREATE TABLE [dbo].[IdentityUserLogins] (
    [UserId] [nvarchar](128) NOT NULL,
    [LoginProvider] [nvarchar](max),
    [ProviderKey] [nvarchar](max),
    CONSTRAINT [PK_dbo.IdentityUserLogins] PRIMARY KEY ([UserId])
)
CREATE TABLE [dbo].[IdentityRoles] (
    [Id] [nvarchar](128) NOT NULL,
    [Name] [nvarchar](max),
    CONSTRAINT [PK_dbo.IdentityRoles] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[IdentityUserRoles] (
    [RoleId] [nvarchar](128) NOT NULL,
    [UserId] [nvarchar](128) NOT NULL,
    [IdentityRole_Id] [nvarchar](128),
    CONSTRAINT [PK_dbo.IdentityUserRoles] PRIMARY KEY ([RoleId], [UserId])
)
CREATE INDEX [IX_IdentityRole_Id] ON [dbo].[IdentityUserRoles]([IdentityRole_Id])
ALTER TABLE [dbo].[IdentityUserRoles] ADD CONSTRAINT [FK_dbo.IdentityUserRoles_dbo.IdentityRoles_IdentityRole_Id] FOREIGN KEY ([IdentityRole_Id]) REFERENCES [dbo].[IdentityRoles] ([Id])
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201604172117391_AutomaticMigration', N'IdentityModels.Migrations.Configuration',  0x1F8B0800000000000400CD5ADD6EDB3614BE1FB0771074B50DA965276BD105768BCC490A63CD0FE2B4D85D414BC70E518AD2482AB331ECC976B147DA2BEC50FFA2245B7695360810C4E4E1777EF81DF2F038FFFDF3EFF8EDDA67D6230849033EB14783A16D0177038FF2D5C48ED4F2C56BFBED9BEFBF1B5F78FEDAFA98C99D68395CC9E5C47E502A3C751CE93E804FE4C0A7AE0864B0540337F01DE205CEF170F88B331A398010366259D6F82EE28AFA107FC08FD380BB10AA88B0ABC00326D3719C99C7A8D635F14186C485893D8D16B020825FDCDD0E1269DB3A6394A02573604BDB229C078A28B4F3F48384B912015FCD431C20EC7E1302CA2D099390DA7F5A8877756578AC5D718A8519941B4915F87B028E4ED2D838E6F283226CE7B1C3E85D6094D5467B1D477062CF3C88873030E27DB0A2A8C3D47A3A6542AF98D857B99E33195E831A64AB0709EEA540CC3F03F17950833DB23A2F3ECA59753C18EA9F236B1A3115099870889420ECC8BA8D168CBABFC1E63EF80C7C72325A2C4F5EBF7C45BC93573FC3C9CBB2CFE835CA550670E856042108B5B983651A096DEACCB32DA7BAD63117E74B8D754988905D9828B67545D6EF81AFD403A6D0F16BDBBAA46BF0B291946E1F38C5BCC2454A44F8F13A628C2C18E4F3CE56BD715871EC917A20B6A8C73F3BA9DFAE2D5384D1E859D7D82948D989AA7701837E59AA119F3F410F21E7B720A6FEDD3F1FAFC9235DC53BDD907F78E2DF018B67E5030D9383BFB2BD9F52B14B11F8FA73954EC9ECA779100957DB1EB48ADC13B102F5850CD650FDB338437DFE4CD656D6D9DCEBA99CA9F8DAE4FF3AB7411BE3CEA40C5C1A33A9E1D04C73A06AFF05F7ACDD0991786326153A866CA121F2034726F6703018D502B45541964E0D0A8A24A92AF9C90C45C9E97AF66121A908E520D2789C851A28163E5FE84958AB863444E56926CA74434CA734F81C545B1985474DB1450D9EA5B5562D56CDB03A0EDB1093387504CB02BBCBC446D052B09BCDCC0EDA9260FB716CE67F2732E67ED5E2533B4F3A71AF01AF1422F3E0A906A0212773C6156F162779B4648F1BA7E57533BE226188E745E9B5938E58F3F4A9F362BEFF1BC04F301C57363C05726B734D2A106405C62CAA464B2FA990EA9C28B220FA449A7A7E4DAC31BF5A7899A96C4DA1FA766674CD96EABF93E5F5576043BE19804580F1465CF9281DBB0F2D8C68C1881FA58411D172154C0316F97CDB75B60DC528F3CB60C65477CC4A315F46AC4CD4F1C68E112E73839CDA0E19D963EEFD5ECC4832B22752C4A7DBE17C685EDE16709306FB512029A8CBEB939167B741C5B1D963E67EE146B543B4853B2B1DCB016FAB58DB51F6CBFEA7DEB8EAADD59E5ED9EDDD3985B205FB865F5FCDB52469BBF2EBE1EA986525C0C6F78653B2E22003D31AA2A381FB31EBCB79B5D53FBC9C3D1ABF1466523F36F287C61E2134CBA13AF76A55912992333FAF8E8C2A689C56241D1AC166899288D85676AD6121BA910AFC811618CCFF605346D1BF42E08A70BA04A992A7AE7D3C1C1D1BBDE4E7D3D775A4F4D8BECDDD6FD617E58F44B80F44D4DFC27DB43D33F41F7CB2FEB10C79606B730FBCC3DA975FBDFDD75BFCCBDDBDA70C53F3C5F14CFB4BBD45F78992A6768C9BF8B506C88C7BB09ED87FC500A7D6ECF74F06C691752330694EADA1F5F736FBBA53A1B7E655DFFDAAA21972789B4A7FC5094B107A1161781B4A25F03EACD579B7827297868435F9552F11BA1C133AE239AC39730E2170ADA3CDE76E3A77165AB91E23CF760565CFF65EBD4BB167DFAE5BDB2E292C26B6B708901409D19B5A807BB4F77676F7B6E96CEE55ED6A0076EAFFED72B559F5B76813B676063B3506CDA034BF629EA41D582F70312F4AFF0F81492AE9AA80D0A53B07B79211B9CC8C2F832C430D8B3211E372B802453C4C9733A1E892B80AA75D9032FEE2E22361118A5CF80BF066FC265261A4D065F017ACD221D209BE4D7FDCF3ACDA3CBE09E3EFEBFA7001CDA4E802DCF05F23CABCDCEECB86AF4E5A20F4C9F10E703CD94B3C8814AC3639D275C03B02A5E1CB0FBC7BF0438660F286CFC9231C621BD2EF3DAC88BB29EADE3690DD1B510DFBF89C929520BE4C318AF5F81139ECF9EB37FF0313326AE316240000 , N'6.1.3-40302')

