using System;
using System.Reflection;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// Documentation wrapper for <see cref="System.Reflection.PropertyInfo"/>
	/// </summary>
	public class PropertyDocumentation : DocumentationBase<PropertyInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.PropertyDocumentation"/> class.
		/// </summary>
		public PropertyDocumentation() : base()
		{
		}
	}
}