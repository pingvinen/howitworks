using System;
using System.Reflection;

namespace HowItWorks.Reflection
{
	/// <summary>
	/// Documentation wrapper for <see cref="System.Reflection.MethodInfo"/>
	/// </summary>
	public class MethodDocumentation : DocumentationBase<MethodInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HowItWorks.Reflection.MethodDocumentation"/> class.
		/// </summary>
		public MethodDocumentation() : base()
		{
		}
	}
}