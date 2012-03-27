using System;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// Represents a namespace
	/// </summary>
	public class Namespace
	{
		public Namespace()
		{
			this.SubNamespaces = new NamespaceCollection();
			this.Types = new TypeDocumentationCollection();
		}
		
		public NamespaceCollection SubNamespaces { get; set; }
		
		public TypeDocumentationCollection Types { get; set; }
	}
}