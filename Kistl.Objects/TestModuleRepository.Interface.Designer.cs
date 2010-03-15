// <autogenerated/>

using System.Linq;

using Kistl.API;

namespace Kistl.App.Test
{

	public class TestModuleRepository
	{
		public TestModuleRepository(IKistlContext ctx)
		{
			this.Context = ctx;
		}
		
		public IKistlContext Context { get; private set; }
		
		/// <summary>List of all TestObjClass</summary>
		/// 
		public IQueryable<TestObjClass> TestObjClasses
		{ 
			get
			{
				return Context.GetQuery<TestObjClass>();
			}
		}
		
		/// <summary>List of all TestCustomObject</summary>
		/// 
		public IQueryable<TestCustomObject> TestCustomObjects
		{ 
			get
			{
				return Context.GetQuery<TestCustomObject>();
			}
		}
		
		/// <summary>List of all Muhblah</summary>
		/// 
		public IQueryable<Muhblah> Muhblas
		{ 
			get
			{
				return Context.GetQuery<Muhblah>();
			}
		}
		
		/// <summary>List of all Fragebogen</summary>
		/// 
		public IQueryable<Fragebogen> Frageboegen
		{ 
			get
			{
				return Context.GetQuery<Fragebogen>();
			}
		}
		
		/// <summary>List of all Company</summary>
		/// Describes a Company
		public IQueryable<Company> Companies
		{ 
			get
			{
				return Context.GetQuery<Company>();
			}
		}
		
		/// <summary>List of all Antwort</summary>
		/// 
		public IQueryable<Antwort> Antworten
		{ 
			get
			{
				return Context.GetQuery<Antwort>();
			}
		}
		
		/// <summary>List of all AnotherTest</summary>
		/// 
		public IQueryable<AnotherTest> AnotherTests
		{ 
			get
			{
				return Context.GetQuery<AnotherTest>();
			}
		}
		
		/// <summary>List of all ANewObjectClass</summary>
		/// 
		public IQueryable<ANewObjectClass> NewObjectClasses
		{ 
			get
			{
				return Context.GetQuery<ANewObjectClass>();
			}
		}
		
	
	}
	
}