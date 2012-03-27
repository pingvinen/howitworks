using System;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// A full API/SDK reference
	/// </summary>
	public class Reference
	{
		public Reference()
		{
			this.Namespaces = new NamespaceCollection();
		}
		
		public NamespaceCollection Namespaces { get; set; }
	}
}