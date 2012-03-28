using System;
using System.Reflection;
using System.Linq;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// Documentation wrapper for <see cref="System.Type"/>
	/// </summary>
	public class TypeDocumentation : DocumentationBase<Type>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.TypeDocumentation"/> class.
		/// </summary>
		public TypeDocumentation() : base()
		{
			this.Constructors = new ConstructorDocumentationCollection();
			this.Methods = new MethodDocumentationCollection();
			this.Properties = new PropertyDocumentationCollection();
		}
		
		/// <summary>
		/// Get the name of the type (without namespace)
		/// </summary>
		public string Name
		{
			get { return base.WrappedElement.Name; }
		}
		
		/// <summary>
		/// Get the namespace of the type
		/// </summary>
		public string Namespace
		{
			get { return base.WrappedElement.Namespace; }
		}
		
		/// <summary>
		/// Get the filename containing the assembly containing the type
		/// </summary>
		public string Assembly
		{
			get { return base.WrappedElement.Module.Name; }
		}
		
		/// <summary>
		/// Get/set the full set of constructors found in the type
		/// </summary>
		public ConstructorDocumentationCollection Constructors { get; set; }
		
		/// <summary>
		/// Get/set the full set of methods found in the type
		/// </summary>
		public MethodDocumentationCollection Methods { get; set; }
		
		/// <summary>
		/// Get/set full set of properties found in the type
		/// </summary>
		public PropertyDocumentationCollection Properties { get; set; }
		
		/// <summary>
		/// Populates instance
		/// </summary>
		protected override void PopulateWorker()
		{
			base.PopulateCollection<ConstructorDocumentation, ConstructorInfo>(this.Constructors, y => y.GetConstructors());
			base.PopulateCollection<MethodDocumentation, MethodInfo>(this.Methods, y => y.GetMethods());
			base.PopulateCollection<PropertyDocumentation, PropertyInfo>(this.Properties, y => y.GetProperties());
		}
	}
}