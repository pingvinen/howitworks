using System;
using Mono.Cecil;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// Documentation wrapper for <see cref="Mono.Cecil.PropertyDefinition"/>
	/// </summary>
	public class PropertyDocumentation : DocumentationBase<PropertyDefinition>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.PropertyDocumentation"/> class.
		/// </summary>
		public PropertyDocumentation() : base()
		{
		}
	}
}