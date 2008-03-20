/****** Object:  ForeignKey [FK_BaseProperties_DataTypes]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaseProperties_DataTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaseProperties]'))
ALTER TABLE [dbo].[BaseProperties] DROP CONSTRAINT [FK_BaseProperties_DataTypes]
GO
/****** Object:  ForeignKey [FK_Methods_DataTypes]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Methods_DataTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Methods]'))
ALTER TABLE [dbo].[Methods] DROP CONSTRAINT [FK_Methods_DataTypes]
GO
/****** Object:  ForeignKey [FK_Taetigkeiten_Mitarbeiter]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Taetigkeiten_Mitarbeiter]') AND parent_object_id = OBJECT_ID(N'[dbo].[Taetigkeiten]'))
ALTER TABLE [dbo].[Taetigkeiten] DROP CONSTRAINT [FK_Taetigkeiten_Mitarbeiter]
GO
/****** Object:  ForeignKey [FK_Taetigkeiten_TaetigkeitsArten]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Taetigkeiten_TaetigkeitsArten]') AND parent_object_id = OBJECT_ID(N'[dbo].[Taetigkeiten]'))
ALTER TABLE [dbo].[Taetigkeiten] DROP CONSTRAINT [FK_Taetigkeiten_TaetigkeitsArten]
GO
/****** Object:  ForeignKey [FK_Taetigkeiten_Zeitkonten]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Taetigkeiten_Zeitkonten]') AND parent_object_id = OBJECT_ID(N'[dbo].[Taetigkeiten]'))
ALTER TABLE [dbo].[Taetigkeiten] DROP CONSTRAINT [FK_Taetigkeiten_Zeitkonten]
GO
/****** Object:  ForeignKey [FK_Tasks_Projekte]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Tasks_Projekte]') AND parent_object_id = OBJECT_ID(N'[dbo].[Tasks]'))
ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK_Tasks_Projekte]
GO
/****** Object:  ForeignKey [FK_Zeitkonten_MitarbeiterCollection_Mitarbeiter]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Zeitkonten_MitarbeiterCollection_Mitarbeiter]') AND parent_object_id = OBJECT_ID(N'[dbo].[Zeitkonten_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Zeitkonten_MitarbeiterCollection] DROP CONSTRAINT [FK_Zeitkonten_MitarbeiterCollection_Mitarbeiter]
GO
/****** Object:  ForeignKey [FK_Zeitkonten_MitarbeiterCollection_Zeitkonten]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Zeitkonten_MitarbeiterCollection_Zeitkonten]') AND parent_object_id = OBJECT_ID(N'[dbo].[Zeitkonten_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Zeitkonten_MitarbeiterCollection] DROP CONSTRAINT [FK_Zeitkonten_MitarbeiterCollection_Zeitkonten]
GO
/****** Object:  Default [DF__ObjectCla__Table__0F975522]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__ObjectCla__Table__0F975522]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
Begin
ALTER TABLE [dbo].[ObjectClasses] DROP CONSTRAINT [DF__ObjectCla__Table__0F975522]

End
GO
/****** Object:  StoredProcedure [dbo].[sp_DropBaseTables]    Script Date: 03/20/2008 18:17:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_DropBaseTables]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_DropBaseTables]
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckBaseTables]    Script Date: 03/20/2008 18:17:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CheckBaseTables]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_CheckBaseTables]
GO
/****** Object:  Table [dbo].[BaseProperties]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BaseProperties]') AND type in (N'U'))
DROP TABLE [dbo].[BaseProperties]
GO
/****** Object:  Table [dbo].[Methods]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Methods]') AND type in (N'U'))
DROP TABLE [dbo].[Methods]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tasks]') AND type in (N'U'))
DROP TABLE [dbo].[Tasks]
GO
/****** Object:  Table [dbo].[Zeitkonten_MitarbeiterCollection]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Zeitkonten_MitarbeiterCollection]') AND type in (N'U'))
DROP TABLE [dbo].[Zeitkonten_MitarbeiterCollection]
GO
/****** Object:  Table [dbo].[Taetigkeiten]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Taetigkeiten]') AND type in (N'U'))
DROP TABLE [dbo].[Taetigkeiten]
GO
/****** Object:  Table [dbo].[CLRObjectParameters]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLRObjectParameters]') AND type in (N'U'))
DROP TABLE [dbo].[CLRObjectParameters]
GO
/****** Object:  Table [dbo].[ObjectParameters]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectParameters]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectParameters]
GO
/****** Object:  Table [dbo].[DateTimeParameters]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DateTimeParameters]') AND type in (N'U'))
DROP TABLE [dbo].[DateTimeParameters]
GO
/****** Object:  Table [dbo].[BoolParameters]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BoolParameters]') AND type in (N'U'))
DROP TABLE [dbo].[BoolParameters]
GO
/****** Object:  Table [dbo].[DoubleParameters]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DoubleParameters]') AND type in (N'U'))
DROP TABLE [dbo].[DoubleParameters]
GO
/****** Object:  Table [dbo].[IntParameters]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntParameters]') AND type in (N'U'))
DROP TABLE [dbo].[IntParameters]
GO
/****** Object:  Table [dbo].[StringParameters]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StringParameters]') AND type in (N'U'))
DROP TABLE [dbo].[StringParameters]
GO
/****** Object:  Table [dbo].[BaseParameters]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BaseParameters]') AND type in (N'U'))
DROP TABLE [dbo].[BaseParameters]
GO
/****** Object:  Table [dbo].[ObjectClasses]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectClasses]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectClasses]
GO
/****** Object:  Table [dbo].[DataTypes]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DataTypes]') AND type in (N'U'))
DROP TABLE [dbo].[DataTypes]
GO
/****** Object:  StoredProcedure [dbo].[sp_DropObjectProperty]    Script Date: 03/20/2008 18:17:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_DropObjectProperty]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_DropObjectProperty]
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckObjectProperty]    Script Date: 03/20/2008 18:17:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CheckObjectProperty]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_CheckObjectProperty]
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckObjectClass]    Script Date: 03/20/2008 18:17:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CheckObjectClass]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_CheckObjectClass]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_TableExists]    Script Date: 03/20/2008 18:17:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_TableExists]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_TableExists]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_ColumnExists]    Script Date: 03/20/2008 18:17:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_ColumnExists]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_ColumnExists]
GO
/****** Object:  Table [dbo].[Projekte_MitarbeiterCollection]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Projekte_MitarbeiterCollection]') AND type in (N'U'))
DROP TABLE [dbo].[Projekte_MitarbeiterCollection]
GO
/****** Object:  Table [dbo].[MethodInvocations]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MethodInvocations]') AND type in (N'U'))
DROP TABLE [dbo].[MethodInvocations]
GO
/****** Object:  Table [dbo].[Assemblies]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Assemblies]') AND type in (N'U'))
DROP TABLE [dbo].[Assemblies]
GO
/****** Object:  Table [dbo].[Icons]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Icons]') AND type in (N'U'))
DROP TABLE [dbo].[Icons]
GO
/****** Object:  Table [dbo].[Kunden]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kunden]') AND type in (N'U'))
DROP TABLE [dbo].[Kunden]
GO
/****** Object:  Table [dbo].[StringProperties]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StringProperties]') AND type in (N'U'))
DROP TABLE [dbo].[StringProperties]
GO
/****** Object:  Table [dbo].[ValueTypeProperties]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ValueTypeProperties]') AND type in (N'U'))
DROP TABLE [dbo].[ValueTypeProperties]
GO
/****** Object:  Table [dbo].[Properties]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Properties]') AND type in (N'U'))
DROP TABLE [dbo].[Properties]
GO
/****** Object:  Table [dbo].[Projekte]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Projekte]') AND type in (N'U'))
DROP TABLE [dbo].[Projekte]
GO
/****** Object:  Table [dbo].[Mitarbeiter]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mitarbeiter]') AND type in (N'U'))
DROP TABLE [dbo].[Mitarbeiter]
GO
/****** Object:  Table [dbo].[Kostentraeger]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kostentraeger]') AND type in (N'U'))
DROP TABLE [dbo].[Kostentraeger]
GO
/****** Object:  Table [dbo].[Kostenstellen]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kostenstellen]') AND type in (N'U'))
DROP TABLE [dbo].[Kostenstellen]
GO
/****** Object:  Table [dbo].[Zeitkonten]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Zeitkonten]') AND type in (N'U'))
DROP TABLE [dbo].[Zeitkonten]
GO
/****** Object:  Table [dbo].[Auftraege]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Auftraege]') AND type in (N'U'))
DROP TABLE [dbo].[Auftraege]
GO
/****** Object:  Table [dbo].[Modules]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Modules]') AND type in (N'U'))
DROP TABLE [dbo].[Modules]
GO
/****** Object:  Table [dbo].[ObjectForDeletedProperties]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectForDeletedProperties]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectForDeletedProperties]
GO
/****** Object:  Table [dbo].[BackReferenceProperties]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BackReferenceProperties]') AND type in (N'U'))
DROP TABLE [dbo].[BackReferenceProperties]
GO
/****** Object:  Table [dbo].[DateTimeProperties]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DateTimeProperties]') AND type in (N'U'))
DROP TABLE [dbo].[DateTimeProperties]
GO
/****** Object:  Table [dbo].[ObjectReferenceProperties]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectReferenceProperties]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectReferenceProperties]
GO
/****** Object:  Table [dbo].[BoolProperties]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BoolProperties]') AND type in (N'U'))
DROP TABLE [dbo].[BoolProperties]
GO
/****** Object:  Table [dbo].[DoubleProperties]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DoubleProperties]') AND type in (N'U'))
DROP TABLE [dbo].[DoubleProperties]
GO
/****** Object:  Table [dbo].[IntProperties]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntProperties]') AND type in (N'U'))
DROP TABLE [dbo].[IntProperties]
GO
/****** Object:  Table [dbo].[Kunden_EMailsCollection]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kunden_EMailsCollection]') AND type in (N'U'))
DROP TABLE [dbo].[Kunden_EMailsCollection]
GO
/****** Object:  Table [dbo].[TaetigkeitsArten]    Script Date: 03/20/2008 18:17:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaetigkeitsArten]') AND type in (N'U'))
DROP TABLE [dbo].[TaetigkeitsArten]
GO
/****** Object:  Table [dbo].[TaetigkeitsArten]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaetigkeitsArten]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TaetigkeitsArten](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_TaetigkeitsArten] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[TaetigkeitsArten] ON
INSERT [dbo].[TaetigkeitsArten] ([ID], [Name]) VALUES (1, N'Entwicklung')
INSERT [dbo].[TaetigkeitsArten] ([ID], [Name]) VALUES (2, N'Meeting')
INSERT [dbo].[TaetigkeitsArten] ([ID], [Name]) VALUES (3, N'Planung')
SET IDENTITY_INSERT [dbo].[TaetigkeitsArten] OFF
/****** Object:  Table [dbo].[Kunden_EMailsCollection]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kunden_EMailsCollection]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Kunden_EMailsCollection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Kunde] [int] NOT NULL,
	[EMails] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_Kunden_EMailsCollection] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Kunden_EMailsCollection] ON
INSERT [dbo].[Kunden_EMailsCollection] ([ID], [fk_Kunde], [EMails]) VALUES (1, 1, N'accent@accent.net')
INSERT [dbo].[Kunden_EMailsCollection] ([ID], [fk_Kunde], [EMails]) VALUES (2, 1, N'moser@accent.com')
INSERT [dbo].[Kunden_EMailsCollection] ([ID], [fk_Kunde], [EMails]) VALUES (6, 2, N'susanne.dobler@mail.com')
INSERT [dbo].[Kunden_EMailsCollection] ([ID], [fk_Kunde], [EMails]) VALUES (7, 1, N'test@test.com')
SET IDENTITY_INSERT [dbo].[Kunden_EMailsCollection] OFF
/****** Object:  Table [dbo].[IntProperties]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[IntProperties](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_IntPropertes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[IntProperties] ([ID]) VALUES (28)
/****** Object:  Table [dbo].[DoubleProperties]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DoubleProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DoubleProperties](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_DoubleProperties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[DoubleProperties] ([ID]) VALUES (18)
INSERT [dbo].[DoubleProperties] ([ID]) VALUES (23)
INSERT [dbo].[DoubleProperties] ([ID]) VALUES (57)
INSERT [dbo].[DoubleProperties] ([ID]) VALUES (65)
INSERT [dbo].[DoubleProperties] ([ID]) VALUES (89)
INSERT [dbo].[DoubleProperties] ([ID]) VALUES (90)
/****** Object:  Table [dbo].[BoolProperties]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BoolProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BoolProperties](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_BoolProperties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[BoolProperties] ([ID]) VALUES (11)
INSERT [dbo].[BoolProperties] ([ID]) VALUES (26)
INSERT [dbo].[BoolProperties] ([ID]) VALUES (83)
INSERT [dbo].[BoolProperties] ([ID]) VALUES (84)
INSERT [dbo].[BoolProperties] ([ID]) VALUES (94)
INSERT [dbo].[BoolProperties] ([ID]) VALUES (95)
/****** Object:  Table [dbo].[ObjectReferenceProperties]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectReferenceProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ObjectReferenceProperties](
	[ID] [int] NOT NULL,
	[ReferenceObjectClassName] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
	[fk_ReferenceObjectClass] [int] NULL,
 CONSTRAINT [PK_ObjectReferenceProperties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (8, N'Kistl.App.Base.ObjectClass', 33)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (19, N'Kistl.App.Projekte.Projekt', 3)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (22, N'Kistl.App.Projekte.Mitarbeiter', 6)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (25, N'Kistl.App.Base.ObjectClass', 2)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (29, N'Kistl.App.Base.ObjectClass', 33)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (45, N'Kistl.App.Base.Module', 18)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (46, N'Kistl.App.Base.ObjectClass', 2)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (47, NULL, 14)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (49, NULL, 6)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (51, NULL, 3)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (53, NULL, 3)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (54, NULL, 6)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (55, NULL, 20)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (64, NULL, 26)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (69, NULL, 27)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (70, NULL, 18)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (72, NULL, 18)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (73, NULL, 18)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (74, NULL, 10)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (75, NULL, 29)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (78, NULL, 18)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (79, NULL, 33)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (86, NULL, 6)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (88, NULL, 31)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (92, NULL, 10)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (93, NULL, 18)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (97, NULL, 33)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (98, NULL, 29)
/****** Object:  Table [dbo].[DateTimeProperties]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DateTimeProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DateTimeProperties](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_DateTimeProperties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[DateTimeProperties] ([ID]) VALUES (16)
INSERT [dbo].[DateTimeProperties] ([ID]) VALUES (17)
INSERT [dbo].[DateTimeProperties] ([ID]) VALUES (38)
INSERT [dbo].[DateTimeProperties] ([ID]) VALUES (56)
/****** Object:  Table [dbo].[BackReferenceProperties]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BackReferenceProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BackReferenceProperties](
	[ID] [int] NOT NULL,
	[ReferenceObjectClassName] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
	[ReferencePropertyName] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
	[fk_ReferenceProperty] [int] NULL,
	[PreFetchToClient] [bit] NOT NULL,
 CONSTRAINT [PK_BackReferenceProperty] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty], [PreFetchToClient]) VALUES (7, N'Kistl.App.Base.BaseProperty', N'ObjectClass', 8, 1)
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty], [PreFetchToClient]) VALUES (14, N'Kistl.App.Projekte.Task', N'Projekt', 19, 0)
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty], [PreFetchToClient]) VALUES (21, N'Kistl.App.Projekte.Projekt', N'Mitarbeiter', 22, 0)
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty], [PreFetchToClient]) VALUES (27, N'Kistl.App.Base.ObjectClass', N'BaseObjectClass', 25, 0)
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty], [PreFetchToClient]) VALUES (31, N'Kistl.App.Base.Method', N'ObjectClass', 29, 1)
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty], [PreFetchToClient]) VALUES (44, N'Kistl.App.Base.ObjectClass', N'Module', 45, 0)
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty], [PreFetchToClient]) VALUES (58, NULL, NULL, 55, 0)
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty], [PreFetchToClient]) VALUES (66, NULL, NULL, 53, 0)
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty], [PreFetchToClient]) VALUES (67, NULL, NULL, 51, 0)
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty], [PreFetchToClient]) VALUES (80, NULL, NULL, 79, 1)
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty], [PreFetchToClient]) VALUES (81, NULL, NULL, 78, 0)
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty], [PreFetchToClient]) VALUES (82, NULL, NULL, 70, 0)
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty], [PreFetchToClient]) VALUES (96, NULL, NULL, 92, 1)
/****** Object:  Table [dbo].[ObjectForDeletedProperties]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectForDeletedProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ObjectForDeletedProperties](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[test] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[DataType] [nvarchar](100) COLLATE Latin1_General_CI_AS NULL,
	[IsAssociation] [bit] NULL,
	[Namespace] [nvarchar](100) COLLATE Latin1_General_CI_AS NULL,
	[ReferenceObjectClassName] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
	[ReferencePropertyName] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_ObjectForDeletedProperties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Modules]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Modules]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Modules](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Namespace] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[ModuleName] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Module] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Modules] ON
INSERT [dbo].[Modules] ([ID], [Namespace], [ModuleName]) VALUES (1, N'Kistl.App.Base', N'KistlBase')
INSERT [dbo].[Modules] ([ID], [Namespace], [ModuleName]) VALUES (2, N'Kistl.App.Projekte', N'Projekte')
INSERT [dbo].[Modules] ([ID], [Namespace], [ModuleName]) VALUES (3, N'Kistl.App.Zeiterfassung', N'Zeiterfassung')
INSERT [dbo].[Modules] ([ID], [Namespace], [ModuleName]) VALUES (4, N'Kistl.App.GUI', N'GUI')
SET IDENTITY_INSERT [dbo].[Modules] OFF
/****** Object:  Table [dbo].[Auftraege]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Auftraege]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Auftraege](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Mitarbeiter] [int] NULL,
	[Auftragsname] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
	[fk_Projekt] [int] NULL,
	[fk_Kunde] [int] NULL,
	[Auftragswert] [float] NULL,
 CONSTRAINT [PK_Auftrag] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Auftraege] ON
INSERT [dbo].[Auftraege] ([ID], [fk_Mitarbeiter], [Auftragsname], [fk_Projekt], [fk_Kunde], [Auftragswert]) VALUES (1, 1, N'Auftrag für den Businessplan', 2, 1, 10)
INSERT [dbo].[Auftraege] ([ID], [fk_Mitarbeiter], [Auftragsname], [fk_Projekt], [fk_Kunde], [Auftragswert]) VALUES (2, 2, N'Auftrag für Marketingunterlagen', 1, 2, 100)
INSERT [dbo].[Auftraege] ([ID], [fk_Mitarbeiter], [Auftragsname], [fk_Projekt], [fk_Kunde], [Auftragswert]) VALUES (3, 2, N'Kistl Implementierungsprojekt', 1, 1, 100000)
SET IDENTITY_INSERT [dbo].[Auftraege] OFF
/****** Object:  Table [dbo].[Zeitkonten]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Zeitkonten]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Zeitkonten](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kontoname] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[MaxStunden] [float] NULL,
	[AktuelleStunden] [float] NULL,
 CONSTRAINT [PK_Zeitkonto] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Zeitkonten] ON
INSERT [dbo].[Zeitkonten] ([ID], [Kontoname], [MaxStunden], [AktuelleStunden]) VALUES (2, N'Kistlkostenträger', 40, 39.5)
INSERT [dbo].[Zeitkonten] ([ID], [Kontoname], [MaxStunden], [AktuelleStunden]) VALUES (3, N'Urlaube', NULL, 8)
SET IDENTITY_INSERT [dbo].[Zeitkonten] OFF
/****** Object:  Table [dbo].[Kostenstellen]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kostenstellen]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Kostenstellen](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_Kostenstelle] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Kostenstellen] ([ID]) VALUES (3)
/****** Object:  Table [dbo].[Kostentraeger]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kostentraeger]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Kostentraeger](
	[ID] [int] NOT NULL,
	[fk_Projekt] [int] NOT NULL,
 CONSTRAINT [PK_Kostentraeger] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Kostentraeger] ([ID], [fk_Projekt]) VALUES (2, 1)
/****** Object:  Table [dbo].[Mitarbeiter]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mitarbeiter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Mitarbeiter](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) COLLATE Latin1_General_CI_AS NULL,
	[Geburtstag] [datetime] NULL,
	[SVNr] [nvarchar](20) COLLATE Latin1_General_CI_AS NULL,
	[TelefonNummer] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_Mitarbeiter] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Mitarbeiter] ON
INSERT [dbo].[Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (1, N'DI David Schmitt', NULL, NULL, NULL)
INSERT [dbo].[Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (2, N'Arthur Zaczek', NULL, NULL, NULL)
INSERT [dbo].[Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (3, N'Susanne Dobler', NULL, NULL, NULL)
INSERT [dbo].[Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (4, N'Josef Pfleger', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Mitarbeiter] OFF
/****** Object:  Table [dbo].[Projekte]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Projekte]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Projekte](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) COLLATE Latin1_General_CI_AS NULL,
	[AufwandGes] [float] NULL,
	[Kundenname] [nvarchar](100) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_Projekte] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Projekte] ON
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (1, N'Kistl', 20, N'Wir selbst')
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (2, N'Ziviltechniker', 20, NULL)
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (3, N'WebCMS.net V1.0', 0, NULL)
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (4, N'Rechnungswesen', 10, NULL)
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (5, N'Neues Projekt', 100, NULL)
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (6, N'test_abc', 100, NULL)
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (7, N'Neues Objekt', 0, NULL)
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (12, N'Neues Projekt im Context', 103, NULL)
SET IDENTITY_INSERT [dbo].[Projekte] OFF
/****** Object:  Table [dbo].[Properties]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Properties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Properties](
	[ID] [int] NOT NULL,
	[IsNullable] [bit] NOT NULL,
	[IsList] [bit] NOT NULL,
 CONSTRAINT [PK_Properties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (1, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (3, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (8, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (9, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (11, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (13, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (15, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (16, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (17, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (18, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (19, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (20, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (22, 1, 1)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (23, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (25, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (26, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (28, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (29, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (30, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (38, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (39, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (40, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (41, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (42, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (43, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (45, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (46, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (47, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (48, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (49, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (50, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (51, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (52, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (53, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (54, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (55, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (56, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (57, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (59, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (60, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (61, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (62, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (63, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (64, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (65, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (68, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (69, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (70, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (71, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (72, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (73, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (74, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (75, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (76, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (77, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (78, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (79, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (83, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (84, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (85, 1, 1)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (86, 1, 1)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (87, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (88, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (89, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (90, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (91, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (92, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (93, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (94, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (95, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (97, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (98, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (99, 0, 0)
/****** Object:  Table [dbo].[ValueTypeProperties]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ValueTypeProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ValueTypeProperties](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_ValueTypeProperties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (1)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (3)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (9)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (11)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (13)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (15)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (16)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (17)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (18)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (20)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (23)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (26)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (28)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (30)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (35)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (38)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (39)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (40)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (41)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (42)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (43)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (48)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (50)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (52)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (56)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (57)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (59)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (60)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (61)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (62)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (63)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (65)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (68)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (71)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (76)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (77)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (83)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (84)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (85)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (87)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (89)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (90)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (91)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (94)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (95)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (99)
/****** Object:  Table [dbo].[StringProperties]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StringProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StringProperties](
	[ID] [int] NOT NULL,
	[Length] [int] NULL,
 CONSTRAINT [PK_StringProperties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (1, 51)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (3, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (9, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (13, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (15, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (20, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (30, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (39, 20)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (40, 50)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (41, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (42, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (43, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (48, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (50, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (52, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (59, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (60, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (61, 10)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (62, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (63, 50)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (68, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (71, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (76, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (77, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (85, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (87, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (91, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (99, 200)
/****** Object:  Table [dbo].[Kunden]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kunden]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Kunden](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kundenname] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[Adresse] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
	[PLZ] [nvarchar](10) COLLATE Latin1_General_CI_AS NOT NULL,
	[Ort] [nvarchar](100) COLLATE Latin1_General_CI_AS NULL,
	[Land] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_Kunde] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Kunden] ON
INSERT [dbo].[Kunden] ([ID], [Kundenname], [Adresse], [PLZ], [Ort], [Land]) VALUES (1, N'Accent2', N'Kremserstraße 1', N'2000', N'Krems', N'AT')
INSERT [dbo].[Kunden] ([ID], [Kundenname], [Adresse], [PLZ], [Ort], [Land]) VALUES (2, N'Susanne Dobler', N'Leopoldgasse', N'3400', N'Klosterneuburg', N'AT')
INSERT [dbo].[Kunden] ([ID], [Kundenname], [Adresse], [PLZ], [Ort], [Land]) VALUES (3, N'Bernhard', N'Bernhardstraße 1', N'1190', N'Wien', N'AT')
SET IDENTITY_INSERT [dbo].[Kunden] OFF
/****** Object:  Table [dbo].[Icons]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Icons]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Icons](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IconFile] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Icon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Icons] ON
INSERT [dbo].[Icons] ([ID], [IconFile]) VALUES (1, N'app.ico')
INSERT [dbo].[Icons] ([ID], [IconFile]) VALUES (2, N'Code_ClassCS.ico')
INSERT [dbo].[Icons] ([ID], [IconFile]) VALUES (3, N'VSProject_genericproject.ico')
INSERT [dbo].[Icons] ([ID], [IconFile]) VALUES (4, N'Resource_Bitmap.ico')
INSERT [dbo].[Icons] ([ID], [IconFile]) VALUES (5, N'user.ico')
INSERT [dbo].[Icons] ([ID], [IconFile]) VALUES (6, N'users.ico')
INSERT [dbo].[Icons] ([ID], [IconFile]) VALUES (7, N'propertiesORoptions.ico')
INSERT [dbo].[Icons] ([ID], [IconFile]) VALUES (8, N'UtilityText.ico')
INSERT [dbo].[Icons] ([ID], [IconFile]) VALUES (9, N'otheroptions.ico')
INSERT [dbo].[Icons] ([ID], [IconFile]) VALUES (10, N'cab.ico')
INSERT [dbo].[Icons] ([ID], [IconFile]) VALUES (11, N'Code_Component.ico')
INSERT [dbo].[Icons] ([ID], [IconFile]) VALUES (12, N'document.ico')
INSERT [dbo].[Icons] ([ID], [IconFile]) VALUES (13, N'idr_dll.ico')
SET IDENTITY_INSERT [dbo].[Icons] OFF
/****** Object:  Table [dbo].[Assemblies]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Assemblies]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Assemblies](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Module] [int] NOT NULL,
	[AssemblyName] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[IsClientAssembly] [bit] NOT NULL,
 CONSTRAINT [PK_Assembly] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Assemblies] ON
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly]) VALUES (1, 1, N'Kistl.App.Projekte.Client', 1)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly]) VALUES (2, 1, N'Kistl.App.Projekte.Server', 0)
SET IDENTITY_INSERT [dbo].[Assemblies] OFF
/****** Object:  Table [dbo].[MethodInvocations]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MethodInvocations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MethodInvocations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Method] [int] NOT NULL,
	[fk_Assembly] [int] NOT NULL,
	[FullTypeName] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[MemberName] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[fk_Module] [int] NOT NULL,
	[fk_InvokeOnObjectClass] [int] NOT NULL,
 CONSTRAINT [PK_MethodInvocation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[MethodInvocations] ON
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (1, 8, 1, N'Kistl.App.Projekte.CustomClientActions_Projekte', N'OnToString_Projekt', 2, 3)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (2, 17, 1, N'Kistl.App.Projekte.CustomClientActions_Projekte', N'OnToString_Mitarbeiter', 2, 6)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (4, 11, 1, N'Kistl.App.Projekte.CustomClientActions_Projekte', N'OnToString_Task', 2, 4)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (5, 5, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnToString_ObjectClass', 1, 2)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (6, 44, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnToString_MethodInvokation', 1, 30)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (8, 14, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnToString_BaseProperty', 1, 5)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (9, 20, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnToString_Method', 1, 10)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (10, 23, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnToString_Module', 1, 18)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (11, 26, 1, N'Kistl.App.Projekte.CustomClientActions_Projekte', N'OnToString_Auftrag', 2, 19)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (12, 29, 1, N'Kistl.App.Zeiterfassung.CustomClientActions_Zeiterfassung', N'OnToString_Zeitkonto', 3, 20)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (13, 32, 1, N'Kistl.App.Zeiterfassung.CustomClientActions_Zeiterfassung', N'OnToString_Taetigkeit', 3, 25)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (14, 35, 1, N'Kistl.App.Projekte.CustomClientActions_Projekte', N'OnToString_Kunde', 2, 26)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (15, 38, 1, N'Kistl.App.GUI.CustomClientActions_GUI', N'OnToString_Icon', 4, 27)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (16, 41, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnToString_Assembly', 1, 29)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (17, 14, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnToString_ObjectReferenceProperty', 1, 14)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (18, 14, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnToString_BackReferenceProperty', 1, 16)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (19, 3, 1, N'Kistl.App.Projekte.CustomClientActions_Projekte', N'OnRechnungErstellen_Auftrag', 2, 19)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (20, 1, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnGetDataType_StringProperty', 1, 9)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (21, 1, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnGetDataType_IntProperty', 1, 11)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (22, 1, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnGetDataType_BoolProperty', 1, 12)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (23, 1, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnGetDataType_DoubleProperty', 1, 13)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (24, 1, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnGetDataType_DateTimeProperty', 1, 15)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (25, 1, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnGetDataType_BaseProperty', 1, 5)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (26, 1, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnGetDataType_ObjectReferenceProperty', 1, 14)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (27, 1, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnGetDataType_BackReferenceProperty', 1, 16)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (28, 6, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnPreSave_ObjectClass', 1, 2)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (29, 9, 2, N'Kistl.App.Projekte.CustomServerActions_Projekte', N'OnPreSetObject_Projekt', 2, 3)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (30, 12, 2, N'Kistl.App.Projekte.CustomServerActions_Projekte', N'OnPreSetObject_Task', 2, 4)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (31, 1, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnGetDataType_StringProperty', 1, 9)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (32, 1, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnGetDataType_IntProperty', 1, 11)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (33, 1, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnGetDataType_BoolProperty', 1, 12)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (34, 1, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnGetDataType_DoubleProperty', 1, 13)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (35, 1, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnGetDataType_DateTimeProperty', 1, 15)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (36, 1, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnGetDataType_BaseProperty', 1, 5)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (37, 1, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnGetDataType_ObjectReferenceProperty', 1, 14)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (38, 1, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnGetDataType_BackReferenceProperty', 1, 16)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (40, 46, 1, N'Kistl.App.GUI.CustomClientActions_GUI', N'OnGetGUIRepresentation_BaseProperty', 4, 5)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (41, 46, 1, N'Kistl.App.GUI.CustomClientActions_GUI', N'OnGetGUIRepresentation_BoolProperty', 4, 12)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (42, 46, 1, N'Kistl.App.GUI.CustomClientActions_GUI', N'OnGetGUIRepresentation_ObjectReferenceProperty', 4, 14)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (43, 46, 1, N'Kistl.App.GUI.CustomClientActions_GUI', N'OnGetGUIRepresentation_DateTimeProperty', 4, 15)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (44, 71, 1, N'Kistl.App.Zeiterfassung.CustomClientActions_Zeiterfassung', N'OnToString_TaetigkeitsArt', 3, 31)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (45, 30, 2, N'Kistl.App.Zeiterfassung.CustomServerActions_Zeiterfassung', N'OnPreSave_Zeitkonto', 3, 20)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (46, 33, 2, N'Kistl.App.Zeiterfassung.CustomServerActions_Zeiterfassung', N'OnPreSave_Taetigkeit', 3, 25)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (47, 82, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnGetDataType_StringParameter', 1, 37)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (48, 82, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnGetDataType_IntParameter', 1, 38)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (49, 80, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnToString_BaseParameter', 1, 36)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (50, 82, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnGetDataType_StringParameter', 1, 37)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (51, 82, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnGetDataType_IntParameter', 1, 38)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (52, 82, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnGetDataType_DoubleParameter', 1, 39)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (53, 82, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnGetDataType_DoubleParameter', 1, 39)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (54, 82, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnGetDataType_DateTimeParameter', 1, 41)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (55, 82, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnGetDataType_BoolParameter', 1, 40)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (56, 82, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnGetDataType_BoolParameter', 1, 40)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (57, 82, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnGetDataType_DateTimeParameter', 1, 41)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (58, 82, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnGetDataType_ObjectParameter', 1, 42)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (59, 82, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnGetDataType_ObjectParameter', 1, 42)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (60, 82, 1, N'Kistl.App.Base.CustomClientActions_KistlBase', N'OnGetDataType_CLRObjectParameter', 1, 43)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [fk_Assembly], [FullTypeName], [MemberName], [fk_Module], [fk_InvokeOnObjectClass]) VALUES (61, 82, 2, N'Kistl.App.Base.CustomServerActions_KistlBase', N'OnGetDataType_CLRObjectParameter', 1, 43)
SET IDENTITY_INSERT [dbo].[MethodInvocations] OFF
/****** Object:  Table [dbo].[Projekte_MitarbeiterCollection]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Projekte_MitarbeiterCollection]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Projekte_MitarbeiterCollection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Projekt] [int] NOT NULL,
	[fk_Mitarbeiter] [int] NULL,
 CONSTRAINT [PK_Projekte_MitarbeiterCollection] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Projekte_MitarbeiterCollection] ON
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter]) VALUES (2, 1, 3)
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter]) VALUES (3, 1, 2)
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter]) VALUES (4, 1, 1)
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter]) VALUES (6, 4, 3)
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter]) VALUES (7, 4, 1)
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter]) VALUES (8, 4, 2)
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter]) VALUES (9, 3, 3)
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter]) VALUES (10, 7, 2)
SET IDENTITY_INSERT [dbo].[Projekte_MitarbeiterCollection] OFF
/****** Object:  UserDefinedFunction [dbo].[fn_ColumnExists]    Script Date: 03/20/2008 18:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_ColumnExists]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE function [dbo].[fn_ColumnExists] (@table nvarchar(500), @column nvarchar(500)) 
returns bit
begin
declare @result int
SELECT @result = count(*) FROM sys.objects o inner join sys.columns c on c.object_id=o.object_id
	WHERE o.object_id = OBJECT_ID(@table) 
		AND o.type in (N''U'')
		AND c.Name = @column
return convert(bit, @result)
end

' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[fn_TableExists]    Script Date: 03/20/2008 18:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_TableExists]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE function [dbo].[fn_TableExists] (@table nvarchar(500)) returns bit
begin
declare @result int
SELECT @result = count(*) FROM sys.objects 
	WHERE object_id = OBJECT_ID(@table) AND type in (N''U'')
return convert(bit, @result)
end

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckObjectClass]    Script Date: 03/20/2008 18:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CheckObjectClass]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[sp_CheckObjectClass]
	(@namespace nvarchar(100)
	,@classname nvarchar(50)
	,@tablename nvarchar(50)
	)  
as
IF NOT EXISTS (select * from dbo.ObjectClasses where 
	[Namespace] = @namespace and [ClassName] = @classname)
BEGIN
	PRINT N''Inserting '' + @namespace + ''.'' + @classname + '' Class''
	INSERT INTO [dbo].[ObjectClasses]
			   ([ClassName]
				,[Namespace]
				,[TableName])
		 VALUES
			   (''ObjectClass''
				,@namespace
				,@tablename)
END
ELSE
BEGIN
	PRINT ''Updateing Kistl.App.Base.ObjectClass Class''
	UPDATE dbo.ObjectClasses SET 
		[TableName] = @tablename
	WHERE [Namespace] = @namespace and [ClassName] = @classname
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckObjectProperty]    Script Date: 03/20/2008 18:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CheckObjectProperty]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[sp_CheckObjectProperty]
	(@namespace nvarchar(100)
	,@classname nvarchar(50)
	,@propertyname nvarchar(50)
	,@datatype nvarchar(150)
	,@IsList bit
	,@IsAssociation bit
	)
as
declare @fk_ObjClass int

select @fk_ObjClass = [ID] from dbo.ObjectClasses where 
	[Namespace] = @namespace and [ClassName] = @classname

IF NOT EXISTS (select * from dbo.ObjectProperties where 
	[fk_ObjectClass] = @fk_ObjClass and [PropertyName] = @propertyname)
BEGIN
	PRINT N''Inserting '' + @namespace + N''.'' + @classname + N''.'' + @propertyname + N'' Property''
	INSERT INTO [dbo].[ObjectProperties]
			([fk_ObjectClass], [PropertyName], [DataType], [IsList], [IsAssociation])
     VALUES (@fk_ObjClass, @propertyname, @datatype, @IsList, @IsAssociation)
END
ELSE
BEGIN
	PRINT N''Updateting '' + @namespace + N''.'' + @classname + N''.'' + @propertyname + N'' Property''
	UPDATE [dbo].[ObjectProperties]
			SET [DataType] = @datatype, [IsList] = @IsList, [IsAssociation] = @IsAssociation
     WHERE [fk_ObjectClass] = @fk_ObjClass and [PropertyName] = @propertyname
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DropObjectProperty]    Script Date: 03/20/2008 18:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_DropObjectProperty]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create procedure [dbo].[sp_DropObjectProperty]
	(@namespace nvarchar(100)
	,@classname nvarchar(50)
	,@propertyname nvarchar(50)
	)
as
declare @fk_ObjClass int

select @fk_ObjClass = [ID] from dbo.ObjectClasses where 
	[Namespace] = @namespace and [ClassName] = @classname

IF EXISTS (select * from dbo.ObjectProperties where 
	[fk_ObjectClass] = @fk_ObjClass and [PropertyName] = @propertyname)
BEGIN
	PRINT N''Dropping '' + @namespace + N''.'' + @classname + N''.'' + @propertyname + N'' Property''
	delete from [dbo].[ObjectProperties]
     WHERE [fk_ObjectClass] = @fk_ObjClass and [PropertyName] = @propertyname
END

' 
END
GO
/****** Object:  Table [dbo].[DataTypes]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DataTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DataTypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [nvarchar](51) COLLATE Latin1_General_CI_AS NOT NULL,
	[fk_DefaultIcon] [int] NULL,
	[fk_Module] [int] NOT NULL,
 CONSTRAINT [PK_DataTypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[DataTypes] ON
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (2, N'ObjectClass', 11, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (3, N'Projekt', 3, 2)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (4, N'Task', 7, 2)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (5, N'BaseProperty', 9, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (6, N'Mitarbeiter', 5, 2)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (7, N'Property', 9, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (8, N'ValueTypeProperty', 9, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (9, N'StringProperty', 9, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (10, N'Method', 2, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (11, N'IntProperty', 9, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (12, N'BoolProperty', 9, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (13, N'DoubleProperty', 9, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (14, N'ObjectReferenceProperty', 9, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (15, N'DateTimeProperty', 9, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (16, N'BackReferenceProperty', 9, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (18, N'Module', 1, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (19, N'Auftrag', 8, 2)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (20, N'Zeitkonto', 12, 3)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (21, N'Kostenstelle', 10, 3)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (23, N'Kostentraeger', 3, 3)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (25, N'Taetigkeit', 7, 3)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (26, N'Kunde', 6, 2)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (27, N'Icon', 4, 4)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (29, N'Assembly', 13, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (30, N'MethodInvocation', 2, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (31, N'TaetigkeitsArt', 8, 3)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (33, N'DataType', 11, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (36, N'BaseParameter', 12, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (37, N'StringParameter', 12, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (38, N'IntParameter', 12, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (39, N'DoubleParameter', 12, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (40, N'BoolParameter', 12, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (41, N'DateTimeParameter', 12, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (42, N'ObjectParameter', 12, 1)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module]) VALUES (43, N'CLRObjectParameter', 12, 1)
SET IDENTITY_INSERT [dbo].[DataTypes] OFF
/****** Object:  Table [dbo].[ObjectClasses]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectClasses]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ObjectClasses](
	[ID] [int] NOT NULL,
	[TableName] [nvarchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
	[fk_BaseObjectClass] [int] NULL,
 CONSTRAINT [PK_ObjectClasses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (2, N'ObjectClasses', 33)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (3, N'Projekte', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (4, N'Tasks', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (5, N'BaseProperties', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (6, N'Mitarbeiter', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (7, N'Properties', 5)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (8, N'ValueTypeProperties', 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (9, N'StringProperties', 8)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (10, N'Methods', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (11, N'IntProperties', 8)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (12, N'BoolProperties', 8)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (13, N'DoubleProperties', 8)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (14, N'ObjectReferenceProperties', 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (15, N'DateTimeProperties', 8)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (16, N'BackReferenceProperties', 5)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (18, N'Modules', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (19, N'Auftraege', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (20, N'Zeitkonten', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (21, N'Kostenstellen', 20)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (23, N'Kostentraeger', 20)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (25, N'Taetigkeiten', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (26, N'Kunden', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (27, N'Icons', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (29, N'Assemblies', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (30, N'MethodInvocations', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (31, N'TaetigkeitsArten', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (33, N'DataTypes', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (36, N'BaseParameters', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (37, N'StringParameters', 36)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (38, N'IntParameters', 36)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (39, N'DoubleParameters', 36)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (40, N'BoolParameters', 36)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (41, N'DateTimeParameters', 36)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (42, N'ObjectParameters', 36)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass]) VALUES (43, N'CLRObjectParameters', 36)
/****** Object:  Table [dbo].[BaseParameters]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BaseParameters]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BaseParameters](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ParameterName] [nvarchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
	[fk_Method] [int] NOT NULL,
	[fk_Module] [int] NOT NULL,
	[IsList] [bit] NOT NULL,
	[IsReturnParameter] [bit] NOT NULL,
 CONSTRAINT [PK_BaseParameters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[BaseParameters] ON
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Module], [IsList], [IsReturnParameter]) VALUES (1, N'TestString', 83, 2, 0, 0)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Module], [IsList], [IsReturnParameter]) VALUES (2, N'TestInt', 83, 2, 0, 0)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Module], [IsList], [IsReturnParameter]) VALUES (3, N'ReturnParameter', 1, 1, 0, 1)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Module], [IsList], [IsReturnParameter]) VALUES (4, N'ReturnParameter', 46, 1, 0, 1)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Module], [IsList], [IsReturnParameter]) VALUES (5, N'ReturnParameter', 82, 1, 0, 1)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Module], [IsList], [IsReturnParameter]) VALUES (6, N'TestDouble', 83, 2, 0, 0)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Module], [IsList], [IsReturnParameter]) VALUES (7, N'TestBool', 83, 2, 0, 0)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Module], [IsList], [IsReturnParameter]) VALUES (8, N'TestDateTime', 83, 2, 0, 0)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Module], [IsList], [IsReturnParameter]) VALUES (9, N'TestDateTimeReturn', 83, 2, 0, 1)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Module], [IsList], [IsReturnParameter]) VALUES (10, N'TestObjectParameter', 83, 2, 0, 0)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Module], [IsList], [IsReturnParameter]) VALUES (11, N'TestCLRObjectParameter', 83, 2, 0, 0)
SET IDENTITY_INSERT [dbo].[BaseParameters] OFF
/****** Object:  Table [dbo].[StringParameters]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StringParameters]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StringParameters](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_StringParameters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[StringParameters] ([ID]) VALUES (1)
INSERT [dbo].[StringParameters] ([ID]) VALUES (3)
INSERT [dbo].[StringParameters] ([ID]) VALUES (4)
INSERT [dbo].[StringParameters] ([ID]) VALUES (5)
/****** Object:  Table [dbo].[IntParameters]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntParameters]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[IntParameters](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_IntParameters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[IntParameters] ([ID]) VALUES (2)
/****** Object:  Table [dbo].[DoubleParameters]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DoubleParameters]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DoubleParameters](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_DoubleParameters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[DoubleParameters] ([ID]) VALUES (6)
/****** Object:  Table [dbo].[BoolParameters]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BoolParameters]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BoolParameters](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_BoolParameters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[BoolParameters] ([ID]) VALUES (7)
/****** Object:  Table [dbo].[DateTimeParameters]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DateTimeParameters]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DateTimeParameters](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_DateTimeParameters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[DateTimeParameters] ([ID]) VALUES (8)
INSERT [dbo].[DateTimeParameters] ([ID]) VALUES (9)
/****** Object:  Table [dbo].[ObjectParameters]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectParameters]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ObjectParameters](
	[ID] [int] NOT NULL,
	[fk_DataType] [int] NOT NULL,
 CONSTRAINT [PK_ObjectParameters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[ObjectParameters] ([ID], [fk_DataType]) VALUES (10, 19)
/****** Object:  Table [dbo].[CLRObjectParameters]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLRObjectParameters]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CLRObjectParameters](
	[ID] [int] NOT NULL,
	[fk_Assembly] [int] NULL,
	[FullTypeName] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_CLRObjectParameters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[CLRObjectParameters] ([ID], [fk_Assembly], [FullTypeName]) VALUES (11, NULL, N'System.Guid')
/****** Object:  Table [dbo].[Taetigkeiten]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Taetigkeiten]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Taetigkeiten](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Mitarbeiter] [int] NOT NULL,
	[fk_Zeitkonto] [int] NOT NULL,
	[Datum] [datetime] NOT NULL,
	[Dauer] [float] NOT NULL,
	[fk_TaetigkeitsArt] [int] NULL,
 CONSTRAINT [PK_Taetigkeit] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Taetigkeiten] ON
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer], [fk_TaetigkeitsArt]) VALUES (1, 2, 2, CAST(0x00009A1E00000000 AS DateTime), 6.5, 1)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer], [fk_TaetigkeitsArt]) VALUES (2, 1, 2, CAST(0x00009A1F00000000 AS DateTime), 4, NULL)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer], [fk_TaetigkeitsArt]) VALUES (5, 2, 2, CAST(0x00009A1C00000000 AS DateTime), 1, NULL)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer], [fk_TaetigkeitsArt]) VALUES (6, 2, 2, CAST(0x00009A1F00000000 AS DateTime), 1, NULL)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer], [fk_TaetigkeitsArt]) VALUES (8, 2, 2, CAST(0x00009A1F00000000 AS DateTime), 1, NULL)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer], [fk_TaetigkeitsArt]) VALUES (9, 2, 2, CAST(0x00009A1F00000000 AS DateTime), 1.5, NULL)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer], [fk_TaetigkeitsArt]) VALUES (10, 2, 2, CAST(0x00009A1F00000000 AS DateTime), 2.5, NULL)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer], [fk_TaetigkeitsArt]) VALUES (11, 2, 2, CAST(0x00009A1600000000 AS DateTime), 2, NULL)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer], [fk_TaetigkeitsArt]) VALUES (12, 2, 2, CAST(0x00009A1600000000 AS DateTime), 3, NULL)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer], [fk_TaetigkeitsArt]) VALUES (13, 3, 2, CAST(0x00009A1600000000 AS DateTime), 3, NULL)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer], [fk_TaetigkeitsArt]) VALUES (14, 2, 2, CAST(0x00009A1600000000 AS DateTime), 10, 1)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer], [fk_TaetigkeitsArt]) VALUES (15, 2, 2, CAST(0x00009A5F00000000 AS DateTime), 2, 3)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer], [fk_TaetigkeitsArt]) VALUES (16, 3, 3, CAST(0x00009A1600000000 AS DateTime), 8, NULL)
SET IDENTITY_INSERT [dbo].[Taetigkeiten] OFF
/****** Object:  Table [dbo].[Zeitkonten_MitarbeiterCollection]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Zeitkonten_MitarbeiterCollection]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Zeitkonten_MitarbeiterCollection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Zeitkonto] [int] NOT NULL,
	[fk_Mitarbeiter] [int] NULL,
 CONSTRAINT [PK_Zeitkonten_MitarbeiterCollection] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Zeitkonten_MitarbeiterCollection] ON
INSERT [dbo].[Zeitkonten_MitarbeiterCollection] ([ID], [fk_Zeitkonto], [fk_Mitarbeiter]) VALUES (3, 3, 3)
INSERT [dbo].[Zeitkonten_MitarbeiterCollection] ([ID], [fk_Zeitkonto], [fk_Mitarbeiter]) VALUES (4, 3, 4)
INSERT [dbo].[Zeitkonten_MitarbeiterCollection] ([ID], [fk_Zeitkonto], [fk_Mitarbeiter]) VALUES (5, 2, 2)
INSERT [dbo].[Zeitkonten_MitarbeiterCollection] ([ID], [fk_Zeitkonto], [fk_Mitarbeiter]) VALUES (6, 2, 1)
INSERT [dbo].[Zeitkonten_MitarbeiterCollection] ([ID], [fk_Zeitkonto], [fk_Mitarbeiter]) VALUES (14, 2, 4)
INSERT [dbo].[Zeitkonten_MitarbeiterCollection] ([ID], [fk_Zeitkonto], [fk_Mitarbeiter]) VALUES (15, 2, 3)
SET IDENTITY_INSERT [dbo].[Zeitkonten_MitarbeiterCollection] OFF
/****** Object:  Table [dbo].[Tasks]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tasks]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tasks](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) COLLATE Latin1_General_CI_AS NULL,
	[DatumVon] [datetime] NULL,
	[DatumBis] [datetime] NULL,
	[Aufwand] [float] NULL,
	[fk_Projekt] [int] NULL,
 CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Tasks] ON
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (1, N'Planung Ziviltechniker', CAST(0x000098A900000000 AS DateTime), CAST(0x000098C800000000 AS DateTime), 10, 2)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (2, N'Umsetzung Ziviltechniker', CAST(0x000098A900000000 AS DateTime), CAST(0x000098C800000000 AS DateTime), 10, 2)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (3, N'Planung Kistl', CAST(0x0000988F00000000 AS DateTime), CAST(0x000098E400000000 AS DateTime), 10, 1)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (5, N'Ein Test2', CAST(0x0000901A00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), 10, 1)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (7, N'Neue Aufgabe', CAST(0x000098A900000000 AS DateTime), CAST(0x000098E400000000 AS DateTime), 10, 6)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (8, N'Zweite Aufgabe', CAST(0x000098A900000000 AS DateTime), CAST(0x000098AC00000000 AS DateTime), 10, 6)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (9, N'Buchhaltungsprogramm schreiben', NULL, NULL, 10, 4)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (10, N'Neuer Task', CAST(0x00009A0400000000 AS DateTime), CAST(0x00009A0500000000 AS DateTime), 1, 12)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (11, N'test', NULL, NULL, 1, 12)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (12, N'test2', NULL, NULL, 101, 12)
SET IDENTITY_INSERT [dbo].[Tasks] OFF
/****** Object:  Table [dbo].[Methods]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Methods]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Methods](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_ObjectClass] [int] NULL,
	[MethodName] [nvarchar](100) COLLATE Latin1_General_CI_AS NULL,
	[fk_Module] [int] NOT NULL
)
END
GO
SET IDENTITY_INSERT [dbo].[Methods] ON
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (1, 5, N'GetDataType', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (3, 19, N'RechnungErstellen', 2)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (4, 2, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (5, 2, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (6, 2, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (7, 3, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (8, 3, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (9, 3, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (10, 4, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (11, 4, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (12, 4, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (13, 5, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (14, 5, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (15, 5, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (16, 6, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (17, 6, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (18, 6, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (19, 10, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (20, 10, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (21, 10, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (22, 18, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (23, 18, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (24, 18, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (25, 19, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (26, 19, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (27, 19, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (28, 20, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (29, 20, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (30, 20, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (31, 25, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (32, 25, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (33, 25, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (34, 26, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (35, 26, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (36, 26, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (37, 27, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (38, 27, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (39, 27, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (40, 29, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (41, 29, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (42, 29, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (43, 30, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (44, 30, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (45, 30, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (46, 5, N'GetGUIRepresentation', 4)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (71, 31, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (72, 31, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (73, 31, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (74, 33, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (75, 33, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (76, 33, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (79, 36, N'PreSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (80, 36, N'ToString', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (81, 36, N'PostSave', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (82, 36, N'GetDataType', 1)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module]) VALUES (83, 6, N'TestMethodForParameter', 2)
SET IDENTITY_INSERT [dbo].[Methods] OFF
/****** Object:  Table [dbo].[BaseProperties]    Script Date: 03/20/2008 18:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BaseProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BaseProperties](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_ObjectClass] [int] NOT NULL,
	[PropertyName] [nvarchar](100) COLLATE Latin1_General_CI_AS NULL,
	[AltText] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
	[fk_Module] [int] NOT NULL,
 CONSTRAINT [PK_ObjectProperties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[BaseProperties] ON
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (1, 33, N'ClassName', N'Der Name der Objektklasse', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (3, 2, N'TableName', N'Tabellenname in der Datenbank', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (7, 33, N'Properties', N'Eigenschaften der Objektklasse', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (8, 5, N'ObjectClass', NULL, 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (9, 5, N'PropertyName', NULL, 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (11, 7, N'IsList', NULL, 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (13, 3, N'Name', N'Projektname', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (14, 3, N'Tasks', NULL, 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (15, 4, N'Name', N'Taskname', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (16, 4, N'DatumVon', N'Start Datum', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (17, 4, N'DatumBis', N'Enddatum', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (18, 4, N'Aufwand', N'Aufwand in Stunden', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (19, 4, N'Projekt', N'Verknüpfung zum Projekt', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (20, 6, N'Name', N'Vorname Nachname', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (21, 6, N'Projekte', N'Projekte des Mitarbeiters für die er Verantwortlich ist', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (22, 3, N'Mitarbeiter', NULL, 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (23, 3, N'AufwandGes', NULL, 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (25, 2, N'BaseObjectClass', N'Pointer auf die Basisklasse', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (26, 7, N'IsNullable', NULL, 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (27, 2, N'SubClasses', N'Liste der vererbten Klassen', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (28, 9, N'Length', NULL, 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (29, 10, N'ObjectClass', NULL, 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (30, 10, N'MethodName', NULL, 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (31, 33, N'Methods', N'Liste aller Methoden der Objektklasse.', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (38, 6, N'Geburtstag', N'Herzlichen Glückwunsch zum Geburtstag', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (39, 6, N'SVNr', N'NNNN TTMMYY', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (40, 6, N'TelefonNummer', N'+43 123 12345678', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (41, 5, N'AltText', NULL, 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (42, 18, N'Namespace', N'CLR Namespace des Moduls', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (43, 18, N'ModuleName', N'Name des Moduls', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (44, 18, N'DataTypes', N'Datentypendes Modules', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (45, 33, N'Module', N'Modul der Objektklasse', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (46, 14, N'ReferenceObjectClass', N'Pointer zur Objektklasse', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (47, 16, N'ReferenceProperty', N'Das Property, welches auf diese Klasse zeigt', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (48, 3, N'Kundenname', N'Bitte geben Sie den Kundennamen ein', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (49, 19, N'Mitarbeiter', NULL, 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (50, 19, N'Auftragsname', N'Bitte füllen Sie einen sprechenden Auftragsnamen aus', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (51, 19, N'Projekt', N'Projekt zum Auftrag', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (52, 20, N'Kontoname', N'Name des Zeiterfassungskontos', 3)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (53, 23, N'Projekt', N'Projekt des Kostenträgers', 3)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (54, 25, N'Mitarbeiter', N'Mitarbeiter', 3)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (55, 25, N'Zeitkonto', N'Zeitkonto', 3)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (56, 25, N'Datum', N'Datum', 3)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (57, 25, N'Dauer', N'Dauer in Stunden', 3)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (58, 20, N'Taetigkeiten', N'Tätigkeiten', 3)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (59, 26, N'Kundenname', N'Name des Kunden', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (60, 26, N'Adresse', N'Adresse & Hausnummer', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (61, 26, N'PLZ', N'Postleitzahl', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (62, 26, N'Ort', N'Ort', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (63, 26, N'Land', N'Land', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (64, 19, N'Kunde', N'Kunde des Projektes', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (65, 19, N'Auftragswert', N'Wert in EUR des Auftrages', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (66, 3, N'Kostentraeger', N'Kostenträger', 3)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (67, 3, N'Auftraege', N'Aufträge', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (68, 27, N'IconFile', N'Filename of the Icon', 4)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (69, 33, N'DefaultIcon', N'Standard Icon wenn IIcon nicht implementiert ist', 4)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (70, 29, N'Module', N'Module', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (71, 29, N'AssemblyName', N'Full Assemblyname eg. MyActions, Version=1.0.0.0', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (72, 5, N'Module', N'Zugehörig zum Modul', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (73, 10, N'Module', N'Zugehörig zum Modul', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (74, 30, N'Method', N'Methode, die Aufgerufen wird', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (75, 30, N'Assembly', N'Assembly, dass die Methode beinhaltet', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (76, 30, N'FullTypeName', N'Voller Name des .NET Types des implementierenden Members', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (77, 30, N'MemberName', N'Name des implementierenden Members', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (78, 30, N'Module', N'Zugehörig zum Modul', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (79, 30, N'InvokeOnObjectClass', N'In dieser Objektklasse implementieren', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (80, 33, N'MethodIvokations', N'Methodenaufrufe implementiert in dieser Objekt Klasse', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (81, 10, N'MethodIvokations', N'Methodenaufrufe implementiert in dieser Objekt Klasse', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (82, 18, N'Assemblies', N'Assemblies des Moduls', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (83, 29, N'IsClientAssembly', N'Legt fest, ob es sich um ein Client-Assembly handelt.', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (84, 16, N'PreFetchToClient', N'Serialisierung der Liste zum Client', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (85, 26, N'EMails', N'EMails des Kunden - können mehrere sein', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (86, 20, N'Mitarbeiter', N'Zugeordnete Mitarbeiter', 3)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (87, 31, N'Name', N'Name der Tätigkeitsart', 3)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (88, 25, N'TaetigkeitsArt', N'Art der Tätigkeit', 3)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (89, 20, N'MaxStunden', N'Maximal erlaubte Stundenanzahl', 3)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (90, 20, N'AktuelleStunden', N'Aktuell gebuchte Stunden', 3)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (91, 36, N'ParameterName', N'Name des Parameter', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (92, 36, N'Method', N'Methode des Parameters', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (93, 36, N'Module', N'Module', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (94, 36, N'IsList', N'Parameter wird als List<> generiert', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (95, 36, N'IsReturnParameter', N'Es darf nur ein Return Parameter angegeben werden', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (96, 10, N'Parameter', N'Parameter der Methode', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (97, 42, N'DataType', N'Kistl-Typ des Parameters', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (98, 43, N'Assembly', N'Assembly des CLR Objektes, NULL für Default Assemblies', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (99, 43, N'FullTypeName', N'Name des CLR Datentypen', 1)
SET IDENTITY_INSERT [dbo].[BaseProperties] OFF
/****** Object:  StoredProcedure [dbo].[sp_CheckBaseTables]    Script Date: 03/20/2008 18:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CheckBaseTables]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[sp_CheckBaseTables] as

/******************* Create Tables if they dont exist *******************/
IF dbo.fn_TableExists(N''[dbo].[ObjectClasses]'') = 0
BEGIN
PRINT ''Creating table [ObjectClasses]''
CREATE TABLE [dbo].[ObjectClasses] (
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [nvarchar](50) NOT NULL,
	[Namespace] nvarchar(100) not null,
	[TableName] nvarchar(50) not null,
	CONSTRAINT [PK_ObjectClasses] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)
) 
END

