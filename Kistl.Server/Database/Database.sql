/****** Object:  ForeignKey [FK_Assembly_Module_fk_Module]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Assembly_Module_fk_Module]') AND parent_object_id = OBJECT_ID(N'[dbo].[Assemblies]'))
ALTER TABLE [dbo].[Assemblies] DROP CONSTRAINT [FK_Assembly_Module_fk_Module]
GO
/****** Object:  ForeignKey [FK_Auftrag_Kunde_fk_Kunde]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Auftrag_Kunde_fk_Kunde]') AND parent_object_id = OBJECT_ID(N'[dbo].[Auftraege]'))
ALTER TABLE [dbo].[Auftraege] DROP CONSTRAINT [FK_Auftrag_Kunde_fk_Kunde]
GO
/****** Object:  ForeignKey [FK_Auftrag_Mitarbeiter_fk_Mitarbeiter]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Auftrag_Mitarbeiter_fk_Mitarbeiter]') AND parent_object_id = OBJECT_ID(N'[dbo].[Auftraege]'))
ALTER TABLE [dbo].[Auftraege] DROP CONSTRAINT [FK_Auftrag_Mitarbeiter_fk_Mitarbeiter]
GO
/****** Object:  ForeignKey [FK_Auftrag_Projekt_fk_Projekt]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Auftrag_Projekt_fk_Projekt]') AND parent_object_id = OBJECT_ID(N'[dbo].[Auftraege]'))
ALTER TABLE [dbo].[Auftraege] DROP CONSTRAINT [FK_Auftrag_Projekt_fk_Projekt]
GO
/****** Object:  ForeignKey [FK_BaseParameter_Method_fk_Method]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaseParameter_Method_fk_Method]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaseParameters]'))
ALTER TABLE [dbo].[BaseParameters] DROP CONSTRAINT [FK_BaseParameter_Method_fk_Method]
GO
/****** Object:  ForeignKey [FK_BaseParameter_Module_fk_Module]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaseParameter_Module_fk_Module]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaseParameters]'))
ALTER TABLE [dbo].[BaseParameters] DROP CONSTRAINT [FK_BaseParameter_Module_fk_Module]
GO
/****** Object:  ForeignKey [FK_BoolParameter_BaseParameter_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BoolParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[BoolParameters]'))
ALTER TABLE [dbo].[BoolParameters] DROP CONSTRAINT [FK_BoolParameter_BaseParameter_ID]
GO
/****** Object:  ForeignKey [FK_BoolProperty_ValueTypeProperty_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BoolProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[BoolProperties]'))
ALTER TABLE [dbo].[BoolProperties] DROP CONSTRAINT [FK_BoolProperty_ValueTypeProperty_ID]
GO
/****** Object:  ForeignKey [FK_CLRObjectParameter_Assembly_fk_Assembly]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLRObjectParameter_Assembly_fk_Assembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLRObjectParameters]'))
ALTER TABLE [dbo].[CLRObjectParameters] DROP CONSTRAINT [FK_CLRObjectParameter_Assembly_fk_Assembly]
GO
/****** Object:  ForeignKey [FK_CLRObjectParameter_BaseParameter_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLRObjectParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLRObjectParameters]'))
ALTER TABLE [dbo].[CLRObjectParameters] DROP CONSTRAINT [FK_CLRObjectParameter_BaseParameter_ID]
GO
/****** Object:  ForeignKey [FK_ControlInfo_Assembly_fk_Assembly]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ControlInfo_Assembly_fk_Assembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[ControlInfos]'))
ALTER TABLE [dbo].[ControlInfos] DROP CONSTRAINT [FK_ControlInfo_Assembly_fk_Assembly]
GO
/****** Object:  ForeignKey [FK_DataType_Icon_fk_DefaultIcon]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DataType_Icon_fk_DefaultIcon]') AND parent_object_id = OBJECT_ID(N'[dbo].[DataTypes]'))
ALTER TABLE [dbo].[DataTypes] DROP CONSTRAINT [FK_DataType_Icon_fk_DefaultIcon]
GO
/****** Object:  ForeignKey [FK_DataType_Module_fk_Module]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DataType_Module_fk_Module]') AND parent_object_id = OBJECT_ID(N'[dbo].[DataTypes]'))
ALTER TABLE [dbo].[DataTypes] DROP CONSTRAINT [FK_DataType_Module_fk_Module]
GO
/****** Object:  ForeignKey [FK_DateTimeParameter_BaseParameter_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DateTimeParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[DateTimeParameters]'))
ALTER TABLE [dbo].[DateTimeParameters] DROP CONSTRAINT [FK_DateTimeParameter_BaseParameter_ID]
GO
/****** Object:  ForeignKey [FK_DateTimeProperty_ValueTypeProperty_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DateTimeProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[DateTimeProperties]'))
ALTER TABLE [dbo].[DateTimeProperties] DROP CONSTRAINT [FK_DateTimeProperty_ValueTypeProperty_ID]
GO
/****** Object:  ForeignKey [FK_DoubleParameter_BaseParameter_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DoubleParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[DoubleParameters]'))
ALTER TABLE [dbo].[DoubleParameters] DROP CONSTRAINT [FK_DoubleParameter_BaseParameter_ID]
GO
/****** Object:  ForeignKey [FK_DoubleProperty_ValueTypeProperty_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DoubleProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[DoubleProperties]'))
ALTER TABLE [dbo].[DoubleProperties] DROP CONSTRAINT [FK_DoubleProperty_ValueTypeProperty_ID]
GO
/****** Object:  ForeignKey [FK_EnumerationEntry_Enumeration_fk_Enumeration]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EnumerationEntry_Enumeration_fk_Enumeration]') AND parent_object_id = OBJECT_ID(N'[dbo].[EnumerationEntries]'))
ALTER TABLE [dbo].[EnumerationEntries] DROP CONSTRAINT [FK_EnumerationEntry_Enumeration_fk_Enumeration]
GO
/****** Object:  ForeignKey [FK_EnumerationProperty_Enumeration_fk_Enumeration]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EnumerationProperty_Enumeration_fk_Enumeration]') AND parent_object_id = OBJECT_ID(N'[dbo].[EnumerationProperties]'))
ALTER TABLE [dbo].[EnumerationProperties] DROP CONSTRAINT [FK_EnumerationProperty_Enumeration_fk_Enumeration]
GO
/****** Object:  ForeignKey [FK_EnumerationProperty_ValueTypeProperty_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EnumerationProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[EnumerationProperties]'))
ALTER TABLE [dbo].[EnumerationProperties] DROP CONSTRAINT [FK_EnumerationProperty_ValueTypeProperty_ID]
GO
/****** Object:  ForeignKey [FK_Enumeration_DataType_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Enumeration_DataType_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Enumerations]'))
ALTER TABLE [dbo].[Enumerations] DROP CONSTRAINT [FK_Enumeration_DataType_ID]
GO
/****** Object:  ForeignKey [FK_IntegerRangeConstraint_Constraint_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IntegerRangeConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[IntegerRangeConstraints]'))
ALTER TABLE [dbo].[IntegerRangeConstraints] DROP CONSTRAINT [FK_IntegerRangeConstraint_Constraint_ID]
GO
/****** Object:  ForeignKey [FK_Interface_DataType_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Interface_DataType_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Interfaces]'))
ALTER TABLE [dbo].[Interfaces] DROP CONSTRAINT [FK_Interface_DataType_ID]
GO
/****** Object:  ForeignKey [FK_IntParameter_BaseParameter_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IntParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[IntParameters]'))
ALTER TABLE [dbo].[IntParameters] DROP CONSTRAINT [FK_IntParameter_BaseParameter_ID]
GO
/****** Object:  ForeignKey [FK_IntProperty_ValueTypeProperty_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IntProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[IntProperties]'))
ALTER TABLE [dbo].[IntProperties] DROP CONSTRAINT [FK_IntProperty_ValueTypeProperty_ID]
GO
/****** Object:  ForeignKey [FK_IsValidIdentifierConstraint_Constraint_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IsValidIdentifierConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[IsValidIdentifierConstraints]'))
ALTER TABLE [dbo].[IsValidIdentifierConstraints] DROP CONSTRAINT [FK_IsValidIdentifierConstraint_Constraint_ID]
GO
/****** Object:  ForeignKey [FK_IsValidNamespaceConstraint_IsValidIdentifierConstraint_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IsValidNamespaceConstraint_IsValidIdentifierConstraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[IsValidNamespaceConstraints]'))
ALTER TABLE [dbo].[IsValidNamespaceConstraints] DROP CONSTRAINT [FK_IsValidNamespaceConstraint_IsValidIdentifierConstraint_ID]
GO
/****** Object:  ForeignKey [FK_Kostenstelle_Zeitkonto_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Kostenstelle_Zeitkonto_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Kostenstellen]'))
ALTER TABLE [dbo].[Kostenstellen] DROP CONSTRAINT [FK_Kostenstelle_Zeitkonto_ID]
GO
/****** Object:  ForeignKey [FK_Kostentraeger_Projekt_fk_Projekt]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Kostentraeger_Projekt_fk_Projekt]') AND parent_object_id = OBJECT_ID(N'[dbo].[Kostentraeger]'))
ALTER TABLE [dbo].[Kostentraeger] DROP CONSTRAINT [FK_Kostentraeger_Projekt_fk_Projekt]
GO
/****** Object:  ForeignKey [FK_Kostentraeger_Zeitkonto_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Kostentraeger_Zeitkonto_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Kostentraeger]'))
ALTER TABLE [dbo].[Kostentraeger] DROP CONSTRAINT [FK_Kostentraeger_Zeitkonto_ID]
GO
/****** Object:  ForeignKey [FK_Kunde_EMailsCollectionEntry_Kunde_fk_Kunde]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Kunde_EMailsCollectionEntry_Kunde_fk_Kunde]') AND parent_object_id = OBJECT_ID(N'[dbo].[Kunden_EMailsCollection]'))
ALTER TABLE [dbo].[Kunden_EMailsCollection] DROP CONSTRAINT [FK_Kunde_EMailsCollectionEntry_Kunde_fk_Kunde]
GO
/****** Object:  ForeignKey [FK_MethodInvocationConstraint_Constraint_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MethodInvocationConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[MethodInvocationConstraints]'))
ALTER TABLE [dbo].[MethodInvocationConstraints] DROP CONSTRAINT [FK_MethodInvocationConstraint_Constraint_ID]
GO
/****** Object:  ForeignKey [FK_MethodInvocation_DataType_fk_InvokeOnObjectClass]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MethodInvocation_DataType_fk_InvokeOnObjectClass]') AND parent_object_id = OBJECT_ID(N'[dbo].[MethodInvocations]'))
ALTER TABLE [dbo].[MethodInvocations] DROP CONSTRAINT [FK_MethodInvocation_DataType_fk_InvokeOnObjectClass]
GO
/****** Object:  ForeignKey [FK_MethodInvocation_Method_fk_Method]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MethodInvocation_Method_fk_Method]') AND parent_object_id = OBJECT_ID(N'[dbo].[MethodInvocations]'))
ALTER TABLE [dbo].[MethodInvocations] DROP CONSTRAINT [FK_MethodInvocation_Method_fk_Method]
GO
/****** Object:  ForeignKey [FK_MethodInvocation_Module_fk_Module]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MethodInvocation_Module_fk_Module]') AND parent_object_id = OBJECT_ID(N'[dbo].[MethodInvocations]'))
ALTER TABLE [dbo].[MethodInvocations] DROP CONSTRAINT [FK_MethodInvocation_Module_fk_Module]
GO
/****** Object:  ForeignKey [FK_MethodInvocation_TypeRef_fk_Implementor]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MethodInvocation_TypeRef_fk_Implementor]') AND parent_object_id = OBJECT_ID(N'[dbo].[MethodInvocations]'))
ALTER TABLE [dbo].[MethodInvocations] DROP CONSTRAINT [FK_MethodInvocation_TypeRef_fk_Implementor]
GO
/****** Object:  ForeignKey [FK_Method_DataType_fk_ObjectClass]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Method_DataType_fk_ObjectClass]') AND parent_object_id = OBJECT_ID(N'[dbo].[Methods]'))
ALTER TABLE [dbo].[Methods] DROP CONSTRAINT [FK_Method_DataType_fk_ObjectClass]
GO
/****** Object:  ForeignKey [FK_Method_Module_fk_Module]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Method_Module_fk_Module]') AND parent_object_id = OBJECT_ID(N'[dbo].[Methods]'))
ALTER TABLE [dbo].[Methods] DROP CONSTRAINT [FK_Method_Module_fk_Module]
GO
/****** Object:  ForeignKey [FK_NotNullableConstraint_Constraint_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NotNullableConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[NotNullableConstraints]'))
ALTER TABLE [dbo].[NotNullableConstraints] DROP CONSTRAINT [FK_NotNullableConstraint_Constraint_ID]
GO
/****** Object:  ForeignKey [FK_ObjectClass_DataType_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_DataType_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
ALTER TABLE [dbo].[ObjectClasses] DROP CONSTRAINT [FK_ObjectClass_DataType_ID]
GO
/****** Object:  ForeignKey [FK_ObjectClass_ObjectClass_fk_BaseObjectClass]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_ObjectClass_fk_BaseObjectClass]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
ALTER TABLE [dbo].[ObjectClasses] DROP CONSTRAINT [FK_ObjectClass_ObjectClass_fk_BaseObjectClass]
GO
/****** Object:  ForeignKey [FK_ObjectClass_PresentableModelDescriptor_fk_DefaultPresentableModelDescriptor]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_PresentableModelDescriptor_fk_DefaultPresentableModelDescriptor]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
ALTER TABLE [dbo].[ObjectClasses] DROP CONSTRAINT [FK_ObjectClass_PresentableModelDescriptor_fk_DefaultPresentableModelDescriptor]
GO
/****** Object:  ForeignKey [FK_ObjectClass_TypeRef_fk_DefaultModel]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_TypeRef_fk_DefaultModel]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
ALTER TABLE [dbo].[ObjectClasses] DROP CONSTRAINT [FK_ObjectClass_TypeRef_fk_DefaultModel]
GO
/****** Object:  ForeignKey [FK_ObjectClass_ImplementsInterfacesCollectionEntry_Interface_fk_ImplementsInterfaces]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_ImplementsInterfacesCollectionEntry_Interface_fk_ImplementsInterfaces]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses_ImplementsInterfacesCollection]'))
ALTER TABLE [dbo].[ObjectClasses_ImplementsInterfacesCollection] DROP CONSTRAINT [FK_ObjectClass_ImplementsInterfacesCollectionEntry_Interface_fk_ImplementsInterfaces]
GO
/****** Object:  ForeignKey [FK_ObjectClass_ImplementsInterfacesCollectionEntry_ObjectClass_fk_ObjectClass]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_ImplementsInterfacesCollectionEntry_ObjectClass_fk_ObjectClass]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses_ImplementsInterfacesCollection]'))
ALTER TABLE [dbo].[ObjectClasses_ImplementsInterfacesCollection] DROP CONSTRAINT [FK_ObjectClass_ImplementsInterfacesCollectionEntry_ObjectClass_fk_ObjectClass]
GO
/****** Object:  ForeignKey [FK_ObjectParameter_BaseParameter_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectParameters]'))
ALTER TABLE [dbo].[ObjectParameters] DROP CONSTRAINT [FK_ObjectParameter_BaseParameter_ID]
GO
/****** Object:  ForeignKey [FK_ObjectParameter_DataType_fk_DataType]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectParameter_DataType_fk_DataType]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectParameters]'))
ALTER TABLE [dbo].[ObjectParameters] DROP CONSTRAINT [FK_ObjectParameter_DataType_fk_DataType]
GO
/****** Object:  ForeignKey [FK_ObjectReferenceProperty_ObjectClass_fk_ReferenceObjectClass]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectReferenceProperty_ObjectClass_fk_ReferenceObjectClass]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectReferenceProperties]'))
ALTER TABLE [dbo].[ObjectReferenceProperties] DROP CONSTRAINT [FK_ObjectReferenceProperty_ObjectClass_fk_ReferenceObjectClass]
GO
/****** Object:  ForeignKey [FK_ObjectReferenceProperty_Property_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectReferenceProperty_Property_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectReferenceProperties]'))
ALTER TABLE [dbo].[ObjectReferenceProperties] DROP CONSTRAINT [FK_ObjectReferenceProperty_Property_ID]
GO
/****** Object:  ForeignKey [FK_PresentableModelDescriptors_TypeRef_fk_PresentableModelRef]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PresentableModelDescriptors_TypeRef_fk_PresentableModelRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[PresentableModelDescriptors]'))
ALTER TABLE [dbo].[PresentableModelDescriptors] DROP CONSTRAINT [FK_PresentableModelDescriptors_TypeRef_fk_PresentableModelRef]
GO
/****** Object:  ForeignKey [FK_PresenterInfo_Assembly_fk_DataAssembly]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PresenterInfo_Assembly_fk_DataAssembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[PresenterInfos]'))
ALTER TABLE [dbo].[PresenterInfos] DROP CONSTRAINT [FK_PresenterInfo_Assembly_fk_DataAssembly]
GO
/****** Object:  ForeignKey [FK_PresenterInfo_Assembly_fk_PresenterAssembly]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PresenterInfo_Assembly_fk_PresenterAssembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[PresenterInfos]'))
ALTER TABLE [dbo].[PresenterInfos] DROP CONSTRAINT [FK_PresenterInfo_Assembly_fk_PresenterAssembly]
GO
/****** Object:  ForeignKey [FK_Projekt_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Projekt_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter]') AND parent_object_id = OBJECT_ID(N'[dbo].[Projekte_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Projekte_MitarbeiterCollection] DROP CONSTRAINT [FK_Projekt_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter]
GO
/****** Object:  ForeignKey [FK_Projekt_MitarbeiterCollectionEntry_Projekt_fk_Projekt]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Projekt_MitarbeiterCollectionEntry_Projekt_fk_Projekt]') AND parent_object_id = OBJECT_ID(N'[dbo].[Projekte_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Projekte_MitarbeiterCollection] DROP CONSTRAINT [FK_Projekt_MitarbeiterCollectionEntry_Projekt_fk_Projekt]
GO
/****** Object:  ForeignKey [FK_Property_PresentableModelDescriptor_fk_ValueModelDescriptor]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Property_PresentableModelDescriptor_fk_ValueModelDescriptor]') AND parent_object_id = OBJECT_ID(N'[dbo].[Properties]'))
ALTER TABLE [dbo].[Properties] DROP CONSTRAINT [FK_Property_PresentableModelDescriptor_fk_ValueModelDescriptor]
GO
/****** Object:  ForeignKey [FK_BaseProperty_ConstraintsCollectionEntry_Constraint_fk_Constraints]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaseProperty_ConstraintsCollectionEntry_Constraint_fk_Constraints]') AND parent_object_id = OBJECT_ID(N'[dbo].[Properties_ConstraintsCollection]'))
ALTER TABLE [dbo].[Properties_ConstraintsCollection] DROP CONSTRAINT [FK_BaseProperty_ConstraintsCollectionEntry_Constraint_fk_Constraints]
GO
/****** Object:  ForeignKey [FK_Properties_ConstraintsCollection_Properties]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Properties_ConstraintsCollection_Properties]') AND parent_object_id = OBJECT_ID(N'[dbo].[Properties_ConstraintsCollection]'))
ALTER TABLE [dbo].[Properties_ConstraintsCollection] DROP CONSTRAINT [FK_Properties_ConstraintsCollection_Properties]
GO
/****** Object:  ForeignKey [FK_RelationEnd_ObjectClass_fk_Type]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RelationEnd_ObjectClass_fk_Type]') AND parent_object_id = OBJECT_ID(N'[dbo].[RelationEnds]'))
ALTER TABLE [dbo].[RelationEnds] DROP CONSTRAINT [FK_RelationEnd_ObjectClass_fk_Type]
GO
/****** Object:  ForeignKey [FK_RelationEnd_Property_fk_Navigator]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RelationEnd_Property_fk_Navigator]') AND parent_object_id = OBJECT_ID(N'[dbo].[RelationEnds]'))
ALTER TABLE [dbo].[RelationEnds] DROP CONSTRAINT [FK_RelationEnd_Property_fk_Navigator]
GO
/****** Object:  ForeignKey [FK_Relation_RelationEnd_fk_A]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Relation_RelationEnd_fk_A]') AND parent_object_id = OBJECT_ID(N'[dbo].[Relations]'))
ALTER TABLE [dbo].[Relations] DROP CONSTRAINT [FK_Relation_RelationEnd_fk_A]
GO
/****** Object:  ForeignKey [FK_Relation_RelationEnd_fk_B]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Relation_RelationEnd_fk_B]') AND parent_object_id = OBJECT_ID(N'[dbo].[Relations]'))
ALTER TABLE [dbo].[Relations] DROP CONSTRAINT [FK_Relation_RelationEnd_fk_B]
GO
/****** Object:  ForeignKey [FK_StringConstraint_Constraint_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StringConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[StringConstraints]'))
ALTER TABLE [dbo].[StringConstraints] DROP CONSTRAINT [FK_StringConstraint_Constraint_ID]
GO
/****** Object:  ForeignKey [FK_StringParameter_BaseParameter_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StringParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[StringParameters]'))
ALTER TABLE [dbo].[StringParameters] DROP CONSTRAINT [FK_StringParameter_BaseParameter_ID]
GO
/****** Object:  ForeignKey [FK_StringProperty_ValueTypeProperty_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StringProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[StringProperties]'))
ALTER TABLE [dbo].[StringProperties] DROP CONSTRAINT [FK_StringProperty_ValueTypeProperty_ID]
GO
/****** Object:  ForeignKey [FK_StringRangeConstraint_Constraint_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StringRangeConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[StringRangeConstraints]'))
ALTER TABLE [dbo].[StringRangeConstraints] DROP CONSTRAINT [FK_StringRangeConstraint_Constraint_ID]
GO
/****** Object:  ForeignKey [FK_StructProperty_Property_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StructProperty_Property_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[StructProperties]'))
ALTER TABLE [dbo].[StructProperties] DROP CONSTRAINT [FK_StructProperty_Property_ID]
GO
/****** Object:  ForeignKey [FK_StructProperty_Struct_fk_StructDefinition]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StructProperty_Struct_fk_StructDefinition]') AND parent_object_id = OBJECT_ID(N'[dbo].[StructProperties]'))
ALTER TABLE [dbo].[StructProperties] DROP CONSTRAINT [FK_StructProperty_Struct_fk_StructDefinition]
GO
/****** Object:  ForeignKey [FK_Struct_DataType_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Struct_DataType_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Structs]'))
ALTER TABLE [dbo].[Structs] DROP CONSTRAINT [FK_Struct_DataType_ID]
GO
/****** Object:  ForeignKey [FK_Task_Projekt_fk_Projekt]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Projekt_fk_Projekt]') AND parent_object_id = OBJECT_ID(N'[dbo].[Tasks]'))
ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK_Task_Projekt_fk_Projekt]
GO
/****** Object:  ForeignKey [FK_Template_Assembly_fk_DisplayedTypeAssembly]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Template_Assembly_fk_DisplayedTypeAssembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[Templates]'))
ALTER TABLE [dbo].[Templates] DROP CONSTRAINT [FK_Template_Assembly_fk_DisplayedTypeAssembly]
GO
/****** Object:  ForeignKey [FK_Template_Visual_fk_VisualTree]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Template_Visual_fk_VisualTree]') AND parent_object_id = OBJECT_ID(N'[dbo].[Templates]'))
ALTER TABLE [dbo].[Templates] DROP CONSTRAINT [FK_Template_Visual_fk_VisualTree]
GO
/****** Object:  ForeignKey [FK_Template_MenuCollectionEntry_Template_fk_Template]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Template_MenuCollectionEntry_Template_fk_Template]') AND parent_object_id = OBJECT_ID(N'[dbo].[Templates_MenuCollection]'))
ALTER TABLE [dbo].[Templates_MenuCollection] DROP CONSTRAINT [FK_Template_MenuCollectionEntry_Template_fk_Template]
GO
/****** Object:  ForeignKey [FK_Template_MenuCollectionEntry_Visual_fk_Menu]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Template_MenuCollectionEntry_Visual_fk_Menu]') AND parent_object_id = OBJECT_ID(N'[dbo].[Templates_MenuCollection]'))
ALTER TABLE [dbo].[Templates_MenuCollection] DROP CONSTRAINT [FK_Template_MenuCollectionEntry_Visual_fk_Menu]
GO
/****** Object:  ForeignKey [FK_TestObjClass_Kunde_fk_ObjectProp]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TestObjClass_Kunde_fk_ObjectProp]') AND parent_object_id = OBJECT_ID(N'[dbo].[TestObjClasses]'))
ALTER TABLE [dbo].[TestObjClasses] DROP CONSTRAINT [FK_TestObjClass_Kunde_fk_ObjectProp]
GO
/****** Object:  ForeignKey [FK_TypeRef_Assembly_fk_Assembly]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TypeRef_Assembly_fk_Assembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[TypeRefs]'))
ALTER TABLE [dbo].[TypeRefs] DROP CONSTRAINT [FK_TypeRef_Assembly_fk_Assembly]
GO
/****** Object:  ForeignKey [FK_TypeRef_TypeRef_fk_Parent]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TypeRef_TypeRef_fk_Parent]') AND parent_object_id = OBJECT_ID(N'[dbo].[TypeRefs]'))
ALTER TABLE [dbo].[TypeRefs] DROP CONSTRAINT [FK_TypeRef_TypeRef_fk_Parent]
GO
/****** Object:  ForeignKey [FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_GenericArguments]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_GenericArguments]') AND parent_object_id = OBJECT_ID(N'[dbo].[TypeRefs_GenericArgumentsCollection]'))
ALTER TABLE [dbo].[TypeRefs_GenericArgumentsCollection] DROP CONSTRAINT [FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_GenericArguments]
GO
/****** Object:  ForeignKey [FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_TypeRef]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_TypeRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[TypeRefs_GenericArgumentsCollection]'))
ALTER TABLE [dbo].[TypeRefs_GenericArgumentsCollection] DROP CONSTRAINT [FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_TypeRef]
GO
/****** Object:  ForeignKey [FK_ValueTypeProperty_Property_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ValueTypeProperty_Property_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[ValueTypeProperties]'))
ALTER TABLE [dbo].[ValueTypeProperties] DROP CONSTRAINT [FK_ValueTypeProperty_Property_ID]
GO
/****** Object:  ForeignKey [FK_ViewDescriptor_TypeRef_fk_ControlRef]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ViewDescriptor_TypeRef_fk_ControlRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[ViewDescriptors]'))
ALTER TABLE [dbo].[ViewDescriptors] DROP CONSTRAINT [FK_ViewDescriptor_TypeRef_fk_ControlRef]
GO
/****** Object:  ForeignKey [FK_ViewDescriptor_TypeRef_fk_PresentedModelDescriptor]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ViewDescriptor_TypeRef_fk_PresentedModelDescriptor]') AND parent_object_id = OBJECT_ID(N'[dbo].[ViewDescriptors]'))
ALTER TABLE [dbo].[ViewDescriptors] DROP CONSTRAINT [FK_ViewDescriptor_TypeRef_fk_PresentedModelDescriptor]
GO
/****** Object:  ForeignKey [FK_Visual_Method_fk_Method]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_Method_fk_Method]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals]'))
ALTER TABLE [dbo].[Visuals] DROP CONSTRAINT [FK_Visual_Method_fk_Method]
GO
/****** Object:  ForeignKey [FK_Visual_ChildrenCollectionEntry_Visual_fk_Children]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_ChildrenCollectionEntry_Visual_fk_Children]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_ChildrenCollection]'))
ALTER TABLE [dbo].[Visuals_ChildrenCollection] DROP CONSTRAINT [FK_Visual_ChildrenCollectionEntry_Visual_fk_Children]
GO
/****** Object:  ForeignKey [FK_Visual_ChildrenCollectionEntry_Visual_fk_Visual]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_ChildrenCollectionEntry_Visual_fk_Visual]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_ChildrenCollection]'))
ALTER TABLE [dbo].[Visuals_ChildrenCollection] DROP CONSTRAINT [FK_Visual_ChildrenCollectionEntry_Visual_fk_Visual]
GO
/****** Object:  ForeignKey [FK_Visual_ContextMenuCollectionEntry_Visual_fk_ContextMenu]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_ContextMenuCollectionEntry_Visual_fk_ContextMenu]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_ContextMenuCollection]'))
ALTER TABLE [dbo].[Visuals_ContextMenuCollection] DROP CONSTRAINT [FK_Visual_ContextMenuCollectionEntry_Visual_fk_ContextMenu]
GO
/****** Object:  ForeignKey [FK_Visual_ContextMenuCollectionEntry_Visual_fk_Visual]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_ContextMenuCollectionEntry_Visual_fk_Visual]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_ContextMenuCollection]'))
ALTER TABLE [dbo].[Visuals_ContextMenuCollection] DROP CONSTRAINT [FK_Visual_ContextMenuCollectionEntry_Visual_fk_Visual]
GO
/****** Object:  ForeignKey [FK_Visual_MenuTreeCollectionEntry_Visual_fk_MenuTree]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_MenuTreeCollectionEntry_Visual_fk_MenuTree]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_MenuTreeCollection]'))
ALTER TABLE [dbo].[Visuals_MenuTreeCollection] DROP CONSTRAINT [FK_Visual_MenuTreeCollectionEntry_Visual_fk_MenuTree]
GO
/****** Object:  ForeignKey [FK_Visual_MenuTreeCollectionEntry_Visual_fk_Visual]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_MenuTreeCollectionEntry_Visual_fk_Visual]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_MenuTreeCollection]'))
ALTER TABLE [dbo].[Visuals_MenuTreeCollection] DROP CONSTRAINT [FK_Visual_MenuTreeCollectionEntry_Visual_fk_Visual]
GO
/****** Object:  ForeignKey [FK_Zeitkonto_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Zeitkonto_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter]') AND parent_object_id = OBJECT_ID(N'[dbo].[Zeitkonten_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Zeitkonten_MitarbeiterCollection] DROP CONSTRAINT [FK_Zeitkonto_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter]
GO
/****** Object:  ForeignKey [FK_Zeitkonto_MitarbeiterCollectionEntry_Zeitkonto_fk_Zeitkonto]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Zeitkonto_MitarbeiterCollectionEntry_Zeitkonto_fk_Zeitkonto]') AND parent_object_id = OBJECT_ID(N'[dbo].[Zeitkonten_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Zeitkonten_MitarbeiterCollection] DROP CONSTRAINT [FK_Zeitkonto_MitarbeiterCollectionEntry_Zeitkonto_fk_Zeitkonto]
GO
/****** Object:  Table [dbo].[BoolProperties]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BoolProperties]') AND type in (N'U'))
DROP TABLE [dbo].[BoolProperties]
GO
/****** Object:  Table [dbo].[DateTimeProperties]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DateTimeProperties]') AND type in (N'U'))
DROP TABLE [dbo].[DateTimeProperties]
GO
/****** Object:  Table [dbo].[EnumerationProperties]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnumerationProperties]') AND type in (N'U'))
DROP TABLE [dbo].[EnumerationProperties]
GO
/****** Object:  Table [dbo].[DoubleProperties]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DoubleProperties]') AND type in (N'U'))
DROP TABLE [dbo].[DoubleProperties]
GO
/****** Object:  Table [dbo].[IntProperties]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntProperties]') AND type in (N'U'))
DROP TABLE [dbo].[IntProperties]
GO
/****** Object:  Table [dbo].[Relations]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Relations]') AND type in (N'U'))
DROP TABLE [dbo].[Relations]
GO
/****** Object:  Table [dbo].[StringProperties]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StringProperties]') AND type in (N'U'))
DROP TABLE [dbo].[StringProperties]
GO
/****** Object:  Table [dbo].[StructProperties]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StructProperties]') AND type in (N'U'))
DROP TABLE [dbo].[StructProperties]
GO
/****** Object:  Table [dbo].[Templates_MenuCollection]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Templates_MenuCollection]') AND type in (N'U'))
DROP TABLE [dbo].[Templates_MenuCollection]
GO
/****** Object:  Table [dbo].[ValueTypeProperties]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ValueTypeProperties]') AND type in (N'U'))
DROP TABLE [dbo].[ValueTypeProperties]
GO
/****** Object:  Table [dbo].[Properties_ConstraintsCollection]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Properties_ConstraintsCollection]') AND type in (N'U'))
DROP TABLE [dbo].[Properties_ConstraintsCollection]
GO
/****** Object:  Table [dbo].[RelationEnds]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RelationEnds]') AND type in (N'U'))
DROP TABLE [dbo].[RelationEnds]
GO
/****** Object:  Table [dbo].[ObjectReferenceProperties]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectReferenceProperties]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectReferenceProperties]
GO
/****** Object:  Table [dbo].[ObjectClasses_ImplementsInterfacesCollection]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectClasses_ImplementsInterfacesCollection]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectClasses_ImplementsInterfacesCollection]
GO
/****** Object:  Table [dbo].[ObjectParameters]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectParameters]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectParameters]
GO
/****** Object:  Table [dbo].[ObjectClasses]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectClasses]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectClasses]
GO
/****** Object:  Table [dbo].[IntParameters]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntParameters]') AND type in (N'U'))
DROP TABLE [dbo].[IntParameters]
GO
/****** Object:  Table [dbo].[Properties]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Properties]') AND type in (N'U'))
DROP TABLE [dbo].[Properties]
GO
/****** Object:  Table [dbo].[ViewDescriptors]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ViewDescriptors]') AND type in (N'U'))
DROP TABLE [dbo].[ViewDescriptors]
GO
/****** Object:  Table [dbo].[Visuals_ChildrenCollection]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Visuals_ChildrenCollection]') AND type in (N'U'))
DROP TABLE [dbo].[Visuals_ChildrenCollection]
GO
/****** Object:  Table [dbo].[Visuals_ContextMenuCollection]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Visuals_ContextMenuCollection]') AND type in (N'U'))
DROP TABLE [dbo].[Visuals_ContextMenuCollection]
GO
/****** Object:  Table [dbo].[Visuals_MenuTreeCollection]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Visuals_MenuTreeCollection]') AND type in (N'U'))
DROP TABLE [dbo].[Visuals_MenuTreeCollection]
GO
/****** Object:  Table [dbo].[Templates]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Templates]') AND type in (N'U'))
DROP TABLE [dbo].[Templates]
GO
/****** Object:  Table [dbo].[StringParameters]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StringParameters]') AND type in (N'U'))
DROP TABLE [dbo].[StringParameters]
GO
/****** Object:  Table [dbo].[DateTimeParameters]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DateTimeParameters]') AND type in (N'U'))
DROP TABLE [dbo].[DateTimeParameters]
GO
/****** Object:  Table [dbo].[DoubleParameters]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DoubleParameters]') AND type in (N'U'))
DROP TABLE [dbo].[DoubleParameters]
GO
/****** Object:  Table [dbo].[BoolParameters]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BoolParameters]') AND type in (N'U'))
DROP TABLE [dbo].[BoolParameters]
GO
/****** Object:  Table [dbo].[CLRObjectParameters]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLRObjectParameters]') AND type in (N'U'))
DROP TABLE [dbo].[CLRObjectParameters]
GO
/****** Object:  Table [dbo].[BaseParameters]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BaseParameters]') AND type in (N'U'))
DROP TABLE [dbo].[BaseParameters]
GO
/****** Object:  Table [dbo].[EnumerationEntries]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnumerationEntries]') AND type in (N'U'))
DROP TABLE [dbo].[EnumerationEntries]
GO
/****** Object:  Table [dbo].[MethodInvocations]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MethodInvocations]') AND type in (N'U'))
DROP TABLE [dbo].[MethodInvocations]
GO
/****** Object:  Table [dbo].[TypeRefs_GenericArgumentsCollection]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TypeRefs_GenericArgumentsCollection]') AND type in (N'U'))
DROP TABLE [dbo].[TypeRefs_GenericArgumentsCollection]
GO
/****** Object:  Table [dbo].[Visuals]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Visuals]') AND type in (N'U'))
DROP TABLE [dbo].[Visuals]
GO
/****** Object:  Table [dbo].[PresentableModelDescriptors]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PresentableModelDescriptors]') AND type in (N'U'))
DROP TABLE [dbo].[PresentableModelDescriptors]
GO
/****** Object:  Table [dbo].[PresenterInfos]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PresenterInfos]') AND type in (N'U'))
DROP TABLE [dbo].[PresenterInfos]
GO
/****** Object:  Table [dbo].[IsValidNamespaceConstraints]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IsValidNamespaceConstraints]') AND type in (N'U'))
DROP TABLE [dbo].[IsValidNamespaceConstraints]
GO
/****** Object:  Table [dbo].[Structs]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Structs]') AND type in (N'U'))
DROP TABLE [dbo].[Structs]
GO
/****** Object:  Table [dbo].[TypeRefs]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TypeRefs]') AND type in (N'U'))
DROP TABLE [dbo].[TypeRefs]
GO
/****** Object:  Table [dbo].[Methods]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Methods]') AND type in (N'U'))
DROP TABLE [dbo].[Methods]
GO
/****** Object:  Table [dbo].[Interfaces]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Interfaces]') AND type in (N'U'))
DROP TABLE [dbo].[Interfaces]
GO
/****** Object:  Table [dbo].[Enumerations]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Enumerations]') AND type in (N'U'))
DROP TABLE [dbo].[Enumerations]
GO
/****** Object:  Table [dbo].[ControlInfos]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ControlInfos]') AND type in (N'U'))
DROP TABLE [dbo].[ControlInfos]
GO
/****** Object:  Table [dbo].[DataTypes]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DataTypes]') AND type in (N'U'))
DROP TABLE [dbo].[DataTypes]
GO
/****** Object:  Table [dbo].[Assemblies]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Assemblies]') AND type in (N'U'))
DROP TABLE [dbo].[Assemblies]
GO
/****** Object:  Table [dbo].[Auftraege]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Auftraege]') AND type in (N'U'))
DROP TABLE [dbo].[Auftraege]
GO
/****** Object:  Table [dbo].[IsValidIdentifierConstraints]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IsValidIdentifierConstraints]') AND type in (N'U'))
DROP TABLE [dbo].[IsValidIdentifierConstraints]
GO
/****** Object:  Table [dbo].[IntegerRangeConstraints]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntegerRangeConstraints]') AND type in (N'U'))
DROP TABLE [dbo].[IntegerRangeConstraints]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tasks]') AND type in (N'U'))
DROP TABLE [dbo].[Tasks]
GO
/****** Object:  Table [dbo].[Projekte_MitarbeiterCollection]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Projekte_MitarbeiterCollection]') AND type in (N'U'))
DROP TABLE [dbo].[Projekte_MitarbeiterCollection]
GO
/****** Object:  Table [dbo].[StringRangeConstraints]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StringRangeConstraints]') AND type in (N'U'))
DROP TABLE [dbo].[StringRangeConstraints]
GO
/****** Object:  Table [dbo].[TestObjClasses]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TestObjClasses]') AND type in (N'U'))
DROP TABLE [dbo].[TestObjClasses]
GO
/****** Object:  Table [dbo].[Zeitkonten_MitarbeiterCollection]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Zeitkonten_MitarbeiterCollection]') AND type in (N'U'))
DROP TABLE [dbo].[Zeitkonten_MitarbeiterCollection]
GO
/****** Object:  Table [dbo].[Kostenstellen]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kostenstellen]') AND type in (N'U'))
DROP TABLE [dbo].[Kostenstellen]
GO
/****** Object:  Table [dbo].[Kostentraeger]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kostentraeger]') AND type in (N'U'))
DROP TABLE [dbo].[Kostentraeger]
GO
/****** Object:  Table [dbo].[MethodInvocationConstraints]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MethodInvocationConstraints]') AND type in (N'U'))
DROP TABLE [dbo].[MethodInvocationConstraints]
GO
/****** Object:  Table [dbo].[Kunden_EMailsCollection]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kunden_EMailsCollection]') AND type in (N'U'))
DROP TABLE [dbo].[Kunden_EMailsCollection]
GO
/****** Object:  Table [dbo].[NotNullableConstraints]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NotNullableConstraints]') AND type in (N'U'))
DROP TABLE [dbo].[NotNullableConstraints]
GO
/****** Object:  Table [dbo].[StringConstraints]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StringConstraints]') AND type in (N'U'))
DROP TABLE [dbo].[StringConstraints]
GO
/****** Object:  Table [dbo].[Projekte]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Projekte]') AND type in (N'U'))
DROP TABLE [dbo].[Projekte]
GO
/****** Object:  Table [dbo].[ObjectForDeletedProperties]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectForDeletedProperties]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectForDeletedProperties]
GO
/****** Object:  Table [dbo].[LastTests]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LastTests]') AND type in (N'U'))
DROP TABLE [dbo].[LastTests]
GO
/****** Object:  Table [dbo].[Kunden]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kunden]') AND type in (N'U'))
DROP TABLE [dbo].[Kunden]
GO
/****** Object:  Table [dbo].[Zeitkonten]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Zeitkonten]') AND type in (N'U'))
DROP TABLE [dbo].[Zeitkonten]
GO
/****** Object:  Table [dbo].[TestCustomObjects]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TestCustomObjects]') AND type in (N'U'))
DROP TABLE [dbo].[TestCustomObjects]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_ColumnExists]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_ColumnExists]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_ColumnExists]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_FKConstraintExists]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_FKConstraintExists]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_FKConstraintExists]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_TableExists]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_TableExists]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fn_TableExists]
GO
/****** Object:  Table [dbo].[Icons]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Icons]') AND type in (N'U'))
DROP TABLE [dbo].[Icons]
GO
/****** Object:  Table [dbo].[Mitarbeiter]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mitarbeiter]') AND type in (N'U'))
DROP TABLE [dbo].[Mitarbeiter]
GO
/****** Object:  Table [dbo].[Modules]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Modules]') AND type in (N'U'))
DROP TABLE [dbo].[Modules]
GO
/****** Object:  Table [dbo].[Muhblas]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Muhblas]') AND type in (N'U'))
DROP TABLE [dbo].[Muhblas]
GO
/****** Object:  Table [dbo].[AnotherTests]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AnotherTests]') AND type in (N'U'))
DROP TABLE [dbo].[AnotherTests]
GO
/****** Object:  Table [dbo].[Constraints]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Constraints]') AND type in (N'U'))
DROP TABLE [dbo].[Constraints]
GO
/****** Object:  Default [DF__ObjectCla__Table__0F975522]    Script Date: 04/27/2009 16:11:31 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__ObjectCla__Table__0F975522]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__ObjectCla__Table__0F975522]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ObjectClasses] DROP CONSTRAINT [DF__ObjectCla__Table__0F975522]
END


End
GO
/****** Object:  Table [dbo].[Constraints]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Constraints]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Constraints](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Reason] [nvarchar](400) COLLATE Latin1_General_CI_AS NULL,
	[fk_ConstrainedProperty] [int] NOT NULL,
	[fk_ConstrainedProperty_pos] [int] NULL,
 CONSTRAINT [PK_Constraints] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Constraints] ON
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (74, NULL, 171, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (75, NULL, 169, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (76, NULL, 168, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (77, NULL, 163, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (78, NULL, 162, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (79, NULL, 155, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (80, NULL, 154, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (81, NULL, 153, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (82, NULL, 150, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (83, NULL, 149, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (84, NULL, 148, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (85, NULL, 139, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (86, NULL, 138, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (87, NULL, 137, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (88, NULL, 136, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (89, NULL, 135, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (90, NULL, 130, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (91, NULL, 129, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (92, NULL, 124, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (93, NULL, 119, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (94, NULL, 118, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (95, NULL, 117, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (96, NULL, 116, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (97, NULL, 115, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (98, NULL, 114, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (99, NULL, 113, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (100, NULL, 112, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (101, NULL, 111, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (102, NULL, 110, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (103, NULL, 109, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (104, NULL, 108, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (105, NULL, 107, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (106, NULL, 104, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (107, NULL, 100, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (108, NULL, 99, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (109, NULL, 97, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (110, NULL, 95, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (111, NULL, 94, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (113, NULL, 92, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (114, NULL, 91, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (115, NULL, 87, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (117, NULL, 83, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (118, NULL, 79, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (119, NULL, 78, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (120, NULL, 77, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (123, NULL, 74, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (124, NULL, 73, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (125, NULL, 72, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (126, NULL, 71, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (127, NULL, 70, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (128, NULL, 68, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (129, NULL, 61, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (130, NULL, 59, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (133, NULL, 55, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (134, NULL, 54, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (136, NULL, 52, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (137, NULL, 45, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (138, NULL, 43, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (139, NULL, 42, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (140, NULL, 30, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (141, NULL, 29, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (142, NULL, 26, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (143, NULL, 11, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (144, NULL, 8, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (145, NULL, 3, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (146, NULL, 1, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (147, N'Strings have to have at least one character.', 28, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (148, N'strings in the database should not be longer than 4k', 172, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (149, N'strings in the database should not be longer than 4k', 173, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (150, NULL, 173, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (151, NULL, 172, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (152, NULL, 167, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (153, NULL, 162, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (154, NULL, 154, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (155, NULL, 149, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (156, NULL, 148, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (157, NULL, 139, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (158, NULL, 136, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (159, NULL, 130, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (160, NULL, 128, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (161, NULL, 127, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (162, N'', 115, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (163, NULL, 109, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (164, NULL, 107, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (165, NULL, 99, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (166, NULL, 91, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (167, NULL, 87, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (168, NULL, 85, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (169, NULL, 77, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (171, NULL, 71, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (172, NULL, 68, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (173, NULL, 63, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (174, NULL, 62, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (175, NULL, 61, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (176, NULL, 60, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (177, NULL, 59, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (178, NULL, 52, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (179, NULL, 50, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (180, NULL, 48, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (181, NULL, 43, NULL)
GO
print 'Processed 100 total records'
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (182, NULL, 42, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (183, NULL, 41, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (184, NULL, 40, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (185, NULL, 39, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (186, NULL, 30, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (187, NULL, 20, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (188, NULL, 15, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (189, NULL, 13, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (190, NULL, 9, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (191, NULL, 3, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (192, N'Classes should have a non-empty name. Names longer than 51 become unwieldy.', 1, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (193, N'Method.ObjectClass and InvokeOnObjectClass have to match.', 74, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (194, NULL, 3, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (195, NULL, 1, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (196, NULL, 9, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (198, NULL, 42, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (199, NULL, 30, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (200, NULL, 91, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (201, NULL, 136, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (202, NULL, 174, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (203, NULL, 179, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (204, NULL, 178, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (205, NULL, 177, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (206, NULL, 176, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (207, NULL, 175, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (208, NULL, 180, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (209, NULL, 184, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (212, N'Cannot create legal O/R mapping without length', 28, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (213, NULL, 209, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (214, NULL, 210, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (215, N'A ViewDescriptor must reference the described View.', 211, NULL)
INSERT [dbo].[Constraints] ([ID], [Reason], [fk_ConstrainedProperty], [fk_ConstrainedProperty_pos]) VALUES (216, N'RelationEndRole can only be 1 (''A'') or 2 (''B'')', 217, NULL)
SET IDENTITY_INSERT [dbo].[Constraints] OFF
/****** Object:  Table [dbo].[AnotherTests]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AnotherTests]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AnotherTests](
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_AnotherTests] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Muhblas]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Muhblas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Muhblas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Muhblas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Modules]    Script Date: 04/27/2009 16:11:31 ******/
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
	[Description] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_Module] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Modules] ON
