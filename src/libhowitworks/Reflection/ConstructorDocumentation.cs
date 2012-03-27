using System;
using System.Reflection;

namespace HowItWorks.Reflection
{
	public class ConstructorDocumentation : DocumentationBase
	{
		public ConstructorDocumentation() : base()
		{
		}
		
		public ConstructorInfo ConstructorInfo { get; set; }
	}
}