IF dbo.fn_TableExists(N''[dbo].[ObjectProperties]'') = 0
BEGIN
PRINT ''Creating table [ObjectProperties]''
CREATE TABLE [dbo].[ObjectProperties] (
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_ObjectClass] [int] NOT NULL,
	[PropertyName] [nvarchar](50) NOT NULL,
	[DataType] [nvarchar](150) NOT NULL,
	[IsList] [bit] NOT NULL default(0),
	[IsAssociation] [bit] NOT NULL default(0),
	CONSTRAINT [PK_ObjectProperties] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)
)
END

/******************* Check each Column *******************/
/******************* Only missing Columns are supported yet *******************/
IF dbo.fn_ColumnExists(N''[dbo].[ObjectClasses]'', N''ID'') = 0
BEGIN
	PRINT ''Adding Column [ObjectClasses].[ID]''
	alter table [dbo].[ObjectClasses] add
		[ID] [int] IDENTITY(1,1) NOT NULL,
		CONSTRAINT [PK_ObjectClasses] PRIMARY KEY CLUSTERED 
		(
			[ID] ASC
		)	
END

IF dbo.fn_ColumnExists(N''[dbo].[ObjectClasses]'', N''ClassName'') = 0
BEGIN
	PRINT ''Adding Column [ObjectClasses].[ClassName]''
	alter table [dbo].[ObjectClasses] add
		[ClassName] [nvarchar](50) NOT NULL
