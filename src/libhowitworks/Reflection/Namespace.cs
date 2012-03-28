using System;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// Represents a namespace
	/// </summary>
	public class Namespace
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.Namespace"/> class.
		/// </summary>
		public Namespace()
		{
			this.SubNamespaces = new NamespaceCollection();
			this.Types = new TypeDocumentationCollection();
		}
		
		/// <summary>
		/// Get/set full set of namespaces contained
		/// within this namespace
		/// </summary>
		public NamespaceCollection SubNamespaces { get; set; }
		
		/// <summary>
		/// Get/set full set of types defined within this
		/// namespace
		/// </summary>
		public TypeDocumentationCollection Types { get; set; }
	}
}