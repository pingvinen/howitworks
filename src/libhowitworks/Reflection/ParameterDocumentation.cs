using System;
using Mono.Cecil;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// Documentation wrapper for <see cref="Mono.Cecil.ParameterDefinition"/>
	/// </summary>
	public class ParameterDocumentation : DocumentationBase<ParameterDefinition>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.ParameterDocumentation"/> class.
		/// </summary>
		public ParameterDocumentation() : base()
		{
		}
	}
}