END

IF dbo.fn_ColumnExists(N''[dbo].[ObjectClasses]'', N''ServerObject'') = 1
BEGIN
	PRINT ''Dropping Column [ObjectClasses].[ServerObject]''
	alter table [dbo].[ObjectClasses] drop column
		[ServerObject]
END

IF dbo.fn_ColumnExists(N''[dbo].[ObjectClasses]'', N''ClientObject'') = 1
BEGIN
	PRINT ''Dropping Column [ObjectClasses].[ClientObject]''
	alter table [dbo].[ObjectClasses] drop column
		[ClientObject]
END

IF dbo.fn_ColumnExists(N''[dbo].[ObjectClasses]'', N''DataObject'') = 1
BEGIN
	PRINT ''Dropping Column [ObjectClasses].[DataObject]''
	alter table [dbo].[ObjectClasses] drop column
		[DataObject]
END

IF dbo.fn_ColumnExists(N''[dbo].[ObjectClasses]'', N''Namespace'') = 0
BEGIN
	PRINT ''Adding Column [ObjectClasses].[Namespace]''
	alter table [dbo].[ObjectClasses] add
		[Namespace] nvarchar(100) not null
END

IF dbo.fn_ColumnExists(N''[dbo].[ObjectClasses]'', N''TableName'') = 0
BEGIN
	PRINT ''Adding Column [ObjectClasses].[TableName]''
	alter table [dbo].[ObjectClasses] add
		[TableName] nvarchar(50) not null
