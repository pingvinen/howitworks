using System;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// A full API/SDK reference
	/// </summary>
	public class Reference
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.Reference"/> class.
		/// </summary>
		public Reference()
		{
			this.Namespaces = new NamespaceCollection();
		}
		
		/// <summary>
		/// Get/set the full set of namespaces found in the reference
		/// </summary>
		public NamespaceCollection Namespaces { get; set; }
	}
}