using System;
using System.Collections.ObjectModel;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// A collection of constructor documentations
	/// </summary>
	public class ConstructorDocumentationCollection : Collection<ConstructorDocumentation>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.ConstructorDocumentationCollection"/> class.
		/// </summary>
		public ConstructorDocumentationCollection() : base()
		{
		}
	}
}