END

-------------

IF dbo.fn_ColumnExists(N''[dbo].[ObjectProperties]'', N''ID'') = 0
BEGIN
	PRINT ''Adding Column [ObjectProperties].[ID]''
	alter table [dbo].[ObjectProperties] add
		[ID] [int] IDENTITY(1,1) NOT NULL,
		CONSTRAINT [PK_ObjectProperties] PRIMARY KEY CLUSTERED 
		(
			[ID] ASC
		)
END

IF dbo.fn_ColumnExists(N''[dbo].[ObjectProperties]'', N''fk_ObjectClass'') = 0
BEGIN
	PRINT ''Adding Column [ObjectProperties].[fk_ObjectClass]''
	alter table [dbo].[ObjectProperties] add
		[fk_ObjectClass] [int] NOT NULL
END

IF dbo.fn_ColumnExists(N''[dbo].[ObjectProperties]'', N''PropertyName'') = 0
BEGIN
	PRINT ''Adding Column [ObjectProperties].[PropertyName]''
	alter table [dbo].[ObjectProperties] add
		[PropertyName] [nvarchar](50) NOT NULL
END

IF dbo.fn_ColumnExists(N''[dbo].[ObjectProperties]'', N''DataType'') = 0
BEGIN
	PRINT ''Adding Column [ObjectProperties].[DataType]''
	alter table [dbo].[ObjectProperties] add
		[DataType] [nvarchar](150) NOT NULL
