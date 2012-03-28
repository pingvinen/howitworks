using System;
using System.Reflection;

namespace HowItWorks.Reflection
{
	public class TypeDocumentation : DocumentationBase<Type>
	{
		public TypeDocumentation() : base()
		{
			this.Constructors = new ConstructorDocumentationCollection();
			this.Methods = new MethodDocumentationCollection();
			this.Properties = new PropertyDocumentationCollection();
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
		
		protected override void PopulateWorker()
		{
			this.PopulateConstructors();
			
			// update this.Methods
			// update this.Properties
		}
		
		private void PopulateConstructors()
		{
			this.Constructors.Clear();
			
			ConstructorInfo[] infos = base.WrappedElement.GetConstructors();
			
			ConstructorDocumentation tmp;
			
			foreach (ConstructorInfo cur in infos)
			{
				tmp = new ConstructorDocumentation();
				tmp.Populate(cur);
				
				this.Constructors.Add(tmp);
			}
		}
	}
}