using System;
using System.Linq;
using Mono.Cecil;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// Documentation wrapper for <see cref="Mono.Cecil.TypeDefinition"/>
	/// </summary>
	public class TypeDocumentation : DocumentationBase<TypeDefinition>
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
			base.PopulateCollectionTwo<ConstructorDocumentation, MethodDefinition>(
					this.Constructors,
					y => y.Methods,
					y => y.IsConstructor
				);
			
			base.PopulateCollectionTwo<MethodDocumentation, MethodDefinition>(
				this.Methods,
				y => y.Methods,
				y => !y.IsConstructor && !y.IsSetter && !y.IsGetter
			);
			
			base.PopulateCollectionTwo<PropertyDocumentation, PropertyDefinition>(
				this.Properties,
				y => y.Properties
			);
		}
	}
}