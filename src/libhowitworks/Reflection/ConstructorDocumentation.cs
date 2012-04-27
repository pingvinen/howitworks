using System;
using Mono.Cecil;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// Documentation wrapper for <see cref="Mono.Cecil.MethodDefinition"/>
	/// </summary>
	public class ConstructorDocumentation : DocumentationBase<MethodDefinition>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.ConstructorDocumentation"/> class.
		/// </summary>
		public ConstructorDocumentation() : base()
		{
		}
	}
}