INSERT [dbo].[Modules] ([ID], [Namespace], [ModuleName], [Description]) VALUES (1, N'Kistl.App.Base', N'KistlBase', NULL)
INSERT [dbo].[Modules] ([ID], [Namespace], [ModuleName], [Description]) VALUES (2, N'Kistl.App.Projekte', N'Projekte', NULL)
INSERT [dbo].[Modules] ([ID], [Namespace], [ModuleName], [Description]) VALUES (3, N'Kistl.App.Zeiterfassung', N'Zeiterfassung', NULL)
INSERT [dbo].[Modules] ([ID], [Namespace], [ModuleName], [Description]) VALUES (4, N'Kistl.App.GUI', N'GUI', NULL)
INSERT [dbo].[Modules] ([ID], [Namespace], [ModuleName], [Description]) VALUES (5, N'Kistl.App.Test', N'TestModule', NULL)
SET IDENTITY_INSERT [dbo].[Modules] OFF
/****** Object:  Table [dbo].[Mitarbeiter]    Script Date: 04/27/2009 16:11:31 ******/
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
INSERT [dbo].[Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (1, N'DI David Schmitt', NULL, N'asdf', NULL)
INSERT [dbo].[Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (2, N'Arthur Zaczek', CAST(0x00006F9700000000 AS DateTime), N'1234', N'')
INSERT [dbo].[Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (3, N'Susanne Dobler', NULL, NULL, NULL)
INSERT [dbo].[Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (4, N'Josef Pfleger', NULL, N'123', NULL)
INSERT [dbo].[Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (5, N'Peter Mayer', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Mitarbeiter] OFF
/****** Object:  Table [dbo].[Icons]    Script Date: 04/27/2009 16:11:31 ******/
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
/****** Object:  UserDefinedFunction [dbo].[fn_TableExists]    Script Date: 04/27/2009 16:11:31 ******/
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
/****** Object:  UserDefinedFunction [dbo].[fn_FKConstraintExists]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_FKConstraintExists]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE function [dbo].[fn_FKConstraintExists] (@fk_constraint nvarchar(500)) returns bit
begin
declare @result int
SELECT @result = count(*) FROM sys.objects 
	WHERE object_id = OBJECT_ID(@fk_constraint) AND type in (N''F'')
return convert(bit, @result)
end

' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[fn_ColumnExists]    Script Date: 04/27/2009 16:11:31 ******/
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
/****** Object:  Table [dbo].[TestCustomObjects]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TestCustomObjects]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TestCustomObjects](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PersonName] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[PhoneNumberMobile_Number] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
	[PhoneNumberMobile_AreaCode] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
	[PhoneNumberOffice_Number] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
	[PhoneNumberOffice_AreaCode] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
	[Birthday] [datetime] NULL,
 CONSTRAINT [PK_TestCustomObjects] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[TestCustomObjects] ON
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (1, N'TestPerson 1631444502', N'1768014687', N'1', N'0.0483946614192774', N'1', CAST(0x00009AF200F5684B AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (2, N'TestPerson 668408229', N'1017303345', N'1', N'1017303345', N'1', CAST(0x00009AF20102CAD5 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (3, N'TestPerson 612671113', N'449166542', N'1', N'449166542', N'1', CAST(0x00009AF20103AFED AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (4, N'TestPerson 1303888886', N'1653762989', N'1', N'1653762989', N'1', CAST(0x00009AF201043B6E AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (5, N'TestPerson 1114544050', N'1908441677', N'1', N'1908441677', N'1', CAST(0x00009AF20104DD2F AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (6, N'TestPerson 2056499088', N'1951616029', N'1', N'1951616029', N'1', CAST(0x00009AF2010FA16D AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (7, N'TestPerson 1059938944', N'910906200', N'1', N'910906200', N'1', CAST(0x00009AF20111B514 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (8, N'TestPerson 303235821', N'1563468126', N'1', N'1563468126', N'1', CAST(0x00009AF2011257B6 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (9, N'TestPerson 1402003243', N'119241189', N'1', N'119241189', N'1', CAST(0x00009AF20112F1B0 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (10, N'TestPerson 20921760', N'188615653', N'1', N'188615653', N'1', CAST(0x00009AF201184258 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (11, N'TestPerson 965300374', N'1654044216', N'1', N'1654044216', N'1', CAST(0x00009AF201188739 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (12, N'TestPerson 1175150861', N'1928070763', N'1', N'1928070763', N'1', CAST(0x00009B4601153898 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (13, N'TestPerson 1698574166', N'1009005532', N'1', N'1009005532', N'1', CAST(0x00009B4601157431 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (14, N'TestPerson 1791266096', N'959286373', N'1', N'959286373', N'1', CAST(0x00009B460126C2A2 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (15, N'TestPerson 957226129', N'457327195', N'1', N'457327195', N'1', CAST(0x00009B4900916CAC AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (16, N'TestPerson 1317848075', N'1248558912', N'1', N'1248558912', N'1', CAST(0x00009B5A00EFF61D AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (17, N'TestPerson 1322696194', N'497878945', N'1', N'497878945', N'1', CAST(0x00009B5A00F126FB AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (18, N'TestPerson 299301653', N'1462843748', N'1', N'1462843748', N'1', CAST(0x00009B5A00F1C6DD AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (19, N'TestPerson 1247437002', N'1069636784', N'1', N'1069636784', N'1', CAST(0x00009B5A00F5A412 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (20, N'TestPerson 429153935', N'748836558', N'1', N'748836558', N'1', CAST(0x00009B5A00F741DD AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (21, N'TestPerson 1006129277', N'819641689', N'1', N'819641689', N'1', CAST(0x00009B5A00FDC17C AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (22, N'TestPerson 847866517', N'1366896772', N'1', N'1366896772', N'1', CAST(0x00009B5A010030B5 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (23, N'TestPerson 843087413', N'541098405', N'1', N'541098405', N'1', CAST(0x00009B5A010B0A29 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (24, N'TestPerson 981200617', N'897968082', N'1', N'897968082', N'1', CAST(0x00009B5A010CC3FB AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (25, N'TestPerson 883845878', N'289208922', N'1', N'289208922', N'1', CAST(0x00009B5B00C9E845 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (26, N'TestPerson 354825311', N'357282141', N'1', N'357282141', N'1', CAST(0x00009B5B00CBCAB0 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (27, N'TestPerson 905620022', N'1775521091', N'1', N'1775521091', N'1', CAST(0x00009B5B00CC2544 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (28, N'TestPerson 23266482', N'1310781919', N'1', N'1310781919', N'1', CAST(0x00009B5B00CD3E30 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (29, N'TestPerson 671814158', N'1606859041', N'1', N'1606859041', N'1', CAST(0x00009B5B00CDB0DB AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (30, N'TestPerson 1061875724', N'148072994', N'1', N'148072994', N'1', CAST(0x00009B5B00D82E92 AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (31, N'TestPerson 1170462528', N'1710876255', N'1', N'1710876255', N'1', CAST(0x00009B5B00D902AB AS DateTime))
INSERT [dbo].[TestCustomObjects] ([ID], [PersonName], [PhoneNumberMobile_Number], [PhoneNumberMobile_AreaCode], [PhoneNumberOffice_Number], [PhoneNumberOffice_AreaCode], [Birthday]) VALUES (32, N'TestPerson 48153817', N'1314816534', N'1', N'1314816534', N'1', CAST(0x00009B5B011FB70F AS DateTime))
SET IDENTITY_INSERT [dbo].[TestCustomObjects] OFF
/****** Object:  Table [dbo].[Zeitkonten]    Script Date: 04/27/2009 16:11:31 ******/
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
	[Notizen] [nvarchar](4000) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_Zeitkonto] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Zeitkonten] ON
INSERT [dbo].[Zeitkonten] ([ID], [Kontoname], [MaxStunden], [AktuelleStunden], [Notizen]) VALUES (2, N'Kistlkostenträger', 70, 41.5, NULL)
INSERT [dbo].[Zeitkonten] ([ID], [Kontoname], [MaxStunden], [AktuelleStunden], [Notizen]) VALUES (3, N'Urlaube', NULL, 8, NULL)
INSERT [dbo].[Zeitkonten] ([ID], [Kontoname], [MaxStunden], [AktuelleStunden], [Notizen]) VALUES (4, N'Neuer Kostenträger für Ziviltechniker', 40, 0, NULL)
INSERT [dbo].[Zeitkonten] ([ID], [Kontoname], [MaxStunden], [AktuelleStunden], [Notizen]) VALUES (8, N'test', 100, 0, NULL)
INSERT [dbo].[Zeitkonten] ([ID], [Kontoname], [MaxStunden], [AktuelleStunden], [Notizen]) VALUES (9, N'test3333', 111, 0, NULL)
INSERT [dbo].[Zeitkonten] ([ID], [Kontoname], [MaxStunden], [AktuelleStunden], [Notizen]) VALUES (10, N'Test für''s rechnungswesen', 1, 0, NULL)
INSERT [dbo].[Zeitkonten] ([ID], [Kontoname], [MaxStunden], [AktuelleStunden], [Notizen]) VALUES (11, N'asdf', 1, 0, NULL)
SET IDENTITY_INSERT [dbo].[Zeitkonten] OFF
/****** Object:  Table [dbo].[Kunden]    Script Date: 04/27/2009 16:11:31 ******/
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
/****** Object:  Table [dbo].[LastTests]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LastTests]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LastTests](
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_LastTests] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[ObjectForDeletedProperties]    Script Date: 04/27/2009 16:11:31 ******/
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
/****** Object:  Table [dbo].[Projekte]    Script Date: 04/27/2009 16:11:31 ******/
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
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (1, N'Kistl', 0, N'Wir selbst')
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (2, N'Ziviltechniker', 65, N'test')
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (3, N'WebCMS.net V1.0', 0, NULL)
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (4, N'Rechnungswesen', 2, NULL)
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (5, N'Neues Projekt test', 11, NULL)
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (6, N'test_abc2', 20, NULL)
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (7, N'Neues Objekt', 0, N'')
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (12, N'Neues Projekt im Context', 103, NULL)
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (17, N'Another Project', NULL, NULL)
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (18, N'Muhblah', 11, N'asdf')
INSERT [dbo].[Projekte] ([ID], [Name], [AufwandGes], [Kundenname]) VALUES (19, N'WebProjekt', 1000, N'test')
SET IDENTITY_INSERT [dbo].[Projekte] OFF
/****** Object:  Table [dbo].[StringConstraints]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StringConstraints]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StringConstraints](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_StringConstraints] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[NotNullableConstraints]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NotNullableConstraints]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NotNullableConstraints](
	[ID] [int] NOT NULL,
	[Reason] [nvarchar](400) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_NotNullableConstraints] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (74, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (75, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (76, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (77, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (78, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (79, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (80, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (81, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (82, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (83, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (84, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (85, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (86, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (87, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (88, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (89, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (90, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (91, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (92, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (93, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (94, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (95, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (96, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (97, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (98, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (99, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (100, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (101, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (102, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (103, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (104, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (105, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (106, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (107, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (108, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (109, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (110, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (111, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (113, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (114, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (115, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (117, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (118, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (119, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (120, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (123, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (124, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (125, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (126, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (127, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (128, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (129, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (130, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (133, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (134, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (136, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (137, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (138, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (139, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (140, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (141, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (142, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (143, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (144, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (145, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (146, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (150, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (151, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (202, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (212, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (213, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (214, NULL)
INSERT [dbo].[NotNullableConstraints] ([ID], [Reason]) VALUES (215, NULL)
/****** Object:  Table [dbo].[Kunden_EMailsCollection]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kunden_EMailsCollection]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Kunden_EMailsCollection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Kunde] [int] NOT NULL,
	[EMails] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Kunden_EMailsCollection] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Kunden_EMailsCollection] ON
INSERT [dbo].[Kunden_EMailsCollection] ([ID], [fk_Kunde], [EMails]) VALUES (6, 2, N'susanne.dobler@mail.com')
INSERT [dbo].[Kunden_EMailsCollection] ([ID], [fk_Kunde], [EMails]) VALUES (42, 1, N'UnitTest21.11.2008 13:10:03@dasz.at')
INSERT [dbo].[Kunden_EMailsCollection] ([ID], [fk_Kunde], [EMails]) VALUES (43, 1, N'UnitTest21.11.2008 17:27:28@dasz.at')
INSERT [dbo].[Kunden_EMailsCollection] ([ID], [fk_Kunde], [EMails]) VALUES (45, 1, N'')
INSERT [dbo].[Kunden_EMailsCollection] ([ID], [fk_Kunde], [EMails]) VALUES (46, 1, N'')
SET IDENTITY_INSERT [dbo].[Kunden_EMailsCollection] OFF
/****** Object:  Table [dbo].[MethodInvocationConstraints]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MethodInvocationConstraints]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MethodInvocationConstraints](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_MethodInvocationConstraints] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[MethodInvocationConstraints] ([ID]) VALUES (193)
/****** Object:  Table [dbo].[Kostentraeger]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kostentraeger]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Kostentraeger](
	[ID] [int] NOT NULL,
	[fk_Projekt] [int] NOT NULL,
	[fk_Projekt_pos] [int] NULL,
 CONSTRAINT [PK_Kostentraeger] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Kostentraeger] ([ID], [fk_Projekt], [fk_Projekt_pos]) VALUES (2, 1, NULL)
INSERT [dbo].[Kostentraeger] ([ID], [fk_Projekt], [fk_Projekt_pos]) VALUES (4, 2, NULL)
INSERT [dbo].[Kostentraeger] ([ID], [fk_Projekt], [fk_Projekt_pos]) VALUES (8, 4, NULL)
INSERT [dbo].[Kostentraeger] ([ID], [fk_Projekt], [fk_Projekt_pos]) VALUES (9, 19, NULL)
INSERT [dbo].[Kostentraeger] ([ID], [fk_Projekt], [fk_Projekt_pos]) VALUES (10, 4, NULL)
INSERT [dbo].[Kostentraeger] ([ID], [fk_Projekt], [fk_Projekt_pos]) VALUES (11, 4, NULL)
/****** Object:  Table [dbo].[Kostenstellen]    Script Date: 04/27/2009 16:11:31 ******/
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
/****** Object:  Table [dbo].[Zeitkonten_MitarbeiterCollection]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Zeitkonten_MitarbeiterCollection]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Zeitkonten_MitarbeiterCollection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Zeitkonto] [int] NOT NULL,
	[fk_Mitarbeiter] [int] NOT NULL,
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
/****** Object:  Table [dbo].[TestObjClasses]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TestObjClasses]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TestObjClasses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StringProp] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[TestEnumProp] [int] NOT NULL,
	[fk_ObjectProp] [int] NOT NULL,
	[MyIntProperty] [int] NULL,
	[fk_ObjectProp_pos] [int] NULL,
 CONSTRAINT [PK_TestObjClasses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[TestObjClasses] ON
INSERT [dbo].[TestObjClasses] ([ID], [StringProp], [TestEnumProp], [fk_ObjectProp], [MyIntProperty], [fk_ObjectProp_pos]) VALUES (5, N'First', 0, 1, NULL, NULL)
INSERT [dbo].[TestObjClasses] ([ID], [StringProp], [TestEnumProp], [fk_ObjectProp], [MyIntProperty], [fk_ObjectProp_pos]) VALUES (6, N'Second', 1, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[TestObjClasses] OFF
/****** Object:  Table [dbo].[StringRangeConstraints]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StringRangeConstraints]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StringRangeConstraints](
	[ID] [int] NOT NULL,
	[MaxLength] [int] NOT NULL,
	[MinLength] [int] NOT NULL,
 CONSTRAINT [PK_StringRangeConstraints] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (152, 400, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (153, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (154, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (155, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (156, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (157, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (158, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (159, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (160, 50, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (161, 50, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (162, 200, 1)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (163, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (164, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (165, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (166, 100, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (167, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (168, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (169, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (171, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (172, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (173, 50, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (174, 100, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (175, 10, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (176, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (177, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (178, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (179, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (180, 100, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (181, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (182, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (183, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (184, 50, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (185, 20, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (186, 100, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (187, 100, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (188, 100, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (189, 100, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (190, 100, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (191, 100, 1)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (192, 51, 1)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (203, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (204, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (205, 600, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (206, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (207, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (208, 200, 0)
INSERT [dbo].[StringRangeConstraints] ([ID], [MaxLength], [MinLength]) VALUES (209, 200, 0)
/****** Object:  Table [dbo].[Projekte_MitarbeiterCollection]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Projekte_MitarbeiterCollection]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Projekte_MitarbeiterCollection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Projekt] [int] NOT NULL,
	[fk_Mitarbeiter] [int] NOT NULL,
	[fk_Projekt_pos] [int] NULL,
	[fk_Mitarbeiter_pos] [int] NULL,
 CONSTRAINT [PK_Projekte_MitarbeiterCollection] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Projekte_MitarbeiterCollection] ON
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter], [fk_Projekt_pos], [fk_Mitarbeiter_pos]) VALUES (8, 4, 2, NULL, NULL)
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter], [fk_Projekt_pos], [fk_Mitarbeiter_pos]) VALUES (9, 3, 3, NULL, NULL)
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter], [fk_Projekt_pos], [fk_Mitarbeiter_pos]) VALUES (20, 17, 4, NULL, NULL)
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter], [fk_Projekt_pos], [fk_Mitarbeiter_pos]) VALUES (26, 2, 5, -1, 2)
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter], [fk_Projekt_pos], [fk_Mitarbeiter_pos]) VALUES (28, 2, 2, -1, 0)
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter], [fk_Projekt_pos], [fk_Mitarbeiter_pos]) VALUES (29, 2, 1, -1, 2)
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter], [fk_Projekt_pos], [fk_Mitarbeiter_pos]) VALUES (30, 5, 1, -1, 0)
INSERT [dbo].[Projekte_MitarbeiterCollection] ([ID], [fk_Projekt], [fk_Mitarbeiter], [fk_Projekt_pos], [fk_Mitarbeiter_pos]) VALUES (31, 18, 1, -1, 0)
SET IDENTITY_INSERT [dbo].[Projekte_MitarbeiterCollection] OFF
/****** Object:  Table [dbo].[Tasks]    Script Date: 04/27/2009 16:11:31 ******/
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
	[fk_Projekt_pos] [int] NULL,
 CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Tasks] ON
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (1, N'Planung Ziviltechniker', CAST(0x000098A900000000 AS DateTime), CAST(0x000098C800000000 AS DateTime), 44, 2, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (2, N'Umsetzung Ziviltechniker', CAST(0x000098A900000000 AS DateTime), CAST(0x000098C800000000 AS DateTime), 10, 2, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (3, N'Planung Kistl', CAST(0x0000988F00000000 AS DateTime), CAST(0x000098E400000000 AS DateTime), 10, NULL, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (5, N'Ein Test2', CAST(0x0000901A00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), 10, 5, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (7, N'Neue Aufgabe', CAST(0x000098A900000000 AS DateTime), CAST(0x000098E400000000 AS DateTime), 10, 6, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (8, N'Zweite Aufgabe', CAST(0x000098A900000000 AS DateTime), CAST(0x000098AC00000000 AS DateTime), 10, 6, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (9, N'Buchhaltungsprogramm schreiben', NULL, NULL, 10, 17, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (10, N'Neuer Task', CAST(0x00009A0400000000 AS DateTime), CAST(0x00009A0500000000 AS DateTime), 1, 4, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (11, N'test', NULL, NULL, 1, 12, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (12, N'test2', NULL, NULL, 101, 12, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (13, N'NUnit Test Task', CAST(0x00009A6E00EAD54C AS DateTime), CAST(0x00009A6F00EAD54C AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (14, N'NUnit Test Task', CAST(0x00009A6E00EB35CE AS DateTime), CAST(0x00009A6F00EB35CE AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (15, N'NUnit Test Task', CAST(0x00009A6E00F414C2 AS DateTime), CAST(0x00009A6F00F414C2 AS DateTime), 1, 4, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (16, N'NUnit Test Task', CAST(0x00009A6E00F4712C AS DateTime), CAST(0x00009A6F00F4712C AS DateTime), 1, 5, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (17, N'NUnit Test Task', CAST(0x00009A6E00F49D28 AS DateTime), CAST(0x00009A6F00F49D28 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (18, N'NUnit Test Task', CAST(0x00009A6E00F4BBF6 AS DateTime), CAST(0x00009A6F00F4BBF6 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (19, N'TestTask', NULL, NULL, 1, 17, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (21, N'asdf', NULL, NULL, 2, 17, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (22, N'asdf', NULL, NULL, NULL, 17, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (23, N'test', NULL, NULL, 11, 18, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (24, N'New Task for Testing', NULL, NULL, 11, 2, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (25, N'NUnit Test Task', CAST(0x00009AE20123BCE6 AS DateTime), CAST(0x00009AE30123BCE6 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (26, N'NUnit Test Task', CAST(0x00009AE201257648 AS DateTime), CAST(0x00009AE301257648 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (27, N'NUnit Test Task', CAST(0x00009AE2012B3EC7 AS DateTime), CAST(0x00009AE3012B3EC7 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (28, N'NUnit Test Task', CAST(0x00009AE2013563AA AS DateTime), CAST(0x00009AE3013563AA AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (29, N'NUnit Test Task', CAST(0x00009AE20135A0BD AS DateTime), CAST(0x00009AE30135A0BD AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (30, N'NUnit Test Task', CAST(0x00009AE400B09584 AS DateTime), CAST(0x00009AE500B09584 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (31, N'NUnit Test Task', CAST(0x00009AE400B10129 AS DateTime), CAST(0x00009AE500B10129 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (32, N'NUnit Test Task', CAST(0x00009AE400CBC965 AS DateTime), CAST(0x00009AE500CBC965 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (33, N'NUnit Test Task', CAST(0x00009AE40132AF38 AS DateTime), CAST(0x00009AE50132AF38 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (34, N'NUnit Test Task', CAST(0x00009B4601153802 AS DateTime), CAST(0x00009B4701153802 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (35, N'NUnit Test Task', CAST(0x00009B4601157396 AS DateTime), CAST(0x00009B4701157396 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (36, N'NUnit Test Task', CAST(0x00009B460126C20C AS DateTime), CAST(0x00009B470126C20C AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (37, N'NUnit Test Task', CAST(0x00009B4900916C00 AS DateTime), CAST(0x00009B4A00916C00 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (38, N'NUnit Test Task', CAST(0x00009B5A00EFF492 AS DateTime), CAST(0x00009B5B00EFF492 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (39, N'NUnit Test Task', CAST(0x00009B5A00F125BC AS DateTime), CAST(0x00009B5B00F125BC AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (40, N'NUnit Test Task', CAST(0x00009B5A00F1C5A7 AS DateTime), CAST(0x00009B5B00F1C5A7 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (41, N'NUnit Test Task', CAST(0x00009B5A00F5A2B5 AS DateTime), CAST(0x00009B5B00F5A2B5 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (42, N'NUnit Test Task', CAST(0x00009B5A00F740AE AS DateTime), CAST(0x00009B5B00F740AE AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (43, N'NUnit Test Task', CAST(0x00009B5A00FDBFC1 AS DateTime), CAST(0x00009B5B00FDBFC1 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (44, N'NUnit Test Task', CAST(0x00009B5A01002F4A AS DateTime), CAST(0x00009B5B01002F4A AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (45, N'NUnit Test Task', CAST(0x00009B5A010B08ED AS DateTime), CAST(0x00009B5B010B08ED AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (46, N'NUnit Test Task', CAST(0x00009B5A010CC296 AS DateTime), CAST(0x00009B5B010CC296 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (47, N'NUnit Test Task', CAST(0x00009B5B00C9E6F3 AS DateTime), CAST(0x00009B5C00C9E6F3 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (48, N'NUnit Test Task', CAST(0x00009B5B00CBC993 AS DateTime), CAST(0x00009B5C00CBC993 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (49, N'NUnit Test Task', CAST(0x00009B5B00CC2433 AS DateTime), CAST(0x00009B5C00CC2433 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (50, N'NUnit Test Task', CAST(0x00009B5B00CD3CD3 AS DateTime), CAST(0x00009B5C00CD3CD3 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (51, N'NUnit Test Task', CAST(0x00009B5B00CDAFB2 AS DateTime), CAST(0x00009B5C00CDAFB2 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (52, N'NUnit Test Task', CAST(0x00009B5B00D82D6E AS DateTime), CAST(0x00009B5C00D82D6E AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (53, N'NUnit Test Task', CAST(0x00009B5B00D90182 AS DateTime), CAST(0x00009B5C00D90182 AS DateTime), 1, 1, NULL)
INSERT [dbo].[Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt], [fk_Projekt_pos]) VALUES (54, N'NUnit Test Task', CAST(0x00009B5B011FB5B0 AS DateTime), CAST(0x00009B5C011FB5B0 AS DateTime), 1, 1, NULL)
SET IDENTITY_INSERT [dbo].[Tasks] OFF
/****** Object:  Table [dbo].[IntegerRangeConstraints]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntegerRangeConstraints]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[IntegerRangeConstraints](
	[ID] [int] NOT NULL,
	[Max] [int] NOT NULL,
	[Min] [int] NOT NULL,
 CONSTRAINT [PK_IntegerRangeConstraints] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[IntegerRangeConstraints] ([ID], [Max], [Min]) VALUES (147, 4000, 1)
INSERT [dbo].[IntegerRangeConstraints] ([ID], [Max], [Min]) VALUES (148, 4000, 0)
INSERT [dbo].[IntegerRangeConstraints] ([ID], [Max], [Min]) VALUES (149, 4000, 0)
INSERT [dbo].[IntegerRangeConstraints] ([ID], [Max], [Min]) VALUES (216, 2, 1)
/****** Object:  Table [dbo].[IsValidIdentifierConstraints]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IsValidIdentifierConstraints]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[IsValidIdentifierConstraints](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_IsValidIdentifierConstraints] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[IsValidIdentifierConstraints] ([ID]) VALUES (194)
INSERT [dbo].[IsValidIdentifierConstraints] ([ID]) VALUES (195)
INSERT [dbo].[IsValidIdentifierConstraints] ([ID]) VALUES (196)
INSERT [dbo].[IsValidIdentifierConstraints] ([ID]) VALUES (198)
INSERT [dbo].[IsValidIdentifierConstraints] ([ID]) VALUES (199)
INSERT [dbo].[IsValidIdentifierConstraints] ([ID]) VALUES (200)
INSERT [dbo].[IsValidIdentifierConstraints] ([ID]) VALUES (201)
/****** Object:  Table [dbo].[Auftraege]    Script Date: 04/27/2009 16:11:31 ******/
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
	[fk_Mitarbeiter_pos] [int] NULL,
	[fk_Projekt_pos] [int] NULL,
	[fk_Kunde_pos] [int] NULL,
 CONSTRAINT [PK_Auftrag] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Auftraege] ON
INSERT [dbo].[Auftraege] ([ID], [fk_Mitarbeiter], [Auftragsname], [fk_Projekt], [fk_Kunde], [Auftragswert], [fk_Mitarbeiter_pos], [fk_Projekt_pos], [fk_Kunde_pos]) VALUES (1, 1, N'Auftrag für den Businessplan', NULL, 1, 10, NULL, NULL, NULL)
INSERT [dbo].[Auftraege] ([ID], [fk_Mitarbeiter], [Auftragsname], [fk_Projekt], [fk_Kunde], [Auftragswert], [fk_Mitarbeiter_pos], [fk_Projekt_pos], [fk_Kunde_pos]) VALUES (2, 2, N'Auftrag für Marketingunterlagen', NULL, 2, 100, NULL, NULL, NULL)
INSERT [dbo].[Auftraege] ([ID], [fk_Mitarbeiter], [Auftragsname], [fk_Projekt], [fk_Kunde], [Auftragswert], [fk_Mitarbeiter_pos], [fk_Projekt_pos], [fk_Kunde_pos]) VALUES (3, 2, N'Kistl Implementierungsprojekt', NULL, 1, 100000, NULL, NULL, NULL)
INSERT [dbo].[Auftraege] ([ID], [fk_Mitarbeiter], [Auftragsname], [fk_Projekt], [fk_Kunde], [Auftragswert], [fk_Mitarbeiter_pos], [fk_Projekt_pos], [fk_Kunde_pos]) VALUES (4, NULL, N'testauftrag', NULL, 2, 100, NULL, NULL, NULL)
INSERT [dbo].[Auftraege] ([ID], [fk_Mitarbeiter], [Auftragsname], [fk_Projekt], [fk_Kunde], [Auftragswert], [fk_Mitarbeiter_pos], [fk_Projekt_pos], [fk_Kunde_pos]) VALUES (5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Auftraege] ([ID], [fk_Mitarbeiter], [Auftragsname], [fk_Projekt], [fk_Kunde], [Auftragswert], [fk_Mitarbeiter_pos], [fk_Projekt_pos], [fk_Kunde_pos]) VALUES (6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Auftraege] ([ID], [fk_Mitarbeiter], [Auftragsname], [fk_Projekt], [fk_Kunde], [Auftragswert], [fk_Mitarbeiter_pos], [fk_Projekt_pos], [fk_Kunde_pos]) VALUES (7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Auftraege] ([ID], [fk_Mitarbeiter], [Auftragsname], [fk_Projekt], [fk_Kunde], [Auftragswert], [fk_Mitarbeiter_pos], [fk_Projekt_pos], [fk_Kunde_pos]) VALUES (8, 5, N'Auftrag Ziviltechniker', 2, 3, 111111, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Auftraege] OFF
/****** Object:  Table [dbo].[Assemblies]    Script Date: 04/27/2009 16:11:31 ******/
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
	[fk_Module_pos] [int] NULL,
 CONSTRAINT [PK_Assembly] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Assemblies] ON
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (1, 1, N'Kistl.App.Projekte.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', 1, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (2, 1, N'Kistl.App.Projekte.Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (3, 4, N'Kistl.Client.ASPNET.Toolkit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (4, 4, N'Kistl.Client.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (13, 4, N'Kistl.Objects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (14, 4, N'Kistl.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (15, 4, N'Kistl.API, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (16, 4, N'Kistl.Client.ASPNET.Toolkit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (17, 4, N'Kistl.Client.Forms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (18, 4, N'Kistl.Client.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (29, 4, N'mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (30, 4, N'Kistl.API.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (31, 4, N'WindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (32, 4, N'PresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (33, 4, N'PresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (34, 4, N'Kistl.Client.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (35, 4, N'Kistl.Client.ASPNET.Toolkit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (36, 4, N'System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (37, 4, N'System.Windows.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089', 0, NULL)
INSERT [dbo].[Assemblies] ([ID], [fk_Module], [AssemblyName], [IsClientAssembly], [fk_Module_pos]) VALUES (38, 4, N'Kistl.Client.Forms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', 0, NULL)
SET IDENTITY_INSERT [dbo].[Assemblies] OFF
/****** Object:  Table [dbo].[DataTypes]    Script Date: 04/27/2009 16:11:31 ******/
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
	[Description] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
	[fk_Module_pos] [int] NULL,
	[fk_DefaultIcon_pos] [int] NULL,
 CONSTRAINT [PK_DataTypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[DataTypes] ON
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (2, N'ObjectClass', 11, 1, N'Metadefinition Object for ObjectClasses.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (3, N'Projekt', 3, 2, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (4, N'Task', 7, 2, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (6, N'Mitarbeiter', 5, 2, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (7, N'Property', 9, 1, N'Metadefinition Object for Properties. This class is abstract.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (8, N'ValueTypeProperty', 9, 1, N'Metadefinition Object for ValueType Properties. This class is abstract.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (9, N'StringProperty', 9, 1, N'Metadefinition Object for String Properties.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (10, N'Method', 2, 1, N'Metadefinition Object for Methods.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (11, N'IntProperty', 9, 1, N'Metadefinition Object for Int Properties.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (12, N'BoolProperty', 9, 1, N'Metadefinition Object for Bool Properties.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (13, N'DoubleProperty', 9, 1, N'Metadefinition Object for Double Properties.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (14, N'ObjectReferenceProperty', 9, 1, N'Metadefinition Object for ObjectReference Properties.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (15, N'DateTimeProperty', 9, 1, N'Metadefinition Object for DateTime Properties.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (18, N'Module', 1, 1, N'Metadefinition Object for Modules.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (19, N'Auftrag', 8, 2, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (20, N'Zeitkonto', 12, 3, N'en:TimeAccount; Ein Konto für die Leistungserfassung. Es können nicht mehr als MaxStunden auf ein Konto gebucht werden.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (26, N'Kunde', 6, 2, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (27, N'Icon', 4, 4, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (29, N'Assembly', 13, 1, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (30, N'MethodInvocation', 2, 1, N'Metadefinition Object for a MethodInvocation on a Method of a DataType.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (33, N'DataType', 11, 1, N'Base Metadefinition Object for Objectclasses, Interfaces, Structs and Enumerations.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (36, N'BaseParameter', 12, 1, N'Metadefinition Object for Parameter. This class is abstract.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (37, N'StringParameter', 12, 1, N'Metadefinition Object for String Parameter.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (38, N'IntParameter', 12, 1, N'Metadefinition Object for Int Parameter.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (39, N'DoubleParameter', 12, 1, N'Metadefinition Object for Double Parameter.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (40, N'BoolParameter', 12, 1, N'Metadefinition Object for Bool Parameter.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (41, N'DateTimeParameter', 12, 1, N'Metadefinition Object for DateTime Parameter.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (42, N'ObjectParameter', 12, 1, N'Metadefinition Object for Object Parameter.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (43, N'CLRObjectParameter', 12, 1, N'Metadefinition Object for CLR Object Parameter.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (44, N'Interface', 11, 1, N'Metadefinition Object for Interfaces.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (45, N'Enumeration', 8, 1, N'Metadefinition Object for Enumerations.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (46, N'EnumerationEntry', 8, 1, N'Metadefinition Object for an Enumeration Entry.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (47, N'EnumerationProperty', 9, 1, N'Metadefinition Object for Enumeration Properties.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (48, N'ITestInterface', 1, 5, N'A Test Interface', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (50, N'TestEnum', NULL, 5, N'A TestEnum', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (51, N'TestObjClass', 5, 5, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (52, N'IRenderer', 2, 4, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (53, N'Toolkit', 4, 4, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (54, N'ControlInfo', NULL, 4, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (55, N'VisualType', NULL, 4, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (58, N'TestCustomObject', NULL, 5, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (59, N'Muhblah', NULL, 5, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (60, N'AnotherTest', NULL, 5, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (61, N'LastTest', NULL, 5, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (62, N'Struct', 11, 1, N'Metadefinition Object for Structs.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (63, N'TestPhoneStruct', NULL, 5, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (64, N'StructProperty', 9, 1, N'Metadefinition Object for Struct Properties.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (66, N'PresenterInfo', NULL, 4, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (67, N'Visual', NULL, 4, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (68, N'Template', NULL, 4, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (69, N'Constraint', NULL, 1, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (70, N'NotNullableConstraint', NULL, 1, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (71, N'IntegerRangeConstraint', NULL, 1, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (73, N'StringRangeConstraint', NULL, 1, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (74, N'MethodInvocationConstraint', NULL, 1, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (75, N'IsValidIdentifierConstraint', NULL, 1, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (76, N'IsValidNamespaceConstraint', NULL, 1, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (77, N'Relation', 11, 1, N'Describes a Relation between two Object Classes', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (78, N'StorageType', 10, 1, N'Storage Type of a 1:1 Releation.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (79, N'TypeRef', 2, 1, N'This class models a reference to a specific, concrete Type. Generic Types have all parameters filled.', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (81, N'Multiplicity', NULL, 1, N'Describes the multiplicities of objects on RelationEnds', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (82, N'RelationEnd', NULL, 1, N'Describes one end of a relation between two object classes', NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (83, N'ViewDescriptor', NULL, 4, NULL, NULL, NULL)
INSERT [dbo].[DataTypes] ([ID], [ClassName], [fk_DefaultIcon], [fk_Module], [Description], [fk_Module_pos], [fk_DefaultIcon_pos]) VALUES (85, N'PresentableModelDescriptor', NULL, 4, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DataTypes] OFF
/****** Object:  Table [dbo].[ControlInfos]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ControlInfos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ControlInfos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Assembly] [int] NOT NULL,
	[ClassName] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[IsContainer] [bit] NOT NULL,
	[Platform] [int] NOT NULL,
	[ControlType] [int] NOT NULL,
	[fk_Assembly_pos] [int] NULL,
 CONSTRAINT [PK_ControlInfos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[ControlInfos] ON
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (285, 4, N'Kistl.GUI.Renderer.WPF.EnumControl', 0, 0, 15, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (286, 4, N'Kistl.GUI.Renderer.WPF.StringListControl', 0, 0, 14, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (287, 4, N'Kistl.GUI.Renderer.WPF.EditSimpleProperty', 0, 0, 13, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (288, 4, N'Kistl.GUI.Renderer.WPF.IntegerListControl', 0, 0, 12, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (289, 4, N'Kistl.GUI.Renderer.WPF.EditIntProperty', 0, 0, 11, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (290, 4, N'Kistl.GUI.Renderer.WPF.DoubleListControl', 0, 0, 10, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (291, 4, N'Kistl.GUI.Renderer.WPF.EditDoubleProperty', 0, 0, 9, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (292, 4, N'Kistl.GUI.Renderer.WPF.DateTimeListControl', 0, 0, 8, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (293, 4, N'Kistl.GUI.Renderer.WPF.EditDateTimeProperty', 0, 0, 7, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (294, 4, N'Kistl.GUI.Renderer.WPF.BooleanListControl', 0, 0, 6, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (295, 4, N'Kistl.GUI.Renderer.WPF.EditBoolProperty', 0, 0, 5, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (296, 4, N'Kistl.GUI.Renderer.WPF.EnumEntryListControl', 0, 0, 16, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (297, 4, N'Kistl.GUI.Renderer.WPF.ObjectListControl', 0, 0, 3, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (298, 4, N'Kistl.GUI.Renderer.WPF.ObjectReferenceControl', 0, 0, 4, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (299, 4, N'Kistl.GUI.Renderer.WPF.GroupBoxWrapper', 1, 0, 2, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (300, 4, N'Kistl.GUI.Renderer.WPF.ObjectTabItem', 1, 0, 1, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (301, 4, N'Kistl.GUI.Renderer.WPF.Renderer', 1, 0, 0, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (302, 3, N'Kistl.Client.ASPNET.Toolkit.StringPropertyControlLoader', 0, 1, 13, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (303, 3, N'Kistl.Client.ASPNET.Toolkit.ObjectReferencePropertyControlLoader', 0, 1, 4, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (304, 3, N'Kistl.Client.ASPNET.Toolkit.ObjectListControlLoader', 0, 1, 3, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (305, 3, N'Kistl.Client.ASPNET.Toolkit.IntPropertyControlLoader', 0, 1, 11, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (306, 3, N'Kistl.Client.ASPNET.Toolkit.DoublePropertyControlLoader', 0, 1, 9, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (307, 3, N'Kistl.Client.ASPNET.Toolkit.DateTimePropertyControlLoader', 0, 1, 7, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (308, 3, N'Kistl.Client.ASPNET.Toolkit.BoolPropertyControlLoader', 0, 1, 5, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (309, 3, N'Kistl.Client.ASPNET.Toolkit.ObjectPanelLoader', 1, 1, 1, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (310, 3, N'Kistl.Client.ASPNET.Toolkit.Renderer', 1, 1, 0, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (311, 4, N'Kistl.GUI.Renderer.WPF.ActionControl', 0, 0, 17, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (312, 3, N'Kistl.Client.ASPNET.Toolkit.Controls.PropertyGroup', 1, 1, 2, NULL)
INSERT [dbo].[ControlInfos] ([ID], [fk_Assembly], [ClassName], [IsContainer], [Platform], [ControlType], [fk_Assembly_pos]) VALUES (313, 4, N'Kistl.GUI.Renderer.WPF.TemplateEditor', 0, 0, 19, NULL)
SET IDENTITY_INSERT [dbo].[ControlInfos] OFF
/****** Object:  Table [dbo].[Enumerations]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Enumerations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Enumerations](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_Enumerations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Enumerations] ([ID]) VALUES (50)
INSERT [dbo].[Enumerations] ([ID]) VALUES (53)
INSERT [dbo].[Enumerations] ([ID]) VALUES (55)
INSERT [dbo].[Enumerations] ([ID]) VALUES (78)
INSERT [dbo].[Enumerations] ([ID]) VALUES (81)
/****** Object:  Table [dbo].[Interfaces]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Interfaces]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Interfaces](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_Interfaces] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Interfaces] ([ID]) VALUES (48)
INSERT [dbo].[Interfaces] ([ID]) VALUES (52)
/****** Object:  Table [dbo].[Methods]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Methods]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Methods](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_ObjectClass] [int] NOT NULL,
	[MethodName] [nvarchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
	[fk_Module] [int] NOT NULL,
	[IsDisplayable] [bit] NOT NULL,
	[Description] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
	[fk_ObjectClass_pos] [int] NULL,
	[fk_Module_pos] [int] NULL,
 CONSTRAINT [PK_Methods] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Methods] ON
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (1, 7, N'GetPropertyTypeString', 1, 1, N'Returns the String representation of this Property Meta Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (3, 19, N'RechnungErstellen', 2, 1, N'Testmethode zum Erstellen von Rechnungen mit Word', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (4, 2, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (5, 2, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (6, 2, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (7, 3, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (8, 3, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (9, 3, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (10, 4, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (11, 4, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (12, 4, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (13, 7, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (14, 7, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (15, 7, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (16, 6, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (17, 6, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (18, 6, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (19, 10, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (20, 10, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (21, 10, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (22, 18, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (23, 18, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (24, 18, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (25, 19, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (26, 19, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (27, 19, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (28, 20, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (29, 20, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (30, 20, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (34, 26, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (35, 26, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (36, 26, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (37, 27, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (38, 27, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (39, 27, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (40, 29, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (41, 29, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (42, 29, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (43, 30, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (44, 30, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (45, 30, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (74, 33, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (75, 33, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (76, 33, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (79, 36, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (80, 36, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (81, 36, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (82, 36, N'GetParameterTypeString', 1, 0, N'Returns the String representation of this Method-Parameter Meta Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (83, 6, N'TestMethodForParameter', 2, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (84, 45, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (85, 45, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (86, 45, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (87, 46, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (88, 46, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (89, 46, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (90, 48, N'TestMethod', 5, 1, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (91, 51, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (92, 51, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (93, 51, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (95, 51, N'TestMethod', 5, 1, N'testmethod', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (96, 52, N'ShowMessage', 4, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (97, 52, N'ShowObject', 4, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (98, 52, N'ChooseObject', 4, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (106, 58, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (107, 58, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (108, 58, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (109, 59, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (110, 59, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (111, 59, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (112, 60, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (113, 60, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (114, 60, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (115, 61, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (116, 61, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (117, 61, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (118, 7, N'GetPropertyType', 1, 0, N'Returns the resulting Type of this Property Meta Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (120, 33, N'GetDataTypeString', 1, 0, N'Returns the String representation of this Datatype Meta Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (121, 33, N'GetDataType', 1, 0, N'Returns the resulting Type of this Datatype Meta Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (123, 36, N'GetParameterType', 1, 0, N'Returns the resulting Type of this Method-Parameter Meta Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (124, 10, N'GetReturnParameter', 1, 1, N'Returns the Return Parameter Meta Object of this Method Meta Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (125, 2, N'GetInheritedMethods', 1, 1, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (126, 66, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (127, 66, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (128, 66, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (129, 67, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (130, 67, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (131, 67, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (132, 68, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (133, 68, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (134, 68, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (135, 69, N'IsValid', 1, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (136, 69, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (137, 69, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (138, 69, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (139, 69, N'GetErrorText', 1, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (141, 54, N'ToString', 1, 0, N'Autogenerated! Returns a String that represents the current Object.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (142, 54, N'PreSave', 1, 0, N'Autogenerated! Method is called by the Context before a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (143, 54, N'PostSave', 1, 0, N'Autogenerated! Method is called by the Context after a commit occurs.', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (144, 68, N'PrepareDefault', 4, 1, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (145, 77, N'PreSave', 1, 0, NULL, NULL, NULL)
GO
print 'Processed 100 total records'
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (146, 77, N'ToString', 1, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (147, 77, N'PostSave', 1, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (148, 79, N'ToString', 1, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (149, 79, N'PreSave', 1, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (150, 79, N'PostSave', 1, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (151, 79, N'AsType', 1, 0, N'get the referenced <see cref="System.Type"/>', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (155, 29, N'RegenerateTypeRefs', 1, 1, N'Regenerates the stored list of TypeRefs from the loaded assembly', NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (157, 82, N'ToString', 1, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (158, 82, N'PostSave', 1, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (159, 82, N'PreSave', 1, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (160, 83, N'PreSave', 1, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (161, 83, N'PostSave', 1, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (162, 83, N'ToString', 1, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (163, 85, N'PreSave', 1, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (164, 85, N'PostSave', 1, 0, NULL, NULL, NULL)
INSERT [dbo].[Methods] ([ID], [fk_ObjectClass], [MethodName], [fk_Module], [IsDisplayable], [Description], [fk_ObjectClass_pos], [fk_Module_pos]) VALUES (165, 85, N'ToString', 1, 0, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Methods] OFF
/****** Object:  Table [dbo].[TypeRefs]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TypeRefs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TypeRefs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](600) COLLATE Latin1_General_CI_AS NOT NULL,
	[fk_Assembly] [int] NOT NULL,
	[fk_Assembly_pos] [int] NULL,
	[fk_Parent] [int] NULL,
 CONSTRAINT [PK_TypeRefs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[TypeRefs] ON
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (1, N'Kistl.App.Base.CustomClientActions_KistlBase', 1, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (2, N'Kistl.App.Zeiterfassung.CustomServerActions_Zeiterfassung', 2, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (3, N'Kistl.App.Projekte.CustomServerActions_Projekte', 2, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (4, N'Kistl.App.Base.CustomServerActions_KistlBase', 2, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (5, N'Kistl.App.GUI.CustomClientActions_GUI', 1, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (6, N'Kistl.App.Zeiterfassung.CustomClientActions_Zeiterfassung', 1, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (8, N'Kistl.App.Projekte.CustomClientActions_Projekte', 1, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (9, N'Kistl.Client.Presentables.ModuleModel', 14, NULL, 83)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (10, N'Kistl.Client.Presentables.ObjectClassModel', 14, NULL, 11)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (11, N'Kistl.Client.Presentables.DataTypeModel', 14, NULL, 83)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (12, N'Kistl.Client.Presentables.SaveContextCommand', 14, NULL, 45)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (13, N'Kistl.Client.Presentables.WorkspaceModel', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (14, N'Kistl.Client.ClientExtensions', 14, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (15, N'Kistl.Client.ClientHelper', 14, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (16, N'Kistl.Client.Presentables.ActionModel', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (17, N'Kistl.Client.Presentables.ObjectListModel', 14, NULL, 355)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (18, N'Kistl.Client.Presentables.DataObjectSelectionTaskModel', 14, NULL, 357)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (23, N'Kistl.Client.ServerDomainManager', 14, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (24, N'Kistl.Client.Presentables.SynchronousThreadManager', 14, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (25, N'Kistl.Client.Presentables.WPF.AsyncThreadManager', 14, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (26, N'Kistl.Client.Presentables.WPF.UiThreadManager', 14, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (27, N'Kistl.Client.Presentables.IThreadManager', 14, NULL, NULL)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (31, N'Kistl.Client.TheseMethodsShouldBeImplementedOnKistlObjects', 14, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (34, N'Kistl.Client.Presentables.ObjectReferenceModel', 14, NULL, 374)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (39, N'Kistl.Client.GUI.IView', 14, NULL, NULL)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (40, N'Kistl.Client.Presentables.ModelState', 14, NULL, 300)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (41, N'Kistl.Client.Presentables.MethodInvocationModel', 14, NULL, 83)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (45, N'Kistl.Client.Presentables.CommandModel', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (46, N'Kistl.Client.Presentables.ICommand', 14, NULL, NULL)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (47, N'Kistl.Client.GuiApplicationContext', 14, NULL, 302)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (48, N'Kistl.Client.IGuiApplicationContext', 14, NULL, NULL)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (81, N'Kistl.Client.Presentables.ModelFactory', 14, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (83, N'Kistl.Client.Presentables.DataObjectModel', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (92, N'Kistl.Client.Presentables.IClearableValue', 14, NULL, NULL)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (94, N'Kistl.Client.Presentables.KistlContextModel', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (95, N'Kistl.Client.Presentables.KistlDebuggerAsModel', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (96, N'Kistl.Client.Presentables.PresentableModel', 14, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (108, N'Kistl.App.Base.Multiplicity', 13, NULL, 300)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (110, N'Kistl.App.Base.StorageType', 13, NULL, 300)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (112, N'Kistl.App.GUI.VisualType', 13, NULL, 300)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (114, N'Kistl.App.GUI.Toolkit', 13, NULL, 300)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (116, N'Kistl.App.Test.TestEnum', 13, NULL, 300)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (145, N'Kistl.Client.WPF.View.KistlDebuggerView', 18, NULL, 317)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (146, N'Kistl.Client.WPF.View.ListValueView', 18, NULL, 319)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (147, N'Kistl.Client.WPF.View.EnumSelectionView', 18, NULL, 319)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (148, N'Kistl.Client.WPF.View.TextValueSelectionView', 18, NULL, 319)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (149, N'Kistl.Client.WPF.View.ActionView', 18, NULL, 318)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (150, N'Kistl.Client.WPF.View.SelectionDialog', 18, NULL, 317)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (151, N'Kistl.Client.WPF.View.NullableBoolValueView', 18, NULL, 319)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (152, N'Kistl.Client.ASPNET.Toolkit.View.NullablePropertyTextBoxViewLoader', 16, NULL, 320)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (153, N'Kistl.Client.Forms.View.NullablePropertyTextBoxView', 17, NULL, 328)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (154, N'Kistl.Client.WPF.View.NullablePropertyTextBoxView', 18, NULL, 319)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (155, N'Kistl.Client.WPF.View.DataObjectView', 18, NULL, 318)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (156, N'Kistl.Client.ASPNET.Toolkit.View.DataObjectListViewLoader', 16, NULL, 320)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (157, N'Kistl.Client.Forms.View.DataObjectListView', 17, NULL, 330)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (158, N'Kistl.Client.WPF.View.DataObjectListView', 18, NULL, 319)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (159, N'Kistl.Client.ASPNET.Toolkit.View.DataObjectReferenceViewLoader', 16, NULL, 320)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (160, N'Kistl.Client.Forms.View.DataObjectReferenceView', 17, NULL, 332)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (161, N'Kistl.Client.WPF.View.ObjectReferenceView', 18, NULL, 319)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (162, N'Kistl.Client.ASPNET.Toolkit.View.DataObjectFullViewLoader', 16, NULL, 320)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (163, N'Kistl.Client.Forms.View.DataObjectFullView', 17, NULL, 334)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (164, N'Kistl.Client.WPF.View.DataObjectFullView', 18, NULL, 318)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (165, N'Kistl.Client.ASPNET.Toolkit.View.WorkspaceViewLoader', 16, NULL, 320)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (166, N'Kistl.Client.Forms.View.WorkspaceView', 17, NULL, 335)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (167, N'Kistl.Client.WPF.View.WorkspaceView', 18, NULL, 317)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (273, N'Kistl.Client.Presentables.EnumerationPropertyModel`1', 14, NULL, 424)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (274, N'Kistl.Client.Presentables.EnumerationPropertyModel`1', 14, NULL, 429)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (275, N'Kistl.Client.Presentables.EnumerationPropertyModel`1', 14, NULL, 434)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (276, N'Kistl.Client.Presentables.EnumerationPropertyModel`1', 14, NULL, 439)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (277, N'Kistl.Client.Presentables.EnumerationPropertyModel`1', 14, NULL, 444)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (278, N'Kistl.Client.WPF.View.PropertyGroupBoxView', 18, NULL, 347)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (282, N'Kistl.Client.Forms.View.DataObjectReferenceView', 17, NULL, NULL)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (283, N'Kistl.Client.Presentables.PropertyGroupModel', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (295, N'System.Object', 29, NULL, NULL)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (299, N'System.ValueType', 29, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (300, N'System.Enum', 29, NULL, 299)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (301, N'Kistl.API.ApplicationContext', 15, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (302, N'Kistl.API.Client.ClientApiContext', 30, NULL, 301)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (310, N'System.Windows.Threading.DispatcherObject', 31, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (311, N'System.Windows.DependencyObject', 31, NULL, 310)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (312, N'System.Windows.Media.Visual', 32, NULL, 311)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (313, N'System.Windows.UIElement', 32, NULL, 312)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (314, N'System.Windows.FrameworkElement', 33, NULL, 313)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (315, N'System.Windows.Controls.Control', 33, NULL, 314)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (316, N'System.Windows.Controls.ContentControl', 33, NULL, 315)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (317, N'System.Windows.Window', 33, NULL, 316)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (318, N'System.Windows.Controls.UserControl', 33, NULL, 316)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (319, N'Kistl.Client.WPF.View.PropertyView', 34, NULL, 318)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (320, N'Kistl.Client.ASPNET.Toolkit.View.ViewLoader', 35, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (321, N'System.MarshalByRefObject', 29, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (322, N'System.ComponentModel.Component', 36, NULL, 321)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (323, N'System.Windows.Forms.Control', 37, NULL, 322)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (324, N'System.Windows.Forms.ScrollableControl', 37, NULL, 323)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (325, N'System.Windows.Forms.ContainerControl', 37, NULL, 324)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (326, N'System.Windows.Forms.UserControl', 37, NULL, 325)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (328, N'Kistl.Client.Forms.View.NullablePropertyTextBoxViewDesignerProxy', 38, NULL, 416)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (330, N'Kistl.Client.Forms.View.DataObjectListViewDesignerProxy', 38, NULL, 418)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (332, N'Kistl.Client.Forms.View.DataObjectReferenceViewDesignerProxy', 38, NULL, 419)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (334, N'Kistl.Client.Forms.View.DataObjectFullViewDesignerProxy', 38, NULL, 420)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (335, N'System.Windows.Forms.Form', 37, NULL, 325)
GO
print 'Processed 100 total records'
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (346, N'System.Windows.Controls.HeaderedContentControl', 33, NULL, 316)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (347, N'System.Windows.Controls.GroupBox', 33, NULL, 346)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (354, N'System.Collections.Generic.ICollection`1', 29, NULL, NULL)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (355, N'Kistl.Client.Presentables.PropertyModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (357, N'Kistl.Client.Presentables.SelectionTaskModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (374, N'Kistl.Client.Presentables.PropertyModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (382, N'Kistl.Client.Presentables.PropertyModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (383, N'System.String', 29, NULL, 295)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (384, N'Kistl.Client.Presentables.ReferencePropertyModel`1', 14, NULL, 382)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (394, N'Kistl.Client.Presentables.ChooseReferencePropertyModel`1', 14, NULL, 384)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (395, N'System.Nullable`1', 29, NULL, 299)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (396, N'Kistl.Client.Presentables.PropertyModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (398, N'System.Int32', 29, NULL, 299)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (399, N'Kistl.Client.Presentables.NullableValuePropertyModel`1', 14, NULL, 396)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (400, N'System.Nullable`1', 29, NULL, 299)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (401, N'Kistl.Client.Presentables.PropertyModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (403, N'System.Double', 29, NULL, 299)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (404, N'Kistl.Client.Presentables.NullableValuePropertyModel`1', 14, NULL, 401)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (405, N'System.Nullable`1', 29, NULL, 299)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (406, N'Kistl.Client.Presentables.PropertyModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (408, N'System.DateTime', 29, NULL, 299)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (409, N'Kistl.Client.Presentables.NullableValuePropertyModel`1', 14, NULL, 406)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (410, N'System.Nullable`1', 29, NULL, 299)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (411, N'Kistl.Client.Presentables.PropertyModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (413, N'System.Boolean', 29, NULL, 299)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (414, N'Kistl.Client.Presentables.NullableValuePropertyModel`1', 14, NULL, 411)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (415, N'Kistl.Client.Presentables.IValueModel`1', 14, NULL, NULL)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (416, N'Kistl.Client.Forms.View.FormsUserControl`1', 17, NULL, 326)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (418, N'Kistl.Client.Forms.View.FormsUserControl`1', 17, NULL, 326)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (419, N'Kistl.Client.Forms.View.FormsUserControl`1', 17, NULL, 326)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (420, N'Kistl.Client.Forms.View.FormsUserControl`1', 17, NULL, 326)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (421, N'System.Nullable`1', 29, NULL, 299)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (422, N'Kistl.Client.Presentables.PropertyModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (424, N'Kistl.Client.Presentables.NullableValuePropertyModel`1', 14, NULL, 422)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (426, N'System.Nullable`1', 29, NULL, 299)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (427, N'Kistl.Client.Presentables.PropertyModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (429, N'Kistl.Client.Presentables.NullableValuePropertyModel`1', 14, NULL, 427)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (431, N'System.Nullable`1', 29, NULL, 299)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (432, N'Kistl.Client.Presentables.PropertyModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (434, N'Kistl.Client.Presentables.NullableValuePropertyModel`1', 14, NULL, 432)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (436, N'System.Nullable`1', 29, NULL, 299)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (437, N'Kistl.Client.Presentables.PropertyModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (439, N'Kistl.Client.Presentables.NullableValuePropertyModel`1', 14, NULL, 437)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (441, N'System.Nullable`1', 29, NULL, 299)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (442, N'Kistl.Client.Presentables.PropertyModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (444, N'Kistl.Client.Presentables.NullableValuePropertyModel`1', 14, NULL, 442)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (447, N'Kistl.API.IDataObject', 15, NULL, NULL)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (448, N'Kistl.Client.Presentables.ObjectResultModel`1', 14, NULL, 560)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (449, N'Kistl.Client.Presentables.MethodResultModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (450, N'Kistl.Client.Presentables.ObjectResultModel`1', 14, NULL, 449)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (454, N'Kistl.Client.Presentables.NullableResultModel`1', 14, NULL, 556)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (458, N'Kistl.Client.Presentables.NullableResultModel`1', 14, NULL, 557)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (462, N'Kistl.Client.Presentables.NullableResultModel`1', 14, NULL, 558)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (466, N'Kistl.Client.Presentables.NullableResultModel`1', 14, NULL, 559)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (469, N'System.Collections.Generic.ICollection`1', 29, NULL, NULL)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (470, N'Kistl.Client.Presentables.PropertyModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (556, N'Kistl.Client.Presentables.MethodResultModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (557, N'Kistl.Client.Presentables.MethodResultModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (558, N'Kistl.Client.Presentables.MethodResultModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (559, N'Kistl.Client.Presentables.MethodResultModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (560, N'Kistl.Client.Presentables.MethodResultModel`1', 14, NULL, 96)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (561, N'System.Collections.Generic.ICollection`1', 29, NULL, NULL)
INSERT [dbo].[TypeRefs] ([ID], [FullName], [fk_Assembly], [fk_Assembly_pos], [fk_Parent]) VALUES (562, N'System.Collections.Generic.ICollection`1', 29, NULL, NULL)
SET IDENTITY_INSERT [dbo].[TypeRefs] OFF
/****** Object:  Table [dbo].[Structs]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Structs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Structs](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_Structs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Structs] ([ID]) VALUES (63)
/****** Object:  Table [dbo].[IsValidNamespaceConstraints]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IsValidNamespaceConstraints]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[IsValidNamespaceConstraints](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_IsValidNamespaceConstraints] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[IsValidNamespaceConstraints] ([ID]) VALUES (198)
/****** Object:  Table [dbo].[PresenterInfos]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PresenterInfos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PresenterInfos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_PresenterAssembly] [int] NOT NULL,
	[PresenterTypeName] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[fk_DataAssembly] [int] NULL,
	[DataTypeName] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[ControlType] [int] NOT NULL,
	[fk_PresenterAssembly_pos] [int] NULL,
	[fk_DataAssembly_pos] [int] NULL,
 CONSTRAINT [PK_PresenterInfos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[PresenterInfos] ON
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (3, 14, N'Kistl.GUI.DefaultMethodPresenter`1', 13, N'Kistl.App.Base.Method', 14, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (4, 14, N'Kistl.GUI.DefaultMethodPresenter`1', 13, N'Kistl.App.Base.Method', 13, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (5, 14, N'Kistl.GUI.DefaultMethodPresenter`1', 13, N'Kistl.App.Base.Method', 12, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (6, 14, N'Kistl.GUI.DefaultMethodPresenter`1', 13, N'Kistl.App.Base.Method', 11, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (7, 14, N'Kistl.GUI.DefaultMethodPresenter`1', 13, N'Kistl.App.Base.Method', 10, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (8, 14, N'Kistl.GUI.DefaultMethodPresenter`1', 13, N'Kistl.App.Base.Method', 9, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (9, 14, N'Kistl.GUI.DefaultMethodPresenter`1', 13, N'Kistl.App.Base.Method', 8, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (10, 14, N'Kistl.GUI.DefaultMethodPresenter`1', 13, N'Kistl.App.Base.Method', 7, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (11, 14, N'Kistl.GUI.DefaultMethodPresenter`1', 13, N'Kistl.App.Base.Method', 6, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (12, 14, N'Kistl.GUI.DefaultMethodPresenter`1', 13, N'Kistl.App.Base.Method', 5, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (13, 14, N'Kistl.GUI.ObjectListMethodPresenter', 13, N'Kistl.App.Base.Method', 3, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (14, 14, N'Kistl.GUI.ObjectMethodPresenter', 13, N'Kistl.App.Base.Method', 4, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (15, 14, N'Kistl.GUI.DefaultListPresenter`1', NULL, N'System.Collections.Generic.IList`1[[Kistl.App.Base.EnumerationEntry, Kistl.Objects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]', 16, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (16, 14, N'Kistl.GUI.EnumerationPresenter`1', 13, N'Kistl.App.Base.EnumerationProperty', 15, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (17, 14, N'Kistl.GUI.DefaultListPresenter`1', 13, N'Kistl.App.Base.StringProperty', 14, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (18, 14, N'Kistl.GUI.DefaultValuePresenter`1', 13, N'Kistl.App.Base.StringProperty', 13, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (19, 14, N'Kistl.GUI.DefaultListPresenter`1', 13, N'Kistl.App.Base.IntProperty', 12, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (20, 14, N'Kistl.GUI.DefaultStructPresenter`1', 13, N'Kistl.App.Base.IntProperty', 11, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (21, 14, N'Kistl.GUI.DefaultListPresenter`1', 13, N'Kistl.App.Base.DoubleProperty', 10, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (22, 14, N'Kistl.GUI.DefaultStructPresenter`1', 13, N'Kistl.App.Base.DoubleProperty', 9, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (23, 14, N'Kistl.GUI.DefaultListPresenter`1', 13, N'Kistl.App.Base.DateTimeProperty', 8, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (24, 14, N'Kistl.GUI.DefaultStructPresenter`1', 13, N'Kistl.App.Base.DateTimeProperty', 7, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (25, 14, N'Kistl.GUI.DefaultListPresenter`1', 13, N'Kistl.App.Base.BoolProperty', 6, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (26, 14, N'Kistl.GUI.DefaultStructPresenter`1', 13, N'Kistl.App.Base.BoolProperty', 5, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (27, 14, N'Kistl.GUI.BackReferencePresenter`1', 13, N'Kistl.App.Base.BackReferenceProperty', 3, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (28, 14, N'Kistl.GUI.ObjectListPresenter`1', 13, N'Kistl.App.Base.ObjectReferenceProperty', 3, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (29, 14, N'Kistl.GUI.ObjectReferencePresenter`1', 13, N'Kistl.App.Base.ObjectReferenceProperty', 4, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (30, 14, N'Kistl.GUI.GroupPresenter', 14, N'Kistl.GUI.GroupPresenter', 2, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (31, 14, N'Kistl.GUI.ObjectPresenter', 15, N'Kistl.API.IDataObject', 1, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (32, 14, N'Kistl.GUI.ActionPresenter', 13, N'Kistl.App.Base.Method', 17, NULL, NULL)
INSERT [dbo].[PresenterInfos] ([ID], [fk_PresenterAssembly], [PresenterTypeName], [fk_DataAssembly], [DataTypeName], [ControlType], [fk_PresenterAssembly_pos], [fk_DataAssembly_pos]) VALUES (33, 4, N'Kistl.GUI.Renderer.WPF.TemplateEditorPresenter', 13, N'Kistl.App.Base.ObjectReferenceProperty', 19, NULL, NULL)
SET IDENTITY_INSERT [dbo].[PresenterInfos] OFF
/****** Object:  Table [dbo].[PresentableModelDescriptors]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PresentableModelDescriptors]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PresentableModelDescriptors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](4000) COLLATE Latin1_General_CI_AS NOT NULL,
	[DefaultVisualType] [int] NOT NULL,
	[fk_PresentableModelRef] [int] NOT NULL,
 CONSTRAINT [PK_PresentableModelDescriptors] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[PresentableModelDescriptors] ON
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (1, N'A debugger window showing the used IKistlContexts and their AttachedObjects', 22, 95)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (2, N'A top-level window containing a Workspace, a visual representation for IKistlContext', 24, 13)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (3, N'A task for the user: select an IDataObject from a list', 23, 18)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (4, N'An action which can be triggered by the user', 17, 16)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (5, N'A reference to an IDataObject', 4, 34)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (6, N'A list of IDataObjects', 3, 17)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (7, N'A complete IDataObject', 1, 83)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (8, N'Select a string value from a set of values', 26, 394)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (9, N'A string attribute', 13, 384)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (10, N'An integer attribute', 13, 399)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (11, N'A floating point attribute', 13, 404)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (12, N'A date and time attribute', 13, 409)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (13, N'A simple true/false attribute', 5, 414)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (14, N'A method returning an IDataObject reference', 4, 448)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (15, N'A group of properties', 2, 283)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (16, N'A method returning a string', 13, 450)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (17, N'A method returning an integer value', 13, 454)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (18, N'A method returning a floating point value', 13, 458)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (19, N'A method returning a date and time value', 13, 462)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (20, N'A method returning true or false', 5, 466)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (21, N'An enumeration value for Multiplicity', 15, 273)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (22, N'An enumeration value for StorageType', 15, 274)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (23, N'An enumeration value for VisualType', 15, 275)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (24, N'An enumeration value for Toolkit', 15, 276)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (25, N'An enumeration value for TestEnum', 15, 277)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (30, N'DataObjectModel with specific extensions for DataTypes', 1, 11)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (31, N'DataObjectModel with specific extensions for MethodInvocations', 1, 41)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (32, N'DataObjectModel with specific extensions for Modules', 1, 9)
INSERT [dbo].[PresentableModelDescriptors] ([ID], [Description], [DefaultVisualType], [fk_PresentableModelRef]) VALUES (33, N'DataObjectModel with specific extensions for ObjectClasses', 1, 10)
SET IDENTITY_INSERT [dbo].[PresentableModelDescriptors] OFF
/****** Object:  Table [dbo].[Visuals]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Visuals]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Visuals](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[ControlType] [int] NOT NULL,
	[fk_Property] [int] NULL,
	[fk_Method] [int] NOT NULL,
	[fk_Property_pos] [int] NULL,
	[fk_Method_pos] [int] NULL,
 CONSTRAINT [PK_Visuals] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[TypeRefs_GenericArgumentsCollection]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TypeRefs_GenericArgumentsCollection]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TypeRefs_GenericArgumentsCollection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_TypeRef] [int] NOT NULL,
	[fk_TypeRef_pos] [int] NULL,
	[fk_GenericArguments] [int] NOT NULL,
	[fk_GenericArguments_pos] [int] NULL,
 CONSTRAINT [PK_TypeRefs_GenericArgumentsCollection] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ON
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (1, 273, 2147483647, 108, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (2, 274, 2147483647, 110, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (3, 275, 2147483647, 112, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (4, 276, 2147483647, 114, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (5, 277, 2147483647, 116, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (6, 355, 2147483647, 354, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (7, 354, 2147483647, 83, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (9, 357, 2147483647, 83, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (26, 374, 2147483647, 83, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (32, 382, 2147483647, 383, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (33, 384, 2147483647, 383, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (43, 394, 2147483647, 383, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (44, 396, 2147483647, 395, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (45, 395, 2147483647, 398, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (47, 399, 2147483647, 398, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (48, 401, 2147483647, 400, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (49, 400, 2147483647, 403, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (51, 404, 2147483647, 403, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (52, 406, 2147483647, 405, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (53, 405, 2147483647, 408, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (55, 409, 2147483647, 408, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (56, 411, 2147483647, 410, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (57, 410, 2147483647, 413, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (59, 414, 2147483647, 413, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (60, 416, 2147483647, 415, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (61, 415, 2147483647, 383, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (63, 418, 2147483647, 17, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (64, 419, 2147483647, 34, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (65, 420, 2147483647, 83, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (66, 422, 2147483647, 421, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (67, 421, 2147483647, 108, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (69, 424, 2147483647, 108, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (71, 427, 2147483647, 426, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (72, 426, 2147483647, 110, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (74, 429, 2147483647, 110, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (76, 432, 2147483647, 431, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (77, 431, 2147483647, 112, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (82, 436, 2147483647, 114, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (92, 448, 2147483647, 447, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (93, 449, 2147483647, 383, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (94, 450, 2147483647, 383, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (98, 454, 2147483647, 398, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (102, 458, 2147483647, 403, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (106, 462, 2147483647, 408, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (107, 559, 2147483647, 410, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (110, 466, 2147483647, 413, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (113, 470, 2147483647, 469, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (114, 469, 2147483647, 383, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (160, 434, 2147483647, 112, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (164, 437, 2147483647, 436, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (167, 439, 2147483647, 114, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (168, 442, 2147483647, 441, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (172, 441, 2147483647, 116, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (174, 444, 2147483647, 116, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (177, 556, 2147483647, 395, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (180, 557, 2147483647, 400, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (201, 558, 2147483647, 405, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (203, 560, 2147483647, 447, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (204, 561, 2147483647, 395, 0)
INSERT [dbo].[TypeRefs_GenericArgumentsCollection] ([ID], [fk_TypeRef], [fk_TypeRef_pos], [fk_GenericArguments], [fk_GenericArguments_pos]) VALUES (205, 562, 2147483647, 398, 0)
SET IDENTITY_INSERT [dbo].[TypeRefs_GenericArgumentsCollection] OFF
/****** Object:  Table [dbo].[MethodInvocations]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MethodInvocations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MethodInvocations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Method] [int] NOT NULL,
	[MemberName] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[fk_Module] [int] NOT NULL,
	[fk_InvokeOnObjectClass] [int] NOT NULL,
	[fk_Implementor] [int] NOT NULL,
	[fk_Method_pos] [int] NULL,
	[fk_Module_pos] [int] NULL,
	[fk_InvokeOnObjectClass_pos] [int] NULL,
	[fk_Implementor_pos] [int] NULL,
 CONSTRAINT [PK_MethodInvocation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[MethodInvocations] ON
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (1, 8, N'OnToString_Projekt', 2, 3, 8, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (2, 17, N'OnToString_Mitarbeiter', 2, 6, 8, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (4, 11, N'OnToString_Task', 2, 4, 8, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (5, 5, N'OnToString_DataType', 1, 33, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (6, 44, N'OnToString_MethodInvokation', 1, 30, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (9, 20, N'OnToString_Method', 1, 10, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (10, 23, N'OnToString_Module', 1, 18, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (11, 26, N'OnToString_Auftrag', 2, 19, 8, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (12, 29, N'OnToString_Zeitkonto', 3, 20, 6, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (14, 35, N'OnToString_Kunde', 2, 26, 8, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (15, 38, N'OnToString_Icon', 4, 27, 5, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (16, 41, N'OnToString_Assembly', 1, 29, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (17, 14, N'OnToString_ObjectReferenceProperty', 1, 14, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (19, 3, N'OnRechnungErstellen_Auftrag', 2, 19, 8, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (20, 1, N'OnGetPropertyTypeString_StringProperty', 1, 9, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (21, 1, N'OnGetPropertyTypeString_IntProperty', 1, 11, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (22, 1, N'OnGetPropertyTypeString_BoolProperty', 1, 12, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (23, 1, N'OnGetPropertyTypeString_DoubleProperty', 1, 13, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (24, 1, N'OnGetPropertyTypeString_DateTimeProperty', 1, 15, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (26, 1, N'OnGetPropertyTypeString_ObjectReferenceProperty', 1, 14, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (28, 6, N'OnPreSave_ObjectClass', 1, 2, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (29, 9, N'OnPreSetObject_Projekt', 2, 3, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (30, 12, N'OnPreSetObject_Task', 2, 4, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (31, 1, N'OnGetPropertyTypeString_StringProperty', 1, 9, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (32, 1, N'OnGetPropertyTypeString_IntProperty', 1, 11, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (33, 1, N'OnGetPropertyTypeString_BoolProperty', 1, 12, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (34, 1, N'OnGetPropertyTypeString_DoubleProperty', 1, 13, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (35, 1, N'OnGetPropertyTypeString_DateTimeProperty', 1, 15, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (37, 1, N'OnGetPropertyTypeString_ObjectReferenceProperty', 1, 14, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (45, 30, N'OnPreSave_Zeitkonto', 3, 20, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (47, 82, N'OnGetParameterTypeString_StringParameter', 1, 37, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (48, 82, N'OnGetParameterTypeString_IntParameter', 1, 38, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (49, 80, N'OnToString_BaseParameter', 1, 36, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (50, 82, N'OnGetParameterTypeString_StringParameter', 1, 37, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (51, 82, N'OnGetParameterTypeString_IntParameter', 1, 38, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (52, 82, N'OnGetParameterTypeString_DoubleParameter', 1, 39, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (53, 82, N'OnGetParameterTypeString_DoubleParameter', 1, 39, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (54, 82, N'OnGetParameterTypeString_DateTimeParameter', 1, 41, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (55, 82, N'OnGetParameterTypeString_BoolParameter', 1, 40, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (56, 82, N'OnGetParameterTypeString_BoolParameter', 1, 40, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (57, 82, N'OnGetParameterTypeString_DateTimeParameter', 1, 41, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (58, 82, N'OnGetParameterTypeString_ObjectParameter', 1, 42, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (59, 82, N'OnGetParameterTypeString_ObjectParameter', 1, 42, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (60, 82, N'OnGetParameterTypeString_CLRObjectParameter', 1, 43, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (61, 82, N'OnGetParameterTypeString_CLRObjectParameter', 1, 43, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (62, 79, N'OnPreSave_BaseParameter', 1, 36, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (63, 21, N'OnPreSave_Method', 1, 10, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (64, 1, N'OnGetPropertyTypeString_EnumerationProperty', 1, 47, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (65, 1, N'OnGetPropertyTypeString_EnumerationProperty', 5, 47, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (66, 85, N'OnToString_Enumeration', 1, 45, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (67, 88, N'OnToString_EnumerationEntry', 1, 46, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (72, 121, N'OnGetDataType_DataType', 1, 33, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (73, 121, N'OnGetDataType_DataType', 1, 33, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (74, 120, N'OnGetDataTypeString_DataType', 1, 33, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (75, 120, N'OnGetDataTypeString_DataType', 1, 33, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (76, 123, N'OnGetParameterType_BaseParameter', 1, 36, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (77, 123, N'OnGetParameterType_BaseParameter', 1, 36, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (78, 123, N'OnGetParameterType_ObjectParameter', 1, 42, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (79, 123, N'OnGetParameterType_ObjectParameter', 1, 42, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (80, 124, N'OnGetReturnParameter_Method', 1, 10, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (81, 125, N'OnGetInheritedMethods_ObjectClass', 1, 2, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (82, 1, N'OnGetPropertyTypeString_StructProperty', 1, 64, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (83, 1, N'OnGetPropertyTypeString_StructProperty', 1, 64, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (87, 135, N'OnIsValid_Constraint', 1, 69, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (88, 135, N'OnIsValid_NotNullableConstraint', 1, 70, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (89, 139, N'OnGetErrorText_NotNullableConstraint', 1, 70, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (90, 136, N'OnToString_NotNullableConstraint', 1, 70, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (91, 136, N'OnToString_IntegerRangeConstraint', 1, 71, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (92, 139, N'OnGetErrorText_IntegerRangeConstraint', 1, 71, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (93, 135, N'OnIsValid_IntegerRangeConstraint', 1, 71, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (94, 141, N'OnToString_ControlInfo', 4, 54, 5, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (95, 136, N'OnToString_StringRangeConstraint', 1, 73, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (96, 139, N'OnGetErrorText_StringRangeConstraint', 1, 73, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (97, 135, N'OnIsValid_StringRangeConstraint', 1, 73, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (98, 139, N'OnGetErrorText_MethodInvocationConstraint', 1, 74, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (99, 136, N'OnToString_MethodInvocationConstraint', 1, 74, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (100, 135, N'OnIsValid_MethodInvocationConstraint', 1, 74, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (101, 126, N'OnToString_PresenterInfo', 4, 66, 5, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (102, 144, N'OnPrepareDefault_Template', 4, 68, 5, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (103, 129, N'OnToString_Visual', 4, 67, 5, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (104, 135, N'OnIsValid_IsValidIdentifierConstraint', 1, 75, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (105, 139, N'OnGetErrorText_IsValidIdentifierConstraint', 1, 75, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (106, 136, N'OnToString_IsValidIdentifierConstraint', 1, 75, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (107, 135, N'OnIsValid_IsValidNamespaceConstraint', 1, 76, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (108, 151, N'OnAsType_TypeRef', 1, 79, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (109, 148, N'OnToString_TypeRef', 1, 79, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (111, 155, N'OnRegenerateTypeRefs_Assembly', 1, 29, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (113, 157, N'OnToString_RelationEnd', 1, 82, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (114, 146, N'OnToString_Relation', 1, 77, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (115, 1, N'OnGetPropertyTypeString_Property', 1, 7, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (116, 1, N'OnGetPropertyTypeString_Property', 1, 7, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (117, 118, N'OnGetPropertyType_Property', 1, 7, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (118, 118, N'OnGetPropertyType_Property', 1, 7, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[MethodInvocations] ([ID], [fk_Method], [MemberName], [fk_Module], [fk_InvokeOnObjectClass], [fk_Implementor], [fk_Method_pos], [fk_Module_pos], [fk_InvokeOnObjectClass_pos], [fk_Implementor_pos]) VALUES (119, 14, N'OnToString_Property', 1, 7, 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[MethodInvocations] OFF
/****** Object:  Table [dbo].[EnumerationEntries]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnumerationEntries]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EnumerationEntries](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Enumeration] [int] NOT NULL,
	[Value] [int] NOT NULL,
	[Name] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[Description] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_EnumerationEntries] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[EnumerationEntries] ON
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (2, 50, 0, N'First', N'First Test Entry')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (3, 50, 1, N'Second', N'Second Test Entry')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (5, 53, 0, N'WPF', N'WPF Toolkit')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (6, 53, 1, N'ASPNET', N'ASPNET Toolkit')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (7, 53, 2, N'TEST', N'TEST Toolkit')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (40, 55, 16, N'SimpleObjectList', NULL)
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (41, 55, 15, N'Enumeration', N'display a value from an Enumeration')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (42, 55, 14, N'StringList', NULL)
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (43, 55, 13, N'String', NULL)
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (44, 55, 12, N'IntegerList', NULL)
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (45, 55, 11, N'Integer', NULL)
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (46, 55, 10, N'DoubleList', NULL)
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (47, 55, 9, N'Double', NULL)
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (48, 55, 8, N'DateTimeList', N'a list of date/time values')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (49, 55, 7, N'DateTime', N'a date/time value')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (50, 55, 6, N'BooleanList', N'a list of booleans')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (51, 55, 5, N'Boolean', N'a boolean')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (52, 55, 4, N'ObjectReference', N'A reference to an object')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (53, 55, 3, N'ObjectList', N'A list of objects')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (54, 55, 2, N'PropertyGroup', N'A group of properties')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (55, 55, 1, N'Object', N'A full view of the object')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (56, 55, 0, N'Renderer', N'The renderer class is no actual "View", but neverthe less needs to be found')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (57, 55, 18, N'MenuGroup', NULL)
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (58, 55, 17, N'MenuItem', NULL)
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (59, 55, 19, N'TemplateEditor', NULL)
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (60, 78, 3, N'Replicate', N'The relation information is stored on both sides of the Relation')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (61, 78, 2, N'Right', N'Deprecated alias for MergeIntoB')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (62, 78, 1, N'Left', N'Deprecated alias for MergeIntoA')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (63, 81, 2, N'One', N'Required Element (exactly one)')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (64, 81, 1, N'ZeroOrOne', N'Optional Element (zero or one)')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (65, 81, 3, N'ZeroOrMore', N'Optional List Element (zero or more)')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (66, 78, 1, N'MergeIntoA', N'The relation information is stored with the A-side ObjectClass')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (67, 78, 2, N'MergeIntoB', N'The relation information is stored with the B-side ObjectClass')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (68, 78, 4, N'Separate', N'The relation information is stored in a separate entity')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (69, 55, 20, N'IntegerSlider', N'Displays an Integer with a slider instead of a text box')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (70, 55, 21, N'ObjectListEntry', N'An object as entry of a list')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (71, 55, 22, N'KistlDebugger', N'The debugger window for displaying the active contexts')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (74, 55, 23, N'SelectionTaskDialog', N'A task for the user: select a value from a list')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (75, 55, 24, N'WorkspaceWindow', N'A top-level window containing a Workspace, a visual representation for IKistlContext')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (76, 55, 26, N'StringSelection', N'Select a string from a aset of values')
INSERT [dbo].[EnumerationEntries] ([ID], [fk_Enumeration], [Value], [Name], [Description]) VALUES (77, 53, 3, N'WinForms', N'Windows Forms Toolkit')
SET IDENTITY_INSERT [dbo].[EnumerationEntries] OFF
/****** Object:  Table [dbo].[BaseParameters]    Script Date: 04/27/2009 16:11:31 ******/
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
	[fk_Method_pos] [int] NULL,
	[fk_Module] [int] NOT NULL,
	[IsList] [bit] NOT NULL,
	[IsReturnParameter] [bit] NOT NULL,
	[Description] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_BaseParameters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[BaseParameters] ON
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (1, N'TestString', 83, 6, 2, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (2, N'TestInt', 83, 4, 2, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (3, N'ReturnParameter', 1, NULL, 1, 0, 1, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (5, N'ReturnParameter', 82, NULL, 1, 0, 1, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (6, N'TestDouble', 83, 3, 2, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (7, N'TestBool', 83, 0, 2, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (8, N'TestDateTime', 83, 2, 2, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (9, N'TestDateTimeReturn', 83, 7, 2, 0, 1, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (10, N'TestObjectParameter', 83, 5, 2, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (11, N'TestCLRObjectParameter', 83, 1, 2, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (12, N'DateTimeParam', 90, NULL, 5, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (13, N'DateTimeParamForTestMethod', 95, NULL, 5, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (14, N'message', 96, NULL, 4, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (16, N'obj', 97, NULL, 4, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (18, N'ctx', 98, NULL, 4, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (19, N'objectType', 98, NULL, 4, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (20, N'result', 98, NULL, 4, 0, 1, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (21, N'ReturnParameter', 118, NULL, 1, 0, 1, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (23, N'ReturnParameter', 120, NULL, 1, 0, 1, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (24, N'ReturnParameter', 121, NULL, 1, 0, 1, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (25, N'ReturnParameter', 123, NULL, 1, 0, 1, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (26, N'Result', 124, NULL, 1, 0, 1, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (27, N'Result', 125, NULL, 1, 1, 1, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (28, N'constrainedValue', 135, 2, 1, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (29, N'return', 135, 0, 1, 0, 1, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (30, N'result', 139, 0, 1, 0, 1, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (31, N'constrainedValue', 139, 2, 1, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (33, N'result', 141, NULL, 4, 0, 1, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (34, N'constrainedObject', 135, 1, 1, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (35, N'constrainedObject', 139, 1, 1, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (36, N'cls', 144, NULL, 4, 0, 0, NULL)
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (37, N'return', 151, 0, 1, 0, 1, N'the referenced Type')
INSERT [dbo].[BaseParameters] ([ID], [ParameterName], [fk_Method], [fk_Method_pos], [fk_Module], [IsList], [IsReturnParameter], [Description]) VALUES (38, N'throwOnError', 151, 1, 1, 0, 0, N'whether to return null (false) or throw an Exception (true) on error')
SET IDENTITY_INSERT [dbo].[BaseParameters] OFF
/****** Object:  Table [dbo].[CLRObjectParameters]    Script Date: 04/27/2009 16:11:31 ******/
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
	[fk_Assembly_pos] [int] NULL,
 CONSTRAINT [PK_CLRObjectParameters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[CLRObjectParameters] ([ID], [fk_Assembly], [FullTypeName], [fk_Assembly_pos]) VALUES (11, NULL, N'System.Guid', NULL)
INSERT [dbo].[CLRObjectParameters] ([ID], [fk_Assembly], [FullTypeName], [fk_Assembly_pos]) VALUES (16, NULL, N'Kistl.API.IDataObject', NULL)
INSERT [dbo].[CLRObjectParameters] ([ID], [fk_Assembly], [FullTypeName], [fk_Assembly_pos]) VALUES (18, NULL, N'Kistl.API.IKistlContext', NULL)
INSERT [dbo].[CLRObjectParameters] ([ID], [fk_Assembly], [FullTypeName], [fk_Assembly_pos]) VALUES (19, NULL, N'System.Type', NULL)
INSERT [dbo].[CLRObjectParameters] ([ID], [fk_Assembly], [FullTypeName], [fk_Assembly_pos]) VALUES (20, NULL, N'Kistl.API.IDataObject', NULL)
INSERT [dbo].[CLRObjectParameters] ([ID], [fk_Assembly], [FullTypeName], [fk_Assembly_pos]) VALUES (21, NULL, N'System.Type', NULL)
INSERT [dbo].[CLRObjectParameters] ([ID], [fk_Assembly], [FullTypeName], [fk_Assembly_pos]) VALUES (24, NULL, N'System.Type', NULL)
INSERT [dbo].[CLRObjectParameters] ([ID], [fk_Assembly], [FullTypeName], [fk_Assembly_pos]) VALUES (25, NULL, N'System.Type', NULL)
INSERT [dbo].[CLRObjectParameters] ([ID], [fk_Assembly], [FullTypeName], [fk_Assembly_pos]) VALUES (28, NULL, N'System.Object', NULL)
INSERT [dbo].[CLRObjectParameters] ([ID], [fk_Assembly], [FullTypeName], [fk_Assembly_pos]) VALUES (31, NULL, N'System.Object', NULL)
INSERT [dbo].[CLRObjectParameters] ([ID], [fk_Assembly], [FullTypeName], [fk_Assembly_pos]) VALUES (34, NULL, N'System.Object', NULL)
INSERT [dbo].[CLRObjectParameters] ([ID], [fk_Assembly], [FullTypeName], [fk_Assembly_pos]) VALUES (35, NULL, N'System.Object', NULL)
INSERT [dbo].[CLRObjectParameters] ([ID], [fk_Assembly], [FullTypeName], [fk_Assembly_pos]) VALUES (37, NULL, N'System.Type', NULL)
/****** Object:  Table [dbo].[BoolParameters]    Script Date: 04/27/2009 16:11:31 ******/
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
INSERT [dbo].[BoolParameters] ([ID]) VALUES (29)
INSERT [dbo].[BoolParameters] ([ID]) VALUES (38)
/****** Object:  Table [dbo].[DoubleParameters]    Script Date: 04/27/2009 16:11:31 ******/
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
/****** Object:  Table [dbo].[DateTimeParameters]    Script Date: 04/27/2009 16:11:31 ******/
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
INSERT [dbo].[DateTimeParameters] ([ID]) VALUES (12)
INSERT [dbo].[DateTimeParameters] ([ID]) VALUES (13)
/****** Object:  Table [dbo].[StringParameters]    Script Date: 04/27/2009 16:11:31 ******/
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
INSERT [dbo].[StringParameters] ([ID]) VALUES (5)
INSERT [dbo].[StringParameters] ([ID]) VALUES (14)
INSERT [dbo].[StringParameters] ([ID]) VALUES (23)
INSERT [dbo].[StringParameters] ([ID]) VALUES (30)
INSERT [dbo].[StringParameters] ([ID]) VALUES (33)
/****** Object:  Table [dbo].[Templates]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Templates]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Templates](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[fk_VisualTree] [int] NOT NULL,
	[DisplayedTypeFullName] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[fk_DisplayedTypeAssembly] [int] NOT NULL,
	[fk_VisualTree_pos] [int] NULL,
	[fk_DisplayedTypeAssembly_pos] [int] NULL,
 CONSTRAINT [PK_Templates] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Visuals_MenuTreeCollection]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Visuals_MenuTreeCollection]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Visuals_MenuTreeCollection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Visual] [int] NOT NULL,
	[fk_MenuTree] [int] NOT NULL,
 CONSTRAINT [PK_Visuals_MenuTreeCollection] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Visuals_ContextMenuCollection]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Visuals_ContextMenuCollection]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Visuals_ContextMenuCollection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Visual] [int] NOT NULL,
	[fk_ContextMenu] [int] NOT NULL,
 CONSTRAINT [PK_Visuals_ContextMenuCollection] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Visuals_ChildrenCollection]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Visuals_ChildrenCollection]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Visuals_ChildrenCollection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Visual] [int] NOT NULL,
	[fk_Children] [int] NOT NULL,
 CONSTRAINT [PK_Visuals_ChildrenCollection] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[ViewDescriptors]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ViewDescriptors]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ViewDescriptors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VisualType] [int] NOT NULL,
	[Toolkit] [int] NOT NULL,
	[fk_ControlRef] [int] NOT NULL,
	[fk_PresentedModelDescriptor] [int] NOT NULL,
 CONSTRAINT [PK_ViewDescriptors] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[ViewDescriptors] ON
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (1, 22, 0, 145, 1)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (2, 24, 1, 165, 2)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (3, 24, 3, 166, 2)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (4, 24, 0, 167, 2)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (5, 23, 0, 150, 3)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (6, 17, 0, 149, 4)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (7, 4, 1, 159, 5)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (8, 4, 3, 282, 5)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (9, 4, 0, 161, 5)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (10, 3, 1, 156, 6)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (11, 3, 3, 157, 6)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (12, 3, 0, 158, 6)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (13, 1, 1, 162, 7)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (14, 1, 3, 163, 7)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (15, 21, 0, 155, 7)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (16, 1, 0, 164, 7)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (17, 26, 0, 148, 8)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (18, 14, 0, 146, 9)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (19, 13, 1, 152, 9)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (20, 13, 3, 153, 9)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (21, 13, 0, 154, 9)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (22, 13, 1, 152, 10)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (23, 13, 3, 153, 10)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (24, 13, 0, 154, 10)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (25, 13, 1, 152, 11)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (26, 13, 3, 153, 11)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (27, 13, 0, 154, 11)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (28, 13, 1, 152, 12)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (29, 13, 3, 153, 12)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (30, 13, 0, 154, 12)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (31, 13, 1, 152, 13)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (32, 13, 3, 153, 13)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (33, 5, 0, 151, 13)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (34, 2, 0, 278, 15)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (35, 13, 1, 152, 16)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (36, 13, 3, 153, 16)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (37, 13, 0, 154, 16)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (38, 13, 1, 152, 17)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (39, 13, 3, 153, 17)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (40, 13, 0, 154, 17)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (41, 13, 1, 152, 18)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (42, 13, 3, 153, 18)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (43, 13, 0, 154, 18)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (44, 13, 1, 152, 19)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (45, 13, 3, 153, 19)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (46, 13, 0, 154, 19)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (47, 13, 1, 152, 20)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (48, 13, 3, 153, 20)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (49, 5, 0, 151, 20)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (50, 13, 1, 152, 21)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (51, 13, 3, 153, 21)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (52, 15, 0, 147, 21)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (53, 13, 1, 152, 22)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (54, 13, 3, 153, 22)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (55, 15, 0, 147, 22)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (56, 13, 1, 152, 23)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (57, 13, 3, 153, 23)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (58, 15, 0, 147, 23)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (59, 13, 1, 152, 24)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (60, 13, 3, 153, 24)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (61, 15, 0, 147, 24)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (62, 13, 1, 152, 25)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (63, 13, 3, 153, 25)
INSERT [dbo].[ViewDescriptors] ([ID], [VisualType], [Toolkit], [fk_ControlRef], [fk_PresentedModelDescriptor]) VALUES (64, 15, 0, 147, 25)
SET IDENTITY_INSERT [dbo].[ViewDescriptors] OFF
/****** Object:  Table [dbo].[Properties]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Properties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Properties](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IsNullable] [bit] NOT NULL,
	[IsList] [bit] NOT NULL,
	[IsIndexed] [bit] NOT NULL,
	[fk_ObjectClass] [int] NOT NULL,
	[PropertyName] [nvarchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
	[AltText] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
	[fk_Module] [int] NOT NULL,
	[Description] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
	[fk_ObjectClass_pos] [int] NULL,
	[fk_Module_pos] [int] NULL,
	[CategoryTags] [nvarchar](4000) COLLATE Latin1_General_CI_AS NULL,
	[fk_ValueModelDescriptor] [int] NULL,
 CONSTRAINT [PK_Properties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Properties] ON
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (1, 0, 0, 0, 33, N'ClassName', N'Der Name der Objektklasse', 1, N'Der Name der Objektklasse', NULL, NULL, N'DataModel Description', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (3, 0, 0, 0, 2, N'TableName', N'Tabellenname in der Datenbank', 1, N'Tabellenname in der Datenbank', NULL, NULL, N'Physical', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (7, 1, 1, 0, 33, N'Properties', N'Eigenschaften der Objektklasse', 1, N'Eigenschaften der Objektklasse', NULL, NULL, N'DataModel', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (8, 0, 0, 0, 7, N'ObjectClass', NULL, 1, NULL, NULL, NULL, N'DataModel', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (9, 1, 0, 0, 7, N'PropertyName', NULL, 1, NULL, NULL, NULL, N'DataModel', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (11, 0, 0, 0, 7, N'IsList', NULL, 1, NULL, NULL, NULL, N'DataModel', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (13, 1, 0, 0, 3, N'Name', N'Projektname', 2, N'Projektname', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (14, 1, 1, 0, 3, N'Tasks', NULL, 2, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (15, 1, 0, 0, 4, N'Name', N'Taskname', 2, N'Taskname', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (16, 1, 0, 0, 4, N'DatumVon', N'Start Datum', 2, N'Start Datum', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (17, 1, 0, 0, 4, N'DatumBis', N'Enddatum', 2, N'Enddatum', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (18, 1, 0, 0, 4, N'Aufwand', N'Aufwand in Stunden', 2, N'Aufwand in Stunden', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (19, 1, 0, 0, 4, N'Projekt', N'Verknüpfung zum Projekt', 2, N'Verknüpfung zum Projekt', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (20, 1, 0, 0, 6, N'Name', N'Vorname Nachname', 2, N'Vorname Nachname', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (21, 1, 1, 1, 6, N'Projekte', N'Projekte des Mitarbeiters für die er Verantwortlich ist', 2, N'Projekte des Mitarbeiters für die er Verantwortlich ist', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (22, 1, 1, 1, 3, N'Mitarbeiter', NULL, 2, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (23, 1, 0, 0, 3, N'AufwandGes', NULL, 2, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (25, 1, 0, 0, 2, N'BaseObjectClass', N'Pointer auf die Basisklasse', 1, N'Pointer auf die Basisklasse', NULL, NULL, N'DataModel', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (26, 0, 0, 0, 7, N'IsNullable', NULL, 1, NULL, NULL, NULL, N'DataModel', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (27, 1, 1, 0, 2, N'SubClasses', N'Liste der vererbten Klassen', 1, N'Liste der vererbten Klassen', NULL, NULL, N'DataModel', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (28, 0, 0, 0, 9, N'Length', NULL, 1, NULL, NULL, NULL, N'DataModel', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (29, 0, 0, 0, 10, N'ObjectClass', NULL, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (30, 0, 0, 0, 10, N'MethodName', NULL, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (31, 1, 1, 0, 33, N'Methods', N'Liste aller Methoden der Objektklasse.', 1, N'Liste aller Methoden der Objektklasse.', NULL, NULL, N'DataModel', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (38, 1, 0, 0, 6, N'Geburtstag', N'Herzlichen Glückwunsch zum Geburtstag', 2, N'Herzlichen Glückwunsch zum Geburtstag', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (39, 1, 0, 0, 6, N'SVNr', N'NNNN TTMMYY', 2, N'NNNN TTMMYY', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (40, 1, 0, 0, 6, N'TelefonNummer', N'+43 123 12345678', 2, N'+43 123 12345678', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (41, 1, 0, 0, 7, N'AltText', NULL, 1, NULL, NULL, NULL, N'Description', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (42, 0, 0, 0, 18, N'Namespace', N'CLR Namespace des Moduls', 1, N'CLR Namespace des Moduls', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (43, 0, 0, 0, 18, N'ModuleName', N'Name des Moduls', 1, N'Name des Moduls', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (44, 1, 1, 0, 18, N'DataTypes', N'Datentypendes Modules', 1, N'Datentypendes Modules', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (45, 0, 0, 0, 33, N'Module', N'Modul der Objektklasse', 1, N'Modul der Objektklasse', NULL, NULL, N'MetaData', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (46, 0, 0, 0, 14, N'ReferenceObjectClass', N'Pointer zur Objektklasse', 1, N'Pointer zur Objektklasse', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (48, 1, 0, 0, 3, N'Kundenname', N'Bitte geben Sie den Kundennamen ein', 2, N'Bitte geben Sie den Kundennamen ein', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (49, 1, 0, 0, 19, N'Mitarbeiter', NULL, 2, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (50, 1, 0, 0, 19, N'Auftragsname', N'Bitte füllen Sie einen sprechenden Auftragsnamen aus', 2, N'Bitte füllen Sie einen sprechenden Auftragsnamen aus', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (51, 1, 0, 0, 19, N'Projekt', N'Projekt zum Auftrag', 2, N'Projekt zum Auftrag', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (52, 0, 0, 0, 20, N'Kontoname', N'Name des Zeiterfassungskontos', 3, N'Name des Zeiterfassungskontos', NULL, NULL, N'Summary,Main', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (59, 0, 0, 0, 26, N'Kundenname', N'Name des Kunden', 2, N'Name des Kunden', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (60, 1, 0, 0, 26, N'Adresse', N'Adresse & Hausnummer', 2, N'Adresse & Hausnummer', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (61, 0, 0, 0, 26, N'PLZ', N'Postleitzahl', 2, N'Postleitzahl', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (62, 1, 0, 0, 26, N'Ort', N'Ort', 2, N'Ort', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (63, 1, 0, 0, 26, N'Land', N'Land', 2, N'Land', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (64, 1, 0, 0, 19, N'Kunde', N'Kunde des Projektes', 2, N'Kunde des Projektes', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (65, 1, 0, 0, 19, N'Auftragswert', N'Wert in EUR des Auftrages', 2, N'Wert in EUR des Auftrages', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (67, 1, 1, 0, 3, N'Auftraege', N'Aufträge', 2, N'Aufträge', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (68, 0, 0, 0, 27, N'IconFile', N'Filename of the Icon', 4, N'Filename of the Icon', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (69, 1, 0, 0, 33, N'DefaultIcon', N'Standard Icon wenn IIcon nicht implementiert ist', 4, N'Standard Icon wenn IIcon nicht implementiert ist', NULL, NULL, N'Description GUI', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (70, 0, 0, 0, 29, N'Module', N'Module', 1, N'Module', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (71, 0, 0, 0, 29, N'AssemblyName', N'Full Assemblyname eg. MyActions, Version=1.0.0.0', 1, N'Full Assemblyname eg. MyActions, Version=1.0.0.0', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (72, 0, 0, 0, 7, N'Module', N'Zugehörig zum Modul', 1, N'Zugehörig zum Modul', NULL, NULL, N'MetaData', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (73, 0, 0, 0, 10, N'Module', N'Zugehörig zum Modul', 1, N'Zugehörig zum Modul', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (74, 0, 0, 0, 30, N'Method', N'Methode, die Aufgerufen wird', 1, N'Methode, die Aufgerufen wird', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (77, 0, 0, 0, 30, N'MemberName', N'Name des implementierenden Members', 1, N'Name des implementierenden Members', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (78, 0, 0, 0, 30, N'Module', N'Zugehörig zum Modul', 1, N'Zugehörig zum Modul', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (79, 0, 0, 0, 30, N'InvokeOnObjectClass', N'In dieser Objektklasse implementieren', 1, N'In dieser Objektklasse implementieren', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (80, 1, 1, 0, 33, N'MethodInvocations', N'all implemented Methods in this DataType', 1, N'all implemented Methods in this DataType', NULL, NULL, N'DataModel', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (81, 1, 1, 0, 10, N'MethodInvokations', N'Methodenaufrufe implementiert in dieser Objekt Klasse', 1, N'Methodenaufrufe implementiert in dieser Objekt Klasse', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (82, 1, 1, 0, 18, N'Assemblies', N'Assemblies des Moduls', 1, N'Assemblies des Moduls', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (83, 0, 0, 0, 29, N'IsClientAssembly', N'Legt fest, ob es sich um ein Client-Assembly handelt.', 1, N'Legt fest, ob es sich um ein Client-Assembly handelt.', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (85, 1, 1, 0, 26, N'EMails', N'EMails des Kunden - können mehrere sein', 2, N'EMails des Kunden - können mehrere sein', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (86, 1, 1, 0, 20, N'Mitarbeiter', N'Zugeordnete Mitarbeiter', 3, N'Zugeordnete Mitarbeiter', NULL, NULL, N'Main', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (89, 1, 0, 0, 20, N'MaxStunden', N'Maximal erlaubte Stundenanzahl', 3, N'Maximal erlaubte Stundenanzahl', NULL, NULL, N'Summary,Main', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (90, 1, 0, 0, 20, N'AktuelleStunden', N'Aktuell gebuchte Stunden', 3, N'Aktuell gebuchte Stunden', NULL, NULL, N'Summary,Main', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (91, 0, 0, 0, 36, N'ParameterName', N'Name des Parameter', 1, N'Name des Parameter', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (92, 0, 0, 0, 36, N'Method', N'Methode des Parameters', 1, N'Methode des Parameters', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (94, 0, 0, 0, 36, N'IsList', N'Parameter wird als List<> generiert', 1, N'Parameter wird als List<> generiert', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (95, 0, 0, 0, 36, N'IsReturnParameter', N'Es darf nur ein Return Parameter angegeben werden', 1, N'Es darf nur ein Return Parameter angegeben werden', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (96, 1, 1, 1, 10, N'Parameter', N'Parameter der Methode', 1, N'Parameter der Methode', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (97, 0, 0, 0, 42, N'DataType', N'Kistl-Typ des Parameters', 1, N'Kistl-Typ des Parameters', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (98, 1, 0, 0, 43, N'Assembly', N'Assembly des CLR Objektes, NULL für Default Assemblies', 1, N'Assembly des CLR Objektes, NULL für Default Assemblies', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (99, 0, 0, 0, 43, N'FullTypeName', N'Name des CLR Datentypen', 1, N'Name des CLR Datentypen', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (100, 0, 0, 0, 46, N'Enumeration', N'Übergeordnete Enumeration', 1, N'Übergeordnete Enumeration', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (103, 1, 1, 0, 45, N'EnumerationEntries', N'Einträge der Enumeration', 1, N'Einträge der Enumeration', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (104, 0, 0, 0, 47, N'Enumeration', N'Enumeration der Eigenschaft', 1, N'Enumeration der Eigenschaft', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (105, 1, 1, 0, 2, N'ImplementsInterfaces', N'Interfaces der Objektklasse', 1, N'Interfaces der Objektklasse', NULL, NULL, N'DataModel', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (107, 0, 0, 0, 48, N'StringProp', N'String Property für das Testinterface', 5, N'String Property für das Testinterface', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (108, 0, 0, 0, 48, N'ObjectProp', N'Objektpointer für das Testinterface', 5, N'Objektpointer für das Testinterface', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (109, 0, 0, 0, 51, N'StringProp', N'String Property', 5, N'String Property', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (110, 0, 0, 0, 51, N'TestEnumProp', N'Test Enumeration Property', 5, N'Test Enumeration Property', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (111, 0, 0, 0, 48, N'TestEnumProp', N'Test Enum Property', 5, N'Test Enum Property', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (112, 0, 0, 0, 51, N'ObjectProp', N'testtest', 5, N'testtest', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (113, 0, 0, 0, 52, N'Platform', N'The Toolkit used by this Renderer', 4, N'The Toolkit used by this Renderer', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (114, 0, 0, 0, 54, N'Assembly', N'The assembly containing the Control', 4, N'The assembly containing the Control', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (115, 0, 0, 0, 54, N'ClassName', N'The name of the class implementing this Control', 4, N'The name of the class implementing this Control', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (116, 0, 0, 0, 54, N'IsContainer', N'Whether or not this Control can contain other Controls', 4, N'Whether or not this Control can contain other Controls', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (117, 0, 0, 0, 54, N'Platform', N'The toolkit of this Control.', 4, N'The toolkit of this Control.', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (118, 0, 0, 0, 54, N'ControlType', N'The type of Control of this implementation', 4, N'The type of Control of this implementation', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (119, 0, 0, 0, 2, N'IsSimpleObject', N'Setting this to true marks the instances of this class as "simple." At first this will only mean that they''ll be displayed inline.', 4, N'Setting this to true marks the instances of this class as "simple." At first this will only mean that they''ll be displayed inline.', NULL, NULL, N'DataModel', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (124, 0, 0, 0, 10, N'IsDisplayable', N'Shows this Method in th GUI', 4, N'Shows this Method in th GUI', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (126, 1, 0, 0, 51, N'MyIntProperty', N'test', 5, N'test', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (127, 1, 0, 0, 63, N'Number', N'Enter a Number', 5, N'Enter a Number', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (128, 1, 0, 0, 63, N'AreaCode', N'Enter Area Code', 5, N'Enter Area Code', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (129, 0, 0, 0, 64, N'StructDefinition', N'Definition of this Struct', 1, N'Definition of this Struct', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (130, 0, 0, 0, 58, N'PersonName', N'Persons Name', 5, N'Persons Name', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (131, 1, 0, 0, 58, N'PhoneNumberMobile', N'Mobile Phone Number', 5, N'Mobile Phone Number', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (132, 1, 0, 0, 58, N'PhoneNumberOffice', N'Office Phone Number', 5, N'Office Phone Number', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (133, 1, 0, 0, 58, N'Birthday', N'Happy Birthday!', 5, N'Happy Birthday!', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (135, 0, 0, 0, 46, N'Value', N'The CLR value of this entry', 1, N'The CLR value of this entry', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (136, 0, 0, 0, 46, N'Name', N'CLR name of this entry', 1, N'CLR name of this entry', NULL, NULL, NULL, NULL)
GO
print 'Processed 100 total records'
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (137, 0, 0, 0, 66, N'ControlType', N'which controls are handled by this Presenter', 4, N'which controls are handled by this Presenter', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (138, 0, 0, 0, 66, N'PresenterAssembly', N'Where to find the implementation of the Presenter', 4, N'Where to find the implementation of the Presenter', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (139, 0, 0, 0, 66, N'PresenterTypeName', N'The CLR namespace and class name of the Presenter', 4, N'The CLR namespace and class name of the Presenter', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (147, 1, 0, 0, 66, N'DataAssembly', N'The Assembly of the Data Type', 4, N'The Assembly of the Data Type', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (148, 0, 0, 0, 66, N'DataTypeName', N'The CLR namespace and class name of the Data Type', 4, N'The CLR namespace and class name of the Data Type', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (149, 0, 0, 0, 67, N'Description', N'A short description of the utility of this visual', 4, N'A short description of the utility of this visual', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (150, 0, 0, 0, 67, N'ControlType', N'Which visual is represented here', 4, N'Which visual is represented here', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (151, 1, 1, 0, 67, N'Children', N'if this is a container, here are the visually contained/controlled children of this Visual', 4, N'if this is a container, here are the visually contained/controlled children of this Visual', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (152, 1, 0, 0, 67, N'Property', N'The Property to display', 4, N'The Property to display', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (153, 0, 0, 0, 67, N'Method', N'The Method whose return value shoud be displayed', 4, N'The Method whose return value shoud be displayed', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (154, 0, 0, 0, 68, N'DisplayName', N'a short name to identify this Template to the user', 4, N'a short name to identify this Template to the user', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (155, 0, 0, 0, 68, N'VisualTree', N'The visual representation of this Template', 4, N'The visual representation of this Template', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (162, 0, 0, 0, 68, N'DisplayedTypeFullName', N'FullName of the Type that is displayed with this Template', 4, N'FullName of the Type that is displayed with this Template', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (163, 0, 0, 0, 68, N'DisplayedTypeAssembly', N'Assembly of the Type that is displayed with this Template', 4, N'Assembly of the Type that is displayed with this Template', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (164, 1, 1, 0, 67, N'ContextMenu', N'The context menu for this Visual', 4, N'The context menu for this Visual', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (165, 1, 1, 0, 68, N'Menu', N'The main menu for this Template', 4, N'The main menu for this Template', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (167, 1, 0, 0, 69, N'Reason', N'The reason of this constraint', 1, N'The reason of this constraint', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (168, 0, 0, 0, 71, N'Max', N'The biggest value accepted by this constraint', 1, N'The biggest value accepted by this constraint', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (169, 0, 0, 0, 71, N'Min', N'The smallest value accepted by this constraint', 1, N'The smallest value accepted by this constraint', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (170, 1, 1, 0, 7, N'Constraints', N'The list of constraints applying to this Property', 1, N'The list of constraints applying to this Property', NULL, NULL, N'DataModel', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (171, 0, 0, 0, 69, N'ConstrainedProperty', N'The property to be constrained', 1, N'The property to be constrained', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (172, 0, 0, 0, 73, N'MaxLength', N'The maximal length of this StringProperty', 1, N'The maximal length of this StringProperty', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (173, 0, 0, 0, 73, N'MinLength', N'The minimal length of this StringProperty', 1, N'The minimal length of this StringProperty', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (174, 0, 0, 0, 2, N'IsFrozenObject', N'if true then all Instances appear in FozenContext.', 1, N'if true then all Instances appear in FozenContext.', NULL, NULL, N'Physical', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (175, 1, 0, 0, 33, N'Description', N'Description of this DataType', 1, N'Description of this DataType', NULL, NULL, N'Description', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (176, 1, 0, 0, 7, N'Description', N'Description of this Property', 1, N'Description of this Property', NULL, NULL, N'Description', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (177, 1, 0, 0, 36, N'Description', N'Description of this Parameter', 1, N'Description of this Parameter', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (178, 1, 0, 0, 46, N'Description', N'Description of this Enumeration Entry', 1, N'Description of this Enumeration Entry', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (179, 1, 0, 0, 18, N'Description', N'Description of this Module', 1, N'Description of this Module', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (180, 1, 0, 0, 10, N'Description', N'Description of this Method', 1, N'Description of this Method', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (183, 1, 0, 0, 77, N'Storage', N'Storagetype for 1:1 Relations', 1, N'Storagetype for 1:1 Relations. Must be null for non 1:1 Relations.', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (184, 1, 0, 0, 77, N'Description', N'Description of this Relation', 1, N'Description of this Relation', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (204, 0, 0, 0, 7, N'IsIndexed', N'Whether or not a list-valued property has a index', 1, N'Whether or not a list-valued property has a index', NULL, NULL, N'DataModel', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (205, 0, 0, 0, 79, N'FullName', NULL, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (206, 0, 0, 0, 79, N'Assembly', N'The assembly containing the referenced Type.', 1, N'The assembly containing the referenced Type.', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (207, 1, 1, 1, 79, N'GenericArguments', N'list of type arguments', 1, N'list of type arguments', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (208, 0, 0, 0, 30, N'Implementor', N'The Type implementing this invocation', 1, N'The Type implementing this invocation', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (209, 0, 0, 0, 80, N'LayoutRef', N'Which Layout is handled by this View', 4, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (210, 0, 0, 0, 80, N'Toolkit', N'', 4, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (211, 0, 0, 0, 80, N'ViewRef', N'the Type of a View for this Layout', 4, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (212, 1, 0, 0, 2, N'DefaultModel', N'The default model to use for the UI', 4, N'The default model to use for the UI', NULL, NULL, N'GUI', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (213, 1, 0, 0, 77, N'A', N'The A-side of this Relation.', 1, N'The A-side of this Relation.', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (214, 1, 0, 0, 77, N'B', N'The B-side of this Relation.', 1, N'The B-side of this Relation.', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (215, 0, 0, 0, 82, N'Type', N'Specifies which type this End of the relation has. MUST NOT be null.', 1, N'Specifies which type this End of the relation has. MUST NOT be null.', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (216, 0, 0, 0, 82, N'RoleName', N'This end''s role name in the relation', 1, N'This end''s role name in the relation', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (217, 0, 0, 0, 82, N'Role', N'Which RelationEndRole this End has', 1, N'Which RelationEndRole this End has', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (218, 1, 0, 0, 82, N'Navigator', N'The ORP to navigate FROM this end of the relation. MAY be null.', 1, N'The ORP to navigate FROM this end of the relation. MAY be null.', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (219, 0, 0, 0, 82, N'Multiplicity', N'Specifies how many instances may occur on this end of the relation.', 1, N'Specifies how many instances may occur on this end of the relation.', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (220, 0, 0, 0, 82, N'HasPersistentOrder', N'Is true, if this RelationEnd persists the order of its elements', 1, N'Is true, if this RelationEnd persists the order of its elements', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (222, 1, 0, 0, 14, N'RelationEnd', NULL, 1, N'The RelationEnd describing this Property', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (223, 1, 0, 0, 82, N'BParent', NULL, 1, N'The Relation using this RelationEnd as B', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (224, 1, 0, 0, 82, N'AParent', NULL, 1, N'The Relation using this RelationEnd as A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (225, 1, 0, 0, 7, N'CategoryTags', NULL, 1, N'A space separated list of category names containing this Property', NULL, NULL, N'Description GUI', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (226, 0, 0, 0, 83, N'PresentedModelDescriptor', NULL, 4, N'The PresentableModel usable by this View', NULL, NULL, N'Main', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (227, 0, 0, 0, 83, N'ControlRef', NULL, 4, N'The control implementing this View', NULL, NULL, N'Main', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (228, 0, 0, 0, 83, N'Toolkit', NULL, 4, N'Which toolkit provides this View', NULL, NULL, N'Summary,Main', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (229, 0, 0, 0, 83, N'VisualType', NULL, 4, N'The visual type of this View', NULL, NULL, N'Summary,Main', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (231, 0, 0, 0, 85, N'PresentableModelRef', NULL, 4, N'The described CLR class'' reference', NULL, NULL, N'Main', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (232, 0, 0, 0, 85, N'Description', NULL, 4, N'describe this PresentableModel', NULL, NULL, N'Summary,Main', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (233, 0, 0, 0, 85, N'DefaultVisualType', NULL, 4, N'The default visual type used for this PresentableModel', NULL, NULL, N'Summary,Main', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (234, 0, 0, 0, 2, N'DefaultPresentableModelDescriptor', NULL, 4, N'The default PresentableModel to use for this ObjectClass', NULL, NULL, N'Main', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (235, 0, 0, 0, 79, N'Parent', NULL, 1, N'The TypeRef of the BaseClass of the referenced Type', NULL, NULL, NULL, NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (236, 0, 0, 0, 7, N'ValueModelDescriptor', NULL, 4, N'The PresentableModel to use for values of this Property', NULL, NULL, N'Main', NULL)
INSERT [dbo].[Properties] ([ID], [IsNullable], [IsList], [IsIndexed], [fk_ObjectClass], [PropertyName], [AltText], [fk_Module], [Description], [fk_ObjectClass_pos], [fk_Module_pos], [CategoryTags], [fk_ValueModelDescriptor]) VALUES (237, 0, 0, 0, 20, N'Notizen', NULL, 3, N'Platz für Notizen', NULL, NULL, N'Main', NULL)
SET IDENTITY_INSERT [dbo].[Properties] OFF
/****** Object:  Table [dbo].[IntParameters]    Script Date: 04/27/2009 16:11:31 ******/
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
/****** Object:  Table [dbo].[ObjectClasses]    Script Date: 04/27/2009 16:11:31 ******/
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
	[IsSimpleObject] [bit] NOT NULL,
	[IsFrozenObject] [bit] NOT NULL,
	[fk_DefaultModel] [int] NULL,
	[fk_BaseObjectClass_pos] [int] NULL,
	[fk_DefaultModel_pos] [int] NULL,
	[fk_DefaultPresentableModelDescriptor] [int] NULL,
 CONSTRAINT [PK_ObjectClasses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (2, N'ObjectClasses', 33, 0, 0, 10, NULL, NULL, 33)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (3, N'Projekte', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (4, N'Tasks', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (6, N'Mitarbeiter', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (7, N'Properties', NULL, 0, 1, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (8, N'ValueTypeProperties', 7, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (9, N'StringProperties', 8, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (10, N'Methods', NULL, 0, 1, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (11, N'IntProperties', 8, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (12, N'BoolProperties', 8, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (13, N'DoubleProperties', 8, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (14, N'ObjectReferenceProperties', 7, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (15, N'DateTimeProperties', 8, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (18, N'Modules', NULL, 0, 1, 9, NULL, NULL, 32)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (19, N'Auftraege', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (20, N'Zeitkonten', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (26, N'Kunden', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (27, N'Icons', NULL, 1, 1, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (29, N'Assemblies', NULL, 0, 1, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (30, N'MethodInvocations', NULL, 0, 1, 41, NULL, NULL, 31)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (33, N'DataTypes', NULL, 0, 1, 11, NULL, NULL, 30)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (36, N'BaseParameters', NULL, 0, 1, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (37, N'StringParameters', 36, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (38, N'IntParameters', 36, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (39, N'DoubleParameters', 36, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (40, N'BoolParameters', 36, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (41, N'DateTimeParameters', 36, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (42, N'ObjectParameters', 36, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (43, N'CLRObjectParameters', 36, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (44, N'Interfaces', 33, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (45, N'Enumerations', 33, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (46, N'EnumerationEntries', NULL, 1, 1, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (47, N'EnumerationProperties', 8, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (51, N'TestObjClasses', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (54, N'ControlInfos', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (58, N'TestCustomObjects', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (59, N'Muhblas', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (60, N'AnotherTests', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (61, N'LastTests', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (62, N'Structs', 33, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (64, N'StructProperties', 7, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (66, N'PresenterInfos', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (67, N'Visuals', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (68, N'Templates', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (69, N'Constraints', NULL, 0, 1, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (70, N'NotNullableConstraints', 69, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (71, N'IntegerRangeConstraints', 69, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (73, N'StringRangeConstraints', 69, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (74, N'MethodInvocationConstraints', 69, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (75, N'IsValidIdentifierConstraints', 69, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (76, N'IsValidNamespaceConstraints', 75, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (77, N'Relations', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (79, N'TypeRefs', NULL, 0, 1, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (82, N'RelationEnds', NULL, 0, 0, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (83, N'ViewDescriptors', NULL, 0, 1, NULL, NULL, NULL, 7)
INSERT [dbo].[ObjectClasses] ([ID], [TableName], [fk_BaseObjectClass], [IsSimpleObject], [IsFrozenObject], [fk_DefaultModel], [fk_BaseObjectClass_pos], [fk_DefaultModel_pos], [fk_DefaultPresentableModelDescriptor]) VALUES (85, N'PresentableModelDescriptors', NULL, 0, 1, NULL, NULL, NULL, 7)
/****** Object:  Table [dbo].[ObjectParameters]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectParameters]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ObjectParameters](
	[ID] [int] NOT NULL,
	[fk_DataType] [int] NOT NULL,
	[fk_DataType_pos] [int] NULL,
 CONSTRAINT [PK_ObjectParameters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[ObjectParameters] ([ID], [fk_DataType], [fk_DataType_pos]) VALUES (10, 19, NULL)
INSERT [dbo].[ObjectParameters] ([ID], [fk_DataType], [fk_DataType_pos]) VALUES (26, 36, NULL)
INSERT [dbo].[ObjectParameters] ([ID], [fk_DataType], [fk_DataType_pos]) VALUES (27, 10, NULL)
INSERT [dbo].[ObjectParameters] ([ID], [fk_DataType], [fk_DataType_pos]) VALUES (36, 2, NULL)
/****** Object:  Table [dbo].[ObjectClasses_ImplementsInterfacesCollection]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectClasses_ImplementsInterfacesCollection]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ObjectClasses_ImplementsInterfacesCollection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_ObjectClass] [int] NOT NULL,
	[fk_ImplementsInterfaces] [int] NOT NULL,
 CONSTRAINT [PK_ObjectClasses_ImplementsInterfacesCollection] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[ObjectClasses_ImplementsInterfacesCollection] ON
INSERT [dbo].[ObjectClasses_ImplementsInterfacesCollection] ([ID], [fk_ObjectClass], [fk_ImplementsInterfaces]) VALUES (1, 51, 48)
SET IDENTITY_INSERT [dbo].[ObjectClasses_ImplementsInterfacesCollection] OFF
/****** Object:  Table [dbo].[ObjectReferenceProperties]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectReferenceProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ObjectReferenceProperties](
	[ID] [int] NOT NULL,
	[fk_ReferenceObjectClass] [int] NOT NULL,
	[fk_RightOf] [int] NULL,
	[fk_LeftOf] [int] NULL,
	[fk_ReferenceObjectClass_pos] [int] NULL,
 CONSTRAINT [PK_ObjectReferenceProperties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (7, 7, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (8, 33, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (14, 4, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (19, 3, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (21, 3, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (22, 6, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (25, 2, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (27, 2, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (29, 33, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (31, 10, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (44, 33, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (45, 18, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (46, 2, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (49, 6, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (51, 3, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (64, 26, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (67, 19, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (69, 27, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (70, 18, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (72, 18, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (73, 18, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (74, 10, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (78, 18, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (79, 33, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (80, 30, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (81, 30, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (82, 29, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (86, 6, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (92, 10, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (96, 36, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (97, 33, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (98, 29, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (100, 45, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (103, 46, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (104, 45, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (105, 44, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (108, 26, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (112, 26, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (114, 29, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (129, 62, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (138, 29, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (147, 29, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (151, 67, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (152, 7, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (153, 10, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (155, 67, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (163, 29, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (164, 67, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (165, 67, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (170, 69, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (171, 7, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (206, 29, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (207, 79, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (208, 79, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (209, 79, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (211, 79, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (212, 79, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (213, 82, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (214, 82, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (215, 2, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (218, 14, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (222, 82, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (223, 77, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (224, 77, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (226, 85, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (227, 79, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (231, 79, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (234, 85, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (235, 79, NULL, NULL, NULL)
INSERT [dbo].[ObjectReferenceProperties] ([ID], [fk_ReferenceObjectClass], [fk_RightOf], [fk_LeftOf], [fk_ReferenceObjectClass_pos]) VALUES (236, 85, NULL, NULL, NULL)
/****** Object:  Table [dbo].[RelationEnds]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RelationEnds]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RelationEnds](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Type] [int] NOT NULL,
	[RoleName] [nvarchar](200) COLLATE Latin1_General_CI_AS NOT NULL,
	[Role] [int] NOT NULL,
	[fk_Navigator] [int] NULL,
	[Multiplicity] [int] NOT NULL,
	[HasPersistentOrder] [bit] NOT NULL,
	[fk_Type_pos] [int] NULL,
	[fk_Navigator_pos] [int] NULL,
 CONSTRAINT [PK_RelationEnds] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[RelationEnds] ON
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (3, 33, N'ObjectClass', 1, 7, 2, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (4, 7, N'Properties', 2, 8, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (9, 3, N'Projekt', 1, 14, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (10, 4, N'Tasks', 2, 19, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (11, 3, N'Projekte', 1, 22, 3, 1, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (12, 6, N'Mitarbeiter', 2, 21, 3, 1, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (13, 2, N'BaseObjectClass', 1, 27, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (14, 2, N'SubClasses', 2, 25, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (15, 33, N'ObjectClass', 1, 31, 2, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (16, 10, N'Methods', 2, 29, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (17, 18, N'Module', 1, 44, 2, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (18, 33, N'DataTypes', 2, 45, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (19, 14, N'ObjectReferenceProperty', 1, 46, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (20, 2, N'ReferenceObjectClass', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (23, 19, N'Auftrag', 1, 49, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (24, 6, N'Mitarbeiter', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (25, 3, N'Projekt', 1, 67, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (26, 19, N'Auftraege', 2, 51, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (33, 19, N'Auftrag', 1, 64, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (34, 26, N'Kunde', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (35, 33, N'DataType', 1, 69, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (36, 27, N'DefaultIcon', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (37, 18, N'Module', 1, 82, 2, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (38, 29, N'Assemblies', 2, 70, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (39, 7, N'BaseProperty', 1, 72, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (40, 18, N'Module', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (41, 10, N'Method', 1, 73, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (42, 18, N'Module', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (43, 10, N'Method', 1, 81, 2, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (44, 30, N'MethodInvokations', 2, 74, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (45, 30, N'MethodInvocation', 1, 78, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (46, 18, N'Module', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (47, 33, N'InvokeOnObjectClass', 1, 80, 2, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (48, 30, N'MethodInvocations', 2, 79, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (49, 20, N'Zeitkonto', 1, 86, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (50, 6, N'Mitarbeiter', 2, NULL, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (53, 10, N'Method', 1, 96, 2, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (54, 36, N'Parameter', 2, 92, 3, 1, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (55, 42, N'ObjectParameter', 1, 97, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (56, 33, N'DataType', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (57, 43, N'CLRObjectParameter', 1, 98, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (58, 29, N'Assembly', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (59, 45, N'Enumeration', 1, 103, 2, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (60, 46, N'EnumerationEntries', 2, 100, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (61, 47, N'EnumerationProperty', 1, 104, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (62, 45, N'Enumeration', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (63, 2, N'ObjectClass', 1, 105, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (64, 44, N'ImplementsInterfaces', 2, NULL, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (65, 51, N'TestObjClass', 1, 112, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (66, 26, N'ObjectProp', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (67, 54, N'ControlInfo', 1, 114, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (68, 29, N'Assembly', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (69, 64, N'StructProperty', 1, 129, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (70, 62, N'StructDefinition', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (71, 66, N'PresenterInfo', 1, 138, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (72, 29, N'PresenterAssembly', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (73, 66, N'PresenterInfo', 1, 147, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (74, 29, N'DataAssembly', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (75, 67, N'Visual', 1, 151, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (76, 67, N'Children', 2, NULL, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (77, 67, N'Visual', 1, 152, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (78, 7, N'Property', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (79, 67, N'Visual', 1, 153, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (80, 10, N'Method', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (81, 68, N'Template', 1, 155, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (82, 67, N'VisualTree', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (83, 68, N'Template', 1, 163, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (84, 29, N'DisplayedTypeAssembly', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (85, 67, N'Visual', 1, 164, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (86, 67, N'ContextMenu', 2, NULL, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (87, 68, N'Template', 1, 165, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (88, 67, N'Menu', 2, NULL, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (89, 7, N'ConstrainedProperty', 1, 170, 2, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (90, 69, N'Constraints', 2, 171, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (95, 79, N'TypeRef', 1, 206, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (96, 29, N'Assembly', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (97, 79, N'TypeRef', 1, 207, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (98, 79, N'GenericArguments', 2, NULL, 3, 1, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (99, 30, N'MethodInvocation', 1, 208, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (100, 79, N'Implementor', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (102, 79, N'LayoutRef', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (104, 79, N'ViewRef', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (105, 2, N'ObjectClass', 1, 212, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (106, 79, N'DefaultModel', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (107, 77, N'Relation', 1, 213, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (108, 82, N'A', 2, 224, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (109, 77, N'Relation', 1, 214, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (110, 82, N'B', 2, 223, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (111, 82, N'RelationEnd', 1, 215, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (112, 2, N'Type', 2, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (113, 82, N'RelationEnd', 1, 218, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (114, 14, N'Navigator', 2, 222, 1, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (115, 85, N'PresentedModelDescriptor', 2, NULL, 2, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (116, 79, N'ControlRef', 2, NULL, 2, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (117, 83, N'View', 1, 226, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (118, 83, N'View', 1, 227, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (119, 79, N'PresentableModelRef', 2, NULL, 2, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (120, 85, N'Descriptor', 1, 231, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (121, 85, N'DefaultPresentableModelDescriptor', 2, NULL, 2, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (122, 2, N'Presentable', 1, 234, 3, 0, NULL, NULL)
GO
print 'Processed 100 total records'
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (123, 79, N'Parent', 2, NULL, 2, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (124, 79, N'Child', 1, 235, 3, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (125, 85, N'ValueModelDescriptor', 2, NULL, 2, 0, NULL, NULL)
INSERT [dbo].[RelationEnds] ([ID], [fk_Type], [RoleName], [Role], [fk_Navigator], [Multiplicity], [HasPersistentOrder], [fk_Type_pos], [fk_Navigator_pos]) VALUES (126, 7, N'Property', 1, 236, 3, 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[RelationEnds] OFF
/****** Object:  Table [dbo].[Properties_ConstraintsCollection]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Properties_ConstraintsCollection]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Properties_ConstraintsCollection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Property] [int] NOT NULL,
	[fk_Constraints] [int] NOT NULL,
 CONSTRAINT [PK_BaseProperties_ConstraintsCollection] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[ValueTypeProperties]    Script Date: 04/27/2009 16:11:31 ******/
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
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (38)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (39)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (40)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (41)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (42)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (43)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (48)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (50)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (52)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (59)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (60)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (61)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (62)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (63)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (65)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (68)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (71)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (77)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (83)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (85)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (89)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (90)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (91)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (94)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (95)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (99)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (107)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (109)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (110)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (111)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (113)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (115)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (116)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (117)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (118)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (119)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (124)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (126)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (127)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (128)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (130)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (133)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (135)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (136)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (137)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (139)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (148)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (149)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (150)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (154)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (162)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (167)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (168)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (169)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (172)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (173)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (174)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (175)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (176)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (177)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (178)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (179)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (180)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (183)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (184)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (204)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (205)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (210)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (216)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (217)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (219)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (220)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (225)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (228)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (229)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (232)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (233)
INSERT [dbo].[ValueTypeProperties] ([ID]) VALUES (237)
/****** Object:  Table [dbo].[Templates_MenuCollection]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Templates_MenuCollection]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Templates_MenuCollection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fk_Template] [int] NOT NULL,
	[fk_Menu] [int] NOT NULL,
 CONSTRAINT [PK_Templates_MenuCollection] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[StructProperties]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StructProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StructProperties](
	[ID] [int] NOT NULL,
	[fk_StructDefinition] [int] NOT NULL,
	[fk_StructDefinition_pos] [int] NULL,
 CONSTRAINT [PK_StructProperties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[StructProperties] ([ID], [fk_StructDefinition], [fk_StructDefinition_pos]) VALUES (131, 63, NULL)
INSERT [dbo].[StructProperties] ([ID], [fk_StructDefinition], [fk_StructDefinition_pos]) VALUES (132, 63, NULL)
/****** Object:  Table [dbo].[StringProperties]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StringProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StringProperties](
	[ID] [int] NOT NULL,
	[Length] [int] NOT NULL,
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
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (77, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (85, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (91, 100)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (99, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (107, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (109, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (115, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (127, 50)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (128, 50)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (130, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (136, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (139, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (148, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (149, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (154, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (162, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (167, 400)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (175, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (176, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (177, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (178, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (179, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (180, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (184, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (205, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (216, 200)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (225, 4000)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (232, 4000)
INSERT [dbo].[StringProperties] ([ID], [Length]) VALUES (237, 4000)
/****** Object:  Table [dbo].[Relations]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Relations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Relations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Storage] [int] NULL,
	[Description] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
	[fk_A] [int] NULL,
	[fk_B] [int] NULL,
	[fk_A_pos] [int] NULL,
	[fk_B_pos] [int] NULL,
 CONSTRAINT [PK_Relations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Relations] ON
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (19, 2, NULL, 3, 4, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (22, 2, NULL, 9, 10, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (23, 4, NULL, 11, 12, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (24, 2, NULL, 13, 14, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (25, 2, NULL, 15, 16, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (26, 2, NULL, 17, 18, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (27, 1, NULL, 19, 20, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (29, 1, NULL, 23, 24, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (30, 2, NULL, 25, 26, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (34, 1, NULL, 33, 34, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (35, 1, NULL, 35, 36, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (36, 2, NULL, 37, 38, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (37, 1, NULL, 39, 40, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (38, 1, NULL, 41, 42, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (39, 2, NULL, 43, 44, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (40, 1, NULL, 45, 46, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (41, 2, NULL, 47, 48, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (42, 4, NULL, 49, 50, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (44, 2, NULL, 53, 54, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (45, 1, NULL, 55, 56, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (46, 1, NULL, 57, 58, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (47, 2, NULL, 59, 60, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (48, 1, NULL, 61, 62, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (49, 4, NULL, 63, 64, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (50, 1, NULL, 65, 66, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (51, 1, NULL, 67, 68, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (52, 1, NULL, 69, 70, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (53, 1, NULL, 71, 72, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (54, 1, NULL, 73, 74, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (55, 4, NULL, 75, 76, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (56, 1, NULL, 77, 78, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (57, 1, NULL, 79, 80, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (58, 1, NULL, 81, 82, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (59, 1, NULL, 83, 84, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (60, 4, NULL, 85, 86, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (61, 4, NULL, 87, 88, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (62, 2, NULL, 89, 90, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (65, 1, NULL, 95, 96, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (66, 4, NULL, 97, 98, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (67, 1, NULL, 99, 100, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (70, 1, NULL, 105, 106, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (71, 1, NULL, 107, 108, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (72, 1, NULL, 109, 110, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (73, 1, NULL, 111, 112, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (74, 1, NULL, 113, 114, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (75, 1, N'This relation describes which presentable model can be displayed with this view', 117, 115, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (76, 1, N'This relation describes which control implements which view', 118, 116, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (77, 1, N'This relation between a PresentableModelDescriptor and the described PresentableModel''s Type', 120, 119, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (78, 1, N'This relation between a PresentableModelDescriptor and the described PresentableModel''s Type', 122, 121, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (79, 1, N'This relation describes the underlying inheritance relationships', 124, 123, NULL, NULL)
INSERT [dbo].[Relations] ([ID], [Storage], [Description], [fk_A], [fk_B], [fk_A_pos], [fk_B_pos]) VALUES (80, 1, N'Connects a Property with the PresentableModel to display her value', 126, 125, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Relations] OFF
/****** Object:  Table [dbo].[IntProperties]    Script Date: 04/27/2009 16:11:31 ******/
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
INSERT [dbo].[IntProperties] ([ID]) VALUES (126)
INSERT [dbo].[IntProperties] ([ID]) VALUES (135)
INSERT [dbo].[IntProperties] ([ID]) VALUES (168)
INSERT [dbo].[IntProperties] ([ID]) VALUES (169)
INSERT [dbo].[IntProperties] ([ID]) VALUES (172)
INSERT [dbo].[IntProperties] ([ID]) VALUES (173)
INSERT [dbo].[IntProperties] ([ID]) VALUES (217)
/****** Object:  Table [dbo].[DoubleProperties]    Script Date: 04/27/2009 16:11:31 ******/
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
INSERT [dbo].[DoubleProperties] ([ID]) VALUES (65)
INSERT [dbo].[DoubleProperties] ([ID]) VALUES (89)
INSERT [dbo].[DoubleProperties] ([ID]) VALUES (90)
/****** Object:  Table [dbo].[EnumerationProperties]    Script Date: 04/27/2009 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnumerationProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EnumerationProperties](
	[ID] [int] NOT NULL,
	[fk_Enumeration] [int] NOT NULL,
	[fk_Enumeration_pos] [int] NULL,
 CONSTRAINT [PK_EnumerationProperties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[EnumerationProperties] ([ID], [fk_Enumeration], [fk_Enumeration_pos]) VALUES (110, 50, NULL)
INSERT [dbo].[EnumerationProperties] ([ID], [fk_Enumeration], [fk_Enumeration_pos]) VALUES (111, 50, NULL)
INSERT [dbo].[EnumerationProperties] ([ID], [fk_Enumeration], [fk_Enumeration_pos]) VALUES (113, 53, NULL)
INSERT [dbo].[EnumerationProperties] ([ID], [fk_Enumeration], [fk_Enumeration_pos]) VALUES (117, 53, NULL)
INSERT [dbo].[EnumerationProperties] ([ID], [fk_Enumeration], [fk_Enumeration_pos]) VALUES (118, 55, NULL)
INSERT [dbo].[EnumerationProperties] ([ID], [fk_Enumeration], [fk_Enumeration_pos]) VALUES (137, 55, NULL)
INSERT [dbo].[EnumerationProperties] ([ID], [fk_Enumeration], [fk_Enumeration_pos]) VALUES (150, 55, NULL)
INSERT [dbo].[EnumerationProperties] ([ID], [fk_Enumeration], [fk_Enumeration_pos]) VALUES (183, 78, NULL)
INSERT [dbo].[EnumerationProperties] ([ID], [fk_Enumeration], [fk_Enumeration_pos]) VALUES (210, 53, NULL)
INSERT [dbo].[EnumerationProperties] ([ID], [fk_Enumeration], [fk_Enumeration_pos]) VALUES (219, 81, NULL)
INSERT [dbo].[EnumerationProperties] ([ID], [fk_Enumeration], [fk_Enumeration_pos]) VALUES (228, 53, NULL)
INSERT [dbo].[EnumerationProperties] ([ID], [fk_Enumeration], [fk_Enumeration_pos]) VALUES (229, 55, NULL)
INSERT [dbo].[EnumerationProperties] ([ID], [fk_Enumeration], [fk_Enumeration_pos]) VALUES (233, 55, NULL)
/****** Object:  Table [dbo].[DateTimeProperties]    Script Date: 04/27/2009 16:11:31 ******/
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
INSERT [dbo].[DateTimeProperties] ([ID]) VALUES (133)
/****** Object:  Table [dbo].[BoolProperties]    Script Date: 04/27/2009 16:11:31 ******/
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
INSERT [dbo].[BoolProperties] ([ID]) VALUES (94)
INSERT [dbo].[BoolProperties] ([ID]) VALUES (95)
INSERT [dbo].[BoolProperties] ([ID]) VALUES (116)
INSERT [dbo].[BoolProperties] ([ID]) VALUES (119)
INSERT [dbo].[BoolProperties] ([ID]) VALUES (124)
INSERT [dbo].[BoolProperties] ([ID]) VALUES (174)
INSERT [dbo].[BoolProperties] ([ID]) VALUES (204)
INSERT [dbo].[BoolProperties] ([ID]) VALUES (220)
/****** Object:  Default [DF__ObjectCla__Table__0F975522]    Script Date: 04/27/2009 16:11:31 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__ObjectCla__Table__0F975522]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__ObjectCla__Table__0F975522]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ObjectClasses] ADD  CONSTRAINT [DF__ObjectCla__Table__0F975522]  DEFAULT ('NewTable') FOR [TableName]
END


End
GO
/****** Object:  ForeignKey [FK_Assembly_Module_fk_Module]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Assembly_Module_fk_Module]') AND parent_object_id = OBJECT_ID(N'[dbo].[Assemblies]'))
ALTER TABLE [dbo].[Assemblies]  WITH CHECK ADD  CONSTRAINT [FK_Assembly_Module_fk_Module] FOREIGN KEY([fk_Module])
REFERENCES [dbo].[Modules] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Assembly_Module_fk_Module]') AND parent_object_id = OBJECT_ID(N'[dbo].[Assemblies]'))
ALTER TABLE [dbo].[Assemblies] CHECK CONSTRAINT [FK_Assembly_Module_fk_Module]
GO
/****** Object:  ForeignKey [FK_Auftrag_Kunde_fk_Kunde]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Auftrag_Kunde_fk_Kunde]') AND parent_object_id = OBJECT_ID(N'[dbo].[Auftraege]'))
ALTER TABLE [dbo].[Auftraege]  WITH CHECK ADD  CONSTRAINT [FK_Auftrag_Kunde_fk_Kunde] FOREIGN KEY([fk_Kunde])
REFERENCES [dbo].[Kunden] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Auftrag_Kunde_fk_Kunde]') AND parent_object_id = OBJECT_ID(N'[dbo].[Auftraege]'))
ALTER TABLE [dbo].[Auftraege] CHECK CONSTRAINT [FK_Auftrag_Kunde_fk_Kunde]
GO
/****** Object:  ForeignKey [FK_Auftrag_Mitarbeiter_fk_Mitarbeiter]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Auftrag_Mitarbeiter_fk_Mitarbeiter]') AND parent_object_id = OBJECT_ID(N'[dbo].[Auftraege]'))
ALTER TABLE [dbo].[Auftraege]  WITH CHECK ADD  CONSTRAINT [FK_Auftrag_Mitarbeiter_fk_Mitarbeiter] FOREIGN KEY([fk_Mitarbeiter])
REFERENCES [dbo].[Mitarbeiter] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Auftrag_Mitarbeiter_fk_Mitarbeiter]') AND parent_object_id = OBJECT_ID(N'[dbo].[Auftraege]'))
ALTER TABLE [dbo].[Auftraege] CHECK CONSTRAINT [FK_Auftrag_Mitarbeiter_fk_Mitarbeiter]
GO
/****** Object:  ForeignKey [FK_Auftrag_Projekt_fk_Projekt]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Auftrag_Projekt_fk_Projekt]') AND parent_object_id = OBJECT_ID(N'[dbo].[Auftraege]'))
ALTER TABLE [dbo].[Auftraege]  WITH CHECK ADD  CONSTRAINT [FK_Auftrag_Projekt_fk_Projekt] FOREIGN KEY([fk_Projekt])
REFERENCES [dbo].[Projekte] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Auftrag_Projekt_fk_Projekt]') AND parent_object_id = OBJECT_ID(N'[dbo].[Auftraege]'))
ALTER TABLE [dbo].[Auftraege] CHECK CONSTRAINT [FK_Auftrag_Projekt_fk_Projekt]
GO
/****** Object:  ForeignKey [FK_BaseParameter_Method_fk_Method]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaseParameter_Method_fk_Method]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaseParameters]'))
ALTER TABLE [dbo].[BaseParameters]  WITH CHECK ADD  CONSTRAINT [FK_BaseParameter_Method_fk_Method] FOREIGN KEY([fk_Method])
REFERENCES [dbo].[Methods] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaseParameter_Method_fk_Method]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaseParameters]'))
ALTER TABLE [dbo].[BaseParameters] CHECK CONSTRAINT [FK_BaseParameter_Method_fk_Method]
GO
/****** Object:  ForeignKey [FK_BaseParameter_Module_fk_Module]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaseParameter_Module_fk_Module]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaseParameters]'))
ALTER TABLE [dbo].[BaseParameters]  WITH CHECK ADD  CONSTRAINT [FK_BaseParameter_Module_fk_Module] FOREIGN KEY([fk_Module])
REFERENCES [dbo].[Modules] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaseParameter_Module_fk_Module]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaseParameters]'))
ALTER TABLE [dbo].[BaseParameters] CHECK CONSTRAINT [FK_BaseParameter_Module_fk_Module]
GO
/****** Object:  ForeignKey [FK_BoolParameter_BaseParameter_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BoolParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[BoolParameters]'))
ALTER TABLE [dbo].[BoolParameters]  WITH CHECK ADD  CONSTRAINT [FK_BoolParameter_BaseParameter_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[BaseParameters] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BoolParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[BoolParameters]'))
ALTER TABLE [dbo].[BoolParameters] CHECK CONSTRAINT [FK_BoolParameter_BaseParameter_ID]
GO
/****** Object:  ForeignKey [FK_BoolProperty_ValueTypeProperty_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BoolProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[BoolProperties]'))
ALTER TABLE [dbo].[BoolProperties]  WITH CHECK ADD  CONSTRAINT [FK_BoolProperty_ValueTypeProperty_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[ValueTypeProperties] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BoolProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[BoolProperties]'))
ALTER TABLE [dbo].[BoolProperties] CHECK CONSTRAINT [FK_BoolProperty_ValueTypeProperty_ID]
GO
/****** Object:  ForeignKey [FK_CLRObjectParameter_Assembly_fk_Assembly]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLRObjectParameter_Assembly_fk_Assembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLRObjectParameters]'))
ALTER TABLE [dbo].[CLRObjectParameters]  WITH CHECK ADD  CONSTRAINT [FK_CLRObjectParameter_Assembly_fk_Assembly] FOREIGN KEY([fk_Assembly])
REFERENCES [dbo].[Assemblies] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLRObjectParameter_Assembly_fk_Assembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLRObjectParameters]'))
ALTER TABLE [dbo].[CLRObjectParameters] CHECK CONSTRAINT [FK_CLRObjectParameter_Assembly_fk_Assembly]
GO
/****** Object:  ForeignKey [FK_CLRObjectParameter_BaseParameter_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLRObjectParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLRObjectParameters]'))
ALTER TABLE [dbo].[CLRObjectParameters]  WITH CHECK ADD  CONSTRAINT [FK_CLRObjectParameter_BaseParameter_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[BaseParameters] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLRObjectParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLRObjectParameters]'))
ALTER TABLE [dbo].[CLRObjectParameters] CHECK CONSTRAINT [FK_CLRObjectParameter_BaseParameter_ID]
GO
/****** Object:  ForeignKey [FK_ControlInfo_Assembly_fk_Assembly]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ControlInfo_Assembly_fk_Assembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[ControlInfos]'))
ALTER TABLE [dbo].[ControlInfos]  WITH CHECK ADD  CONSTRAINT [FK_ControlInfo_Assembly_fk_Assembly] FOREIGN KEY([fk_Assembly])
REFERENCES [dbo].[Assemblies] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ControlInfo_Assembly_fk_Assembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[ControlInfos]'))
ALTER TABLE [dbo].[ControlInfos] CHECK CONSTRAINT [FK_ControlInfo_Assembly_fk_Assembly]
GO
/****** Object:  ForeignKey [FK_DataType_Icon_fk_DefaultIcon]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DataType_Icon_fk_DefaultIcon]') AND parent_object_id = OBJECT_ID(N'[dbo].[DataTypes]'))
ALTER TABLE [dbo].[DataTypes]  WITH CHECK ADD  CONSTRAINT [FK_DataType_Icon_fk_DefaultIcon] FOREIGN KEY([fk_DefaultIcon])
REFERENCES [dbo].[Icons] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DataType_Icon_fk_DefaultIcon]') AND parent_object_id = OBJECT_ID(N'[dbo].[DataTypes]'))
ALTER TABLE [dbo].[DataTypes] CHECK CONSTRAINT [FK_DataType_Icon_fk_DefaultIcon]
GO
/****** Object:  ForeignKey [FK_DataType_Module_fk_Module]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DataType_Module_fk_Module]') AND parent_object_id = OBJECT_ID(N'[dbo].[DataTypes]'))
ALTER TABLE [dbo].[DataTypes]  WITH CHECK ADD  CONSTRAINT [FK_DataType_Module_fk_Module] FOREIGN KEY([fk_Module])
REFERENCES [dbo].[Modules] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DataType_Module_fk_Module]') AND parent_object_id = OBJECT_ID(N'[dbo].[DataTypes]'))
ALTER TABLE [dbo].[DataTypes] CHECK CONSTRAINT [FK_DataType_Module_fk_Module]
GO
/****** Object:  ForeignKey [FK_DateTimeParameter_BaseParameter_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DateTimeParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[DateTimeParameters]'))
ALTER TABLE [dbo].[DateTimeParameters]  WITH CHECK ADD  CONSTRAINT [FK_DateTimeParameter_BaseParameter_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[BaseParameters] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DateTimeParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[DateTimeParameters]'))
ALTER TABLE [dbo].[DateTimeParameters] CHECK CONSTRAINT [FK_DateTimeParameter_BaseParameter_ID]
GO
/****** Object:  ForeignKey [FK_DateTimeProperty_ValueTypeProperty_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DateTimeProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[DateTimeProperties]'))
ALTER TABLE [dbo].[DateTimeProperties]  WITH CHECK ADD  CONSTRAINT [FK_DateTimeProperty_ValueTypeProperty_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[ValueTypeProperties] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DateTimeProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[DateTimeProperties]'))
ALTER TABLE [dbo].[DateTimeProperties] CHECK CONSTRAINT [FK_DateTimeProperty_ValueTypeProperty_ID]
GO
/****** Object:  ForeignKey [FK_DoubleParameter_BaseParameter_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DoubleParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[DoubleParameters]'))
ALTER TABLE [dbo].[DoubleParameters]  WITH CHECK ADD  CONSTRAINT [FK_DoubleParameter_BaseParameter_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[BaseParameters] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DoubleParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[DoubleParameters]'))
ALTER TABLE [dbo].[DoubleParameters] CHECK CONSTRAINT [FK_DoubleParameter_BaseParameter_ID]
GO
/****** Object:  ForeignKey [FK_DoubleProperty_ValueTypeProperty_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DoubleProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[DoubleProperties]'))
ALTER TABLE [dbo].[DoubleProperties]  WITH CHECK ADD  CONSTRAINT [FK_DoubleProperty_ValueTypeProperty_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[ValueTypeProperties] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DoubleProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[DoubleProperties]'))
ALTER TABLE [dbo].[DoubleProperties] CHECK CONSTRAINT [FK_DoubleProperty_ValueTypeProperty_ID]
GO
/****** Object:  ForeignKey [FK_EnumerationEntry_Enumeration_fk_Enumeration]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EnumerationEntry_Enumeration_fk_Enumeration]') AND parent_object_id = OBJECT_ID(N'[dbo].[EnumerationEntries]'))
ALTER TABLE [dbo].[EnumerationEntries]  WITH CHECK ADD  CONSTRAINT [FK_EnumerationEntry_Enumeration_fk_Enumeration] FOREIGN KEY([fk_Enumeration])
REFERENCES [dbo].[Enumerations] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EnumerationEntry_Enumeration_fk_Enumeration]') AND parent_object_id = OBJECT_ID(N'[dbo].[EnumerationEntries]'))
ALTER TABLE [dbo].[EnumerationEntries] CHECK CONSTRAINT [FK_EnumerationEntry_Enumeration_fk_Enumeration]
GO
/****** Object:  ForeignKey [FK_EnumerationProperty_Enumeration_fk_Enumeration]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EnumerationProperty_Enumeration_fk_Enumeration]') AND parent_object_id = OBJECT_ID(N'[dbo].[EnumerationProperties]'))
ALTER TABLE [dbo].[EnumerationProperties]  WITH CHECK ADD  CONSTRAINT [FK_EnumerationProperty_Enumeration_fk_Enumeration] FOREIGN KEY([fk_Enumeration])
REFERENCES [dbo].[Enumerations] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EnumerationProperty_Enumeration_fk_Enumeration]') AND parent_object_id = OBJECT_ID(N'[dbo].[EnumerationProperties]'))
ALTER TABLE [dbo].[EnumerationProperties] CHECK CONSTRAINT [FK_EnumerationProperty_Enumeration_fk_Enumeration]
GO
/****** Object:  ForeignKey [FK_EnumerationProperty_ValueTypeProperty_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EnumerationProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[EnumerationProperties]'))
ALTER TABLE [dbo].[EnumerationProperties]  WITH CHECK ADD  CONSTRAINT [FK_EnumerationProperty_ValueTypeProperty_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[ValueTypeProperties] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EnumerationProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[EnumerationProperties]'))
ALTER TABLE [dbo].[EnumerationProperties] CHECK CONSTRAINT [FK_EnumerationProperty_ValueTypeProperty_ID]
GO
/****** Object:  ForeignKey [FK_Enumeration_DataType_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Enumeration_DataType_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Enumerations]'))
ALTER TABLE [dbo].[Enumerations]  WITH CHECK ADD  CONSTRAINT [FK_Enumeration_DataType_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[DataTypes] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Enumeration_DataType_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Enumerations]'))
ALTER TABLE [dbo].[Enumerations] CHECK CONSTRAINT [FK_Enumeration_DataType_ID]
GO
/****** Object:  ForeignKey [FK_IntegerRangeConstraint_Constraint_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IntegerRangeConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[IntegerRangeConstraints]'))
ALTER TABLE [dbo].[IntegerRangeConstraints]  WITH CHECK ADD  CONSTRAINT [FK_IntegerRangeConstraint_Constraint_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Constraints] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IntegerRangeConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[IntegerRangeConstraints]'))
ALTER TABLE [dbo].[IntegerRangeConstraints] CHECK CONSTRAINT [FK_IntegerRangeConstraint_Constraint_ID]
GO
/****** Object:  ForeignKey [FK_Interface_DataType_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Interface_DataType_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Interfaces]'))
ALTER TABLE [dbo].[Interfaces]  WITH CHECK ADD  CONSTRAINT [FK_Interface_DataType_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[DataTypes] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Interface_DataType_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Interfaces]'))
ALTER TABLE [dbo].[Interfaces] CHECK CONSTRAINT [FK_Interface_DataType_ID]
GO
/****** Object:  ForeignKey [FK_IntParameter_BaseParameter_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IntParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[IntParameters]'))
ALTER TABLE [dbo].[IntParameters]  WITH CHECK ADD  CONSTRAINT [FK_IntParameter_BaseParameter_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[BaseParameters] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IntParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[IntParameters]'))
ALTER TABLE [dbo].[IntParameters] CHECK CONSTRAINT [FK_IntParameter_BaseParameter_ID]
GO
/****** Object:  ForeignKey [FK_IntProperty_ValueTypeProperty_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IntProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[IntProperties]'))
ALTER TABLE [dbo].[IntProperties]  WITH CHECK ADD  CONSTRAINT [FK_IntProperty_ValueTypeProperty_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[ValueTypeProperties] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IntProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[IntProperties]'))
ALTER TABLE [dbo].[IntProperties] CHECK CONSTRAINT [FK_IntProperty_ValueTypeProperty_ID]
GO
/****** Object:  ForeignKey [FK_IsValidIdentifierConstraint_Constraint_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IsValidIdentifierConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[IsValidIdentifierConstraints]'))
ALTER TABLE [dbo].[IsValidIdentifierConstraints]  WITH CHECK ADD  CONSTRAINT [FK_IsValidIdentifierConstraint_Constraint_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Constraints] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IsValidIdentifierConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[IsValidIdentifierConstraints]'))
ALTER TABLE [dbo].[IsValidIdentifierConstraints] CHECK CONSTRAINT [FK_IsValidIdentifierConstraint_Constraint_ID]
GO
/****** Object:  ForeignKey [FK_IsValidNamespaceConstraint_IsValidIdentifierConstraint_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IsValidNamespaceConstraint_IsValidIdentifierConstraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[IsValidNamespaceConstraints]'))
ALTER TABLE [dbo].[IsValidNamespaceConstraints]  WITH CHECK ADD  CONSTRAINT [FK_IsValidNamespaceConstraint_IsValidIdentifierConstraint_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[IsValidIdentifierConstraints] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_IsValidNamespaceConstraint_IsValidIdentifierConstraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[IsValidNamespaceConstraints]'))
ALTER TABLE [dbo].[IsValidNamespaceConstraints] CHECK CONSTRAINT [FK_IsValidNamespaceConstraint_IsValidIdentifierConstraint_ID]
GO
/****** Object:  ForeignKey [FK_Kostenstelle_Zeitkonto_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Kostenstelle_Zeitkonto_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Kostenstellen]'))
ALTER TABLE [dbo].[Kostenstellen]  WITH CHECK ADD  CONSTRAINT [FK_Kostenstelle_Zeitkonto_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Zeitkonten] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Kostenstelle_Zeitkonto_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Kostenstellen]'))
ALTER TABLE [dbo].[Kostenstellen] CHECK CONSTRAINT [FK_Kostenstelle_Zeitkonto_ID]
GO
/****** Object:  ForeignKey [FK_Kostentraeger_Projekt_fk_Projekt]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Kostentraeger_Projekt_fk_Projekt]') AND parent_object_id = OBJECT_ID(N'[dbo].[Kostentraeger]'))
ALTER TABLE [dbo].[Kostentraeger]  WITH CHECK ADD  CONSTRAINT [FK_Kostentraeger_Projekt_fk_Projekt] FOREIGN KEY([fk_Projekt])
REFERENCES [dbo].[Projekte] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Kostentraeger_Projekt_fk_Projekt]') AND parent_object_id = OBJECT_ID(N'[dbo].[Kostentraeger]'))
ALTER TABLE [dbo].[Kostentraeger] CHECK CONSTRAINT [FK_Kostentraeger_Projekt_fk_Projekt]
GO
/****** Object:  ForeignKey [FK_Kostentraeger_Zeitkonto_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Kostentraeger_Zeitkonto_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Kostentraeger]'))
ALTER TABLE [dbo].[Kostentraeger]  WITH CHECK ADD  CONSTRAINT [FK_Kostentraeger_Zeitkonto_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Zeitkonten] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Kostentraeger_Zeitkonto_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Kostentraeger]'))
ALTER TABLE [dbo].[Kostentraeger] CHECK CONSTRAINT [FK_Kostentraeger_Zeitkonto_ID]
GO
/****** Object:  ForeignKey [FK_Kunde_EMailsCollectionEntry_Kunde_fk_Kunde]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Kunde_EMailsCollectionEntry_Kunde_fk_Kunde]') AND parent_object_id = OBJECT_ID(N'[dbo].[Kunden_EMailsCollection]'))
ALTER TABLE [dbo].[Kunden_EMailsCollection]  WITH CHECK ADD  CONSTRAINT [FK_Kunde_EMailsCollectionEntry_Kunde_fk_Kunde] FOREIGN KEY([fk_Kunde])
REFERENCES [dbo].[Kunden] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Kunde_EMailsCollectionEntry_Kunde_fk_Kunde]') AND parent_object_id = OBJECT_ID(N'[dbo].[Kunden_EMailsCollection]'))
ALTER TABLE [dbo].[Kunden_EMailsCollection] CHECK CONSTRAINT [FK_Kunde_EMailsCollectionEntry_Kunde_fk_Kunde]
GO
/****** Object:  ForeignKey [FK_MethodInvocationConstraint_Constraint_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MethodInvocationConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[MethodInvocationConstraints]'))
ALTER TABLE [dbo].[MethodInvocationConstraints]  WITH CHECK ADD  CONSTRAINT [FK_MethodInvocationConstraint_Constraint_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Constraints] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MethodInvocationConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[MethodInvocationConstraints]'))
ALTER TABLE [dbo].[MethodInvocationConstraints] CHECK CONSTRAINT [FK_MethodInvocationConstraint_Constraint_ID]
GO
/****** Object:  ForeignKey [FK_MethodInvocation_DataType_fk_InvokeOnObjectClass]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MethodInvocation_DataType_fk_InvokeOnObjectClass]') AND parent_object_id = OBJECT_ID(N'[dbo].[MethodInvocations]'))
ALTER TABLE [dbo].[MethodInvocations]  WITH CHECK ADD  CONSTRAINT [FK_MethodInvocation_DataType_fk_InvokeOnObjectClass] FOREIGN KEY([fk_InvokeOnObjectClass])
REFERENCES [dbo].[DataTypes] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MethodInvocation_DataType_fk_InvokeOnObjectClass]') AND parent_object_id = OBJECT_ID(N'[dbo].[MethodInvocations]'))
ALTER TABLE [dbo].[MethodInvocations] CHECK CONSTRAINT [FK_MethodInvocation_DataType_fk_InvokeOnObjectClass]
GO
/****** Object:  ForeignKey [FK_MethodInvocation_Method_fk_Method]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MethodInvocation_Method_fk_Method]') AND parent_object_id = OBJECT_ID(N'[dbo].[MethodInvocations]'))
ALTER TABLE [dbo].[MethodInvocations]  WITH CHECK ADD  CONSTRAINT [FK_MethodInvocation_Method_fk_Method] FOREIGN KEY([fk_Method])
REFERENCES [dbo].[Methods] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MethodInvocation_Method_fk_Method]') AND parent_object_id = OBJECT_ID(N'[dbo].[MethodInvocations]'))
ALTER TABLE [dbo].[MethodInvocations] CHECK CONSTRAINT [FK_MethodInvocation_Method_fk_Method]
GO
/****** Object:  ForeignKey [FK_MethodInvocation_Module_fk_Module]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MethodInvocation_Module_fk_Module]') AND parent_object_id = OBJECT_ID(N'[dbo].[MethodInvocations]'))
ALTER TABLE [dbo].[MethodInvocations]  WITH CHECK ADD  CONSTRAINT [FK_MethodInvocation_Module_fk_Module] FOREIGN KEY([fk_Module])
REFERENCES [dbo].[Modules] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MethodInvocation_Module_fk_Module]') AND parent_object_id = OBJECT_ID(N'[dbo].[MethodInvocations]'))
ALTER TABLE [dbo].[MethodInvocations] CHECK CONSTRAINT [FK_MethodInvocation_Module_fk_Module]
GO
/****** Object:  ForeignKey [FK_MethodInvocation_TypeRef_fk_Implementor]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MethodInvocation_TypeRef_fk_Implementor]') AND parent_object_id = OBJECT_ID(N'[dbo].[MethodInvocations]'))
ALTER TABLE [dbo].[MethodInvocations]  WITH CHECK ADD  CONSTRAINT [FK_MethodInvocation_TypeRef_fk_Implementor] FOREIGN KEY([fk_Implementor])
REFERENCES [dbo].[TypeRefs] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MethodInvocation_TypeRef_fk_Implementor]') AND parent_object_id = OBJECT_ID(N'[dbo].[MethodInvocations]'))
ALTER TABLE [dbo].[MethodInvocations] CHECK CONSTRAINT [FK_MethodInvocation_TypeRef_fk_Implementor]
GO
/****** Object:  ForeignKey [FK_Method_DataType_fk_ObjectClass]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Method_DataType_fk_ObjectClass]') AND parent_object_id = OBJECT_ID(N'[dbo].[Methods]'))
ALTER TABLE [dbo].[Methods]  WITH CHECK ADD  CONSTRAINT [FK_Method_DataType_fk_ObjectClass] FOREIGN KEY([fk_ObjectClass])
REFERENCES [dbo].[DataTypes] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Method_DataType_fk_ObjectClass]') AND parent_object_id = OBJECT_ID(N'[dbo].[Methods]'))
ALTER TABLE [dbo].[Methods] CHECK CONSTRAINT [FK_Method_DataType_fk_ObjectClass]
GO
/****** Object:  ForeignKey [FK_Method_Module_fk_Module]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Method_Module_fk_Module]') AND parent_object_id = OBJECT_ID(N'[dbo].[Methods]'))
ALTER TABLE [dbo].[Methods]  WITH CHECK ADD  CONSTRAINT [FK_Method_Module_fk_Module] FOREIGN KEY([fk_Module])
REFERENCES [dbo].[Modules] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Method_Module_fk_Module]') AND parent_object_id = OBJECT_ID(N'[dbo].[Methods]'))
ALTER TABLE [dbo].[Methods] CHECK CONSTRAINT [FK_Method_Module_fk_Module]
GO
/****** Object:  ForeignKey [FK_NotNullableConstraint_Constraint_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NotNullableConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[NotNullableConstraints]'))
ALTER TABLE [dbo].[NotNullableConstraints]  WITH CHECK ADD  CONSTRAINT [FK_NotNullableConstraint_Constraint_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Constraints] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NotNullableConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[NotNullableConstraints]'))
ALTER TABLE [dbo].[NotNullableConstraints] CHECK CONSTRAINT [FK_NotNullableConstraint_Constraint_ID]
GO
/****** Object:  ForeignKey [FK_ObjectClass_DataType_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_DataType_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
ALTER TABLE [dbo].[ObjectClasses]  WITH CHECK ADD  CONSTRAINT [FK_ObjectClass_DataType_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[DataTypes] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_DataType_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
ALTER TABLE [dbo].[ObjectClasses] CHECK CONSTRAINT [FK_ObjectClass_DataType_ID]
GO
/****** Object:  ForeignKey [FK_ObjectClass_ObjectClass_fk_BaseObjectClass]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_ObjectClass_fk_BaseObjectClass]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
ALTER TABLE [dbo].[ObjectClasses]  WITH CHECK ADD  CONSTRAINT [FK_ObjectClass_ObjectClass_fk_BaseObjectClass] FOREIGN KEY([fk_BaseObjectClass])
REFERENCES [dbo].[ObjectClasses] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_ObjectClass_fk_BaseObjectClass]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
ALTER TABLE [dbo].[ObjectClasses] CHECK CONSTRAINT [FK_ObjectClass_ObjectClass_fk_BaseObjectClass]
GO
/****** Object:  ForeignKey [FK_ObjectClass_PresentableModelDescriptor_fk_DefaultPresentableModelDescriptor]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_PresentableModelDescriptor_fk_DefaultPresentableModelDescriptor]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
ALTER TABLE [dbo].[ObjectClasses]  WITH CHECK ADD  CONSTRAINT [FK_ObjectClass_PresentableModelDescriptor_fk_DefaultPresentableModelDescriptor] FOREIGN KEY([fk_DefaultPresentableModelDescriptor])
REFERENCES [dbo].[PresentableModelDescriptors] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_PresentableModelDescriptor_fk_DefaultPresentableModelDescriptor]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
ALTER TABLE [dbo].[ObjectClasses] CHECK CONSTRAINT [FK_ObjectClass_PresentableModelDescriptor_fk_DefaultPresentableModelDescriptor]
GO
/****** Object:  ForeignKey [FK_ObjectClass_TypeRef_fk_DefaultModel]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_TypeRef_fk_DefaultModel]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
ALTER TABLE [dbo].[ObjectClasses]  WITH CHECK ADD  CONSTRAINT [FK_ObjectClass_TypeRef_fk_DefaultModel] FOREIGN KEY([fk_DefaultModel])
REFERENCES [dbo].[TypeRefs] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_TypeRef_fk_DefaultModel]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses]'))
ALTER TABLE [dbo].[ObjectClasses] CHECK CONSTRAINT [FK_ObjectClass_TypeRef_fk_DefaultModel]
GO
/****** Object:  ForeignKey [FK_ObjectClass_ImplementsInterfacesCollectionEntry_Interface_fk_ImplementsInterfaces]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_ImplementsInterfacesCollectionEntry_Interface_fk_ImplementsInterfaces]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses_ImplementsInterfacesCollection]'))
ALTER TABLE [dbo].[ObjectClasses_ImplementsInterfacesCollection]  WITH CHECK ADD  CONSTRAINT [FK_ObjectClass_ImplementsInterfacesCollectionEntry_Interface_fk_ImplementsInterfaces] FOREIGN KEY([fk_ImplementsInterfaces])
REFERENCES [dbo].[Interfaces] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_ImplementsInterfacesCollectionEntry_Interface_fk_ImplementsInterfaces]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses_ImplementsInterfacesCollection]'))
ALTER TABLE [dbo].[ObjectClasses_ImplementsInterfacesCollection] CHECK CONSTRAINT [FK_ObjectClass_ImplementsInterfacesCollectionEntry_Interface_fk_ImplementsInterfaces]
GO
/****** Object:  ForeignKey [FK_ObjectClass_ImplementsInterfacesCollectionEntry_ObjectClass_fk_ObjectClass]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_ImplementsInterfacesCollectionEntry_ObjectClass_fk_ObjectClass]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses_ImplementsInterfacesCollection]'))
ALTER TABLE [dbo].[ObjectClasses_ImplementsInterfacesCollection]  WITH CHECK ADD  CONSTRAINT [FK_ObjectClass_ImplementsInterfacesCollectionEntry_ObjectClass_fk_ObjectClass] FOREIGN KEY([fk_ObjectClass])
REFERENCES [dbo].[ObjectClasses] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectClass_ImplementsInterfacesCollectionEntry_ObjectClass_fk_ObjectClass]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectClasses_ImplementsInterfacesCollection]'))
ALTER TABLE [dbo].[ObjectClasses_ImplementsInterfacesCollection] CHECK CONSTRAINT [FK_ObjectClass_ImplementsInterfacesCollectionEntry_ObjectClass_fk_ObjectClass]
GO
/****** Object:  ForeignKey [FK_ObjectParameter_BaseParameter_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectParameters]'))
ALTER TABLE [dbo].[ObjectParameters]  WITH CHECK ADD  CONSTRAINT [FK_ObjectParameter_BaseParameter_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[BaseParameters] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectParameters]'))
ALTER TABLE [dbo].[ObjectParameters] CHECK CONSTRAINT [FK_ObjectParameter_BaseParameter_ID]
GO
/****** Object:  ForeignKey [FK_ObjectParameter_DataType_fk_DataType]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectParameter_DataType_fk_DataType]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectParameters]'))
ALTER TABLE [dbo].[ObjectParameters]  WITH CHECK ADD  CONSTRAINT [FK_ObjectParameter_DataType_fk_DataType] FOREIGN KEY([fk_DataType])
REFERENCES [dbo].[DataTypes] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectParameter_DataType_fk_DataType]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectParameters]'))
ALTER TABLE [dbo].[ObjectParameters] CHECK CONSTRAINT [FK_ObjectParameter_DataType_fk_DataType]
GO
/****** Object:  ForeignKey [FK_ObjectReferenceProperty_ObjectClass_fk_ReferenceObjectClass]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectReferenceProperty_ObjectClass_fk_ReferenceObjectClass]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectReferenceProperties]'))
ALTER TABLE [dbo].[ObjectReferenceProperties]  WITH CHECK ADD  CONSTRAINT [FK_ObjectReferenceProperty_ObjectClass_fk_ReferenceObjectClass] FOREIGN KEY([fk_ReferenceObjectClass])
REFERENCES [dbo].[ObjectClasses] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectReferenceProperty_ObjectClass_fk_ReferenceObjectClass]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectReferenceProperties]'))
ALTER TABLE [dbo].[ObjectReferenceProperties] CHECK CONSTRAINT [FK_ObjectReferenceProperty_ObjectClass_fk_ReferenceObjectClass]
GO
/****** Object:  ForeignKey [FK_ObjectReferenceProperty_Property_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectReferenceProperty_Property_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectReferenceProperties]'))
ALTER TABLE [dbo].[ObjectReferenceProperties]  WITH CHECK ADD  CONSTRAINT [FK_ObjectReferenceProperty_Property_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Properties] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectReferenceProperty_Property_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectReferenceProperties]'))
ALTER TABLE [dbo].[ObjectReferenceProperties] CHECK CONSTRAINT [FK_ObjectReferenceProperty_Property_ID]
GO
/****** Object:  ForeignKey [FK_PresentableModelDescriptors_TypeRef_fk_PresentableModelRef]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PresentableModelDescriptors_TypeRef_fk_PresentableModelRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[PresentableModelDescriptors]'))
ALTER TABLE [dbo].[PresentableModelDescriptors]  WITH CHECK ADD  CONSTRAINT [FK_PresentableModelDescriptors_TypeRef_fk_PresentableModelRef] FOREIGN KEY([fk_PresentableModelRef])
REFERENCES [dbo].[TypeRefs] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PresentableModelDescriptors_TypeRef_fk_PresentableModelRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[PresentableModelDescriptors]'))
ALTER TABLE [dbo].[PresentableModelDescriptors] CHECK CONSTRAINT [FK_PresentableModelDescriptors_TypeRef_fk_PresentableModelRef]
GO
/****** Object:  ForeignKey [FK_PresenterInfo_Assembly_fk_DataAssembly]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PresenterInfo_Assembly_fk_DataAssembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[PresenterInfos]'))
ALTER TABLE [dbo].[PresenterInfos]  WITH CHECK ADD  CONSTRAINT [FK_PresenterInfo_Assembly_fk_DataAssembly] FOREIGN KEY([fk_DataAssembly])
REFERENCES [dbo].[Assemblies] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PresenterInfo_Assembly_fk_DataAssembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[PresenterInfos]'))
ALTER TABLE [dbo].[PresenterInfos] CHECK CONSTRAINT [FK_PresenterInfo_Assembly_fk_DataAssembly]
GO
/****** Object:  ForeignKey [FK_PresenterInfo_Assembly_fk_PresenterAssembly]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PresenterInfo_Assembly_fk_PresenterAssembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[PresenterInfos]'))
ALTER TABLE [dbo].[PresenterInfos]  WITH CHECK ADD  CONSTRAINT [FK_PresenterInfo_Assembly_fk_PresenterAssembly] FOREIGN KEY([fk_PresenterAssembly])
REFERENCES [dbo].[Assemblies] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PresenterInfo_Assembly_fk_PresenterAssembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[PresenterInfos]'))
ALTER TABLE [dbo].[PresenterInfos] CHECK CONSTRAINT [FK_PresenterInfo_Assembly_fk_PresenterAssembly]
GO
/****** Object:  ForeignKey [FK_Projekt_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Projekt_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter]') AND parent_object_id = OBJECT_ID(N'[dbo].[Projekte_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Projekte_MitarbeiterCollection]  WITH CHECK ADD  CONSTRAINT [FK_Projekt_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter] FOREIGN KEY([fk_Mitarbeiter])
REFERENCES [dbo].[Mitarbeiter] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Projekt_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter]') AND parent_object_id = OBJECT_ID(N'[dbo].[Projekte_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Projekte_MitarbeiterCollection] CHECK CONSTRAINT [FK_Projekt_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter]
GO
/****** Object:  ForeignKey [FK_Projekt_MitarbeiterCollectionEntry_Projekt_fk_Projekt]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Projekt_MitarbeiterCollectionEntry_Projekt_fk_Projekt]') AND parent_object_id = OBJECT_ID(N'[dbo].[Projekte_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Projekte_MitarbeiterCollection]  WITH CHECK ADD  CONSTRAINT [FK_Projekt_MitarbeiterCollectionEntry_Projekt_fk_Projekt] FOREIGN KEY([fk_Projekt])
REFERENCES [dbo].[Projekte] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Projekt_MitarbeiterCollectionEntry_Projekt_fk_Projekt]') AND parent_object_id = OBJECT_ID(N'[dbo].[Projekte_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Projekte_MitarbeiterCollection] CHECK CONSTRAINT [FK_Projekt_MitarbeiterCollectionEntry_Projekt_fk_Projekt]
GO
/****** Object:  ForeignKey [FK_Property_PresentableModelDescriptor_fk_ValueModelDescriptor]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Property_PresentableModelDescriptor_fk_ValueModelDescriptor]') AND parent_object_id = OBJECT_ID(N'[dbo].[Properties]'))
ALTER TABLE [dbo].[Properties]  WITH CHECK ADD  CONSTRAINT [FK_Property_PresentableModelDescriptor_fk_ValueModelDescriptor] FOREIGN KEY([fk_ValueModelDescriptor])
REFERENCES [dbo].[PresentableModelDescriptors] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Property_PresentableModelDescriptor_fk_ValueModelDescriptor]') AND parent_object_id = OBJECT_ID(N'[dbo].[Properties]'))
ALTER TABLE [dbo].[Properties] CHECK CONSTRAINT [FK_Property_PresentableModelDescriptor_fk_ValueModelDescriptor]
GO
/****** Object:  ForeignKey [FK_BaseProperty_ConstraintsCollectionEntry_Constraint_fk_Constraints]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaseProperty_ConstraintsCollectionEntry_Constraint_fk_Constraints]') AND parent_object_id = OBJECT_ID(N'[dbo].[Properties_ConstraintsCollection]'))
ALTER TABLE [dbo].[Properties_ConstraintsCollection]  WITH CHECK ADD  CONSTRAINT [FK_BaseProperty_ConstraintsCollectionEntry_Constraint_fk_Constraints] FOREIGN KEY([fk_Constraints])
REFERENCES [dbo].[Constraints] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaseProperty_ConstraintsCollectionEntry_Constraint_fk_Constraints]') AND parent_object_id = OBJECT_ID(N'[dbo].[Properties_ConstraintsCollection]'))
ALTER TABLE [dbo].[Properties_ConstraintsCollection] CHECK CONSTRAINT [FK_BaseProperty_ConstraintsCollectionEntry_Constraint_fk_Constraints]
GO
/****** Object:  ForeignKey [FK_Properties_ConstraintsCollection_Properties]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Properties_ConstraintsCollection_Properties]') AND parent_object_id = OBJECT_ID(N'[dbo].[Properties_ConstraintsCollection]'))
ALTER TABLE [dbo].[Properties_ConstraintsCollection]  WITH CHECK ADD  CONSTRAINT [FK_Properties_ConstraintsCollection_Properties] FOREIGN KEY([fk_Property])
REFERENCES [dbo].[Properties] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Properties_ConstraintsCollection_Properties]') AND parent_object_id = OBJECT_ID(N'[dbo].[Properties_ConstraintsCollection]'))
ALTER TABLE [dbo].[Properties_ConstraintsCollection] CHECK CONSTRAINT [FK_Properties_ConstraintsCollection_Properties]
GO
/****** Object:  ForeignKey [FK_RelationEnd_ObjectClass_fk_Type]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RelationEnd_ObjectClass_fk_Type]') AND parent_object_id = OBJECT_ID(N'[dbo].[RelationEnds]'))
ALTER TABLE [dbo].[RelationEnds]  WITH CHECK ADD  CONSTRAINT [FK_RelationEnd_ObjectClass_fk_Type] FOREIGN KEY([fk_Type])
REFERENCES [dbo].[ObjectClasses] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RelationEnd_ObjectClass_fk_Type]') AND parent_object_id = OBJECT_ID(N'[dbo].[RelationEnds]'))
ALTER TABLE [dbo].[RelationEnds] CHECK CONSTRAINT [FK_RelationEnd_ObjectClass_fk_Type]
GO
/****** Object:  ForeignKey [FK_RelationEnd_Property_fk_Navigator]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RelationEnd_Property_fk_Navigator]') AND parent_object_id = OBJECT_ID(N'[dbo].[RelationEnds]'))
ALTER TABLE [dbo].[RelationEnds]  WITH CHECK ADD  CONSTRAINT [FK_RelationEnd_Property_fk_Navigator] FOREIGN KEY([fk_Navigator])
REFERENCES [dbo].[Properties] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RelationEnd_Property_fk_Navigator]') AND parent_object_id = OBJECT_ID(N'[dbo].[RelationEnds]'))
ALTER TABLE [dbo].[RelationEnds] CHECK CONSTRAINT [FK_RelationEnd_Property_fk_Navigator]
GO
/****** Object:  ForeignKey [FK_Relation_RelationEnd_fk_A]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Relation_RelationEnd_fk_A]') AND parent_object_id = OBJECT_ID(N'[dbo].[Relations]'))
ALTER TABLE [dbo].[Relations]  WITH CHECK ADD  CONSTRAINT [FK_Relation_RelationEnd_fk_A] FOREIGN KEY([fk_A])
REFERENCES [dbo].[RelationEnds] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Relation_RelationEnd_fk_A]') AND parent_object_id = OBJECT_ID(N'[dbo].[Relations]'))
ALTER TABLE [dbo].[Relations] CHECK CONSTRAINT [FK_Relation_RelationEnd_fk_A]
GO
/****** Object:  ForeignKey [FK_Relation_RelationEnd_fk_B]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Relation_RelationEnd_fk_B]') AND parent_object_id = OBJECT_ID(N'[dbo].[Relations]'))
ALTER TABLE [dbo].[Relations]  WITH CHECK ADD  CONSTRAINT [FK_Relation_RelationEnd_fk_B] FOREIGN KEY([fk_B])
REFERENCES [dbo].[RelationEnds] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Relation_RelationEnd_fk_B]') AND parent_object_id = OBJECT_ID(N'[dbo].[Relations]'))
ALTER TABLE [dbo].[Relations] CHECK CONSTRAINT [FK_Relation_RelationEnd_fk_B]
GO
/****** Object:  ForeignKey [FK_StringConstraint_Constraint_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StringConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[StringConstraints]'))
ALTER TABLE [dbo].[StringConstraints]  WITH CHECK ADD  CONSTRAINT [FK_StringConstraint_Constraint_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Constraints] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StringConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[StringConstraints]'))
ALTER TABLE [dbo].[StringConstraints] CHECK CONSTRAINT [FK_StringConstraint_Constraint_ID]
GO
/****** Object:  ForeignKey [FK_StringParameter_BaseParameter_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StringParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[StringParameters]'))
ALTER TABLE [dbo].[StringParameters]  WITH CHECK ADD  CONSTRAINT [FK_StringParameter_BaseParameter_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[BaseParameters] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StringParameter_BaseParameter_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[StringParameters]'))
ALTER TABLE [dbo].[StringParameters] CHECK CONSTRAINT [FK_StringParameter_BaseParameter_ID]
GO
/****** Object:  ForeignKey [FK_StringProperty_ValueTypeProperty_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StringProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[StringProperties]'))
ALTER TABLE [dbo].[StringProperties]  WITH CHECK ADD  CONSTRAINT [FK_StringProperty_ValueTypeProperty_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[ValueTypeProperties] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StringProperty_ValueTypeProperty_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[StringProperties]'))
ALTER TABLE [dbo].[StringProperties] CHECK CONSTRAINT [FK_StringProperty_ValueTypeProperty_ID]
GO
/****** Object:  ForeignKey [FK_StringRangeConstraint_Constraint_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StringRangeConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[StringRangeConstraints]'))
ALTER TABLE [dbo].[StringRangeConstraints]  WITH CHECK ADD  CONSTRAINT [FK_StringRangeConstraint_Constraint_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Constraints] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StringRangeConstraint_Constraint_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[StringRangeConstraints]'))
ALTER TABLE [dbo].[StringRangeConstraints] CHECK CONSTRAINT [FK_StringRangeConstraint_Constraint_ID]
GO
/****** Object:  ForeignKey [FK_StructProperty_Property_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StructProperty_Property_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[StructProperties]'))
ALTER TABLE [dbo].[StructProperties]  WITH CHECK ADD  CONSTRAINT [FK_StructProperty_Property_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Properties] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StructProperty_Property_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[StructProperties]'))
ALTER TABLE [dbo].[StructProperties] CHECK CONSTRAINT [FK_StructProperty_Property_ID]
GO
/****** Object:  ForeignKey [FK_StructProperty_Struct_fk_StructDefinition]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StructProperty_Struct_fk_StructDefinition]') AND parent_object_id = OBJECT_ID(N'[dbo].[StructProperties]'))
ALTER TABLE [dbo].[StructProperties]  WITH CHECK ADD  CONSTRAINT [FK_StructProperty_Struct_fk_StructDefinition] FOREIGN KEY([fk_StructDefinition])
REFERENCES [dbo].[Structs] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StructProperty_Struct_fk_StructDefinition]') AND parent_object_id = OBJECT_ID(N'[dbo].[StructProperties]'))
ALTER TABLE [dbo].[StructProperties] CHECK CONSTRAINT [FK_StructProperty_Struct_fk_StructDefinition]
GO
/****** Object:  ForeignKey [FK_Struct_DataType_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Struct_DataType_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Structs]'))
ALTER TABLE [dbo].[Structs]  WITH CHECK ADD  CONSTRAINT [FK_Struct_DataType_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[DataTypes] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Struct_DataType_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Structs]'))
ALTER TABLE [dbo].[Structs] CHECK CONSTRAINT [FK_Struct_DataType_ID]
GO
/****** Object:  ForeignKey [FK_Task_Projekt_fk_Projekt]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Projekt_fk_Projekt]') AND parent_object_id = OBJECT_ID(N'[dbo].[Tasks]'))
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Task_Projekt_fk_Projekt] FOREIGN KEY([fk_Projekt])
REFERENCES [dbo].[Projekte] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Projekt_fk_Projekt]') AND parent_object_id = OBJECT_ID(N'[dbo].[Tasks]'))
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Task_Projekt_fk_Projekt]
GO
/****** Object:  ForeignKey [FK_Template_Assembly_fk_DisplayedTypeAssembly]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Template_Assembly_fk_DisplayedTypeAssembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[Templates]'))
ALTER TABLE [dbo].[Templates]  WITH CHECK ADD  CONSTRAINT [FK_Template_Assembly_fk_DisplayedTypeAssembly] FOREIGN KEY([fk_DisplayedTypeAssembly])
REFERENCES [dbo].[Assemblies] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Template_Assembly_fk_DisplayedTypeAssembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[Templates]'))
ALTER TABLE [dbo].[Templates] CHECK CONSTRAINT [FK_Template_Assembly_fk_DisplayedTypeAssembly]
GO
/****** Object:  ForeignKey [FK_Template_Visual_fk_VisualTree]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Template_Visual_fk_VisualTree]') AND parent_object_id = OBJECT_ID(N'[dbo].[Templates]'))
ALTER TABLE [dbo].[Templates]  WITH CHECK ADD  CONSTRAINT [FK_Template_Visual_fk_VisualTree] FOREIGN KEY([fk_VisualTree])
REFERENCES [dbo].[Visuals] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Template_Visual_fk_VisualTree]') AND parent_object_id = OBJECT_ID(N'[dbo].[Templates]'))
ALTER TABLE [dbo].[Templates] CHECK CONSTRAINT [FK_Template_Visual_fk_VisualTree]
GO
/****** Object:  ForeignKey [FK_Template_MenuCollectionEntry_Template_fk_Template]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Template_MenuCollectionEntry_Template_fk_Template]') AND parent_object_id = OBJECT_ID(N'[dbo].[Templates_MenuCollection]'))
ALTER TABLE [dbo].[Templates_MenuCollection]  WITH CHECK ADD  CONSTRAINT [FK_Template_MenuCollectionEntry_Template_fk_Template] FOREIGN KEY([fk_Template])
REFERENCES [dbo].[Templates] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Template_MenuCollectionEntry_Template_fk_Template]') AND parent_object_id = OBJECT_ID(N'[dbo].[Templates_MenuCollection]'))
ALTER TABLE [dbo].[Templates_MenuCollection] CHECK CONSTRAINT [FK_Template_MenuCollectionEntry_Template_fk_Template]
GO
/****** Object:  ForeignKey [FK_Template_MenuCollectionEntry_Visual_fk_Menu]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Template_MenuCollectionEntry_Visual_fk_Menu]') AND parent_object_id = OBJECT_ID(N'[dbo].[Templates_MenuCollection]'))
ALTER TABLE [dbo].[Templates_MenuCollection]  WITH CHECK ADD  CONSTRAINT [FK_Template_MenuCollectionEntry_Visual_fk_Menu] FOREIGN KEY([fk_Menu])
REFERENCES [dbo].[Visuals] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Template_MenuCollectionEntry_Visual_fk_Menu]') AND parent_object_id = OBJECT_ID(N'[dbo].[Templates_MenuCollection]'))
ALTER TABLE [dbo].[Templates_MenuCollection] CHECK CONSTRAINT [FK_Template_MenuCollectionEntry_Visual_fk_Menu]
GO
/****** Object:  ForeignKey [FK_TestObjClass_Kunde_fk_ObjectProp]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TestObjClass_Kunde_fk_ObjectProp]') AND parent_object_id = OBJECT_ID(N'[dbo].[TestObjClasses]'))
ALTER TABLE [dbo].[TestObjClasses]  WITH CHECK ADD  CONSTRAINT [FK_TestObjClass_Kunde_fk_ObjectProp] FOREIGN KEY([fk_ObjectProp])
REFERENCES [dbo].[Kunden] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TestObjClass_Kunde_fk_ObjectProp]') AND parent_object_id = OBJECT_ID(N'[dbo].[TestObjClasses]'))
ALTER TABLE [dbo].[TestObjClasses] CHECK CONSTRAINT [FK_TestObjClass_Kunde_fk_ObjectProp]
GO
/****** Object:  ForeignKey [FK_TypeRef_Assembly_fk_Assembly]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TypeRef_Assembly_fk_Assembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[TypeRefs]'))
ALTER TABLE [dbo].[TypeRefs]  WITH CHECK ADD  CONSTRAINT [FK_TypeRef_Assembly_fk_Assembly] FOREIGN KEY([fk_Assembly])
REFERENCES [dbo].[Assemblies] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TypeRef_Assembly_fk_Assembly]') AND parent_object_id = OBJECT_ID(N'[dbo].[TypeRefs]'))
ALTER TABLE [dbo].[TypeRefs] CHECK CONSTRAINT [FK_TypeRef_Assembly_fk_Assembly]
GO
/****** Object:  ForeignKey [FK_TypeRef_TypeRef_fk_Parent]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TypeRef_TypeRef_fk_Parent]') AND parent_object_id = OBJECT_ID(N'[dbo].[TypeRefs]'))
ALTER TABLE [dbo].[TypeRefs]  WITH CHECK ADD  CONSTRAINT [FK_TypeRef_TypeRef_fk_Parent] FOREIGN KEY([fk_Parent])
REFERENCES [dbo].[TypeRefs] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TypeRef_TypeRef_fk_Parent]') AND parent_object_id = OBJECT_ID(N'[dbo].[TypeRefs]'))
ALTER TABLE [dbo].[TypeRefs] CHECK CONSTRAINT [FK_TypeRef_TypeRef_fk_Parent]
GO
/****** Object:  ForeignKey [FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_GenericArguments]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_GenericArguments]') AND parent_object_id = OBJECT_ID(N'[dbo].[TypeRefs_GenericArgumentsCollection]'))
ALTER TABLE [dbo].[TypeRefs_GenericArgumentsCollection]  WITH CHECK ADD  CONSTRAINT [FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_GenericArguments] FOREIGN KEY([fk_GenericArguments])
REFERENCES [dbo].[TypeRefs] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_GenericArguments]') AND parent_object_id = OBJECT_ID(N'[dbo].[TypeRefs_GenericArgumentsCollection]'))
ALTER TABLE [dbo].[TypeRefs_GenericArgumentsCollection] CHECK CONSTRAINT [FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_GenericArguments]
GO
/****** Object:  ForeignKey [FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_TypeRef]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_TypeRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[TypeRefs_GenericArgumentsCollection]'))
ALTER TABLE [dbo].[TypeRefs_GenericArgumentsCollection]  WITH CHECK ADD  CONSTRAINT [FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_TypeRef] FOREIGN KEY([fk_TypeRef])
REFERENCES [dbo].[TypeRefs] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_TypeRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[TypeRefs_GenericArgumentsCollection]'))
ALTER TABLE [dbo].[TypeRefs_GenericArgumentsCollection] CHECK CONSTRAINT [FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_TypeRef]
GO
/****** Object:  ForeignKey [FK_ValueTypeProperty_Property_ID]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ValueTypeProperty_Property_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[ValueTypeProperties]'))
ALTER TABLE [dbo].[ValueTypeProperties]  WITH CHECK ADD  CONSTRAINT [FK_ValueTypeProperty_Property_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Properties] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ValueTypeProperty_Property_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[ValueTypeProperties]'))
ALTER TABLE [dbo].[ValueTypeProperties] CHECK CONSTRAINT [FK_ValueTypeProperty_Property_ID]
GO
/****** Object:  ForeignKey [FK_ViewDescriptor_TypeRef_fk_ControlRef]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ViewDescriptor_TypeRef_fk_ControlRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[ViewDescriptors]'))
ALTER TABLE [dbo].[ViewDescriptors]  WITH CHECK ADD  CONSTRAINT [FK_ViewDescriptor_TypeRef_fk_ControlRef] FOREIGN KEY([fk_ControlRef])
REFERENCES [dbo].[TypeRefs] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ViewDescriptor_TypeRef_fk_ControlRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[ViewDescriptors]'))
ALTER TABLE [dbo].[ViewDescriptors] CHECK CONSTRAINT [FK_ViewDescriptor_TypeRef_fk_ControlRef]
GO
/****** Object:  ForeignKey [FK_ViewDescriptor_TypeRef_fk_PresentedModelDescriptor]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ViewDescriptor_TypeRef_fk_PresentedModelDescriptor]') AND parent_object_id = OBJECT_ID(N'[dbo].[ViewDescriptors]'))
ALTER TABLE [dbo].[ViewDescriptors]  WITH CHECK ADD  CONSTRAINT [FK_ViewDescriptor_TypeRef_fk_PresentedModelDescriptor] FOREIGN KEY([fk_PresentedModelDescriptor])
REFERENCES [dbo].[PresentableModelDescriptors] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ViewDescriptor_TypeRef_fk_PresentedModelDescriptor]') AND parent_object_id = OBJECT_ID(N'[dbo].[ViewDescriptors]'))
ALTER TABLE [dbo].[ViewDescriptors] CHECK CONSTRAINT [FK_ViewDescriptor_TypeRef_fk_PresentedModelDescriptor]
GO
/****** Object:  ForeignKey [FK_Visual_Method_fk_Method]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_Method_fk_Method]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals]'))
ALTER TABLE [dbo].[Visuals]  WITH CHECK ADD  CONSTRAINT [FK_Visual_Method_fk_Method] FOREIGN KEY([fk_Method])
REFERENCES [dbo].[Methods] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_Method_fk_Method]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals]'))
ALTER TABLE [dbo].[Visuals] CHECK CONSTRAINT [FK_Visual_Method_fk_Method]
GO
/****** Object:  ForeignKey [FK_Visual_ChildrenCollectionEntry_Visual_fk_Children]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_ChildrenCollectionEntry_Visual_fk_Children]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_ChildrenCollection]'))
ALTER TABLE [dbo].[Visuals_ChildrenCollection]  WITH CHECK ADD  CONSTRAINT [FK_Visual_ChildrenCollectionEntry_Visual_fk_Children] FOREIGN KEY([fk_Children])
REFERENCES [dbo].[Visuals] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_ChildrenCollectionEntry_Visual_fk_Children]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_ChildrenCollection]'))
ALTER TABLE [dbo].[Visuals_ChildrenCollection] CHECK CONSTRAINT [FK_Visual_ChildrenCollectionEntry_Visual_fk_Children]
GO
/****** Object:  ForeignKey [FK_Visual_ChildrenCollectionEntry_Visual_fk_Visual]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_ChildrenCollectionEntry_Visual_fk_Visual]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_ChildrenCollection]'))
ALTER TABLE [dbo].[Visuals_ChildrenCollection]  WITH CHECK ADD  CONSTRAINT [FK_Visual_ChildrenCollectionEntry_Visual_fk_Visual] FOREIGN KEY([fk_Visual])
REFERENCES [dbo].[Visuals] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_ChildrenCollectionEntry_Visual_fk_Visual]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_ChildrenCollection]'))
ALTER TABLE [dbo].[Visuals_ChildrenCollection] CHECK CONSTRAINT [FK_Visual_ChildrenCollectionEntry_Visual_fk_Visual]
GO
/****** Object:  ForeignKey [FK_Visual_ContextMenuCollectionEntry_Visual_fk_ContextMenu]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_ContextMenuCollectionEntry_Visual_fk_ContextMenu]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_ContextMenuCollection]'))
ALTER TABLE [dbo].[Visuals_ContextMenuCollection]  WITH CHECK ADD  CONSTRAINT [FK_Visual_ContextMenuCollectionEntry_Visual_fk_ContextMenu] FOREIGN KEY([fk_ContextMenu])
REFERENCES [dbo].[Visuals] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_ContextMenuCollectionEntry_Visual_fk_ContextMenu]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_ContextMenuCollection]'))
ALTER TABLE [dbo].[Visuals_ContextMenuCollection] CHECK CONSTRAINT [FK_Visual_ContextMenuCollectionEntry_Visual_fk_ContextMenu]
GO
/****** Object:  ForeignKey [FK_Visual_ContextMenuCollectionEntry_Visual_fk_Visual]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_ContextMenuCollectionEntry_Visual_fk_Visual]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_ContextMenuCollection]'))
ALTER TABLE [dbo].[Visuals_ContextMenuCollection]  WITH CHECK ADD  CONSTRAINT [FK_Visual_ContextMenuCollectionEntry_Visual_fk_Visual] FOREIGN KEY([fk_Visual])
REFERENCES [dbo].[Visuals] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_ContextMenuCollectionEntry_Visual_fk_Visual]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_ContextMenuCollection]'))
ALTER TABLE [dbo].[Visuals_ContextMenuCollection] CHECK CONSTRAINT [FK_Visual_ContextMenuCollectionEntry_Visual_fk_Visual]
GO
/****** Object:  ForeignKey [FK_Visual_MenuTreeCollectionEntry_Visual_fk_MenuTree]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_MenuTreeCollectionEntry_Visual_fk_MenuTree]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_MenuTreeCollection]'))
ALTER TABLE [dbo].[Visuals_MenuTreeCollection]  WITH CHECK ADD  CONSTRAINT [FK_Visual_MenuTreeCollectionEntry_Visual_fk_MenuTree] FOREIGN KEY([fk_MenuTree])
REFERENCES [dbo].[Visuals] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_MenuTreeCollectionEntry_Visual_fk_MenuTree]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_MenuTreeCollection]'))
ALTER TABLE [dbo].[Visuals_MenuTreeCollection] CHECK CONSTRAINT [FK_Visual_MenuTreeCollectionEntry_Visual_fk_MenuTree]
GO
/****** Object:  ForeignKey [FK_Visual_MenuTreeCollectionEntry_Visual_fk_Visual]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_MenuTreeCollectionEntry_Visual_fk_Visual]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_MenuTreeCollection]'))
ALTER TABLE [dbo].[Visuals_MenuTreeCollection]  WITH CHECK ADD  CONSTRAINT [FK_Visual_MenuTreeCollectionEntry_Visual_fk_Visual] FOREIGN KEY([fk_Visual])
REFERENCES [dbo].[Visuals] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visual_MenuTreeCollectionEntry_Visual_fk_Visual]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visuals_MenuTreeCollection]'))
ALTER TABLE [dbo].[Visuals_MenuTreeCollection] CHECK CONSTRAINT [FK_Visual_MenuTreeCollectionEntry_Visual_fk_Visual]
GO
/****** Object:  ForeignKey [FK_Zeitkonto_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Zeitkonto_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter]') AND parent_object_id = OBJECT_ID(N'[dbo].[Zeitkonten_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Zeitkonten_MitarbeiterCollection]  WITH CHECK ADD  CONSTRAINT [FK_Zeitkonto_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter] FOREIGN KEY([fk_Mitarbeiter])
REFERENCES [dbo].[Mitarbeiter] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Zeitkonto_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter]') AND parent_object_id = OBJECT_ID(N'[dbo].[Zeitkonten_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Zeitkonten_MitarbeiterCollection] CHECK CONSTRAINT [FK_Zeitkonto_MitarbeiterCollectionEntry_Mitarbeiter_fk_Mitarbeiter]
GO
/****** Object:  ForeignKey [FK_Zeitkonto_MitarbeiterCollectionEntry_Zeitkonto_fk_Zeitkonto]    Script Date: 04/27/2009 16:11:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Zeitkonto_MitarbeiterCollectionEntry_Zeitkonto_fk_Zeitkonto]') AND parent_object_id = OBJECT_ID(N'[dbo].[Zeitkonten_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Zeitkonten_MitarbeiterCollection]  WITH CHECK ADD  CONSTRAINT [FK_Zeitkonto_MitarbeiterCollectionEntry_Zeitkonto_fk_Zeitkonto] FOREIGN KEY([fk_Zeitkonto])
REFERENCES [dbo].[Zeitkonten] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Zeitkonto_MitarbeiterCollectionEntry_Zeitkonto_fk_Zeitkonto]') AND parent_object_id = OBJECT_ID(N'[dbo].[Zeitkonten_MitarbeiterCollection]'))
ALTER TABLE [dbo].[Zeitkonten_MitarbeiterCollection] CHECK CONSTRAINT [FK_Zeitkonto_MitarbeiterCollectionEntry_Zeitkonto_fk_Zeitkonto]
GO
