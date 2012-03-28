using System;

namespace HowItWorks.Reflection
{
	public class TypeDocumentation : DocumentationBase<Type>
	{
		public TypeDocumentation() : base()
		{
		}

		public string Name
		{
			get { return base.WrappedElement.Name; }
		}
		
		public string Namespace
		{
			get { return base.WrappedElement.Namespace; }
		}
		
		public string Assembly
		{
			get { return base.WrappedElement.Module.Name; }
		}
		
		public ConstructorDocumentationCollection Constructors { get; set; }
		public MethodDocumentationCollection Methods { get; set; }
		public PropertyDocumentationCollection Properties { get; set; }
		
		protected override void FromFrameworkTypeWorker()
		{
			// update this.Constructors
			// update this.Methods
			// update this.Properties
		}
	}
}