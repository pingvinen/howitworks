using System;

namespace HowItWorks.Reflection
{
	public class TypeDocumentation : DocumentationBase
	{
		public TypeDocumentation() : base()
		{
		}

		public Type Type { get; set; }
		
		public string Name
		{
			get { return this.Type.Name; }
		}
		
		public string Namespace
		{
			get { return this.Type.Namespace; }
		}
		
		public string Assembly
		{
			get { return this.Type.Module.Name; }
		}
		
		public ConstructorDocumentationCollection Constructors { get; set; }
		public MethodDocumentationCollection Methods { get; set; }
		public PropertyDocumentationCollection Properties { get; set; }
	}
}