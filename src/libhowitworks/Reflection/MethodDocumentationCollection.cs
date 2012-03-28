using System;
using System.Collections.ObjectModel;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// A collection of method documentations
	/// </summary>
	public class MethodDocumentationCollection : Collection<MethodDocumentation>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.MethodDocumentationCollection"/> class.
		/// </summary>
		public MethodDocumentationCollection() : base()
		{
		}
	}
}