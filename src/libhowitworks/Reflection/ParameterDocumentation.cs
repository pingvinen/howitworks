using System;
using System.Reflection;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// Documentation wrapper for <see cref="System.Reflection.ParameterInfo"/>
	/// </summary>
	public class ParameterDocumentation : DocumentationBase<ParameterInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.ParameterDocumentation"/> class.
		/// </summary>
		public ParameterDocumentation() : base()
		{
		}
	}
}