END

IF dbo.fn_ColumnExists(N''[dbo].[ObjectProperties]'', N''IsList'') = 0
BEGIN
	PRINT ''Adding Column [ObjectProperties].[IsList]''
	alter table [dbo].[ObjectProperties] add
		[IsList] [bit] NOT NULL default(0)
END

IF dbo.fn_ColumnExists(N''[dbo].[ObjectProperties]'', N''IsAssociation'') = 0
BEGIN
	PRINT ''Adding Column [ObjectProperties].[IsAssociation]''
	alter table [dbo].[ObjectProperties] add
		[IsAssociation] [bit] NOT NULL default(0)
END

IF dbo.fn_ColumnExists(N''[dbo].[ObjectProperties]'', N''AssociationClass'') = 1
BEGIN
	PRINT ''Dropping Column [ObjectProperties].[AssociationClass]''
	alter table [dbo].[ObjectProperties] drop column
		AssociationClass
END


/******************* Check Content of ObjectClass *******************/
exec sp_CheckObjectClass N''Kistl.App.Base'', N''ObjectClass'', N''ObjectClasses''
exec sp_CheckObjectClass N''Kistl.App.Base'', N''ObjectProperty'', N''ObjectProperties''

/******************* Check Content of ObjectProperty *******************/
exec sp_CheckObjectProperty N''Kistl.App.Base'', N''ObjectClass'', N''ClassName'', N''System.String'', 0, 0
exec sp_CheckObjectProperty N''Kistl.App.Base'', N''ObjectClass'', N''Namespace'', N''System.String'', 0, 0
exec sp_CheckObjectProperty N''Kistl.App.Base'', N''ObjectClass'', N''TableName'', N''System.String'', 0, 0
exec sp_CheckObjectProperty N''Kistl.App.Base'', N''ObjectClass'', N''Properties'', N''Kistl.App.Base.ObjectProperty'', 1, 1

