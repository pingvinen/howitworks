using System;
using System.Collections.ObjectModel;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// A collection of type documentations
	/// </summary>
	public class TypeDocumentationCollection : Collection<TypeDocumentation>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.TypeDocumentationCollection"/> class.
		/// </summary>
		public TypeDocumentationCollection() : base()
		{
		}
	}
}