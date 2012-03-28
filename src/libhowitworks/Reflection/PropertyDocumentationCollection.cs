using System;
using System.Collections.ObjectModel;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// A collection of property documentations
	/// </summary>
	public class PropertyDocumentationCollection : Collection<PropertyDocumentation>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.PropertyDocumentationCollection"/> class.
		/// </summary>
		public PropertyDocumentationCollection() : base()
		{
		}
	}
}