exec sp_DropObjectProperty N''Kistl.App.Base'', N''ObjectClass'', N''ServerObject''
exec sp_DropObjectProperty N''Kistl.App.Base'', N''ObjectClass'', N''ClientObject''
exec sp_DropObjectProperty N''Kistl.App.Base'', N''ObjectClass'', N''DataObject''


exec sp_CheckObjectProperty N''Kistl.App.Base'', N''ObjectProperty'', N''fk_ObjectClass'', N''System.Int32'', 0, 1
exec sp_CheckObjectProperty N''Kistl.App.Base'', N''ObjectProperty'', N''PropertyName'', N''System.String'', 0, 0
exec sp_CheckObjectProperty N''Kistl.App.Base'', N''ObjectProperty'', N''DataType'', N''System.String'', 0, 0
exec sp_CheckObjectProperty N''Kistl.App.Base'', N''ObjectProperty'', N''IsList'', N''System.Boolean'', 0, 0
exec sp_CheckObjectProperty N''Kistl.App.Base'', N''ObjectProperty'', N''IsAssociation'', N''System.Boolean'', 0, 0

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DropBaseTables]    Script Date: 03/20/2008 18:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_DropBaseTables]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[sp_DropBaseTables] 
as

IF dbo.fn_TableExists(N''[dbo].[ObjectClasses]'') = 1
BEGIN
	drop table dbo.ObjectProperties
