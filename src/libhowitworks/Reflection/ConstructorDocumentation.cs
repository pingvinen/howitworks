using System;
using System.Reflection;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// Documentation wrapper for <see cref="System.Reflection.ConstructorInfo"/>
	/// </summary>
	public class ConstructorDocumentation : DocumentationBase<ConstructorInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.ConstructorDocumentation"/> class.
		/// </summary>
		public ConstructorDocumentation() : base()
		{
		}
	}
}