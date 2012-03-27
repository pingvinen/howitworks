using System;
using System.Reflection;

namespace HowItWorks.Reflection
{
	public class ParameterDocumentation : DocumentationBase
	{
		public ParameterDocumentation() : base()
		{
		}
		
		public ParameterInfo ParameterInfo { get; set; }
	}
}