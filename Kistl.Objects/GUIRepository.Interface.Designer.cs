// <autogenerated/>

using System.Linq;

using Kistl.API;

namespace Kistl.App.GUI
{

	public class GUIRepository
	{
		public GUIRepository(IKistlContext ctx)
		{
			this.Context = ctx;
		}
		
		public IKistlContext Context { get; private set; }
		
		/// <summary>List of all WorkspaceKind</summary>
		/// The basic workspace where multiple objects can be edited
		public IQueryable<WorkspaceKind> WorkspaceKinds
		{ 
			get
			{
				return Context.GetQuery<WorkspaceKind>();
			}
		}
		
		/// <summary>List of all Visual</summary>
		/// 
		public IQueryable<Visual> Visuals
		{ 
			get
			{
				return Context.GetQuery<Visual>();
			}
		}
		
		/// <summary>List of all ViewDescriptor</summary>
		/// 
		public IQueryable<ViewDescriptor> ViewDescriptors
		{ 
			get
			{
				return Context.GetQuery<ViewDescriptor>();
			}
		}
		
		/// <summary>List of all TypeRefRefKind</summary>
		/// A specifc ObjectRefKind for selecting TypeRefs
		public IQueryable<TypeRefRefKind> TypeRefRefKinds
		{ 
			get
			{
				return Context.GetQuery<TypeRefRefKind>();
			}
		}
		
		/// <summary>List of all TextboxKind</summary>
		/// A textbox-like control
		public IQueryable<TextboxKind> TextboxKinds
		{ 
			get
			{
				return Context.GetQuery<TextboxKind>();
			}
		}
		
		/// <summary>List of all Template</summary>
		/// 
		public IQueryable<Template> Templates
		{ 
			get
			{
				return Context.GetQuery<Template>();
			}
		}
		
		/// <summary>List of all StringSelectorKind</summary>
		/// Select a string fron a set of values
		public IQueryable<StringSelectorKind> StringSelectorKinds
		{ 
			get
			{
				return Context.GetQuery<StringSelectorKind>();
			}
		}
		
		/// <summary>List of all SingleLineDataObjectKind</summary>
		/// Presents a data object in a single line
		public IQueryable<SingleLineDataObjectKind> SingleLineDataObjectKinds
		{ 
			get
			{
				return Context.GetQuery<SingleLineDataObjectKind>();
			}
		}
		
		/// <summary>List of all RelationEditorKind</summary>
		/// A special editor for relations
		public IQueryable<RelationEditorKind> RelationEditorKinds
		{ 
			get
			{
				return Context.GetQuery<RelationEditorKind>();
			}
		}
		
		/// <summary>List of all PropertyGroupKind</summary>
		/// Displays a group of properties from a data object
		public IQueryable<PropertyGroupKind> PropertyGroupKinds
		{ 
			get
			{
				return Context.GetQuery<PropertyGroupKind>();
			}
		}
		
		/// <summary>List of all PresentableModelDescriptor</summary>
		/// 
		public IQueryable<PresentableModelDescriptor> PresentableModelDescriptors
		{ 
			get
			{
				return Context.GetQuery<PresentableModelDescriptor>();
			}
		}
		
		/// <summary>List of all ObjectRefKind</summary>
		/// A control managing a reference to an object
		public IQueryable<ObjectRefKind> ObjectRefKinds
		{ 
			get
			{
				return Context.GetQuery<ObjectRefKind>();
			}
		}
		
		/// <summary>List of all ObjectRefGridCellKind</summary>
		/// 
		public IQueryable<ObjectRefGridCellKind> ObjectRefGridCellKinds
		{ 
			get
			{
				return Context.GetQuery<ObjectRefGridCellKind>();
			}
		}
		
		/// <summary>List of all ObjectListKind</summary>
		/// A control managing a list of objects
		public IQueryable<ObjectListKind> ObjectListKinds
		{ 
			get
			{
				return Context.GetQuery<ObjectListKind>();
			}
		}
		
		/// <summary>List of all LauncherKind</summary>
		/// The first openend window where applications can be selected and the object tree browsed
		public IQueryable<LauncherKind> LauncherKinds
		{ 
			get
			{
				return Context.GetQuery<LauncherKind>();
			}
		}
		
		/// <summary>List of all LabelKind</summary>
		/// A simple read-only label
		public IQueryable<LabelKind> LabelKinds
		{ 
			get
			{
				return Context.GetQuery<LabelKind>();
			}
		}
		
		/// <summary>List of all Icon</summary>
		/// 
		public IQueryable<Icon> Icons
		{ 
			get
			{
				return Context.GetQuery<Icon>();
			}
		}
		
		/// <summary>List of all EnumerationSelectorKind</summary>
		/// Select a value fron an Enumeration
		public IQueryable<EnumerationSelectorKind> EnumerationSelectorKinds
		{ 
			get
			{
				return Context.GetQuery<EnumerationSelectorKind>();
			}
		}
		
		/// <summary>List of all DataObjectSummaryKind</summary>
		/// 
		public IQueryable<DataObjectSummaryKind> DataObjectSummaryKinds
		{ 
			get
			{
				return Context.GetQuery<DataObjectSummaryKind>();
			}
		}
		
		/// <summary>List of all DataObjectSelectionTaskKind</summary>
		/// Choose a data object from a set of values
		public IQueryable<DataObjectSelectionTaskKind> DataObjectSelectionTaskKinds
		{ 
			get
			{
				return Context.GetQuery<DataObjectSelectionTaskKind>();
			}
		}
		
		/// <summary>List of all DataObjectKind</summary>
		/// Displays a complete DataObject with all its properties
		public IQueryable<DataObjectKind> DataObjectKinds
		{ 
			get
			{
				return Context.GetQuery<DataObjectKind>();
			}
		}
		
		/// <summary>List of all ControlKindClass</summary>
		/// Extended MetaClass for defining supported interfaces of ControlKinds
		public IQueryable<ControlKindClass> ControlKindClasses
		{ 
			get
			{
				return Context.GetQuery<ControlKindClass>();
			}
		}
		
		/// <summary>List of all ControlKind</summary>
		/// The ControlKind specifies the toolkit-independent kind or type of control that should display a given Presentable.
		public IQueryable<ControlKind> ControlKinds
		{ 
			get
			{
				return Context.GetQuery<ControlKind>();
			}
		}
		
		/// <summary>List of all CheckboxKind</summary>
		/// Select a boolean value with a checkbox
		public IQueryable<CheckboxKind> CheckboxKinds
		{ 
			get
			{
				return Context.GetQuery<CheckboxKind>();
			}
		}
		
		/// <summary>List of all ActionKind</summary>
		/// Represent an user action or menu item
		public IQueryable<ActionKind> ActionKinds
		{ 
			get
			{
				return Context.GetQuery<ActionKind>();
			}
		}
		
	
	}
	
}