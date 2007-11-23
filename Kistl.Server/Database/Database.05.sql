/****** Object:  ForeignKey [FK_BaseProperties_ObjectClasses]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaseProperties_ObjectClasses]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaseProperties]'))
ALTER TABLE [dbo].[BaseProperties] DROP CONSTRAINT [FK_BaseProperties_ObjectClasses]
GO
/****** Object:  ForeignKey [FK_Methods_ObjectClasses]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Methods_ObjectClasses]') AND parent_object_id = OBJECT_ID(N'[dbo].[Methods]'))
ALTER TABLE [dbo].[Methods] DROP CONSTRAINT [FK_Methods_ObjectClasses]
GO
/****** Object:  ForeignKey [FK_Tasks_Projekte]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Tasks_Projekte]') AND parent_object_id = OBJECT_ID(N'[dbo].[Tasks]'))
ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK_Tasks_Projekte]
GO
/****** Object:  Default [DF__ObjectCla__Names__0EA330E9]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__ObjectCla__Names__0EA330E9]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
Begin
ALTER TABLE [dbo].[ObjectClasses] DROP CONSTRAINT [DF__ObjectCla__Names__0EA330E9]

End
GO
/****** Object:  Default [DF__ObjectCla__Table__0F975522]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__ObjectCla__Table__0F975522]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
Begin
ALTER TABLE [dbo].[ObjectClasses] DROP CONSTRAINT [DF__ObjectCla__Table__0F975522]

End
GO
/****** Object:  Default [DF_Projekte_fk_Mitarbeiter]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Projekte_fk_Mitarbeiter]') AND parent_object_id = OBJECT_ID(N'[dbo].[Projekte]'))
Begin
ALTER TABLE [dbo].[Projekte] DROP CONSTRAINT [DF_Projekte_fk_Mitarbeiter]

End
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckBaseTables]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CheckBaseTables]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_CheckBaseTables]
GO
/****** Object:  StoredProcedure [dbo].[sp_DropBaseTables]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_DropBaseTables]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_DropBaseTables]
GO
/****** Object:  StoredProcedure [dbo].[sp_DropObjectProperty]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_DropObjectProperty]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_DropObjectProperty]
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckObjectProperty]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CheckObjectProperty]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_CheckObjectProperty]
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckObjectClass]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CheckObjectClass]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_CheckObjectClass]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tasks]') AND type in (N'U'))
DROP TABLE [dbo].[Tasks]
GO
/****** Object:  Table [dbo].[BaseProperties]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BaseProperties]') AND type in (N'U'))
DROP TABLE [dbo].[BaseProperties]
GO
/****** Object:  Table [dbo].[Methods]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Methods]') AND type in (N'U'))
DROP TABLE [dbo].[Methods]
GO
/****** Object:  Table [dbo].[StringProperties]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StringProperties]') AND type in (N'U'))
DROP TABLE [dbo].[StringProperties]
GO
/****** Object:  Table [dbo].[ValueTypeProperties]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ValueTypeProperties]') AND type in (N'U'))
DROP TABLE [dbo].[ValueTypeProperties]
GO
/****** Object:  Table [dbo].[Properties]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Properties]') AND type in (N'U'))
DROP TABLE [dbo].[Properties]
GO
/****** Object:  Table [dbo].[Projekte]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Projekte]') AND type in (N'U'))
DROP TABLE [dbo].[Projekte]
GO
/****** Object:  Table [dbo].[Mitarbeiter]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mitarbeiter]') AND type in (N'U'))
DROP TABLE [dbo].[Mitarbeiter]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_TableExists]    Script Date: 11/23/2007 16:38:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_TableExists]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_TableExists]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_ColumnExists]    Script Date: 11/23/2007 16:38:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_ColumnExists]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_ColumnExists]
GO
/****** Object:  Table [dbo].[ObjectForDeletedProperties]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectForDeletedProperties]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectForDeletedProperties]
GO
/****** Object:  Table [dbo].[BackReferenceProperties]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BackReferenceProperties]') AND type in (N'U'))
DROP TABLE [dbo].[BackReferenceProperties]
GO
/****** Object:  Table [dbo].[ObjectClasses]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectClasses]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectClasses]
GO
/****** Object:  Table [dbo].[DateTimeProperties]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DateTimeProperties]') AND type in (N'U'))
DROP TABLE [dbo].[DateTimeProperties]
GO
/****** Object:  Table [dbo].[ObjectReferenceProperties]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectReferenceProperties]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectReferenceProperties]
GO
/****** Object:  Table [dbo].[BoolProperties]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BoolProperties]') AND type in (N'U'))
DROP TABLE [dbo].[BoolProperties]
GO
/****** Object:  Table [dbo].[DoubleProperties]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DoubleProperties]') AND type in (N'U'))
DROP TABLE [dbo].[DoubleProperties]
GO
/****** Object:  Table [dbo].[IntProperties]    Script Date: 11/23/2007 16:38:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntProperties]') AND type in (N'U'))
DROP TABLE [dbo].[IntProperties]
GO
/****** Object:  Table [dbo].[IntProperties]    Script Date: 11/23/2007 16:38:37 ******/
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
/****** Object:  Table [dbo].[DoubleProperties]    Script Date: 11/23/2007 16:38:37 ******/
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
/****** Object:  Table [dbo].[BoolProperties]    Script Date: 11/23/2007 16:38:37 ******/
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
INSERT [dbo].[BoolProperties] ([ID]) VALUES (12)
INSERT [dbo].[BoolProperties] ([ID]) VALUES (26)
/****** Object:  Table [dbo].[ObjectReferenceProperties]    Script Date: 11/23/2007 16:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectReferenceProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ObjectReferenceProperties](
	[ID] [int] NOT NULL,
	[fk_ObjectClassType] [int] NULL,
	[ReferenceObjectClassName] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_ObjectReferenceProperties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ObjectClassType], [ReferenceObjectClassName]) VALUES (8, 2, N'Kistl.App.Base.ObjectClass')
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ObjectClassType], [ReferenceObjectClassName]) VALUES (19, 3, N'Kistl.App.Projekte.Projekt')
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ObjectClassType], [ReferenceObjectClassName]) VALUES (22, 6, N'Kistl.App.Projekte.Mitarbeiter')
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ObjectClassType], [ReferenceObjectClassName]) VALUES (25, 2, N'Kistl.App.Base.ObjectClass')
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ObjectClassType], [ReferenceObjectClassName]) VALUES (29, 2, N'Kistl.App.Base.ObjectClass')
/****** Object:  Table [dbo].[DateTimeProperties]    Script Date: 11/23/2007 16:38:37 ******/
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
/****** Object:  Table [dbo].[ObjectClasses]    Script Date: 11/23/2007 16:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectClasses]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ObjectClasses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[Namespace] [nvarchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
	[TableName] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[fk_BaseObjectClass] [int] NULL,
 CONSTRAINT [PK_ObjectClasses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[ObjectClasses] ON
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (2, N'ObjectClass', N'Kistl.App.Base', N'ObjectClasses', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (3, N'Projekt', N'Kistl.App.Projekte', N'Projekte', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (4, N'Task', N'Kistl.App.Projekte', N'Tasks', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (5, N'BaseProperty', N'Kistl.App.Base', N'BaseProperties', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (6, N'Mitarbeiter', N'Kistl.App.Projekte', N'Mitarbeiter', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (7, N'Property', N'Kistl.App.Base', N'Properties', 5)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (8, N'ValueTypeProperty', N'Kistl.App.Base', N'ValueTypeProperties', 7)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (9, N'StringProperty', N'Kistl.App.Base', N'StringProperties', 8)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (10, N'Method', N'Kistl.App.Base', N'Methods', NULL)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (11, N'IntProperty', N'Kistl.App.Base', N'IntProperties', 8)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (12, N'BoolProperty', N'Kistl.App.Base', N'BoolProperties', 8)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (13, N'DoubleProperty', N'Kistl.App.Base', N'DoubleProperties', 8)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (14, N'ObjectReferenceProperty', N'Kistl.App.Base', N'ObjectReferenceProperties', 7)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (15, N'DateTimeProperty', N'Kistl.App.Base', N'DateTimeProperties', 8)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (16, N'BackReferenceProperty', N'Kistl.App.Base', N'BackReferenceProperties', 5)
INSERT [dbo].[ObjectClasses] ([ID], [ClassName], [Namespace], [TableName], [fk_BaseObjectClass]) VALUES (17, N'ObjectForDeletedProperties', N'Kistl.App.Delete', N'ObjectForDeletedProperties', NULL)
SET IDENTITY_INSERT [dbo].[ObjectClasses] OFF
/****** Object:  Table [dbo].[BackReferenceProperties]    Script Date: 11/23/2007 16:38:37 ******/
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
 CONSTRAINT [PK_BackReferenceProperty] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName]) VALUES (7, N'Kistl.App.Base.BaseProperty', N'ObjectClass')
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName]) VALUES (14, N'Kistl.App.Projekte.Task', N'Projekt')
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName]) VALUES (21, N'Kistl.App.Projekte.Projekt', N'Mitarbeiter')
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName]) VALUES (27, N'Kistl.App.Base.ObjectClass', N'BaseObjectClass')
INSERT [dbo].[BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName]) VALUES (31, N'Kistl.App.Base.Method', N'ObjectClass')
/****** Object:  Table [dbo].[ObjectForDeletedProperties]    Script Date: 11/23/2007 16:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectForDeletedProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ObjectForDeletedProperties](
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ObjectForDeletedProperties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  UserDefinedFunction [dbo].[fn_ColumnExists]    Script Date: 11/23/2007 16:38:38 ******/
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
/****** Object:  UserDefinedFunction [dbo].[fn_TableExists]    Script Date: 11/23/2007 16:38:39 ******/
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
/****** Object:  Table [dbo].[Mitarbeiter]    Script Date: 11/23/2007 16:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mitarbeiter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Mitarbeiter](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
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
INSERT [dbo].[Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (1, N'David Schmitt', NULL, NULL, NULL)
INSERT [dbo].[Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (2, N'Arthur Zaczek', NULL, NULL, NULL)
INSERT [dbo].[Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (3, N'Susanne Dobler', NULL, NULL, NULL)
INSERT [dbo].[Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (4, N'Josef Pfleger', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Mitarbeiter] OFF
/****** Object:  Table [dbo].[Projekte]    Script Date: 11/23/2007 16:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Projekte]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Projekte](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) COLLATE Latin1_General_CI_AS NULL,
	[fk_Mitarbeiter] [int] NOT NULL,
	[AufwandGes] [float] NULL,
 CONSTRAINT [PK_Projekte] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Projekte] ON
INSERT [dbo].[Projekte] ([ID], [Name], [fk_Mitarbeiter], [AufwandGes]) VALUES (1, N'Kistl', 1, 100)
INSERT [dbo].[Projekte] ([ID], [Name], [fk_Mitarbeiter], [AufwandGes]) VALUES (2, N'Ziviltechniker', 3, 235)
INSERT [dbo].[Projekte] ([ID], [Name], [fk_Mitarbeiter], [AufwandGes]) VALUES (3, N'WebCMS.net V1.0', 4, 0)
INSERT [dbo].[Projekte] ([ID], [Name], [fk_Mitarbeiter], [AufwandGes]) VALUES (4, N'Rechnungswesen', 2, 100)
INSERT [dbo].[Projekte] ([ID], [Name], [fk_Mitarbeiter], [AufwandGes]) VALUES (5, N'Neues Projekt', 1, 100)
INSERT [dbo].[Projekte] ([ID], [Name], [fk_Mitarbeiter], [AufwandGes]) VALUES (6, N'test_abc', 1, 100)
INSERT [dbo].[Projekte] ([ID], [Name], [fk_Mitarbeiter], [AufwandGes]) VALUES (7, N'Neues Objekt', 2, 100)
SET IDENTITY_INSERT [dbo].[Projekte] OFF
/****** Object:  Table [dbo].[Properties]    Script Date: 11/23/2007 16:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Properties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Properties](
	[ID] [int] NOT NULL,
	[IsNullable] [bit] NULL,
	[IsList] [bit] NULL,
 CONSTRAINT [PK_Properties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (1, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (2, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (3, 0, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (8, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (9, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (10, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (11, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (12, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (13, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (15, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (16, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (17, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (18, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (19, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (20, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (22, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (23, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (25, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (26, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (28, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (29, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (30, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (35, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (36, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (37, 1, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (38, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (39, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (40, 1, 0)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList]) VALUES (41, 1, 0)
/****** Object:  Table [dbo].[ValueTypeProperties]    Script Date: 11/23/2007 16:38:37 ******/
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
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (2)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (3)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (9)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (10)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (11)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (12)
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
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (36)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (37)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (38)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (39)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (40)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (41)
/****** Object:  Table [dbo].[StringProperties]    Script Date: 11/23/2007 16:38:37 ******/
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
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (2, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (3, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (9, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (10, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (13, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (15, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (20, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (30, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (35, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (36, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (37, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (39, 20)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (40, 50)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (41, 200)
/****** Object:  Table [dbo].[Methods]    Script Date: 11/23/2007 16:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Methods]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Methods](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_ObjectClass] [int] NOT NULL,
	[MethodName] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL
)
END
GO
SET IDENTITY_INSERT [dbo].[Methods] ON
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName]) VALUES (1, 5, N'GetDataType')
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName]) VALUES (2, 7, N'GetDatabaseType')
SET IDENTITY_INSERT [dbo].[Methods] OFF
/****** Object:  Table [dbo].[BaseProperties]    Script Date: 11/23/2007 16:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BaseProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BaseProperties](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_ObjectClass] [int] NOT NULL,
	[PropertyName] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[AltText] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_ObjectProperties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[BaseProperties] ON
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (1, 2, N'ClassName', N'Der Name der Objektklasse')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (2, 2, N'Namespace', N'Der Namespace der Objektklasse. Wird durch Module ersetzt werden.')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (3, 2, N'TableName', N'Tabellenname in der Datenbank')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (7, 2, N'Properties', N'Eigenschaften der Objektklasse')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (8, 5, N'fk_ObjectClass', NULL)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (9, 5, N'PropertyName', NULL)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (10, 17, N'DataType', NULL)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (11, 7, N'IsList', NULL)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (12, 17, N'IsAssociation', NULL)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (13, 3, N'Name', N'Projektname')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (14, 3, N'Tasks', NULL)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (15, 4, N'Name', N'Taskname')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (16, 4, N'DatumVon', N'Start Datum')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (17, 4, N'DatumBis', N'Enddatum')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (18, 4, N'Aufwand', N'Aufwand in Stunden')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (19, 4, N'fk_Projekt', N'Verknüpfung zum Projekt')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (20, 6, N'Name', N'Vorname Nachname')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (21, 6, N'Projekte', N'Projekte des Mitarbeiters für die er Verantwortlich ist')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (22, 3, N'fk_Mitarbeiter', NULL)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (23, 3, N'AufwandGes', NULL)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (25, 2, N'fk_BaseObjectClass', N'Pointer auf die Basisklasse')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (26, 7, N'IsNullable', NULL)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (27, 2, N'SubClasses', N'Liste der vererbten Klassen')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (28, 9, N'Length', NULL)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (29, 10, N'fk_ObjectClass', NULL)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (30, 10, N'MethodName', NULL)
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (31, 2, N'Methods', N'Liste aller Methoden der Objektklasse.')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (35, 14, N'ReferenceObjectClassName', N'Name mit Namespace der Objektklasse, die Referenziert werden soll')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (36, 16, N'ReferenceObjectClassName', N'Name der Klasse mit Namespace, die auf einen selber zeigt')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (37, 16, N'ReferencePropertyName', N'Name der Eigenschaft, die auf einen selber zeigt')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (38, 6, N'Geburtstag', N'Herzlichen Glückwunsch zum Geburtstag')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (39, 6, N'SVNr', N'NNNN TTMMYY')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (40, 6, N'TelefonNummer', N'+43 123 12345678')
INSERT [dbo].[BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (41, 5, N'AltText', NULL)
SET IDENTITY_INSERT [dbo].[BaseProperties] OFF
/****** Object:  Table [dbo].[Tasks]    Script Date: 11/23/2007 16:38:37 ******/
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
	[fk_Projekt] [int] NOT NULL,
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
SET IDENTITY_INSERT [dbo].[Tasks] OFF
/****** Object:  StoredProcedure [dbo].[sp_CheckObjectClass]    Script Date: 11/23/2007 16:38:37 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_CheckObjectProperty]    Script Date: 11/23/2007 16:38:37 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_DropObjectProperty]    Script Date: 11/23/2007 16:38:37 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_DropBaseTables]    Script Date: 11/23/2007 16:38:37 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_CheckBaseTables]    Script Date: 11/23/2007 16:38:37 ******/
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
/****** Object:  Default [DF__ObjectCla__Names__0EA330E9]    Script Date: 11/23/2007 16:38:37 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__ObjectCla__Names__0EA330E9]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
Begin
ALTER TABLE [dbo].[ObjectClasses] ADD  CONSTRAINT [DF__ObjectCla__Names__0EA330E9]  DEFAULT ('Kistl.App') FOR [Namespace]

End
GO
/****** Object:  Default [DF__ObjectCla__Table__0F975522]    Script Date: 11/23/2007 16:38:37 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__ObjectCla__Table__0F975522]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
Begin
ALTER TABLE [dbo].[ObjectClasses] ADD  CONSTRAINT [DF__ObjectCla__Table__0F975522]  DEFAULT ('NewTable') FOR [TableName]

End
GO
/****** Object:  Default [DF_Projekte_fk_Mitarbeiter]    Script Date: 11/23/2007 16:38:37 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Projekte_fk_Mitarbeiter]') AND parent_object_id = OBJECT_ID(N'[dbo].[Projekte]'))
Begin
ALTER TABLE [dbo].[Projekte] ADD  CONSTRAINT [DF_Projekte_fk_Mitarbeiter]  DEFAULT ((-1)) FOR [fk_Mitarbeiter]

End
GO
/****** Object:  ForeignKey [FK_BaseProperties_ObjectClasses]    Script Date: 11/23/2007 16:38:37 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaseProperties_ObjectClasses]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaseProperties]'))
ALTER TABLE [dbo].[BaseProperties]  WITH CHECK ADD  CONSTRAINT [FK_BaseProperties_ObjectClasses] FOREIGN KEY([fk_ObjectClass])
REFERENCES [dbo].[ObjectClasses] ([ID])
GO
ALTER TABLE [dbo].[BaseProperties] CHECK CONSTRAINT [FK_BaseProperties_ObjectClasses]
GO
/****** Object:  ForeignKey [FK_Methods_ObjectClasses]    Script Date: 11/23/2007 16:38:37 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Methods_ObjectClasses]') AND parent_object_id = OBJECT_ID(N'[dbo].[Methods]'))
ALTER TABLE [dbo].[Methods]  WITH CHECK ADD  CONSTRAINT [FK_Methods_ObjectClasses] FOREIGN KEY([fk_ObjectClass])
REFERENCES [dbo].[ObjectClasses] ([ID])
GO
ALTER TABLE [dbo].[Methods] CHECK CONSTRAINT [FK_Methods_ObjectClasses]
GO
/****** Object:  ForeignKey [FK_Tasks_Projekte]    Script Date: 11/23/2007 16:38:37 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Tasks_Projekte]') AND parent_object_id = OBJECT_ID(N'[dbo].[Tasks]'))
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Projekte] FOREIGN KEY([fk_Projekt])
REFERENCES [dbo].[Projekte] ([ID])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_Projekte]
GO
