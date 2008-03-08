/****** Object:  ForeignKey [FK_BaseProperties_ObjectClasses]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaseProperties_ObjectClasses]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaseProperties]'))
ALTER TABLE [dbo].[BaseProperties] DROP CONSTRAINT [FK_BaseProperties_ObjectClasses]
GO
/****** Object:  ForeignKey [FK_Methods_ObjectClasses]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Methods_ObjectClasses]') AND parent_object_id = OBJECT_ID(N'[dbo].[Methods]'))
ALTER TABLE [dbo].[Methods] DROP CONSTRAINT [FK_Methods_ObjectClasses]
GO
/****** Object:  ForeignKey [FK_Tasks_Projekte]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Tasks_Projekte]') AND parent_object_id = OBJECT_ID(N'[dbo].[Tasks]'))
ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK_Tasks_Projekte]
GO
/****** Object:  Default [DF__ObjectCla__Table__0F975522]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__ObjectCla__Table__0F975522]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
Begin
ALTER TABLE [dbo].[ObjectClasses] DROP CONSTRAINT [DF__ObjectCla__Table__0F975522]

End
GO
/****** Object:  Table [dbo].[BaseProperties]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BaseProperties]') AND type in (N'U'))
DROP TABLE [dbo].[BaseProperties]
GO
/****** Object:  Table [dbo].[Methods]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Methods]') AND type in (N'U'))
DROP TABLE [dbo].[Methods]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tasks]') AND type in (N'U'))
DROP TABLE [dbo].[Tasks]
GO
/****** Object:  Table [dbo].[StringProperties]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StringProperties]') AND type in (N'U'))
DROP TABLE [dbo].[StringProperties]
GO
/****** Object:  Table [dbo].[ValueTypeProperties]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ValueTypeProperties]') AND type in (N'U'))
DROP TABLE [dbo].[ValueTypeProperties]
GO
/****** Object:  Table [dbo].[Properties]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Properties]') AND type in (N'U'))
DROP TABLE [dbo].[Properties]
GO
/****** Object:  Table [dbo].[Projekte]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Projekte]') AND type in (N'U'))
DROP TABLE [dbo].[Projekte]
GO
/****** Object:  Table [dbo].[Mitarbeiter]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mitarbeiter]') AND type in (N'U'))
DROP TABLE [dbo].[Mitarbeiter]
GO
/****** Object:  Table [dbo].[MethodInvocations]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MethodInvocations]') AND type in (N'U'))
DROP TABLE [dbo].[MethodInvocations]
GO
/****** Object:  Table [dbo].[Assemblies]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Assemblies]') AND type in (N'U'))
DROP TABLE [dbo].[Assemblies]
GO
/****** Object:  Table [dbo].[Icons]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Icons]') AND type in (N'U'))
DROP TABLE [dbo].[Icons]
GO
/****** Object:  Table [dbo].[Kunden]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kunden]') AND type in (N'U'))
DROP TABLE [dbo].[Kunden]
GO
/****** Object:  Table [dbo].[Taetigkeiten]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Taetigkeiten]') AND type in (N'U'))
DROP TABLE [dbo].[Taetigkeiten]
GO
/****** Object:  Table [dbo].[Kostentraeger]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kostentraeger]') AND type in (N'U'))
DROP TABLE [dbo].[Kostentraeger]
GO
/****** Object:  Table [dbo].[Kostenstellen]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kostenstellen]') AND type in (N'U'))
DROP TABLE [dbo].[Kostenstellen]
GO
/****** Object:  Table [dbo].[Zeitkonten]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Zeitkonten]') AND type in (N'U'))
DROP TABLE [dbo].[Zeitkonten]
GO
/****** Object:  Table [dbo].[Auftraege]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Auftraege]') AND type in (N'U'))
DROP TABLE [dbo].[Auftraege]
GO
/****** Object:  Table [dbo].[Modules]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Modules]') AND type in (N'U'))
DROP TABLE [dbo].[Modules]
GO
/****** Object:  Table [dbo].[ObjectForDeletedProperties]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectForDeletedProperties]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectForDeletedProperties]
GO
/****** Object:  Table [dbo].[BackReferenceProperties]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BackReferenceProperties]') AND type in (N'U'))
DROP TABLE [dbo].[BackReferenceProperties]
GO
/****** Object:  Table [dbo].[ObjectClasses]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectClasses]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectClasses]
GO
/****** Object:  Table [dbo].[DateTimeProperties]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DateTimeProperties]') AND type in (N'U'))
DROP TABLE [dbo].[DateTimeProperties]
GO
/****** Object:  Table [dbo].[ObjectReferenceProperties]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectReferenceProperties]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectReferenceProperties]
GO
/****** Object:  Table [dbo].[BoolProperties]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BoolProperties]') AND type in (N'U'))
DROP TABLE [dbo].[BoolProperties]
GO
/****** Object:  Table [dbo].[DoubleProperties]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DoubleProperties]') AND type in (N'U'))
DROP TABLE [dbo].[DoubleProperties]
GO
/****** Object:  Table [dbo].[IntProperties]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntProperties]') AND type in (N'U'))
DROP TABLE [dbo].[IntProperties]
GO
/****** Object:  Table [dbo].[Kunden_EMailsCollection]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kunden_EMailsCollection]') AND type in (N'U'))
DROP TABLE [dbo].[Kunden_EMailsCollection]
GO
/****** Object:  Table [dbo].[Projekte_MitarbeiterCollection]    Script Date: 03/08/2008 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Projekte_MitarbeiterCollection]') AND type in (N'U'))
DROP TABLE [dbo].[Projekte_MitarbeiterCollection]
GO
/****** Object:  Table [dbo].[Projekte_MitarbeiterCollection]    Script Date: 03/08/2008 18:10:40 ******/
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
SET IDENTITY_INSERT [dbo].[Projekte_MitarbeiterCollection] OFF
/****** Object:  Table [dbo].[Kunden_EMailsCollection]    Script Date: 03/08/2008 18:10:40 ******/
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
INSERT [dbo].[Kunden_EMailsCollection] ([ID], [fk_Kunde], [EMails]) VALUES (4, 1, N'office@accent.net')
INSERT [dbo].[Kunden_EMailsCollection] ([ID], [fk_Kunde], [EMails]) VALUES (5, 1, N'test@test.com')
INSERT [dbo].[Kunden_EMailsCollection] ([ID], [fk_Kunde], [EMails]) VALUES (6, 2, N'susanne.dobler@mail.com')
SET IDENTITY_INSERT [dbo].[Kunden_EMailsCollection] OFF
/****** Object:  Table [dbo].[IntProperties]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[DoubleProperties]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[BoolProperties]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[ObjectReferenceProperties]    Script Date: 03/08/2008 18:10:40 ******/
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
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (8, N'Kistl.App.Base.ObjectClass', 2)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (19, N'Kistl.App.Projekte.Projekt', 3)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (22, N'Kistl.App.Projekte.Mitarbeiter', 6)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (25, N'Kistl.App.Base.ObjectClass', 2)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (29, N'Kistl.App.Base.ObjectClass', 2)
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
INSERT [dbo].[ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (79, NULL, 2)
/****** Object:  Table [dbo].[DateTimeProperties]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[ObjectClasses]    Script Date: 03/08/2008 18:10:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectClasses]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ObjectClasses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [nvarchar](51) COLLATE Latin1_General_CI_AS NOT NULL,
	[TableName] [nvarchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
	[fk_BaseObjectClass] [int] NULL,
	[fk_Module] [int] NOT NULL,
	[BaseObjectClass] [int] NULL,
	[fk_DefaultIcon] [int] NULL,
 CONSTRAINT [PK_ObjectClasses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[ObjectClasses] ON
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (2, N'ObjectClass', N'ObjectClasses', NULL, 1, NULL, 11)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (3, N'Projekt', N'Projekte', NULL, 2, NULL, 3)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (4, N'Task', N'Tasks', NULL, 2, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (5, N'BaseProperty', N'BaseProperties', NULL, 1, NULL, 9)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (6, N'Mitarbeiter', N'Mitarbeiter', NULL, 2, NULL, 5)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (7, N'Property', N'Properties', 5, 1, NULL, 9)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (8, N'ValueTypeProperty', N'ValueTypeProperties', 7, 1, NULL, 9)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (9, N'StringProperty', N'StringProperties', 8, 1, NULL, 9)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (10, N'Method', N'Methods', NULL, 1, NULL, 2)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (11, N'IntProperty', N'IntProperties', 8, 1, NULL, 9)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (12, N'BoolProperty', N'BoolProperties', 8, 1, NULL, 9)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (13, N'DoubleProperty', N'DoubleProperties', 8, 1, NULL, 9)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (14, N'ObjectReferenceProperty', N'ObjectReferenceProperties', 7, 1, NULL, 9)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (15, N'DateTimeProperty', N'DateTimeProperties', 8, 1, NULL, 9)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (16, N'BackReferenceProperty', N'BackReferenceProperties', 5, 1, NULL, 9)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (18, N'Module', N'Modules', NULL, 1, NULL, 1)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (19, N'Auftrag', N'Auftraege', NULL, 2, NULL, 8)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (20, N'Zeitkonto', N'Zeitkonten', NULL, 3, NULL, 12)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (21, N'Kostenstelle', N'Kostenstellen', 20, 3, NULL, 10)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (23, N'Kostentraeger', N'Kostentraeger', 20, 3, NULL, 3)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (25, N'Taetigkeit', N'Taetigkeiten', NULL, 3, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (26, N'Kunde', N'Kunden', NULL, 2, NULL, 6)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (27, N'Icon', N'Icons', NULL, 4, NULL, 4)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (29, N'Assembly', N'Assemblies', NULL, 1, NULL, 13)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (30, N'MethodInvocation', N'MethodInvocations', NULL, 1, NULL, 2)
SET IDENTITY_INSERT [dbo].[ObjectClasses] OFF
/****** Object:  Table [dbo].[BackReferenceProperties]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[ObjectForDeletedProperties]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[Modules]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[Auftraege]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[Zeitkonten]    Script Date: 03/08/2008 18:10:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Zeitkonten]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Zeitkonten](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kontoname] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Zeitkonto] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Zeitkonten] ON
INSERT [dbo].[Zeitkonten] ([ID], [Kontoname]) VALUES (1, N'Kistlkostenträger - Entwicklung')
INSERT [dbo].[Zeitkonten] ([ID], [Kontoname]) VALUES (2, N'Kistlkostenträger - Meeting')
INSERT [dbo].[Zeitkonten] ([ID], [Kontoname]) VALUES (3, N'Urlaube')
SET IDENTITY_INSERT [dbo].[Zeitkonten] OFF
/****** Object:  Table [dbo].[Kostenstellen]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[Kostentraeger]    Script Date: 03/08/2008 18:10:40 ******/
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
INSERT [dbo].[Kostentraeger] ([ID], [fk_Projekt]) VALUES (1, 1)
INSERT [dbo].[Kostentraeger] ([ID], [fk_Projekt]) VALUES (2, 1)
/****** Object:  Table [dbo].[Taetigkeiten]    Script Date: 03/08/2008 18:10:40 ******/
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
 CONSTRAINT [PK_Taetigkeit] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Taetigkeiten] ON
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer]) VALUES (1, 2, 1, CAST(0x00009A1E00000000 AS DateTime), 6.5)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer]) VALUES (2, 1, 1, CAST(0x00009A1F00000000 AS DateTime), 4)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer]) VALUES (4, 1, 2, CAST(0x00009A1C00000000 AS DateTime), 1)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer]) VALUES (5, 2, 2, CAST(0x00009A1C00000000 AS DateTime), 1)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer]) VALUES (6, 2, 2, CAST(0x00009A1F00000000 AS DateTime), 1)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer]) VALUES (7, 1, 2, CAST(0x00009A1F00000000 AS DateTime), 1)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer]) VALUES (8, 2, 2, CAST(0x00009A1F00000000 AS DateTime), 1)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer]) VALUES (9, 2, 1, CAST(0x00009A1F00000000 AS DateTime), 1.5)
INSERT [dbo].[Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer]) VALUES (10, 2, 1, CAST(0x00009A1F00000000 AS DateTime), 2.5)
SET IDENTITY_INSERT [dbo].[Taetigkeiten] OFF
/****** Object:  Table [dbo].[Kunden]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[Icons]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[Assemblies]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[MethodInvocations]    Script Date: 03/08/2008 18:10:40 ******/
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
SET IDENTITY_INSERT [dbo].[MethodInvocations] OFF
/****** Object:  Table [dbo].[Mitarbeiter]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[Projekte]    Script Date: 03/08/2008 18:10:40 ******/
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
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (7, N'Neues Objekt', 100, NULL)
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (12, N'Neues Projekt im Context', 103, NULL)
SET IDENTITY_INSERT [dbo].[Projekte] OFF
/****** Object:  Table [dbo].[Properties]    Script Date: 03/08/2008 18:10:40 ******/
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
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (8, 1, 0)
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
/****** Object:  Table [dbo].[ValueTypeProperties]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[StringProperties]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[Tasks]    Script Date: 03/08/2008 18:10:40 ******/
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
/****** Object:  Table [dbo].[Methods]    Script Date: 03/08/2008 18:10:40 ******/
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
SET IDENTITY_INSERT [dbo].[Methods] OFF
/****** Object:  Table [dbo].[BaseProperties]    Script Date: 03/08/2008 18:10:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BaseProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BaseProperties](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_ObjectClass] [int] NULL,
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
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (1, 2, N'ClassName', N'Der Name der Objektklasse', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (3, 2, N'TableName', N'Tabellenname in der Datenbank', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (7, 2, N'Properties', N'Eigenschaften der Objektklasse', 1)
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
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (31, 2, N'Methods', N'Liste aller Methoden der Objektklasse.', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (38, 6, N'Geburtstag', N'Herzlichen Glückwunsch zum Geburtstag', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (39, 6, N'SVNr', N'NNNN TTMMYY', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (40, 6, N'TelefonNummer', N'+43 123 12345678', 2)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (41, 5, N'AltText', NULL, 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (42, 18, N'Namespace', N'CLR Namespace des Moduls', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (43, 18, N'ModuleName', N'Name des Moduls', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (44, 18, N'ObjectClasses', N'Ojektklassen des Modules', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (45, 2, N'Module', N'Modul der Objektklasse', 1)
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
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (69, 2, N'DefaultIcon', N'Standard Icon wenn IIcon nicht implementiert ist', 4)
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
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (80, 2, N'MethodIvokations', N'Methodenaufrufe implementiert in dieser Objekt Klasse', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (81, 10, N'MethodIvokations', N'Methodenaufrufe implementiert in dieser Objekt Klasse', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (82, 18, N'Assemblies', N'Assemblies des Moduls', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (83, 29, N'IsClientAssembly', N'Legt fest, ob es sich um ein Client-Assembly handelt.', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (84, 16, N'PreFetchToClient', N'Serialisierung der Liste zum Client', 1)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module]) VALUES (85, 26, N'EMails', N'EMails des Kunden - können mehrere sein', 2)
SET IDENTITY_INSERT [dbo].[BaseProperties] OFF
/****** Object:  Default [DF__ObjectCla__Table__0F975522]    Script Date: 03/08/2008 18:10:40 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__ObjectCla__Table__0F975522]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
Begin
ALTER TABLE [dbo].[ObjectClasses] ADD  CONSTRAINT [DF__ObjectCla__Table__0F975522]  DEFAULT ('NewTable') FOR [TableName]

End
GO
/****** Object:  ForeignKey [FK_BaseProperties_ObjectClasses]    Script Date: 03/08/2008 18:10:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaseProperties_ObjectClasses]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaseProperties]'))
ALTER TABLE [dbo].[BaseProperties]  WITH CHECK ADD  CONSTRAINT [FK_BaseProperties_ObjectClasses] FOREIGN KEY([fk_ObjectClass])
REFERENCES [dbo].[ObjectClasses] ([ID])
GO
ALTER TABLE [dbo].[BaseProperties] CHECK CONSTRAINT [FK_BaseProperties_ObjectClasses]
GO
/****** Object:  ForeignKey [FK_Methods_ObjectClasses]    Script Date: 03/08/2008 18:10:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Methods_ObjectClasses]') AND parent_object_id = OBJECT_ID(N'[dbo].[Methods]'))
ALTER TABLE [dbo].[Methods]  WITH CHECK ADD  CONSTRAINT [FK_Methods_ObjectClasses] FOREIGN KEY([fk_ObjectClass])
REFERENCES [dbo].[ObjectClasses] ([ID])
GO
ALTER TABLE [dbo].[Methods] CHECK CONSTRAINT [FK_Methods_ObjectClasses]
GO
/****** Object:  ForeignKey [FK_Tasks_Projekte]    Script Date: 03/08/2008 18:10:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Tasks_Projekte]') AND parent_object_id = OBJECT_ID(N'[dbo].[Tasks]'))
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Projekte] FOREIGN KEY([fk_Projekt])
REFERENCES [dbo].[Projekte] ([ID])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_Projekte]
GO