END


IF dbo.fn_TableExists(N''[dbo].[ObjectProperties]'') = 1
BEGIN
	drop table dbo.ObjectClasses
END
' 
END
GO
/****** Object:  Default [DF__ObjectCla__Table__0F975522]    Script Date: 03/20/2008 18:17:09 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__ObjectCla__Table__0F975522]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
Begin
ALTER TABLE [dbo].[ObjectClasses] ADD  CONSTRAINT [DF__ObjectCla__Table__0F975522]  DEFAULT ('NewTable') FOR [TableName]

End
GO
/****** Object:  ForeignKey [FK_BaseProperties_DataTypes]    Script Date: 03/20/2008 18:17:09 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaseProperties_DataTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaseProperties]'))
ALTER TABLE [dbo].[BaseProperties]  WITH CHECK ADD  CONSTRAINT [FK_BaseProperties_DataTypes] FOREIGN KEY([fk_ObjectClass])
REFERENCES [dbo].[DataTypes] ([ID])
GO
ALTER TABLE [dbo].[BaseProperties] CHECK CONSTRAINT [FK_BaseProperties_DataTypes]
GO
/****** Object:  ForeignKey [FK_Methods_DataTypes]    Script Date: 03/20/2008 18:17:09 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Methods_DataTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Methods]'))
ALTER TABLE [dbo].[Methods]  WITH CHECK ADD  CONSTRAINT [FK_Methods_DataTypes] FOREIGN KEY([fk_ObjectClass])
REFERENCES [dbo].[DataTypes] ([ID])
GO
ALTER TABLE [dbo].[Methods] CHECK CONSTRAINT [FK_Methods_DataTypes]
GO
/****** Object:  ForeignKey [FK_Taetigkeiten_Mitarbeiter]    Script Date: 03/20/2008 18:17:09 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Taetigkeiten_Mitarbeiter]') AND parent_object_id = OBJECT_ID(N'[dbo].[Taetigkeiten]'))
ALTER TABLE [dbo].[Taetigkeiten]  WITH CHECK ADD  CONSTRAINT [FK_Taetigkeiten_Mitarbeiter] FOREIGN KEY([fk_Mitarbeiter])
REFERENCES [dbo].[Mitarbeiter] ([ID])
GO
ALTER TABLE [dbo].[Taetigkeiten] CHECK CONSTRAINT [FK_Taetigkeiten_Mitarbeiter]
GO
/****** Object:  ForeignKey [FK_Taetigkeiten_TaetigkeitsArten]    Script Date: 03/20/2008 18:17:09 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Taetigkeiten_TaetigkeitsArten]') AND parent_object_id = OBJECT_ID(N'[dbo].[Taetigkeiten]'))
ALTER TABLE [dbo].[Taetigkeiten]  WITH CHECK ADD  CONSTRAINT [FK_Taetigkeiten_TaetigkeitsArten] FOREIGN KEY([fk_TaetigkeitsArt])
REFERENCES [dbo].[TaetigkeitsArten] ([ID])
GO
ALTER TABLE [dbo].[Taetigkeiten] CHECK CONSTRAINT [FK_Taetigkeiten_TaetigkeitsArten]
GO
/****** Object:  ForeignKey [FK_Taetigkeiten_Zeitkonten]    Script Date: 03/20/2008 18:17:09 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Taetigkeiten_Zeitkonten]') AND parent_object_id = OBJECT_ID(N'[dbo].[Taetigkeiten]'))
ALTER TABLE [dbo].[Taetigkeiten]  WITH CHECK ADD  CONSTRAINT [FK_Taetigkeiten_Zeitkonten] FOREIGN KEY([fk_Zeitkonto])
REFERENCES [dbo].[Zeitkonten] ([ID])
GO
ALTER TABLE [dbo].[Taetigkeiten] CHECK CONSTRAINT [FK_Taetigkeiten_Zeitkonten]
GO
/****** Object:  ForeignKey [FK_Tasks_Projekte]    Script Date: 03/20/2008 18:17:09 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Tasks_Projekte]') AND parent_object_id = OBJECT_ID(N'[dbo].[Tasks]'))
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Projekte] FOREIGN KEY([fk_Projekt])
REFERENCES [dbo].[Projekte] ([ID])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_Projekte]
GO
/****** Object:  ForeignKey [FK_Zeitkonten_MitarbeiterCollection_Mitarbeiter]    Script Date: 03/20/2008 18:17:09 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Zeitkonten_MitarbeiterCollection_Mitarbeiter]') AND parent_object_id = OBJECT_ID(N'[dbo].[Zeitkonten_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Zeitkonten_MitarbeiterCollection]  WITH CHECK ADD  CONSTRAINT [FK_Zeitkonten_MitarbeiterCollection_Mitarbeiter] FOREIGN KEY([fk_Mitarbeiter])
REFERENCES [dbo].[Mitarbeiter] ([ID])
GO
ALTER TABLE [dbo].[Zeitkonten_MitarbeiterCollection] CHECK CONSTRAINT [FK_Zeitkonten_MitarbeiterCollection_Mitarbeiter]
GO
/****** Object:  ForeignKey [FK_Zeitkonten_MitarbeiterCollection_Zeitkonten]    Script Date: 03/20/2008 18:17:09 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Zeitkonten_MitarbeiterCollection_Zeitkonten]') AND parent_object_id = OBJECT_ID(N'[dbo].[Zeitkonten_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Zeitkonten_MitarbeiterCollection]  WITH CHECK ADD  CONSTRAINT [FK_Zeitkonten_MitarbeiterCollection_Zeitkonten] FOREIGN KEY([fk_Zeitkonto])
REFERENCES [dbo].[Zeitkonten] ([ID])
GO
ALTER TABLE [dbo].[Zeitkonten_MitarbeiterCollection] CHECK CONSTRAINT [FK_Zeitkonten_MitarbeiterCollection_Zeitkonten]
GO
